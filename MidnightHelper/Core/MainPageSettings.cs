using System;
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
            LaunchBrowser();
            
            DoJobQueue();
        }

        private void InitializeElements()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            RefreshButton = Driver.FindElement(By.Id("mobile_connect_btn"));
        }

        private void LaunchBrowser()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(MainUrl);
        }

        private void DoJobQueue()
        {
            InitializeElements();

            RefreshButton.Click();

            Driver.Navigate().Refresh();

            InitializeElements();

            RefreshButton.Click();

            Driver.Close();
        }
    }
}
