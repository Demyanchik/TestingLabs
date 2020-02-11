using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace task
{
    public partial class Form1 : Form
    {
        IWebDriver driver;

        public Form1()
        {
            InitializeComponent();
        }

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

        private void task1()
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


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                task1();
                MessageBox.Show(driver.FindElement(By.ClassName("t-ttl")).Text);
                //driver.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                task2();
                //driver.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
