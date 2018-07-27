using MVVMCrossLibTemplate.TestApp.Core.ViewModels;
using MvvmCross.ViewModels;

namespace MVVMCrossLibTemplate.TestApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Setup.Register();

            RegisterAppStart<FirstViewModel>();
        }
    }
}
