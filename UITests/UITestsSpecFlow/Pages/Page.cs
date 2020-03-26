using System;
using Xamarin.UITest;

namespace UITestsSpecFlow.Pages
{
    public abstract class BasePage
    {
        protected IApp app;

        public BasePage(IApp app)
        {
            this.app = app;
        }
    }
}
