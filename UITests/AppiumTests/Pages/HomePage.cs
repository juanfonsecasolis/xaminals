using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;

namespace AppiumTests.Pages
{
    public class HomePage : BasePage
    {
        protected Func<string, By> genericCategoryLocator = x => By.XPath(String.Format(
            "//android.widget.FrameLayout[@content-desc='{0}']/android.widget.ImageView", x));
        protected Func<string, By> genericTextLocator = x => MobileBy.AndroidUIAutomator(
            String.Format("new UiSelector().textContains(\"{0}\")", x));
        protected By firstAnimalLocator = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.support.v4.view.ViewPager/android.view.ViewGroup/android.view.ViewGroup/android.support.v7.widget.RecyclerView/android.view.ViewGroup[1]/android.view.ViewGroup");

        public HomePage(AppiumDriver<AppiumWebElement> driver) : base(driver)
        {
        }

        internal AnimalPage tapAnimal(string category, string animal)
        {
            driver.FindElement(genericCategoryLocator(category)).Click();
            scrollDown();
            driver.FindElement(firstAnimalLocator).Click();
            return new AnimalPage(driver);
        }
    }
}
