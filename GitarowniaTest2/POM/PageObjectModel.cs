using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Chrome;
using GitarowniaTest2.POM;

namespace GitarowniaTest2.POM
{
    public class SeleniumBase
    {
        protected IWebDriver _driver { get; set; }

        public SeleniumBase(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver GetDriver()
        {
            if (_driver == null)
                _driver = new ChromeDriver();
            return _driver;
        }
    }

    public class POMBase : SeleniumBase
    {
        public POMBase(IWebDriver driver) : base(driver)
        { }

        public void GoToURL(string url)
        {
            _driver.Navigate().GoToUrl(url);
            Thread.Sleep(5000);
            PageFactory.InitElements(_driver, this);
        }

        public void CenterElement(IWebElement element)
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0," + element.Location.Y + ")");
        }

        public void Maximize()
        {
            _driver.Manage().Window.Maximize();
        }

        public void Close()
        {
            _driver.Close();
        }

    }
}

   public class PageObjectModel : POMBase
    {
        public PageObjectModel(IWebDriver driver) : base(driver)
        {
       }
        
    }

