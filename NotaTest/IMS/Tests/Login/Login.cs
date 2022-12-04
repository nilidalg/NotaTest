using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Configuration;
using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium.Support.Extensions;

namespace NotaTest.IMS.Login
{
    class LoginObjects
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [FindsBy(How = How.CssSelector, Using = "input[name='USER_LOGIN']")]
        public IWebElement LoginInput { get; set; }

        [FindsBy(How = How.ClassName, Using = "input[name='USER_PASSWORD']")]
        public IWebElement PwdInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='Войти']")]
        public IWebElement Loginbutton { get; set; }



        public LoginObjects(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3000));
        }

        public void InputLogin(string Login)
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + Login + "'", element);
            //Ввод логина [admin]
        }

        public void InputPwd(string Pwd)
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + Pwd + "'", element);
            //Ввод пароля [admin]
        }
        public void InputLoginDoer(string LoginDoer)
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + LoginDoer + "'", element);
            //Ввод логина [admin]
        }

        public void InputPwdDoer(string PwdDoer)
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + PwdDoer + "'", element);
            //Ввод пароля [admin]
        }
        public void InputLoginOwner(string LoginOwner)
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + LoginOwner + "'", element);
            //Ввод логина [admin]
        }

        public void InputPwdOwner(string PwdOwner)
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + PwdOwner + "'", element);
            //Ввод пароля [admin]
        }

        public void InputLoginSoisp(string LoginSoisp)
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + LoginSoisp + "'", element);
            //Ввод логина [admin]
        }

        public void InputPwdSoisp(string PwdSoisp)
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + PwdSoisp + "'", element);
            //Ввод пароля [admin]
        }


        public void LoginButton()
        {
            System.Threading.Thread.Sleep(2000);
            //wait.Until(ExpectedConditions.ElementToBeClickable(Loginbutton)).Click();
            //$('input[value="Войти"]').click();
            IWebElement element = driver.FindElement(By.CssSelector("input[value='Войти']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].click();", element);
        }


        public void InputLoginSoglReg(string LoginSoglReg)
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + LoginSoglReg + "'", element);
            //Ввод логина [Согласующий(рег)]
        }

        public void InputLoginSoglFed(string LoginSoglFed)
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + LoginSoglFed + "'", element);
            //Ввод логина [Согласующий(рег)]
        }

        public void InputPwdSoglReg(string PwdSoglReg)
        {


            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + PwdSoglReg + "'", element);
            //Ввод пароля [Согласующий(рег)]
        }
        public void InputPwdSoglFed(string PwdSoglFed)
        {


            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + PwdSoglFed + "'", element);
            //Ввод пароля [Согласующий(рег)]
        }


        public void InputLoginOperFed(string LoginOperFed)
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + LoginOperFed + "'", element);
            //Ввод логина [Оперативный дежурный(фед)]
        }

        public void InputPwdOperFed(string PwdOperFed)
        {


            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + PwdOperFed + "'", element);
            //Ввод пароля [Оперативный дежурный(фед)]
        }

        public void InputLoginOperReg(string LoginOperReg)
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + LoginOperReg + "'", element);
        }

        public void InputPwdOperReg(string PwdOperReg)
        {


            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value ='" + PwdOperReg + "'", element);
        }

        public void InputLoginSois()
        {
            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_LOGIN']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='devnull@sispol.ru';", element);
        }

        public void InputPwdSois()
        {


            IWebElement element = driver.FindElement(By.CssSelector("input[name='USER_PASSWORD']"));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].value='Abt8v@~Z0n6!';", element);
        }
















    }
}
