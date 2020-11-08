using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.iOS;
using SPAutoma.PageObjects;

namespace SPAutoma
{
    [Obsolete]
    [TestClass]
    public class SignInTest
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
        public void login()
        {
            SignIn sample = new SignIn(driver);

            sample.auth();
        }
       
    }
}
