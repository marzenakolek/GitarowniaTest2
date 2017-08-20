
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
    class Szukaj : POMBase
    {
        public Szukaj(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "menu_search_text")]
        public IWebElement searchbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_search']/button/span")]
        public IWebElement btnsearch { get; set; }

        [FindsBy(How = How.Id, Using = "filter_producer_val1268578375")]
        public IWebElement btnpr { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='filter_sizes_val135']")]
        public IWebElement btnrz { get; set; }
        [FindsBy(How = How.Id, Using = "filter_pricerange_val0-100")]
        public IWebElement btncn { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='filters_submit']/span[1]")]
        public IWebElement btnfiltruj { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='filter_list']/div/div[2]")]
        public IWebElement boxfiltry { get; set; }
    }
}
