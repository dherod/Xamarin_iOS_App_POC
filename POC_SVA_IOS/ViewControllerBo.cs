using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace POC_SVA_IOS
{
	partial class ViewControllerBo : UIViewController
	{
		public ViewControllerBo (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			boCloseButton.TouchUpInside += (sender, e) => 
				DismissViewController(true, null);
		}
	}
}
