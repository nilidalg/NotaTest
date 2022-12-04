using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace NotaTest.IMS.PageObjects
{
    class GoTo
    {
        private IWebDriver driver;
        private WebDriverWait wait;



        public GoTo(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3000));

        }

        public void LoginPage(string LoginPage)
        {
            driver.Navigate().GoToUrl(LoginPage);
        }

        public void WorkingGroupPage(string WorkingGroupPage)
        {
            driver.Navigate().GoToUrl(WorkingGroupPage);
        }
        public void WorkGroupPageForChange(string WorkGroupPageForChange)
        {
            driver.Navigate().GoToUrl(WorkGroupPageForChange);
        }

        public void IncidentPage(string IncidentPage)
        {
            driver.Navigate().GoToUrl(IncidentPage);
        }
        public void IncidentPageForOper(string IncidentPageForOper)
        {
            driver.Navigate().GoToUrl(IncidentPageForOper);
        }


        public void IncidentPageTask(string IncidentPageTask)
        {
            driver.Navigate().GoToUrl(IncidentPageTask);
        }

        public void PageTasks(string IncidentPageTask)
        {
            driver.Navigate().GoToUrl(IncidentPageTask);
        }

        public void NewTask(string NewTask)
        {
            driver.Navigate().GoToUrl(NewTask);
        }
    }
}
