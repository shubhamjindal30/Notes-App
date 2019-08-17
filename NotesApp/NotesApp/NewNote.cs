using System;

using UIKit;

namespace NotesApp
{
    public partial class DetailViewController : UIViewController
    {
        public DetailViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            NotesContent.WeakDelegate = this;

            
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void DoneAction(Foundation.NSObject sender)
        {
            this.DismissModalViewController(true);
        }

        partial void CancelAction(Foundation.NSObject sender)
        {
            this.DismissModalViewController(true);
        }

        
    }
}

