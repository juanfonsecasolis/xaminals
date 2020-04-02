using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;

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
