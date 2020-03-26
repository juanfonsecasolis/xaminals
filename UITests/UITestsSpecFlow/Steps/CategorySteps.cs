using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using UITestsSpecFlow.Pages;

namespace UITestsSpecFlow.Steps
{
    [Binding]
    public class CategorySteps
    {
        [Given("that I am in the home screen")]
        public void GivenIAmInTheHomeScreen()
        {

        }

        [When("I navigate through the categories")]
        public void WhenINavigateThroughTheCategories()
        {
            // TODO
        }

        [Then("at least one animal should be displayed per category")]
        public void ThenAtLeastOneAnimalShouldBeDisplayedPerCategory()
        {
            CategoryPage categoryPage = new CategoryPage();
            int count;
            foreach (var category in new[] { "Domestic", "Monkeys", "Elephants", "Bears" })
            {
                categoryPage.switchToCategory(category);
                count = categoryPage.countVisibleAnimals();
                Assert.That(count, Is.GreaterThanOrEqualTo(1),
                    String.Format("No elements are displayed in the tab {0}.", category));
            }
        }
    }
}
