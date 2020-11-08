using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.iOS;
using SPAutoma.PageObjects;
using SPAutoma.PageObjects.Level2;
using SPAutoma.PageObjects.Level3;

namespace SPAutoma.Tests.Level2
{
    [Obsolete]
    [TestClass]
    public class MoreSitesTest
    {
        public static IOSDriver<IOSElement> driver;
        [TestInitialize]
        public void StartPoint()
        {
            SetupCapabilities cap = new SetupCapabilities();
            driver = cap.Setup();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [TestMethod, TestCategory("BVT")]
        public void OpenDocWebPart()
        {
            //SignIn sample = new SignIn(driver);
            MoreSites ms = new MoreSites(driver);
            ms.OpenDocWp();
            //sample.auth(); 
        }
    }
}