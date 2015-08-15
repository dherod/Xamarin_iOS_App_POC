using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace POC_SVA_IOS
{
	partial class ViewControllerSnow : UIViewController
	{
		public ViewControllerSnow (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			snowCloseButton.TouchUpInside += (sender, e) => 
				DismissViewController(true, null);
		}
	}
}
