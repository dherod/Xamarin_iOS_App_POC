using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace POC_SVA_IOS
{
	partial class ViewControllerCeleste : UIViewController
	{
		public ViewControllerCeleste (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			celesteCloseButton.TouchUpInside += (sender, e) => 
				DismissViewController(true, null);
		}
	}
}
