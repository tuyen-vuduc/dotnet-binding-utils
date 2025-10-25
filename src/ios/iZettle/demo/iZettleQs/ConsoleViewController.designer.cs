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
    [Register ("ConsoleViewController")]
    partial class ConsoleViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem btnDone { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView logTextView { get; set; }

        [Action ("done:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void done (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnDone != null) {
                btnDone.Dispose ();
                btnDone = null;
            }

            if (logTextView != null) {
                logTextView.Dispose ();
                logTextView = null;
            }
        }
    }
}