using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using UITestsSpecFlow.Pages;
using Xamarin.UITest;

namespace UITestsSpecFlow
{
    public abstract class BaseTestFixture
    {
        protected BaseTestFixture(Platform platform)
        {
            AppManager.Platform = platform;
        }
        
    }
}
