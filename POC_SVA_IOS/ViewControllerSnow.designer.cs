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
	[Register ("ViewControllerSnow")]
	partial class ViewControllerSnow
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton snowCloseButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (snowCloseButton != null) {
				snowCloseButton.Dispose ();
				snowCloseButton = null;
			}
		}
	}
}
