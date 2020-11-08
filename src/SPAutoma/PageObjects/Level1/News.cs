using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPAutoma.PageObjects.Level1
{
    class News
    {
        private IWebDriver dr;

        [Obsolete]
        public News(IWebDriver driver)
        {
            this.dr = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='News']")]
        private IWebElement NewsTab { get; set; }
        public IWebElement getNewsTab()
        {
            return NewsTab;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Filter All news']")]
        private IWebElement NewsFilter { get; set; }
        public IWebElement getNewsFilter()
        {
            return NewsFilter;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='More actions']")]
        private IWebElement NewsOptions { get; set; }
        public IWebElement getNewsOptions()
        {
            return NewsOptions;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Share']")]
        private IWebElement NewsOptShare { get; set; }
        public IWebElement getNewsOptShare()
        {
            return NewsOptShare;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Save for later']")]
        private IWebElement NewsOptSave { get; set; }
        public IWebElement getNewsOptSave()
        {
            return NewsOptSave;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Details']")]
        private IWebElement NewsOptDetails { get; set; }
        public IWebElement getNewsOptDetails()
        {
            return NewsOptDetails;
        }
        //Method Implementation//
        public void auth()
        {
            
        }

    }
}
