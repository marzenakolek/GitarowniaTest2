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

namespace GitarowniaTest2.POM
{
    public class LogIn : POMBase
    {
        public LogIn(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "signin_login_input")]
        public IWebElement txtsignin_login_input { get; set; }
        [FindsBy(How = How.Id, Using = "signin_pass_input")]
        public IWebElement txtsignin_pass_input { get; set; }
        [FindsBy(How = How.ClassName, Using = "signin_button")]
        public IWebElement btnsignin_button { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_additional']/a[1]")]
        public IWebElement linklogin { get; set; }
        [FindsBy(How = How.Id, Using = "menu_additional")]
        public IWebElement txtkonto { get; set; }
    }
}
