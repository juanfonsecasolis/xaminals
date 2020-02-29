using System;
using Xamarin.UITest;

namespace UITests.Pages
{
    public abstract class Page
    {
        protected IApp app;

        public Page(IApp app)
        {
            this.app = app;
        }
    }
}
