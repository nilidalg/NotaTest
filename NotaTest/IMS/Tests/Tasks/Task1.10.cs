﻿using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Drawing.Imaging;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using System.Linq;
using System.Configuration;
using OpenQA.Selenium.Remote;
using System.Diagnostics;
using NotaTest.IMS.PageObjects;
using NotaTest.IMS.Login;
using System.Threading;
using RelevantCodes.ExtentReports;
using NUnit.Framework.Interfaces;

namespace IMS.Tests.Task1_10
{
    public class Task1_10
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private LoginObjects loginObjects;
        private GoTo goTo;
        private IncidentPage incidentPage;
        public static ExtentTest test;
        public static ExtentReports extent;



        [SetUp]

        public void Test()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string reportPath = projectPath + "Reports\\MyOwnReport.html";

            extent = new ExtentReports(reportPath, false);
            extent
            .AddSystemInfo("Host Name", "Artur")
            .AddSystemInfo("Environment", "QA")
            .AddSystemInfo("User Name", "Artur G");
            extent.LoadConfig(projectPath + "extent-config.xml");

            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3000));
            driver.Manage().Window.Maximize();
            loginObjects = new LoginObjects(driver);
            goTo = new GoTo(driver);
            incidentPage = new IncidentPage(driver);


        }

        [Test]
        public void TestTask1_10()
        {
            test = extent.StartTest("Отмена создания новой подзадачи");
            goTo.LoginPage(ConfigurationManager.AppSettings["LoginPage"]);
            loginObjects.InputLoginOperReg(ConfigurationManager.AppSettings["LoginOperReg"]);
            loginObjects.InputPwdOperReg(ConfigurationManager.AppSettings["PwdOperReg"]);
            loginObjects.LoginButton();
            goTo.PageTasks(ConfigurationManager.AppSettings["PageTasks"]);
            goTo.NewTask(ConfigurationManager.AppSettings["NewTask"]); 
            //incidentPage.OneMoreTask();
            //incidentPage.NameOfTask();
            //incidentPage.CacncelCreateTask();
            //test.Log(LogStatus.Pass, "Тест пройден успешно");






        }

        [TearDown]
        public void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;

            if (status == TestStatus.Failed)
            {
                test.Log(LogStatus.Fail, stackTrace + errorMessage);
            }
            extent.EndTest(test);
            driver.Quit();
            driver = null;

        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
            extent.Close();
        }
    }
}
