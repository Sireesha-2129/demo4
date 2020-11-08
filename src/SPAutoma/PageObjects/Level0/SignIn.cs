using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPAutoma.PageObjects
{
    [Obsolete]
    class SignIn
    {
        private IWebDriver dr;
        public SignIn(IWebDriver driver)
        {
            this.dr = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@name='Sign in to SharePoint Online']")]
        private IWebElement SignIn1 { get; set; }
        public IWebElement getSignIn1()
        {
            return SignIn1;
        }

        [FindsBy(How = How.XPath, Using = "//*[@name='Sign in to SharePoint Server']")]
        private IWebElement FreSps { get; set; }

        public IWebElement getFreSps()
        {
            return FreSps;
        }

        [FindsBy(How = How.XPath, Using = "//*[@value='someone@example.com']")]
        private IWebElement Username { get; set; }

        public IWebElement getUsername()
        {
            return Username;
        }

        [FindsBy(How = How.XPath, Using = "//*[@name='Next button']")]
        private IWebElement Next { get; set; }

        public IWebElement getNext()
        {
            return Next;
        }

        [FindsBy(How = How.XPath, Using = "//*[@value='Password']")]
        private IWebElement Password1 { get; set; }

        public IWebElement getPassword1()
        {
            return Password1;
        }

        [FindsBy(How = How.XPath, Using = "//*[@name='Sign in']")]
        private IWebElement SignInPassword { get; set; }

        public IWebElement getSignInPassword()
        {
            return SignInPassword;
        }
        // Handling Alert allow or dont allow

        [FindsBy(How = How.XPath, Using = "//*[@name='Allow']")]
        private IWebElement Allow { get; set; }

        public IWebElement getAllow()
        {
            return Allow;
        }

        [FindsBy(How = How.XPath, Using = "//*[@name='Don’t Allow']")]
        private IWebElement DontAllow { get; set; }

        public IWebElement getDontAllow()
        {
            return DontAllow;
        }
        
        [FindsBy(How = How.XPath, Using = "//*[@value='Welcome to the Find tab!']")]
        private IWebElement SignInValidation { get; set; }

        public IWebElement getSignInValidation()
        {
            return SignInValidation;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Me']")]
        private IWebElement Me { get; set; }
        public IWebElement getMe()
        {
            return Me;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Settings']")]
        private IWebElement Settings { get; set; }
        public IWebElement getSettings()
        {
            return Settings;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Sign out']")]
        private IWebElement SignOut { get; set; }
        public IWebElement getSignOut()
        {
            return SignOut;
        }
        [FindsBy(How = How.XPath, Using = "//*[@name='Sign out']")]
        private IWebElement SignOutOpt { get; set; }
        public IWebElement getSignOutOpt()
        {
            return SignOutOpt;
        }
        [FindsBy(How = How.XPath, Using = "//*[@label='Open Home site']")]
        private IWebElement HomeSite { get; set; }
        public IWebElement getHomeSite()
        {
            return HomeSite;
        }
        //feedback alert
        //*[@name='Not now']
        //*[@name='Sure']
        public void auth()
        {
            Assertion asser = new Assertion();
            getSignIn1().Click();
            getUsername().SendKeys("AdeleV@M365x927792.OnMicrosoft.com");
            getNext().Click();
            getPassword1().Click();
            getPassword1().SendKeys("Hpop1234");
            getSignInPassword().Click();
            getAllow().Click();
            getSignInValidation().Click();
            asser.ValidateNotNull(getHomeSite());
        }
        public void signOutApp()
        {
            getMe().Click();
            getSettings().Click();
            getSignOut().Click();
            getSignOutOpt().Click();
        }

    }
}

//        IWebDriver driver;
//        By Spo = By.XPath("//*[@name='Sign in to SharePoint Online']");
//        By Sps = By.XPath("//*[@name='Sign in to SharePoint Server']");
//        By Username = By.XPath("//*[@value='someone@example.com']");
//        By UserNext = By.XPath("//*[@name='Next button']");
//        By Password = By.XPath("//*[@value='Password']");
//        By Login = By.XPath("//*[@name='Sign in']");
//        By Allow = By.XPath("//*[@name='Allow']");
//        By Dontallow = By.XPath("//*[@name='Don’t Allow']");
//        By Teaching = By.XPath("//*[@value='Welcome to the Find tab!']");

//        public Signin(IWebDriver driver)
//        {
//            this.driver = driver;
//        }

//        public void auth()
//        {
//            driver.FindElement(Sps).Click();
//            driver.FindElement(Username).SendKeys("AdeleV@M365x927792.OnMicrosoft.com");
//            driver.FindElement(UserNext).Click();
//            driver.FindElement(Password).Click();
//            driver.FindElement(Password).SendKeys("Hpop1234");
//            driver.FindElement(Login).Click();
//            driver.FindElement(Allow).Click();
//            driver.FindElement(Teaching).Click();
//        }


//    }
//}

































































//using OpenQA.Selenium;
//using OpenQA.Selenium.Appium.iOS;
//using OpenQA.Selenium.Support.PageObjects;
//using SPAutoma;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace SPAutoma.PageObjects
//{
//    [Obsolete]
//    public class SignIn
//    {   

//    public static IOSDriver<IOSElement> driver = null;
//    private IWebDriver dr;
//    public SignIn(IWebDriver driver)
//    {
//            this.dr = driver;
//            PageFactory.InitElements(driver, this);
//    }
//    public void auth()
//    {
//        SignIn sp = new SignIn(SignInTest.driver);
//        sp.getSignIn1().Click();
//        sp.getUsername().SendKeys("AdeleV@M365x927792.OnMicrosoft.com");
//        sp.getNext().Click();
//        sp.getPassword1().Click();
//        sp.getPassword1().SendKeys("Hpop1234");
//        sp.getSignInPassword().Click();
//        sp.getAllow().Click();
//        sp.getSignInValidation().Click();
//    }

//    [FindsBy(How = How.XPath, Using = "//*[@name='Sign in to SharePoint Online']")]
//    private IWebElement SignIn1 { get; set; }
//    public IWebElement getSignIn1()
//    {
//        return SignIn1;
//    }

//    [FindsBy(How = How.XPath, Using = "//*[@name='Sign in to SharePoint Server']")]
//    private IWebElement FreSps { get; set; }

//    public IWebElement getFreSps()
//    {
//        return FreSps;
//    }

//    [FindsBy(How = How.XPath, Using = "//*[@value='someone@example.com']")]
//    private IWebElement Username { get; set; }

//    public IWebElement getUsername()
//    {
//        return Username;
//    }

//    [FindsBy(How = How.XPath, Using = "//*[@name='Next button']")]
//    private IWebElement Next { get; set; }

//    public IWebElement getNext()
//    {
//        return Next;
//    }

//    [FindsBy(How = How.XPath, Using = "//*[@value='Password']")]
//    private IWebElement Password1 { get; set; }

//    public IWebElement getPassword1()
//    {
//        return Password1;
//    }

//    [FindsBy(How = How.XPath, Using = "//*[@name='Sign in']")]
//    private IWebElement SignInPassword { get; set; }

//    public IWebElement getSignInPassword()
//    {
//        return SignInPassword;
//    }
//    // Handling Alert allow or dont allow

//    [FindsBy(How = How.XPath, Using = "//*[@name='Allow']")]
//    private IWebElement Allow { get; set; }

//    public IWebElement getAllow()
//    {
//        return Allow;
//    }

//    [FindsBy(How = How.XPath, Using = "//*[@name='Don’t Allow']")]
//    private IWebElement DontAllow { get; set; }

//    public IWebElement getDontAllow()
//    {
//        return DontAllow;
//    }
//    //[FindsBy(How = How.XPath, Using = "//*[@name='Search']")]
//    //private IWebElement SearchIcon { get; set; }

//    //public IWebElement getSearchIcon()
//    //{
//    //    return SearchIcon;
//    //}

//    [FindsBy(How = How.XPath, Using = "//*[@value='Welcome to the Find tab!']")]
//    private IWebElement SignInValidation { get; set; }

//    public IWebElement getSignInValidation()
//    {
//        return SignInValidation;
//    }

//    }
//}