using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms.Platform.Android;

namespace Xamarin.Forms.Samples.Csharp.Droid
{
	[Activity(Label = "Xamarin.Forms.Samples.Xaml.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);
			Forms.Init(this, bundle);

			// Visual Studio Mobile Center
			// https://mobile.azure.com/users/nanotaboada/apps/codevel-android/
			MobileCenter.Start("f46000b1-3ce1-446e-9854-4a36766e5adb", typeof(Analytics), typeof(Crashes));

			LoadApplication(new App());
		}
	}
}
