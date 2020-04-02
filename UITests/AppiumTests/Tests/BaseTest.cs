using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;

namespace AppiumTests.Tests
{
    public class BaseTest
    {
        protected AppiumDriver<AppiumWebElement> driver;

        public BaseTest()
        {
            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "android");
            appiumOptions.AddAdditionalCapability("appActivity", "crc649c546b802d1e9379.MainActivity");
            appiumOptions.AddAdditionalCapability("appPackage", "com.companyname.xaminals");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.FullReset, false);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.NoReset, true);

            AppiumLocalService appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            appiumLocalService.Start();
            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
            driver.LaunchApp();
        }
    }
}
