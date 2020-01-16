using MVVMCrossLibTemplate.TestApp.Core;
using Foundation;
using MvvmCross.Platforms.Ios.Core;
using UIKit;

namespace MVVMCrossLibTemplate.TestApp.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            //AppCenter.Start("", typeof(Analytics), typeof(Crashes));

            return base.FinishedLaunching(application, launchOptions);
        }
    }
}
