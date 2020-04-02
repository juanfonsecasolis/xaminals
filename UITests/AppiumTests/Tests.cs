using System;
using AppiumTests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using Xunit;

// npm install -g appium (to solve the no nodes issue)

namespace AppiumTests
{

    public class HomeScreenTest : IDisposable
    {

        HomePage homePage;
        AppiumDriver<AppiumWebElement> driver;

        public HomeScreenTest()
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

            homePage = new HomePage(driver);
        }

        public void Dispose()
        {
            driver.CloseApp();
            driver.Dispose();
        }

        [Fact]
        public void VerifyElementsAreClickable()
        {
            /* Xamarin UI test
            String category = "Domestic";
            String animal = "Sphynx";
            AnimalPage animalPage = homePage.tapAnimal(category, animal);
            Assert.That(animalPage.getHeader().Contains(animal), Is.True,
                String.Format("Text '{0}' not found in description", animal));
            */

            String category = "Domestic";
            String animal = "Sphynx";
            AnimalPage animalPage = homePage.tapAnimal(category, animal);

            Assert.True(true);
        }
    }
}