using System;
using UIKit;
using Foundation;
using System.Linq;
using CoreGraphics;

namespace SignaturePad
{
    [Register("SignatureView")]
    public class SignatureView : UIImageView
    {

        public SignatureView(IntPtr handle) : base(handle)
        {
           // BackgroundColor = UIColor.DarkGray;
        }

        public override void TouchesMoved(NSSet touches, UIEvent evt)
        {
            var touchesArray = touches.ToArray<UITouch>();
            var touch = touchesArray.FirstOrDefault();

            if (touch == null)
                return;

            UIGraphics.BeginImageContextWithOptions(Bounds.Size, false, 0);
            var context = UIGraphics.GetCurrentContext();
            this.Image?.Draw(Bounds);

            DrawSignature(context, touch);

            this.Image = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
        }

        void DrawSignature(CGContext context, UITouch touch)
        {
            var previousLocation = touch.PreviousLocationInView(this);
            var location = touch.LocationInView(this);

            context.SetStrokeColor(color.CGColor);
            context.SetLineWidth(width);
            context.SetLineCap(CGLineCap.Round);

            context.MoveTo(previousLocation.X, previousLocation.Y);
            context.AddLineToPoint(location.X, location.Y);
            context.StrokePath();
        }

        nfloat width = 6;
        readonly UIColor color = UIColor.Red;
    }
}
