using Android.Content;
using MVVMCrossLibTemplate.TestApp.Core;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Presenters;

namespace MVVMCrossLibTemplate.TestApp.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override void InitializeIoC()
        {
            base.InitializeIoC();
        }

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories(registry);
            MvxAppCompatSetupHelper.FillTargetFactories(registry);
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            //AppCenter.Start("", typeof(Analytics), typeof(Crashes));
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter() => new MvxAppCompatViewPresenter(AndroidViewAssemblies);

    }
}
