using OpenQA.Selenium.Appium.iOS;
using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System.Threading;

namespace SPAutoma
{
    [Obsolete]
    class SetupCapabilities
    {
        public static IOSDriver<IOSElement> driver = null;

        public IOSDriver<IOSElement> Setup()
        {
            AppiumOptions capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability("platformName", "iOS");
            capabilities.AddAdditionalCapability("platformVersion", "13.1");
            //capabilities.AddAdditionalCapability("platformVersion", "13.0");
            capabilities.AddAdditionalCapability("automationName", "XCUITest");
            capabilities.AddAdditionalCapability("deviceName", "iPhone 11");
            capabilities.AddAdditionalCapability("udid", "CA3F023A-B1AC-4B24-A679-9769E76EEBB8");
            //capabilities.AddAdditionalCapability("udid", "4B5E6DDA-BD09-46BF-93B7-F1CC8F5B34CF");
            //capabilities.AddAdditionalCapability("app", "/Users/likhitha/Desktop/SharePoint.app");
            //capabilities.AddAdditionalCapability("app", "/Users/csy/Desktop/SharePoint.app");

            //Connecting to Appium Server
            var driver = new IOSDriver<IOSElement>(new Uri("http://10.171.164.54:4723/wd/hub"), capabilities, new TimeSpan(0, 30, 0));
            //var driver = new IOSDriver<IOSElement>(new Uri("http://10.10.73.33:4723/wd/hub"), capabilities, new TimeSpan(0, 30, 0));
            //var driver = new IOSDriver<IOSElement>(new Uri("http://10.10.57.253:4723/wd/hub"), capabilities, new TimeSpan(0, 30, 0));

            return driver;
        }
    }
}