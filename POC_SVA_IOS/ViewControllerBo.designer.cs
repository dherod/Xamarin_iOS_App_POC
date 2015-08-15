// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace POC_SVA_IOS
{
	[Register ("ViewControllerBo")]
	partial class ViewControllerBo
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton boCloseButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (boCloseButton != null) {
				boCloseButton.Dispose ();
				boCloseButton = null;
			}
		}
	}
}
