using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestProject
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

        /*
        [Test]
        public void TestRepl()
        {
            app.Repl();
        }
        */
        [Test]
        public void TestButtons()
        {
            app.Tap(b => b.Marked("Button_1"));
            app.Tap(b => b.Marked("Button_7"));
            app.Tap(b => b.Marked("Button_1"));
            app.Tap(b => b.Marked("Button_2"));
            app.Tap(b => b.Marked("Button_-"));
            app.Tap(b => b.Marked("Button_2"));
            app.Tap(b => b.Marked("Button_^"));
            app.Tap(b => b.Marked("Button_3"));
            app.Tap(b => b.Marked("Equals"));
        }

        [Test]
        public void TestMonkeyUser()
        {
            app.Tap(b => b.Marked("Button_-"));
            app.Tap(b => b.Marked("Button_^"));
            app.Tap(b => b.Marked("Button_."));
            app.Tap(b => b.Marked("Button_/"));
            app.Tap(b => b.Marked("Button_*"));
            app.Tap(b => b.Marked("Equals"));
        }
    }
}
