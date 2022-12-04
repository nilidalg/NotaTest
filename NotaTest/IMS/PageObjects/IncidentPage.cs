using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NotaTest.IMS.PageObjects
{
    class IncidentPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [FindsBy(How = How.CssSelector, Using = "a[title='Добавить инцидент']")]
        public IWebElement AddIncidentButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='UF_SERIAL_NUMBER']")]
        public IWebElement NumberOfIncident { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@data-name='UF_LEVEL']")]
        public IWebElement Levellist { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='popup - window - content - popup - window - mqwvsnr3']/div/div[4]")]
        public IWebElement Priority { get; set; }

        public IncidentPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3000));

        }
        
        public void addIncidentButton()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(AddIncidentButton)).Click();
            driver.Navigate().GoToUrl("https://b24ims.notamedia.ru/incident/details/0/?category_id=0");
            //Создание инцидента
        }
        public void CheckCreatIncidentButton()
        {
            //IWebElement element = driver.FindElement(By.CssSelector("input[name='UF_SERIAL_NUMBER']"));
            //Assert.IsNull(driver.FindElement(By.CssSelector("#toolbar_deal_list > a")).Displayed);
            
        }

        public void NumberOfIncidentInput()
        {
            System.Threading.Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.CssSelector("input[name='UF_SERIAL_NUMBER']"));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='4532534';", element);
            //Ввод номера инцидента
        }
        public void FindAndChooseIncident()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("CRM_DEAL_LIST_V12_C_0_search"))).SendKeys("Тест для редактирования инцидента");
            //System.Threading.Thread.Sleep(2000);
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("CRM_DEAL_LIST_V12_C_0_search']"))).SendKeys(Keys.Enter);
            //System.Threading.Thread.Sleep(2000);
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Тест для редактирования инцидента"))).Click();
        }

        public void ChangeNumberOfIncidentInput()
        {
            System.Threading.Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));
            IWebElement element = driver.FindElement(By.ClassName("ui-entity-editor-content-block"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            System.Threading.Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[name='UF_SERIAL_NUMBER']"))).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[name='UF_SERIAL_NUMBER']"))).SendKeys(Keys.Control + "a");
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[name='UF_SERIAL_NUMBER']"))).SendKeys(Keys.Backspace);

            var generator = new Random();
            var randomNumber = generator.Next(500, 100000);
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + randomNumber + "'", driver.FindElement(By.CssSelector("[name='UF_SERIAL_NUMBER']")));

            //Ввод номера группы
        }

        public void DescriptionOfIncidentInput()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector("textarea[name='TITLE']"));
            wait.Until(ExpectedConditions.ElementToBeClickable(element)).SendKeys("Тестовое название");
            //IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            //jse.ExecuteScript("arguments[0].click();", element);
            //jse.ExecuteScript("arguments[0].value='Тест312312';", element);
            //Ввод названия инцидента
        }

        public void ShortDescriptionOfIncidentInput()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector("input[name='UF_SHORT_NAME']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='тест';", element);
            //Ввод короткого названия инцидента
        }

        public void AdressOfIncidentInput()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector(".uf-address-search-input"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Москва';", element);
            //Ввод адреса инцидента
        }

        public void LevelOfIncidentInput()
        {
            System.Threading.Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.CssSelector(".main-ui-control.main-ui-select[data-name='UF_LEVEL']"));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Клик на выподающий список для выбора уровня инцидента
        }

        public void LevelOfIncidentInputValueFed()
        {

            //IWebElement element = driver.FindElement(By.CssSelector("span[id='UF_LEVEL_control_'] span:nth-child(2)"));
            IWebElement element = driver.FindElement(By.XPath ("//*[text()='Федеральный']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор Федерального уровня инцидента


        }
        public void LevelOfIncidentInputValueReg()
        {

            //IWebElement element = driver.FindElement(By.CssSelector("span[id='UF_LEVEL_control_'] span:nth-child(2)"));
            IWebElement element = driver.FindElement(By.XPath("//*[text()='Региональный']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор Регионального уровня инцидента


        }
        public void LevelOfIncidentInputValueMun()
        {

            //IWebElement element = driver.FindElement(By.CssSelector("span[id='UF_LEVEL_control_'] span:nth-child(2)"));
            IWebElement element = driver.FindElement(By.XPath("//*[text()='Муниципальный']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор Муниципального уровня инцидента


        }
        public void LevelOfIncidentInputValueGvrmnt()
        {

            //IWebElement element = driver.FindElement(By.CssSelector("span[id='UF_LEVEL_control_'] span:nth-child(2)"));
            IWebElement element = driver.FindElement(By.XPath("//*[text()='Правительственный']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор Правительственого уровня инцидента


        }

        public void PriorityOfIncident()
        {
            System.Threading.Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.CssSelector("#UF_IMPORTANCE_control_"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Клик на выподающий список для выбора приоритета инцидента
        }



        public void PriorityOfIncidentInputMedium()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[.='Средний']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор приоритета [Средний]

            
        }

        public void PriorityOfIncidentInputLow()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[.='Низкий']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор приоритета [Низкий]


        }

        public void PriorityOfIncidentInputHigh()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[.='Высокий']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор приоритета [Высокий]


        }

        public void BigDescriptionOfIncidentInput()
        {
            
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector("textarea[name='UF_DESCRIPTION']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Тест Тест';", element);
            //Ввод описания инцидента
        }

        public void TimeOfEnd()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();\

            IWebElement element = driver.FindElement(By.CssSelector("input[value='26.05.2022']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element);
            action.Perform();

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='20.07.2023';", element);
        }
        public void CreateTask()
        {
            IWebElement element = driver.FindElement(By.CssSelector(".crm-entity-stream-section-new-action[data-item-id='task']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();



        }

        public void NameOfTask()
        {
            System.Threading.Thread.Sleep(5000);

            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));


            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input[data-bx-id='task-edit-title']"))).SendKeys("TEST");
            

        }

        public void DescriptionOfTask()
        {
            System.Threading.Thread.Sleep(5000);

            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("bx-editor-iframe")));


            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("body"))).SendKeys("TEST");
            driver.SwitchTo().ParentFrame();


        }

        public void StatusOfTask()
        {
            
            driver.FindElement(By.CssSelector("#divbitrix_tasks_task_default_1"));
            driver.SwitchTo().Frame(1);


            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("body"))).SendKeys("TEST 2");
            driver.SwitchTo().ParentFrame();


        }

        public void CacncelCreateTask()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@class='ui-btn ui-btn-link']"))).Click();
            //IWebElement element = driver.FindElement(By.CssSelector("input[data-bx-id='task-edit-cancel-button']"));
            //Actions action = new Actions(driver);

            //action.MoveToElement(element).Click().Build().Perform();



        }
        public void SaveTask()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));


            
            //IWebElement element = driver.FindElement(By.CssSelector(".ui-btn.ui-btn-success"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='ui-btn ui-btn-success']"))).Click();
            //Actions action = new Actions(driver);

            //action.MoveToElement(element).Click().Build().Perform();



        }

        public void SaveTaskAndCreateOneMore()
        {
            //driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));


            String javascript = "$(\"button[value = '1']\").click()";
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript(javascript);





        }
        public void SaveTaskWithOutFrame()
        {
            //driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));



            //IWebElement element = driver.FindElement(By.CssSelector(".ui-btn.ui-btn-success"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='ui-btn ui-btn-success']"))).Click();
            //Actions action = new Actions(driver);

            //action.MoveToElement(element).Click().Build().Perform();



        }

        public void TaskPageActionButton()
        {
            



            //IWebElement element = driver.FindElement(By.CssSelector(".ui-btn.ui-btn-success"));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//tbody/tr[1]/td[2]/span[1]/a[1]"))).Click();
            //Actions action = new Actions(driver);

            //action.MoveToElement(element).Click().Build().Perform();



        }

        public void CreateTaskInActionBar()
        {




            
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Добавить подзадачу')]"))).Click();
            



        }

        public void ClickOnTask()
        {




            //IWebElement element = driver.FindElement(By.CssSelector(".ui-btn.ui-btn-success"));
            driver.Navigate().GoToUrl("https://b24ims.notamedia.ru/company/personal/user/1/tasks/task/view/1510/");
            //Actions action = new Actions(driver);

            //action.MoveToElement(element).Click().Build().Perform();



        }

        public void OneMoreTask()
        {



            
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@class='task-more-button ui-btn ui-btn-light-border ui-btn-dropdown']"))).Click();
            System.Threading.Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@title='Добавить подзадачу']//span[2]"))).Click();
            



        }

        public void ClickOnEndTask()
        {




            
            IWebElement element = driver.FindElement(By.CssSelector("//tbody/tr[1]/td[2]/span[1]/a[1]"));
            
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();



        }









        public void Cancel()
        {

            IWebElement element = driver.FindElement(By.CssSelector("a[title='[Esc]']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //TODO Wait to present alert

        }

        public void SaveButton()
        {

            IWebElement element = driver.FindElement(By.CssSelector("button[title='[Ctrl+Enter]']"));
            element.SendKeys(Keys.Control + Keys.Enter);
            System.Threading.Thread.Sleep(3000);
        }
    }
}
