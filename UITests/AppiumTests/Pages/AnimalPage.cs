using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace AppiumTests.Pages
{

    public class AnimalPage : BasePage
    {
        By backButtonLocator = ByAccessibilityId.XPath("//android.widget.ImageButton[@content-desc=\"OK\"]");

        public AnimalPage(AppiumDriver<AppiumWebElement> driver) : base(driver)
        {
        }

    }
}
