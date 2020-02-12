﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Page_obj.Pages
{
    class HomePage
    {
        [FindsBy(How=How.Name, Using = "schedule_station_from")] 
        private IWebElement Station_from;
        [FindsBy(How = How.Name, Using = "schedule_station_to")]
        private IWebElement Station_to;
        [FindsBy(How = How.ClassName, Using = "j-date_to")]
        private IWebElement Date;
        [FindsBy(How = How.ClassName, Using = "m-border_inner")]
        private IWebElement Find;
        [FindsBy(How = How.ClassName, Using = "j-popup-content")]
        private IWebElement Station_Error;
        public HomePage(IWebDriver Browser)
        {

            PageFactory.InitElements(Browser, this);
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

        public HomePage InpuntInformation(string StationFrom,string StationTo,string date)
        {
            sendkeys(Station_from, StationFrom);
            sendkeys(Station_to, StationTo);
            Date.SendKeys(date);
            Date.Click();
            Find.Click();
            return this;

        }
        public string GetError()
        {
            return Station_Error.Text;
        }
        
    }
}
