// /*******************************************************************
//  *
//  * AppDelegate.cs copyright 2017 ben, 42nd Parallel - ALL RIGHTS RESERVED.
//  *
//  *******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace SharedApp.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			Forms9Patch.iOS.Settings.LicenseKey = "4EVK-FBGY-GGFQ-6MGW-RK5A-8B9A-4EAP-9RL8-AA82-2GLA-FAAX-NDQK-Q93G";

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
