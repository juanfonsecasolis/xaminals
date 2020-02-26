using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void VerifyAllTabsContainAtLeastOneElement()
        {
            int count;
            foreach (var tab in new[] {"Domestic","Monkeys","Elephants","Bears"}) { 
                app.Tap(x => x.Text(tab));
                count = app.Query(x => x.Class("ItemContentView")).Count();
                Assert.That(count, Is.GreaterThanOrEqualTo(1), String.Format("No elements are displayed in the tab {0}.",tab));
            }
        }

        [Test]
        public void VerifyElementsAreClickable()
        {
            
            String cat = "Domestic";
            String animal = "Sphynx";
            String targetText = "The Sphynx cat is a breed of cat known for its lack of coat(fur).";
            app.Tap(x => x.Text(cat));
            app.ScrollDownTo(x => x.Text(animal));
            app.Tap(x => x.Text(animal));
            bool result = app.Query(x => x.Class("LabelRenderer"))[2].Text.Contains(targetText);
            Assert.That(result, Is.True,String.Format("Content text not found for {0}:{1}",cat,animal));
        }

        [Test]
        public void VerifySearchBoxIsWorking()
        {
            app.ClearText(x => x.Class("AppCompatAutoCompleteTextView"));            app.EnterText(x => x.Class("AppCompatAutoCompleteTextView"), "Highlander");
            app.Tap(x => x.Text("Highlander"));
            app.Query(x => x.Class("LabelRenderer"))[2].Text.Contains("The Highlander (also known as the Highlander Shorthair)");
        }
    }
}
