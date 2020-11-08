using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.iOS;
using SPAutoma.PageObjects;
using SPAutoma.PageObjects.Level1;

namespace SPAutoma.Tests.Level1
{
    [Obsolete]
    [TestClass]
    public class FindTest
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
        public void FindPane()
        {
            SignIn sample = new SignIn(driver);
            Find fi = new Find(driver);
            //sample.auth();       
            fi.FindOpenLinks();
            fi.FindOpenfiles();
            //sample.signOutApp();
        }

        [TestMethod, TestCategory("BVT")]
        public void FindOpenLpc()
        {
            Find fi = new Find(driver);
            fi.FindLpcard();
        }
    }
}
