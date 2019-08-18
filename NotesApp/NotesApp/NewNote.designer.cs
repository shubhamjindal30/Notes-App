// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
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
        }
    }
}