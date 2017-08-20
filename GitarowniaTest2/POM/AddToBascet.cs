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
    class AddToBascet : POMBase
    {
        public AddToBascet(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "menu_search_text")]
        public IWebElement txtmenu_search_text { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#menu_search > button")]
        public IWebElement btnhiddenphone { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='search']/div/div/a[3]")]
        public IWebElement btnproduct { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#projector_button_basket")]
        public IWebElement btnbascet { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='menu_basket']/a")]
        public IWebElement btnbascet1 { get; set; }
        [FindsBy(How = How.ClassName, Using = "productslist_item")]
        public IWebElement txtproductslist_item { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='basketedit_productslist']")]
        public IList<IWebElement> basketcaseItems { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='menu_categories']/ul[2]/li[3]/a")]
        public IWebElement menubtnhover { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='searchingPreloader1']/div[3]/div[3]/span[2]")]
        public IWebElement selecttest { get; set; }
    }
}
