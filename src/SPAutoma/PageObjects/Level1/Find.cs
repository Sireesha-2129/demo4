using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SPAutoma.PageObjects.Level1
{
    class Find
    {
        private IWebDriver dr;

        [Obsolete]
        public Find(IWebDriver driver)
        {
            this.dr = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Find']")]
        private IWebElement FindTab { get; set; }
        public IWebElement getFindTab()
        {
            return FindTab;
        }        
        [FindsBy(How = How.XPath, Using = "//*[@name='Back']")]
        private IWebElement Back { get; set; }
        public IWebElement getBack()
        {
            return Back;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='617C786B 2F30 4DC3 BBE0 15404C']")]
        private IWebElement FindHomeIcon { get; set; }
        public IWebElement getFindHomeIcon()
        {
            return FindHomeIcon;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Search']")]
        private IWebElement FindSearch { get; set; }
        public IWebElement getFindSearch()
        {
            return FindSearch;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='More sites']")]
        private IWebElement MoreSites { get; set; }
        public IWebElement getMoreSites()
        {
            return MoreSites;
        }
        //Base Element//
        [FindsBy(How = How.XPath, Using = "//*[@name='More actions']")]
        private IWebElement BaseMoreOptions { get; set; }
        public IWebElement getBaseMoreOptions()
        {
            return BaseMoreOptions;
        }        
        [FindsBy(How = How.XPath, Using = "//*[@name='Share']")]
        private IWebElement BaseOptShare { get; set; }
        public IWebElement getBaseOptShare()
        {
            return BaseOptShare;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Stop following']")]
        private IWebElement BaseOptFollow { get; set; }
        public IWebElement getBaseOptFollow()
        {
            return BaseOptFollow;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Details']")]
        private IWebElement BaseOptDetails { get; set; }
        public IWebElement getBaseOptDetails()
        {
            return BaseOptDetails;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='More people']")]
        private IWebElement MorePeople { get; set; }
        public IWebElement getMorePeople()
        {
            return MorePeople;
        }        
        [FindsBy(How = How.XPath, Using = "//*[@name='Alex Wilber']")]
        private IWebElement FindLpc { get; set; }
        public IWebElement getFindLpc()
        {
            return FindLpc;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Word file: Document8, modified Wed at 3:06 PM, 18 KB']")]
        private IWebElement FindLpcFile { get; set; }
        public IWebElement getFindLpcFile()
        {
            return FindLpcFile;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Show More Files']")]
        private IWebElement FindLpcShowMoreFiles { get; set; }
        public IWebElement getFindLpcShowMoreFiles()
        {
            return FindLpcShowMoreFiles;
        }        
        [FindsBy(How = How.XPath, Using = "//*[@class='UIAView']")]
        private IWebElement Person { get; set; }
        public IWebElement getPerson()
        {
            return Person;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='More files']")]
        private IWebElement MoreFiles { get; set; }
        public IWebElement getMoreFiles()
        {
            return MoreFiles;
        }        
        [FindsBy(How = How.XPath, Using = "//*[@name='NONE_LABPRINT00 BASE (1)']")]
        private IWebElement FindOpenXcelFile { get; set; }
        public IWebElement getFindOpenXcelFile()
        {
            return FindOpenXcelFile;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='SM_13032020B']")]
        private IWebElement FindOpenWordFile { get; set; }
        public IWebElement getFindOpenWordFile()
        {
            return FindOpenWordFile;
        }
        public void FindOpenLinks()
        {
            getMoreSites().Click();
            getBack().Click();
            getMorePeople().Click();
            getBack().Click();
            getMoreFiles().Click();
            getBack().Click();
            //getFindHomeIcon().Click();
            //getBack().Click();            
        }
        public void FindOpenfiles()
        {
            getFindOpenXcelFile().Click();
            Thread.Sleep(4000);
            getBack().Click();
            getFindOpenWordFile().Click();
            Thread.Sleep(4000);
            getBack().Click();
        }
        public void FindFilesMoreOptions()
        {
            getBaseMoreOptions().Click();
            getBaseOptShare().Click();
        }
        public void FindLpcard()
        {
            getFindLpc().Click();
            getFindLpcFile().Click();
            Thread.Sleep(4000);
            getBack().Click();
            getFindLpcShowMoreFiles().Click();
            Thread.Sleep(3000);
            getBack().Click();           
            getBack().Click();
        }

    }
}
