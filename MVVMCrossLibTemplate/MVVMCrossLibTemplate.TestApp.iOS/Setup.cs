using MVVMCrossLibTemplate.TestApp.Core;
using MvvmCross.Platforms.Ios.Core;
using UIKit;
using MvvmCross.IoC;

namespace MVVMCrossLibTemplate.TestApp.iOS
{
    public class Setup : MvxIosSetup<App>
    {
        protected override IMvxIoCProvider InitializeIoC()
        {
            return base.InitializeIoC();
        }
    }
}
