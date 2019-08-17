using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
namespace NotesApp
{
    public class TableViewSource : UITableViewSource
    {
        List<string> Names, Content;
        UIViewController ParentViewController;
        public TableViewSource(UIViewController ParentViewController)
        {
            this.ParentViewController = ParentViewController;
            Names = NoteContent.Names;
            Content = NoteContent.Content;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("cell");
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, "cell");
                cell.TextLabel.Text = Names[indexPath.Row];
            }
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Names.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            string NameSelected = Names[indexPath.Row];
            string ContentSelected = Content[indexPath.Row];

            var alert = UIAlertController.Create("Edit Note", "", UIAlertControllerStyle.Alert);
            alert.AddTextField((obj) =>
            {
                obj.Font = UIFont.SystemFontOfSize(20);
                obj.TextAlignment = UITextAlignment.Center;
                obj.Text = NameSelected;

            });
            alert.AddTextField((obj) =>
            {
                obj.Font = UIFont.SystemFontOfSize(20);
                obj.TextAlignment = UITextAlignment.Center;
                obj.Text = ContentSelected;

            });
            alert.AddAction(UIAlertAction.Create("Done", UIAlertActionStyle.Default, (obj) =>
            {
                tableView.DeselectRow(indexPath, true);
            }));

            ParentViewController.PresentViewController(alert, true, null);

        }
    }
}
