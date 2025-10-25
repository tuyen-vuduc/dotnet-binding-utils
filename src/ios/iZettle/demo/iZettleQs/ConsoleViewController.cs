using Foundation;
using System;
using UIKit;

namespace iZettleQs
{
    public partial class ConsoleViewController : UIViewController
    {
        string log;

        public ConsoleViewController (IntPtr handle) : base (handle)
        {
        }

        public void AddToLog(NSObject obj) {
            if (obj == null) return;

            var date = DateTime.Now;

            log = $@"
{date.ToLongTimeString()}
{obj.GetType().Name}:{obj}


{log}
";
        }

        partial void done(UIBarButtonItem btnItem) {
            DismissViewController(true, null);
        }
    }
}