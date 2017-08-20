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
    public class ProduktObserwowany : POMBase
    {
        public ProduktObserwowany(IWebDriver driver) : base(driver)
        {
        }
        [FindsBy(How = How.Id, Using = "menu_search_text")]
        public IWebElement searchbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_search']/button/span")]
        public IWebElement btnsearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='search']/div/div/a[1]")]
        public IWebElement btnobserwowany { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_basket']/div/a[1]/span[1]")]
        public IWebElement btnobserwowany2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_compare_product']/div[1]")]
        public IWebElement obsercontainer { get; set; }
    }
}
//*[@id="menu_compare_product"]/div[1]