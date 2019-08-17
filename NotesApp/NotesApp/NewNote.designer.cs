// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NotesApp
{
	[Register ("NewNote")]
	partial class DetailViewController
	{
		[Outlet]
		UIKit.UITextView NotesContent { get; set; }

		[Outlet]
		UIKit.UITextField NotesLabel { get; set; }

		[Action ("CancelAction:")]
		partial void CancelAction (Foundation.NSObject sender);

		[Action ("DoneAction:")]
		partial void DoneAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (NotesLabel != null) {
				NotesLabel.Dispose ();
				NotesLabel = null;
			}

			if (NotesContent != null) {
				NotesContent.Dispose ();
				NotesContent = null;
			}
		}
	}
}
