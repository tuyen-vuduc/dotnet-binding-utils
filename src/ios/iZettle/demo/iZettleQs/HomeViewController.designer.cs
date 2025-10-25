// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iZettleQs
{
    [Register ("HomeViewController")]
    partial class HomeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel amountLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        iZettleQs.AmountWheel amountWheel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton chargeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView dotView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIToolbar lastPaymentInfoToolBar { get; set; }

        [Action ("charge:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void charge (UIKit.UIButton sender);

        [Action ("enforceAccount:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void enforceAccount (UIKit.UIButton sender);

        [Action ("lastPaymentInfo:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void lastPaymentInfo (UIKit.UIBarButtonItem sender);

        [Action ("refundLastPayment:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void refundLastPayment (UIKit.UIBarButtonItem sender);

        [Action ("settings:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void settings (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (amountLabel != null) {
                amountLabel.Dispose ();
                amountLabel = null;
            }

            if (amountWheel != null) {
                amountWheel.Dispose ();
                amountWheel = null;
            }

            if (chargeButton != null) {
                chargeButton.Dispose ();
                chargeButton = null;
            }

            if (dotView != null) {
                dotView.Dispose ();
                dotView = null;
            }

            if (lastPaymentInfoToolBar != null) {
                lastPaymentInfoToolBar.Dispose ();
                lastPaymentInfoToolBar = null;
            }
        }
    }
}