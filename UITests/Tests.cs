using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using UITests.Pages;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        Platform platform;
        CategoryPage homePage;

        public Tests(Platform platform)
        {
            this.platform = platform;
            this.homePage = new CategoryPage();
        }

        [SetUp]
        public void BeforeEachTest()
        {
            Settings.AppContext = AppInitializer.StartApp(platform);
        }
        
        [Test]
        public void VerifyAllTabsContainAtLeastOneElement()
        {
            int count;
            foreach (var category in new[] {"Domestic","Monkeys","Elephants","Bears"}) {
                homePage.switchToCategory(category);
                count = homePage.countVisibleAnimals();
                Assert.That(count, Is.GreaterThanOrEqualTo(1), String.Format("No elements are displayed in the tab {0}.", category));
            }
        }

        [Test]
        public void VerifyElementsAreClickable()
        {
            String category = "Domestic";
            String animal = "Sphynx";
            String targetDescription = "The Sphynx cat is a breed of cat known for its lack of coat(fur).";
            AnimalPage animalPage = homePage.tapAnimal(category, animal);
            Assert.That(animalPage.getDescription().Contains(targetDescription), Is.True, String.Format("Text '{0}' not found in description", targetDescription));
        }

        [Test]
        public void VerifySearchBoxIsWorking()
        {
            String animal = "Highlander";
            String targetDescription = "The Highlander (also known as the Highlander Shorthair)";
            AnimalPage animalPage = homePage.searchAnimal(animal);
            Assert.That(animalPage.getDescription().Contains(targetDescription), Is.True, String.Format("Text '{0}' not found in description",targetDescription));
        }
    }
}
