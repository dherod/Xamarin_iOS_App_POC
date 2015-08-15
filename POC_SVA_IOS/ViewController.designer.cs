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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton boButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton celesteButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton snowButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (boButton != null) {
				boButton.Dispose ();
				boButton = null;
			}
			if (celesteButton != null) {
				celesteButton.Dispose ();
				celesteButton = null;
			}
			if (snowButton != null) {
				snowButton.Dispose ();
				snowButton = null;
			}
		}
	}
}
