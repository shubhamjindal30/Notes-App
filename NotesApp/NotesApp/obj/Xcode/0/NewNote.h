// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface NewNote : UIViewController {
	UITextView *_NotesContent;
	UITextField *_NotesLabel;
}

@property (nonatomic, retain) IBOutlet UITextView *NotesContent;

@property (nonatomic, retain) IBOutlet UITextField *NotesLabel;

- (IBAction)CancelAction:(id)sender;

- (IBAction)DoneAction:(id)sender;

@end
