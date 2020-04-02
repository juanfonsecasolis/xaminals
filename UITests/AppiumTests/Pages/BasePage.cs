using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;

namespace AppiumTests.Pages
{

    public abstract class BasePage
    {
        protected AppiumDriver<AppiumWebElement> driver;
        // TODO: public abstract PlatformQuery trait();

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
