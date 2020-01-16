using Android.App;
using Android.Content.PM;
using MvvmCross.Core;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;

namespace MVVMCrossLibTemplate.TestApp.Droid
{
    [Activity(
        Label = "MVVMCrossLibTemplate"
        , MainLauncher = true
        , Icon = "@mipmap/ic_launcher"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity<MvxAndroidSetup<Core.App>, Core.App>
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
            MvxSetup.RegisterSetupType<Setup>(this.GetType().Assembly);
        }

        // Stop the user from hitting back during the splash screen startup
        public override void OnBackPressed()
        {
        }
    }
}
