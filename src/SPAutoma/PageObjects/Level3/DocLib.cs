using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SPAutoma.PageObjects.Level3
{
    class DocLib
    {
        private IWebDriver dr;

        [Obsolete]
        public DocLib(IWebDriver driver)
        {
            this.dr = driver;
            PageFactory.InitElements(driver, this);
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
        [FindsBy(How = How.XPath, Using = "//*[@value='Files']")]
        private IWebElement Files { get; set; }
        public IWebElement getFiles()
        {
            return Files;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Documents']")]
        private IWebElement DocFolder { get; set; }
        public IWebElement getDocFolder()
        {
            return DocFolder;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='All Files']")]
        private IWebElement DocAll { get; set; }
        public IWebElement getDocAll()
        {
            return DocAll;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Document.docx']")]
        private IWebElement Word { get; set; }
        public IWebElement getWord()
        {
            return Word;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Book.xlsx']")]
        private IWebElement Excel { get; set; }
        public IWebElement getExcel()
        {
            return Excel;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Presentation.pptx']")]
        private IWebElement Ppt { get; set; }
        public IWebElement getPpt()
        {
            return Ppt;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Image.PNG']")]
        private IWebElement Img { get; set; }
        public IWebElement getImg()
        {
            return Img;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='text.txt']")]
        private IWebElement txt { get; set; }
        public IWebElement gettxt()
        {
            return txt;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Video.MP4']")]
        private IWebElement Video { get; set; }
        public IWebElement getVideo()
        {
            return Video;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Back']")]
        private IWebElement Back { get; set; }
        public IWebElement getBack()
        {
            return Back;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Play']")]
        private IWebElement Play { get; set; }
        public IWebElement getPlay()
        {
            return Play;
        }
        public void OpenSite()
        {
            getSite().Click();
            getHam().Click();
            getFiles().Click();
            getDocFolder().Click();
            getDocAll().Click();
            getWord().Click();
            Thread.Sleep(3000);
            getBack().Click();
            getExcel().Click();
            Thread.Sleep(3000);
            getBack().Click();
            getPpt().Click();
            Thread.Sleep(3000);
            getBack().Click();
            getImg().Click();
            Thread.Sleep(3000);
            getBack().Click();
            gettxt().Click();
            Thread.Sleep(3000);
            getBack().Click();
            getVideo().Click();
            getPlay().Click();
            Thread.Sleep(8000);
            getBack().Click();
            getBack().Click();
            getBack().Click();
            getBack().Click();
            getBack().Click();
        }
    }
}