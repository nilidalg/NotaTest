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
    class WorkingGroup
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [FindsBy(How = How.CssSelector, Using = "a[title='Добавить инцидент']")]
        public IWebElement AddIncidentButton { get; set; }
        public WorkingGroup(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3000));
        }

        public void AddWorkingGroupButton()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(AddIncidentButton)).Click();
            driver.Navigate().GoToUrl("https://b24ims.notamedia.ru/incident/details/0/?category_id=1");
            //Создание инцидента
        }

        public void NumberOfGroupInput()
        {
            System.Threading.Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.CssSelector("[name='UF_SERIAL_NUMBER']"));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='453';", element);
            //Ввод номера группы
        }

        public void ChangeNumberOfGroupInput()
        {
            System.Threading.Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));
            IWebElement element = driver.FindElement(By.XPath("//span[@class='fields integer field-item']"));
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

        public void DescriptionOfGroupInput()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector("#title_text"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Тест';", element);
            //Ввод названия инцидента
        }
        public void ChangeDescriptionOfGroupInput()
        {
            System.Threading.Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));
            IWebElement element = driver.FindElement(By.XPath("//div[@class='ui-entity-editor-content-block ui-entity-editor-field-text ui-entity-editor-content-block-click-editable']/div[@class='ui-entity-editor-content-block']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            System.Threading.Thread.Sleep(3000);
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element2 = driver.FindElement(By.CssSelector("textarea[name='TITLE']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Тест';", element2);
            
            //Ввод названия инцидента
        }

        public void ShortDescriptionOfGroupInput()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.XPath("//input[@name='UF_SHORT_NAME']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='тест';", element);
            //Ввод короткого названия инцидента

            
        }
        public void ChangeShortDescriptionOfGroupInput()
        {
            
            System.Threading.Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));
            IWebElement element = driver.FindElement(By.XPath("//span[contains(text(),'Тест')]"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            System.Threading.Thread.Sleep(3000);
            IWebElement element2 = driver.FindElement(By.CssSelector("[name='UF_SHORT_NAME']"));
            wait.Until(ExpectedConditions.ElementToBeClickable(element2)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(element2)).SendKeys(Keys.Control + "a");
            wait.Until(ExpectedConditions.ElementToBeClickable(element2)).SendKeys(Keys.Backspace);

            var generator = new Random();
            var randomNumber = generator.Next(500, 100000);
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + randomNumber + "'", element2);
        }

        public void AdressOfGroupInput()
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector(".uf-address-search-input"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Москва';", element);
            //Ввод адреса инцидента
        }

        public void ChangeAdressOfGroupInput()
        {
            System.Threading.Thread.Sleep(3000);
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));
            IWebElement element = driver.FindElement(By.XPath("//span[@class='fields address field-item']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            System.Threading.Thread.Sleep(3000);
            IWebElement element2 = driver.FindElement(By.CssSelector(".uf-address-search-input"));
            wait.Until(ExpectedConditions.ElementToBeClickable(element2)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(element2)).SendKeys(Keys.Control + "a");
            wait.Until(ExpectedConditions.ElementToBeClickable(element2)).SendKeys(Keys.Backspace);

            var generator = new Random();
            var randomNumber = generator.Next(500, 100000);
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + randomNumber + "'", element2);
            //Ввод адреса инцидента
        }

        public void LevelOfGroupInput()
        {
            IWebElement element = driver.FindElement(By.CssSelector(".main-ui-control.main-ui-select[data-name='UF_LEVEL']"));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Клик на выподающий список для выбора уровня инцидента
        }

        public void LevelOfGroupInputValueFed()
        {

            //IWebElement element = driver.FindElement(By.CssSelector("span[id='UF_LEVEL_control_'] span:nth-child(2)"));
            IWebElement element = driver.FindElement(By.XPath("//*[text()='Федеральный']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор Федерального уровня инцидента


        }
        public void LevelOfGroupInputValueReg()
        {

            //IWebElement element = driver.FindElement(By.CssSelector("span[id='UF_LEVEL_control_'] span:nth-child(2)"));
            IWebElement element = driver.FindElement(By.XPath("//*[text()='Региональный']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор Регионального уровня инцидента


        }
        public void LevelOfGroupInputValueMun()
        {

            //IWebElement element = driver.FindElement(By.CssSelector("span[id='UF_LEVEL_control_'] span:nth-child(2)"));
            IWebElement element = driver.FindElement(By.XPath("//*[text()='Муниципальный']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор Муниципального уровня инцидента


        }
        public void LevelOfGroupInputValueGvrmnt()
        {

            //IWebElement element = driver.FindElement(By.CssSelector("span[id='UF_LEVEL_control_'] span:nth-child(2)"));
            IWebElement element = driver.FindElement(By.XPath("//*[text()='Правительственный']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор Правительственого уровня инцидента


        }

        public void PriorityOfGroup()
        {
            IWebElement element = driver.FindElement(By.CssSelector("#UF_IMPORTANCE_control_"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Клик на выподающий список для выбора приоритета инцидента
        }
        public void ChangePriorityOfGroup()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));
            IWebElement element = driver.FindElement(By.CssSelector("span[class='field-item']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Клик на выподающий список для выбора приоритета инцидента
        }


        public void PriorityOfGroupInputMedium()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[.='Средний']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор приоритета [Средний]


        }

        public void PriorityOfGroupInputLow()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[.='Низкий']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор приоритета [Низкий]


        }

        public void PriorityOfGroupInputHigh()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[.='Высокий']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Выбор приоритета [Высокий]


        }

        public void BigDescriptionOfGroupInput()
        {

            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector("textarea[name='UF_DESCRIPTION']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Тест Тест';", element);
            //Ввод описания инцидента
        }

        public void ChangeBigDescriptionOfGroupInput()
        {
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("side-panel-iframe")));
            //wait.Until(ExpectedConditions.ElementToBeClickable(NumberOfIncident)).Click();
            IWebElement element = driver.FindElement(By.CssSelector("div[data-cid='UF_DESCRIPTION'] span[class='fields string field-item']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //Ввод описания инцидента
        }

        public void SaveButton()
        {
            
            IWebElement element = driver.FindElement(By.CssSelector("button[title='[Ctrl+Enter]']"));
            element.SendKeys(Keys.Control + Keys.Enter);
            System.Threading.Thread.Sleep(3000);

        }
        public void Cancel()
        {

            IWebElement element = driver.FindElement(By.CssSelector("a[title='[Esc]']"));
            Actions action = new Actions(driver);

            action.MoveToElement(element).Click().Build().Perform();
            //TODO Wait to present alert

        }
        public void ClickOnGroup()
        {

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[.='Test']"))).Click();
            //Выбор группы (первой в списке с нужным именем)
        }

        public void CheckErrorMsg()
        {
            //IWebElement element = driver.FindElement(By.CssSelector("input[name='UF_SERIAL_NUMBER']"));
            Assert.IsNotNull(driver.FindElement(By.CssSelector(".errortext")).Displayed);

        }
    }
}
