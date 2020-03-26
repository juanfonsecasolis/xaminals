using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace UITestsSpecFlow
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public static void RegisterPages()
        {
            AppManager.Platform = Xamarin.UITest.Platform.Android; // TODO: need to fix this
            AppManager.StartApp();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
        }
    }
}
