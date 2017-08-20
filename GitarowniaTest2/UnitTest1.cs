using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace GitarowniaTest2.POM
{
    [TestClass]
    public class UnitTest1
    {

        private IWebDriver _driver;
        private PageObjectModel _pom;
        private  string itemDisplayTextExpect = "ZEBRA MUSIC długopis Klawiatura";
        private DropDown _dd;
        private DoPorównania _dp;
        private ProduktObserwowany _po;
        private UsuńZObserwowanych _uzo;
        private LogIn _li;
        private Szukaj _sz;
        

        [TestInitialize]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _pom = new PageObjectModel(_driver);
            _pom.Maximize();
            
            _dd = new DropDown(_driver);
            _dd.Maximize();

            _dp = new DoPorównania(_driver);
            _dp.Maximize();

            _po = new ProduktObserwowany(_driver);
            _po.Maximize();

            _uzo = new UsuńZObserwowanych(_driver);
            _uzo.Maximize();

            _li = new LogIn(_driver);
            _li.Maximize();

            _sz = new Szukaj(_driver);
            _sz.Maximize();

        }

        [TestCleanup]
        public void TearDown()
        {
            _pom.Close();
        }

        [TestMethod]
        public void _search()
        {
            _sz.GoToURL("https://gitarownia.pl");
            _sz.searchbox.SendKeys("flet");
            _sz.btnsearch.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);
            _sz.CenterElement(_sz.btnpr);
            _sz.btnpr.Click();
            _sz.btnrz.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);
            _sz.btncn.Click();
            _sz.btnfiltruj.Click();
            Assert.AreEqual("Producent: HohnerRozmiary: renseansowyCena: 0.00zł - 100.00zł", _sz.boxfiltry.Text);
        }

        private object WebDriverWait(object driver, object timeout)
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void _logIn()
        {
            _li.GoToURL("https://gitarownia.iai-shop.com/signin.php");
            _li.CenterElement(_li.txtsignin_login_input);
            _li.txtsignin_login_input.SendKeys("KowalskiJan");
            _li.txtsignin_pass_input.SendKeys("test111");
            _li.btnsignin_button.Click();
            Assert.AreEqual("Witamy, Twoje konto | Wyloguj się", _li.txtkonto.Text);
        }

        [TestMethod]
        public void _dodajDoPorównania()
        {
            _dp.GoToURL("https://gitarownia.pl");
            _dp.searchbox.SendKeys("WARWICK PRWPROCUPBLK kubek");
            _dp.btnsearch.Click();
            Thread.Sleep(500);
            _dp.CenterElement(_dp.btnporownaj);
            _dp.btnporownaj.Click();
            Thread.Sleep(500);
            _dp.searchbox.Clear();
            _dp.searchbox.SendKeys("FENDER 9100282000 kubek");
            _dp.btnsearch.Click();
            Thread.Sleep(500);
            _dp.btnporownaj.Click();
            _dp.btnporownajduży.Click();
            Thread.Sleep(500);
            var popup = _driver.WindowHandles[1]; // handler for the new tab
            Assert.IsTrue(!string.IsNullOrEmpty(popup)); // tab was opened
            Assert.AreEqual(_driver.SwitchTo().Window(popup).Url, "https://gitarownia.iai-shop.com/product-compare.php"); // url is OK  
            _driver.SwitchTo().Window(_driver.WindowHandles[1]).Close(); // close the tab
            _driver.SwitchTo().Window(_driver.WindowHandles[0]);
        }
        [TestMethod]
        public void __produktObserwowany()
        {
            _po.GoToURL("https://gitarownia.pl");
            _po.searchbox.SendKeys("ZEBRA MUSIC długopis Klawiatura");
            _po.btnsearch.Click();
            Thread.Sleep(500);
            _po.CenterElement(_po.btnobserwowany);
            _po.btnobserwowany.Click();
            Thread.Sleep(500);
            _po.CenterElement(_po.btnobserwowany2);
            Assert.AreEqual("DODANE DO PORÓWNANIA", _po.obsercontainer.Text);
            
        }
        [TestMethod]
        public void _usunzObserwowanych()
        {
            _uzo.GoToURL("https://gitarownia.pl");
            _uzo.searchbox.SendKeys("ZEBRA MUSIC długopis Klawiatura");
            _uzo.btnsearch.Click();
            Thread.Sleep(500);
            _uzo.CenterElement(_uzo.btnobserwowany);
            _uzo.btnobserwowany.Click();
            Thread.Sleep(500);
            _uzo.CenterElement(_uzo.btnobserwowany2);
            _uzo.btnobserwowany2.Click();
            _uzo.CenterElement(_uzo.btnusun);
            _uzo.btnusun.Click();
            Assert.AreEqual("Lista obserwowanych jest pusta.", _uzo.txtkomunik.Text);

        }

        [TestMethod]
        public void __dropDownMenu()
        {
            _dd.GoToURL("https://gitarownia.pl");
            Actions act = new Actions(_driver);
            act.MoveToElement(_dd.btnddmenu);
            act.MoveToElement(_dd.btngitara);
            act.MoveToElement(_dd.btngitarakustyczna);
            act.Click();
            act.Perform();
            foreach (IWebElement ele in _dd.txtgitarycont)
                try
                {
                    IWebElement gitarakustyczna = ele.FindElement(By.ClassName("product-name"));
                  
                    gitarakustyczna.Click();
                    break;
                }
                catch { }
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);
            Assert.AreEqual(true, _dd.txtgitarycont.Any((item) => item.Text.Contains("EPIPHONE DR100 VS")));
            
        }
        
    }
}