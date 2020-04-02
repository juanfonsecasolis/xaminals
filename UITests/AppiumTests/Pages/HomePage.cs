using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;

namespace AppiumTests.Pages
{
    public class HomePage : BasePage
    {

        public HomePage(AppiumDriver<AppiumWebElement> driver) : base(driver)
        {
        }

        internal AnimalPage tapAnimal(string category, string animal)
        {
            driver.FindElement(genericCategoryLocator(category)).Click();
            //scrollDown();
            driver.FindElement(firstAnimalLocator).Click();
            return new AnimalPage(driver);
        }
    }
}
