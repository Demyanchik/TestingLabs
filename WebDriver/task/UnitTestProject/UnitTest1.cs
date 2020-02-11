using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Windows.Forms;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private void sendkeys(IWebElement ele, String val)
        {
            while (true)
            {
                ele.Clear();
                ele.SendKeys(val);
                if (ele.GetAttribute("value").Equals(val))
                    break;

            }

        }

        private void task2()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.tutu.ru");

            IWebElement el = driver.FindElement(By.ClassName("j-station_input_from"));
            sendkeys(el, "Москва");
            el = driver.FindElement(By.ClassName("j-station_input_to"));
            sendkeys(el, "Санкт-Петербург");

            el = driver.FindElement(By.ClassName("j-date_to"));
            sendkeys(el, "3.10.2019");
            driver.FindElement(By.ClassName("m-border_inner")).Click();
        }

        [TestMethod]
        public void Task1()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.tutu.ru");

            IWebElement el = driver.FindElement(By.ClassName("j-station_input_from"));
            sendkeys(el, "Минск");
            el = driver.FindElement(By.ClassName("j-station_input_to"));
            sendkeys(el, "Санкт-Петербург");

            //driver.FindElement(By.ClassName("j-date_to")).SendKeys("20.02.2019");
            driver.FindElement(By.ClassName("m-border_inner")).Click();
            Assert.AreEqual("ж/д", driver.FindElement(By.ClassName("t-nowrap")).Text);
            driver.Quit();
        }

        [TestMethod]
        public void Task2()
        {
           
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.tutu.ru");

            IWebElement el = driver.FindElement(By.ClassName("j-station_input_from"));
            sendkeys(el, "Москва");
            el = driver.FindElement(By.ClassName("j-station_input_to"));
            sendkeys(el, "");

            driver.FindElement(By.ClassName("j-date_to")).SendKeys("20.02.2020");
            
            driver.FindElement(By.ClassName("m-border_inner")).Click();
            Assert.AreEqual("Пожалуйста, укажите название станции", driver.FindElement(By.ClassName("j-popup-content")).Text);
            driver.Quit();
        }

    }
}
