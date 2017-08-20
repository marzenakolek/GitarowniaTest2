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
    public class DoPorównania : POMBase
    {
        public DoPorównania(IWebDriver driver) : base(driver)
        {
        }
        [FindsBy(How = How.Id, Using = "menu_search_text")]
        public IWebElement searchbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_search']/button/span")]
        public IWebElement btnsearch { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='search']/div/div/a[1]")]
        public IWebElement btnporownaj { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_compare_product']/div[3]/a[2]")]
        public IWebElement btnporownajduży { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_compare_product']/div[2]")]
        public IWebElement txtporownaj { get; set; }
    }
}
