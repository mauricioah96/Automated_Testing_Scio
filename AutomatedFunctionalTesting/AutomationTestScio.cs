using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Nest;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomatedFunctionalTesting
{
    class AutomationTestScio
    {
        IWebDriver driver;
        string email = "corD72DRDrfgHO+@gmail.com";
        string password = "1234hola";

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:/Users/amaur/Desktop/chromedriver_win32 (7)");
        }

        [Test]
        public void test()
        {

            //ABRIR LA PÁGINA
            driver.Url = "http://automationpractice.com/index.php";

            //CLICK EN SIGN IN
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"header\"]/div[2]/div/div/nav/div[1]/a")).Click();

            //----------------------------------------Registrarse-----------------------------------------------------------

            //ESCRIBIR EMAIL PARA REGISTRARSE
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"email_create\"]")).SendKeys(text: email);

            //CLICK EN CREATE ACCOUNT
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"SubmitCreate\"]/span")).Click();

            driver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account#account-creation";

            Thread.Sleep(5000);

            //CLICK EN MR
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"id_gender1\"]")).Click();
            
            //ESCRIBIR FIRST NAME
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"customer_firstname\"]")).SendKeys(text: "Mauricio");

            //ESCRIBIR LAST NAME
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"customer_lastname\"]")).SendKeys(text: "Acuña");

            //ESCRIBIR EL PASSWORD
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"passwd\"]")).SendKeys(text: password);

            //ESCRIBIR ADDRESS
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"address1\"]")).SendKeys(text: "Calle 1234, #110");

            //ESCRIBIR CITY
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"city\"]")).SendKeys(text: "KFC");

            //CLICK EN STATE
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"id_state\"]")).Click();

            //CLICK EN KENTUCKY
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"id_state\"]/option[19]")).Click();

            //ESCRIBIR ZIP CODE
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"postcode\"]")).SendKeys(text: "97133");

            //ESCRIBIR MOBILE PHONE
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"phone_mobile\"]")).SendKeys(text: "97133");

            //CLICK EN REGISTER
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"submitAccount\"]/span")).Click();

            //---------------------------------------Comprar-------------------------------------------------------------

            //CLICK EN TSHIRTS
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"block_top_menu\"]/ul/li[3]/a")).Click();

            //CLICK EN BLUSA
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"category\"]")).Click();

            Thread.Sleep(5000);

            //CLICK EN ADD TO CART
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"center_column\"]/ul/li/div/div[2]/div[2]/a[1]")).Click();

            Thread.Sleep(5000);
            //CLICK EN PROCEED CHECKOUT
            driver.FindElement(By.XPath(xpathToFind: "//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a")).Click();

            Thread.Sleep(5000);
            //CLICK AGREGAR DOS ARTÍCULOS
            driver.FindElement(By.XPath(xpathToFind: "/html/body/div/div[2]/div/div[3]/div/div[2]/table/tbody/tr/td[5]/input[2]")).Clear();
            driver.FindElement(By.XPath(xpathToFind: "/html/body/div/div[2]/div/div[3]/div/div[2]/table/tbody/tr/td[5]/input[2]")).SendKeys(text: "2");

            //CLICK PROCEED CHECKOUT
            driver.FindElement(By.XPath(xpathToFind: "/html/body/div/div[2]/div/div[3]/div/p[2]/a[1]")).Click();
            Thread.Sleep(5000);

            //CLICK PROCEED CHECKOUT
            driver.FindElement(By.XPath(xpathToFind: "/html/body/div/div[2]/div/div[3]/div/form/p/button")).Click();
            Thread.Sleep(5000);

            //CLICK AGREE TERMS OF SERVICE
            driver.FindElement(By.XPath(xpathToFind: " / html / body / div / div[2] / div / div[3] / div / div / form / div / p[2] / div / span / input")).Click();
            Thread.Sleep(5000);

            //CLICK PROCEED CHECKOUT
            driver.FindElement(By.XPath(xpathToFind: "/html/body/div/div[2]/div/div[3]/div/div/form/p/button")).Click();
            Thread.Sleep(5000);

            //PAY BY BANK WIRE
            driver.FindElement(By.XPath(xpathToFind: "/ html / body / div / div[2] / div / div[3] / div / div / div[3] / div[1] / div / p / a")).Click();
            Thread.Sleep(5000);

            //CLICK I CONFIRM MY ORDER
            driver.FindElement(By.XPath(xpathToFind: "/ html / body / div / div[2] / div / div[3] / div / form / p / button")).Click();
            Thread.Sleep(5000);

            //CLICK REGRESAR A PERFIL
            driver.FindElement(By.XPath(xpathToFind: "/ html / body / div / div[1] / header / div[2] / div / div / nav / div[1] / a")).Click();
            Thread.Sleep(5000);

            //CLICK SIGN OUT
            driver.FindElement(By.XPath(xpathToFind: "/ html / body / div / div[1] / header / div[2] / div / div / nav / div[2] / a")).Click();
        }

        private IWebDriver getWebDriver()
        {
            throw new NotImplementedException();
        }

        [TearDown]
        public void closeBrowser()
        {
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
