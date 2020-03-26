using System;
using Xamarin.UITest;

namespace UITestsSpecFlow.Pages
{
    public abstract class BasePage
    {
        protected IApp app => AppManager.App;
        protected bool OnAndroid => AppManager.Platform == Platform.Android;
        protected bool OniOS => AppManager.Platform == Platform.iOS;

        public BasePage()
        {
        }
    }
}
