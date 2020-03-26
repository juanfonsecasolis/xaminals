using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using UITestsSpecFlow.Pages;
using UITestsSpecFlow.Steps;
using Xamarin.UITest;

namespace UITestsSpecFlow
{
    [Binding]
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public partial class TestFeature : BaseTestFixture
    {
        public TestFeature(Platform platform) : base(platform)
        {
            
        }

    }
}
