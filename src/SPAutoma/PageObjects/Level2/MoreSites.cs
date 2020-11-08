using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SPAutoma.PageObjects.Level2
{
    class MoreSites
    {
        private IWebDriver dr;

        [Obsolete]
        public MoreSites(IWebDriver driver)
        {
            this.dr = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='More sites']")]
        private IWebElement MoreSites1 { get; set; }
        public IWebElement getMoreSites1()
        {
            return MoreSites1;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='STS']")]
        private IWebElement Site { get; set; }
        public IWebElement getSite()
        {
            return Site;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Navigation Menu button']")]
        private IWebElement Ham { get; set; }
        public IWebElement getHam()
        {
            return Ham;
        }        
        [FindsBy(How = How.XPath, Using = "//*[@value='Document Web Part']")]
        private IWebElement DocWebPart { get; set; }
        public IWebElement getDocWebPart()
        {
            return DocWebPart;
        }        
        [FindsBy(How = How.XPath, Using = "//*[@name='All Files'][2]")]
        private IWebElement DocWpFolder { get; set; }
        public IWebElement getDocWpFolder()
        {
            return DocWpFolder;
        }        
        [FindsBy(How = How.XPath, Using = "//*[@name='Document.docx']")]
        private IWebElement DocWpFileOpen { get; set; }
        public IWebElement getDocWpFileOpen()
        {
            return DocWpFileOpen;
        }        
        [FindsBy(How = How.XPath, Using = "//*[@name='Back']")]
        private IWebElement Back { get; set; }
        public IWebElement getBack()
        {
            return Back;
        }
        public void OpenDocWp()
        {
            getMoreSites1().Click();
            Thread.Sleep(2000);
            getSite().Click();
            Thread.Sleep(2000);
            getHam().Click();
            Thread.Sleep(2000);            
            getDocWebPart().Click();
            Thread.Sleep(2000);
            getDocWpFolder().Click();
            Thread.Sleep(1000);
            getDocWpFolder().Click();
            Thread.Sleep(2000);
            getDocWpFileOpen().Click();
            Thread.Sleep(3000);
            getBack().Click();
            getBack().Click();
            getBack().Click();
        }
    }
}
