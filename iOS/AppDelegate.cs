using Foundation;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using UIKit;
using Xamarin.Forms.Platform.iOS;


namespace Xamarin.Forms.Samples.Csharp.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			Forms.Init();

			// Visual Studio Mobile Center
			// https://mobile.azure.com/users/nanotaboada/apps/codevel-ios
			MobileCenter.Start("c73d6909-508b-4ea7-80da-d9028738987c", typeof(Analytics), typeof(Crashes));

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
