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
            //app.Repl();
            app.Screenshot("First screen.");
            app.Tap(x => x.Text("Bears"));
            var result = app.Query(x => x.Text("American Black Bear"));
            var targetText = "China";
            var count = app.Query(x => x.Property("text").Contains(targetText)).Count();
            Assert.That(count,Is.EqualTo(1), String.Format("There is no element that contain '%s'", targetText));
        }
    }
}
