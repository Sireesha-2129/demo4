using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPAutoma.PageObjects.Level1
{
    class Me
    {
        private IWebDriver dr;

        [Obsolete]
        public Me(IWebDriver driver)
        {
            this.dr = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Me']")]
        private IWebElement MeTab { get; set; }
        public IWebElement getMeTab()
        {
            return MeTab;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Settings']")]
        private IWebElement MeSettings { get; set; }
        public IWebElement getMeSettings()
        {
            return MeSettings;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Recent Tab, 1 of 2']")]
        private IWebElement MeRecentTab { get; set; }
        public IWebElement getMeRecentTab()
        {
            return MeRecentTab;
        }        
        [FindsBy(How = How.XPath, Using = "//*[@name='Show All']")]
        private IWebElement MeRecentShowAll { get; set; }
        public IWebElement getMeRecentShowAll()
        {
            return MeRecentShowAll;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='More actions']")]
        private IWebElement MeRecentOptions { get; set; }
        public IWebElement getMeRecentOptions()
        {
            return MeRecentOptions;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Share']")]
        private IWebElement MeRecentOptShare { get; set; }
        public IWebElement getMeRecentOptShare()
        {
            return MeRecentOptShare;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Save for later']")]
        private IWebElement MeRecentOptSave { get; set; }
        public IWebElement getMeRecentOptSave()
        {
            return MeRecentOptSave;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Details']")]
        private IWebElement MeRecentOptDetails { get; set; }
        public IWebElement getMeRecentOptDetails()
        {
            return MeRecentOptDetails;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Saved Tab, 2 of 2']")]
        private IWebElement MeSavedTab { get; set; }
        public IWebElement getMeSavedTab()
        {
            return MeSavedTab;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Show All']")]
        private IWebElement MeSavedShowAll { get; set; }
        public IWebElement getMeSavedShowAll()
        {
            return MeSavedShowAll;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='More actions']")]
        private IWebElement MeSavedOptions { get; set; }
        public IWebElement getMeSavedOptions()
        {
            return MeSavedOptions;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Share']")]
        private IWebElement MeSavedOptShare { get; set; }
        public IWebElement getMeSavedOptShare()
        {
            return MeSavedOptShare;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Save for later']")]
        private IWebElement MeSavedOptSave { get; set; }
        public IWebElement getMeSavedOptSave()
        {
            return MeSavedOptSave;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Details']")]
        private IWebElement MeSavedOptDetails { get; set; }
        public IWebElement getMeSavedOptDetails()
        {
            return MeSavedOptDetails;
        }

    }
}
