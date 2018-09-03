// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace SignaturePad
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        SignaturePad.SignatureView signaturePad { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (signaturePad != null) {
                signaturePad.Dispose ();
                signaturePad = null;
            }
        }
    }
}