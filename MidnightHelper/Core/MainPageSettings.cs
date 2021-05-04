using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MidnightHelper.Core
{
    class MainPageSettings
    {
        public string MainUrl { get => "http://192.168.8.1/html/home.html"; }
        public IWebDriver Driver { get; set; }
        public IWebElement RefreshButton { get; set; }

        public void PageWorker()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(MainUrl);
            
            InitializeElements();

            RefreshButton.Click();

            Driver.Navigate().Refresh();

            InitializeElements();

            RefreshButton.Click();

            Driver.Close();
        }
        private void InitializeElements()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            RefreshButton = Driver.FindElement(By.Id("mobile_connect_btn"));
        }
    }
}
