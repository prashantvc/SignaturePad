using System;

using UIKit;

namespace SignaturePad
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var clearButton = new UIBarButtonItem(UIBarButtonSystemItem.Refresh);
            clearButton.Clicked += ClearButton_Clicked;
            NavigationItem.RightBarButtonItem = clearButton;

            var saveButton = new UIBarButtonItem(UIBarButtonSystemItem.Save);
            saveButton.Clicked += SaveButton_Clicked;
            NavigationItem.LeftBarButtonItem = saveButton;
        }

        void SaveButton_Clicked(object sender, EventArgs e)
        {

            //signaturePad.Image.SaveToPhotosAlbum()
        }


        void ClearButton_Clicked(object sender, EventArgs e)
        {
            signaturePad.ClearPad();
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
