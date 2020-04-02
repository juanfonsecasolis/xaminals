using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

namespace AppiumTests.Pages
{

    public abstract class BasePage
    {
        protected AppiumDriver<AppiumWebElement> driver;

        //@FindBy(XPath="//[contains(text(),'Domestic')]")
        protected Func<string, By> genericCategoryLocator = x => By.XPath(String.Format(
            "//android.widget.FrameLayout[@content-desc='{0}']/android.widget.ImageView", x));
        protected Func<string, By> genericTextLocator = x => MobileBy.AndroidUIAutomator(
            String.Format("new UiSelector().textContains(\"{0}\")",x));
        protected By firstAnimalLocator = By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.support.v4.widget.DrawerLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout[1]/android.view.ViewGroup/android.support.v4.view.ViewPager/android.view.ViewGroup/android.view.ViewGroup/android.support.v7.widget.RecyclerView/android.view.ViewGroup[1]/android.view.ViewGroup");

        public BasePage(AppiumDriver<AppiumWebElement> driver)
        {
            this.driver = driver;
        }

        public void tapElement(AppiumWebElement element) {
            TouchActions actions = new TouchActions(driver);
            actions.SingleTap(element);
            actions.Perform();
        }

        public void scrollDown()
        {
            TouchActions actions = new TouchActions(driver);
            actions.Scroll(50,0);
        }
    }
}
