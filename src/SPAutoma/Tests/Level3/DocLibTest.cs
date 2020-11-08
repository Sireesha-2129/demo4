using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.iOS;
using SPAutoma.PageObjects;
using SPAutoma.PageObjects.Level3;

namespace SPAutoma.Tests.Level3
{
    [Obsolete]
    [TestClass]
    public class DocLibTest
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
        public void doclibPane()
        {
            //SignIn sample = new SignIn(driver);
            DocLib doc = new DocLib(driver);
            //sample.auth();       
            doc.OpenSite();
        }
    }
}