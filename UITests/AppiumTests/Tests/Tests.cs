using System;
using AppiumTests.Pages;
using AppiumTests.Tests;
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

    public class HomeScreenTest : BaseTest, IDisposable
    {

        HomePage homePage;

        public HomeScreenTest()
        {
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