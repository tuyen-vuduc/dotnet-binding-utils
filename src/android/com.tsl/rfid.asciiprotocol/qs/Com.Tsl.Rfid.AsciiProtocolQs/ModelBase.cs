using Android.OS;
using Android.Util;
using Com.UK.Tsl.Rfid.Asciiprotocol;

namespace Com.Tsl.Rfid.AsciiProtocolQs;
public class ModelBase
{
    // Debugging
    private static readonly bool D =
#if DEBUG
        true
#else
        false
#endif
        ;

    // Model busy state changed message
    public static readonly int BUSY_STATE_CHANGED_NOTIFICATION = 1;
    public static readonly int MESSAGE_NOTIFICATION = 2;

    // 
    protected Handler mHandler;
    protected bool mBusy;
    private Exception mException;
    protected AsciiCommander mCommander;
    protected AsyncTask mTaskRunner;
    protected double mLastTaskExecutionDuration;

    private DateTime mTaskStartTime;

    /**
	 * @return true if the model is currently performing a task
	 */
    public bool isBusy() { return mBusy; }

    /**
	 * Set the task busy state
	 * @param isBusy
	 */
    protected void setBusy(bool isBusy)
    {
        if (mBusy != isBusy)
        {
            mBusy = isBusy;

            if (mHandler != null)
            {
                Message msg = mHandler.ObtainMessage(BUSY_STATE_CHANGED_NOTIFICATION, isBusy);
                mHandler.SendMessage(msg);
            }
        }
    }


    /**
	 * Send a message to the client using the current Handler
	 * 
	 * @param message The message to send as String
	 */
    protected void sendMessageNotification(String message)
    {
        if (mHandler != null)
        {
            Message msg = mHandler.ObtainMessage(MESSAGE_NOTIFICATION, message);
            mHandler.SendMessage(msg);
        }
    }

    public bool isTaskRunning() { return mTaskRunner != null; }

    public ModelBase()
    {
        mCommander = null;
        mHandler = null;
        mBusy = false;
        mLastTaskExecutionDuration = -1.00;
    }

    /**
	 * @return the commander the model uses
	 */
    public AsciiCommander getCommander() { return mCommander; }
    /**
	 * @param commander the commander the model uses
	 */
    public void setCommander(AsciiCommander commander) { mCommander = commander; }

    /**
	 * @return the handler for model notifications
	 */
    public Handler getHandler() { return mHandler; }
    /**
	 * @param handler the handler for model notifications
	 */
    public void setHandler(Handler handler) { mHandler = handler; }


    /**
	 * @return the error as an exception or null if none
	 */
    public Exception error() { return mException; }

    /**
	 * @param e the error as an exception
	 */
    protected void setError(Exception e) { mException = e; }

    /**
	 * @return the current execution duration if a task is running otherwise the duration of the last task
	 */
    public double getTaskExecutionDuration()
    {
        if (mLastTaskExecutionDuration >= 0.0)
        {
            return mLastTaskExecutionDuration;
        }
        else
        {
            DateTime now = DateTime.Now;
            return (now.Millisecond - mTaskStartTime.Millisecond) / 1000.0;
        }
    }

    /**
	 * Execute the given task
	 * 
	 * The busy state is notified to the client
	 * 
	 * Tasks should throw an exception to indicate (and return) error
	 * 
	 * @param task the Runnable task to be performed 
	 */
    public void performTask(Action task)
    {
        if (mCommander == null)
        {
            throw (new ModelException("There is no AsciiCommander set for this model!"));
        }
        else
        {
            if (mTaskRunner != null)
            {
                throw (new ModelException("Task is already running!"));
            }
            else
            {
                mTaskRunner = new XAsyncTask(
                    preExecute: () =>
                    {
                        mLastTaskExecutionDuration = -1.0;
                        mTaskStartTime = DateTime.Now;
                    },
                    execute: () =>
                    {
                        try
                        {
                            setBusy(true);
                            mException = null;
                            task?.Invoke();
                        }
                        catch (Exception e)
                        {
                            mException = e;
                        }
                    },
                    postExecute: () =>
                {
                    mTaskRunner?.Dispose();
                    mTaskRunner = null;
                    setBusy(false);

                    // Update the time taken
                    DateTime finishTime = new DateTime();
                    mLastTaskExecutionDuration = (finishTime.Millisecond - mTaskStartTime.Millisecond) / 1000.0;

                    if (D)
                    {
                        Log.Info(
                            nameof(XAsyncTask),
                            string.Format("Time taken (ms): %{0} {1:N2}",
                            finishTime.Millisecond - mTaskStartTime.Millisecond,
                            mLastTaskExecutionDuration));
                    }
                });

                try
                {
                    if ((int)Android.OS.Build.VERSION.SdkInt >= 11)
                    {
                        // Ensure the tasks are executed serially whatever newer API versions may choose by default
                        mTaskRunner.ExecuteOnExecutor(AsyncTask.SerialExecutor);
                    }
                    else
                    {
                        // Tasks will be executed concurrently on API < 11
                        mTaskRunner.Execute();
                    }
                }
                catch (Exception e)
                {
                    mException = e;
                }
            }
        }
    }

}