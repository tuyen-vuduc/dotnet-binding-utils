using Foundation;
using System;
using UIKit;
using iZettle;
using CoreAnimation;

namespace iZettleQs
{
    public partial class HomeViewController : UIViewController
    {
        iZettleSDKPaymentInfo _lastPaymentInfo;
        string _lastReference;
        DateTime _timestamp;
        NSError _lastError;

        readonly string numberFormat = "{0:D}";

        public HomeViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            amountLabel.Text = string.Format("{0:F}", amountWheel.Amount.DoubleValue);
            amountWheel.AmountUpdated += (obj) =>
            {
                amountLabel.Text = string.Format("{0:F}", amountWheel.Amount.DoubleValue);
            };
        }

        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();

            MakeViewRound(chargeButton);
            MakeViewRound(dotView);
        }

        partial void charge(UIButton btnCharge)
        {
            _lastReference = Guid.NewGuid().ToString();

            var amount = amountWheel.Amount;

            iZettleSDK.Shared.ChargeAmount(amount, false, _lastReference, this, (iZettleSDKPaymentInfo paymentInfo, NSError error) =>
            {
                _lastPaymentInfo = paymentInfo;
                _lastError = error;
                _timestamp = DateTime.Now;

                UpdateLastPaymentToolbar();
                ShowConsole();
            });
        }

        partial void settings(UIBarButtonItem btnSetting)
        {
            iZettleSDK.Shared.PresentSettingsFromViewController(this);
        }

        partial void lastPaymentInfo(UIBarButtonItem btnViewHistory)
        {
            iZettleSDK.Shared.RetrievePaymentInfoForReference(_lastReference, this, (iZettleSDKPaymentInfo arg0, NSError arg1) =>
            {

                _lastPaymentInfo = arg0;
                _lastError = arg1;

                ShowConsole();
            });
        }

        partial void refundLastPayment(UIBarButtonItem btnRefund)
        {
            var paymentReference = _lastReference;
            _lastReference = Guid.NewGuid().ToString();

            iZettleSDK.Shared.RefundAmount(null, paymentReference, _lastReference, this, (arg0, arg1) =>
            {
                _lastPaymentInfo = arg0;
                _lastError = arg1;

                ShowConsole();
            });
        }

        partial void enforceAccount(UIButton btnEnforce)
        {
            var alertVc = UIAlertController.Create("Enforce user account", "Enter email", UIAlertControllerStyle.Alert);

            var enforce = UIAlertAction.Create("Enforce", UIAlertActionStyle.Default, (obj) =>
            {
                var email = alertVc.TextFields[0].Text;

                iZettleSDK.Shared.EnforcedUserAccount = string.IsNullOrWhiteSpace(email) ? null : email;

                var btnEnforceTitle = string.IsNullOrWhiteSpace(email) ? "Enforce account" : $"Enforced: {email}";
                btnEnforce.SetTitle(btnEnforceTitle, UIControlState.Normal);
            });

            var cancel = UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, (obj) =>
            {

            });

            alertVc.AddAction(enforce);
            alertVc.AddAction(cancel);
            alertVc.AddTextField(txtEmail =>
            {
                txtEmail.Text = iZettleSDK.Shared.EnforcedUserAccount;
                txtEmail.Placeholder = "Email";
                txtEmail.KeyboardType = UIKeyboardType.EmailAddress;
            });

            PresentViewController(alertVc, true, null);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (string.Equals(segue.Identifier, "showConsole") == false && sender != this) return;

            var consoleVc = segue.DestinationViewController as ConsoleViewController;

            consoleVc.AddToLog((NSObject)_lastError ?? (NSObject)_lastPaymentInfo);
        }

        void UpdateLastPaymentToolbar()
        {
            lastPaymentInfoToolBar.Hidden = _lastPaymentInfo?.Description == null;

            if (!lastPaymentInfoToolBar.Hidden)
            {
                var btnLastPayment = lastPaymentInfoToolBar.Items[0];
                btnLastPayment.Title = string.Format("{0:F}", _timestamp);
            }
        }

        void ShowConsole()
        {
            PerformSegue("showConsole", this);
        }

        void MakeViewRound(UIView aView)
        {
            UIBezierPath circlePath = UIBezierPath.FromOval(aView.Bounds);
            var shape = new CAShapeLayer();
            shape.Path = circlePath.CGPath;

            aView.Layer.Mask = shape;
        }
    }
}