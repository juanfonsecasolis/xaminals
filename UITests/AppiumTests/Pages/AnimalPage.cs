using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;

namespace AppiumTests.Pages
{
    public class AnimalPage : BasePage
    {

        public AnimalPage(AppiumDriver<AppiumWebElement> driver) : base(driver)
        {
        }

        public String getDescription()
        {
            return "";
        }

        internal String getHeader()
        {
            return "";
        }
    }
}
