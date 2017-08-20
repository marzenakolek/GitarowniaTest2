


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
       

    public class DropDown : POMBase
    {
        public DropDown(IWebDriver driver) : base(driver)
        {
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_categories']/ul[2]/li[1]/a")]
        public IWebElement btnddmenu { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_categories']/ul[2]/li[1]/ul/li[1]/a")]
        public IWebElement btngitara { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_categories']/ul[2]/li[1]/ul/li[1]/ul/li[1]/a")]
        public IWebElement btngitarakustyczna { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='search']")]
        public IList<IWebElement> txtgitarycont { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='projector_form']/div[1]/div[3]")]
        public IList<IWebElement> txtakust { get; set; }
    }
}
