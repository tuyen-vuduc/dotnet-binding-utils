using Com.UK.Tsl.Rfid.Asciiprotocol.Commands;
using Com.UK.Tsl.Rfid.Asciiprotocol.Enumerations;
using Com.UK.Tsl.Rfid.Asciiprotocol.Responders;
using Java.Lang;

namespace Com.Tsl.Rfid.AsciiProtocolQs;

/**
 * A class to illustrate how to return the RSSI for a target tag using either the
 * FindTag command or the InventoryCommand
 */
public partial class TagFinderModel : ModelBase
{

    // The instances used to issue commands
    private InventoryCommand mInventoryCommand;
    private FindTagCommand mFindTagCommand;

    // The responder to capture incoming RSSI responses
    private SignalStrengthResponder mSignalStrengthResponder;

    // The switch state responder
    private SwitchResponder mSwitchResponder;

    private bool mUseFindTagCommand = false;


    public string getTargetTagEpc() { return mTargetTagEpc; }
    public void setTargetTagEpc(string targetTagEpc)
    {
        if (targetTagEpc != null)
        {
            mTargetTagEpc = targetTagEpc.ToUpper();
        }
    }
    private string mTargetTagEpc = null;

    // True if the User is scanning
    public bool isScanning() { return mScanning; }
    public void setScanning(bool scanning) { mScanning = scanning; }
    private bool mScanning = false;


    /**
     * @return the delegate for the raw signal strength responses in dBm
     */
    public ISignalStrengthReceivedDelegate getRawSignalDelegate() => mSignalStrengthResponder.RawSignalStrengthReceivedDelegate;
    /**
     * @param delegate the delegate for the raw signal strength responses in dBm
     */
    public void setRawSignalDelegate(ISignalStrengthReceivedDelegate @delegate) => mSignalStrengthResponder.RawSignalStrengthReceivedDelegate = @delegate;

    /**
     * @return the delegate for the percentage signal strength responses in range 0 - 100 %
     */
    public ISignalStrengthReceivedDelegate getPercentageSignalDelegate() => mSignalStrengthResponder.PercentageSignalStrengthReceivedDelegate;
    /**
     * @param delegate the delegate for the percentage signal strength responses in range 0 - 100 %
     */
    public void setPercentageSignalDelegate(ISignalStrengthReceivedDelegate @delegate) => mSignalStrengthResponder.PercentageSignalStrengthReceivedDelegate = (@delegate);

    /**
     * @return the delegate for the signal strength transponder count delegate
     */
    public ISignalStrengthCountDelegate getSignalStrengthCountDelegate() => mSignalStrengthResponder.SignalStrengthCountDelegate;

    /**
     * @param delegate the delegate for the signal strength transponder count delegate
     */
    public void setSignalStrengthCountDelegate(ISignalStrengthCountDelegate @delegate) => mSignalStrengthResponder.SignalStrengthCountDelegate = @delegate;


    // Control
    private bool mEnabled;
    public bool enabled() { return mEnabled; }

    public void setEnabled(bool state)
    {
        bool oldState = mEnabled;
        mEnabled = state;

        // Update the commander for state changes
        if (oldState != state)
        {
            if (mEnabled)
            {
                // Listen for transponders
                getCommander().AddResponder(mSignalStrengthResponder);
                // Listen for trigger
                getCommander().AddResponder(mSwitchResponder);

            }
            else
            {
                // Stop listening for trigger
                getCommander().AddResponder(mSwitchResponder);
                // Stop listening for transponders
                getCommander().RemoveResponder(mSignalStrengthResponder);
            }

        }
    }

    /**
     * @return true if the current Reader supports the .ft (Find Tag) command
     */
    public bool isFindTagCommandAvailable()
    {
        return mUseFindTagCommand;
    }


    /**
     * A class to demonstrate the use of the AsciiProtocol library to read and write to transponders
     */
    public TagFinderModel()
    {
        mInventoryCommand = InventoryCommand.SynchronousCommand();
        mFindTagCommand = FindTagCommand.SynchronousCommand();
        mSignalStrengthResponder = new SignalStrengthResponder();
        mSwitchResponder = new SwitchResponder();
        mSwitchResponder.SwitchStateReceivedDelegate = new XSwitchStateReceivedDelegate((switchState) =>
        {
            // When trigger released
            if (switchState == SwitchState.Off)
            {
                mScanning = false;
                // Fake a signal report for both percentage and RSSI to indicate action stopped
                if (mSignalStrengthResponder.RawSignalStrengthReceivedDelegate != null)
                {
                    mSignalStrengthResponder.RawSignalStrengthReceivedDelegate.SignalStrengthReceived(null);
                }
                if (mSignalStrengthResponder.PercentageSignalStrengthReceivedDelegate != null)
                {
                    mSignalStrengthResponder.PercentageSignalStrengthReceivedDelegate.SignalStrengthReceived(null);
                }
            }
            else if (switchState == SwitchState.Single)
            {
                mScanning = true;
            }
        });

    }

    //
    // Reset the reader configuration to default command values
    //
    public void resetDevice()
    {
        if (getCommander().IsConnected)
        {
            try
            {
                sendMessageNotification("\nInitialising reader...\n");

                performTask(() =>
                    {
                        getCommander().ExecuteCommand(new FactoryDefaultsCommand());

                        // Test for presence of the FindTag command
                        mFindTagCommand.ReadParameters = TriState.Yes;
                        mFindTagCommand.TakeNoAction = TriState.Yes;
                        mCommander.ExecuteCommand(mFindTagCommand);
                        // If Reader responded without error then we can use the special command otherwise use the standard inventory command
                        mUseFindTagCommand = mFindTagCommand.IsSuccessful;

                        // Now prepare first find parameters
                        updateTargetParameters();

                        sendMessageNotification("\nDone.\n");
                    });

            }
            catch (ModelException e)
            {
                sendMessageNotification("Unable to perform action: " + e.Message);
            }
        }
    }


    //
    // Reconfigure the Reader to target the current
    //
    public void updateTarget()
    {
        if (!this.isBusy())
        {
            try
            {
                sendMessageNotification("\nUpdating target...");

                performTask(() =>
                {
                    updateTargetParameters();
                });

            }
            catch (ModelException e)
            {
                sendMessageNotification("Unable to perform action: " + e.Message);
            }
        }
    }

    //
    // Reconfigure the Reader to target the current
    //
    public void updateTargetParameters()
    {
        if (getCommander().IsConnected)
        {
            // Configure the switch actions
            SwitchActionCommand switchActionCommand = SwitchActionCommand.SynchronousCommand();
            switchActionCommand.ResetParameters = TriState.Yes;
            switchActionCommand.AsynchronousReportingEnabled = TriState.Yes;

            // Only change defaults if there is a valid target tag
            if (!string.IsNullOrEmpty(mTargetTagEpc))
            {
                // Configure the single press switch action for the appropriate command
                switchActionCommand.SinglePressAction = mUseFindTagCommand ? SwitchAction.FindTag : SwitchAction.Inventory;
                // Lower the repeat delay to maximise the response rate
                switchActionCommand.SinglePressRepeatDelay = 10;
            }

            mCommander.ExecuteCommand(switchActionCommand);


            // Now adjust the commands to target the chosen tag
            bool succeeded = false;

            if (string.IsNullOrEmpty(mTargetTagEpc))
            {
                succeeded = true;
            }
            else
            {

                string targetEpcData = mTargetTagEpc;
                // Pad data if not whole number of bytes
                if (targetEpcData.Length % 2 == 1)
                {
                    targetEpcData += "0";
                }

                if (mUseFindTagCommand)
                {
                    mFindTagCommand = FindTagCommand.SynchronousCommand();
                    mFindTagCommand.ResetParameters = TriState.Yes;

                    // Only configure if target valid
                    if (!string.IsNullOrEmpty(mTargetTagEpc) && mEnabled)
                    {
                        mFindTagCommand.SelectData = (targetEpcData);
                        mFindTagCommand.SelectLength = (mTargetTagEpc.Length * 4);
                        mFindTagCommand.SelectOffset = (0x20);

                        mFindTagCommand.TriggerOverride = StartStop.Start;
                    }
                    else
                    {
                        mFindTagCommand.TriggerOverride = string.IsNullOrEmpty(mTargetTagEpc)
                            ? StartStop.Stop
                            : StartStop.NotSpecified;
                    }

                    mFindTagCommand.TakeNoAction = (TriState.Yes);

                    //mFindTagCommand.setReadParameters(TriState.Yes);
                    getCommander().ExecuteCommand(mFindTagCommand);
                    succeeded = mFindTagCommand.IsSuccessful;

                }
                else
                {
                    // Configure the inventory
                    mInventoryCommand = InventoryCommand.SynchronousCommand();
                    mInventoryCommand.ResetParameters = (TriState.Yes);
                    mInventoryCommand.TakeNoAction = (TriState.Yes);

                    // Only configure if target valid
                    if (!string.IsNullOrEmpty(mTargetTagEpc) && mEnabled)
                    {
                        mInventoryCommand.IncludeTransponderRssi = TriState.Yes;

                        mInventoryCommand.QuerySession = QuerySession.Session0;
                        mInventoryCommand.QueryTarget = QueryTarget.TargetB;

                        mInventoryCommand.InventoryOnly = TriState.No;

                        mInventoryCommand.SelectData = targetEpcData;
                        mInventoryCommand.SelectOffset = 0x20;
                        mInventoryCommand.SelectLength = mTargetTagEpc.Length * 4;
                        mInventoryCommand.SelectAction = SelectAction.DeassertSetBNotAssertSetA;
                        mInventoryCommand.SelectTarget = SelectTarget.Session0;

                        mInventoryCommand.UseAlert = TriState.No;
                    }

                    getCommander().ExecuteCommand(mInventoryCommand);
                    succeeded = mInventoryCommand.IsSuccessful;
                }
            }

            if (succeeded)
            {
                sendMessageNotification("updated\n");
            }
            else
            {
                sendMessageNotification("\n !!! update failed - ensure only hex characters used !!!\n");
            }
        }
    }

    //----------------------------------------------------------------------------------------------
    //
    //----------------------------------------------------------------------------------------------


    /**
     * Check the given command for errors and report them via the model message system
     * @param command The command to check
     */
    private void reportErrors(AsciiSelfResponderCommandBase command)
    {
        if (!command.IsSuccessful)
        {
            sendMessageNotification(string.Format(
                    "{0} failed!\nError code: {1}\n", command.GetType().Name, command.ErrorCode));
            foreach (string message in command.Messages)
            {
                sendMessageNotification(message + "\n");
            }
        }

    }

}

partial class XSwitchStateReceivedDelegate : Java.Lang.Object, ISwitchStateReceivedDelegate
{
    private readonly Action<SwitchState?> action;

    public XSwitchStateReceivedDelegate(Action<SwitchState?> action)
    {
        this.action = action;
    }

    public void SwitchStateReceived(SwitchState? p0)
    {
        action?.Invoke(p0);
    }
}

partial class XSignalStrengthReceivedDelegate : Java.Lang.Object, ISignalStrengthReceivedDelegate
{
    private readonly Action<int?> action;

    public XSignalStrengthReceivedDelegate(Action<int?> action)
    {
        this.action = action;
    }
    public void SignalStrengthReceived(Integer? p0)
    {
        action?.Invoke(p0?.IntValue());
    }
}
partial class XSignalStrengthCountDelegate : Java.Lang.Object, ISignalStrengthCountDelegate
{
    private readonly Action<int?> action;

    public XSignalStrengthCountDelegate(Action<int?> action)
    {
        this.action = action;
    }

    public void SignalStrengthCount(Integer? p0)
    {
        action?.Invoke(p0?.IntValue());
    }
}
