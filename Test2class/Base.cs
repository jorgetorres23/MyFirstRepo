using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Test2class
{
    //contructor
    class Base
    {
        //atributos/interface
        private IWebDriver driver;
        
        //contructor: initialize variable
        public Base()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("http://testing.todorvachev.com/");
        }

        //metodos
        public void TearDown()
        {
            driver.Quit();
        }
        public void RedMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void GreenMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public IWebElement FindElementByCss(string locator, string name)
        {
            IWebElement webElement = (IWebElement)driver.FindElement(By.CssSelector(locator));
            Thread.Sleep(1000);
            try
            {
                GreenMessage("Element " + name + " found.");
            }
            catch
            {
                RedMessage("Element " + name + " not found");
                webElement = null;
            }
            return webElement;
        }

        public IWebElement FindElementByXpath(string locator, string name)
        {
            IWebElement webElement = (IWebElement)driver.FindElement(By.XPath(locator));
            Thread.Sleep(1000);
            try
            {
                GreenMessage("Element " + name + " found.");
            }
            catch
            {
                RedMessage("Element " + name + " not found");
                webElement = null;
            }
            return webElement;
        }

        public IWebElement FindElementById(string locator, string name)
        {
            IWebElement webElement = (IWebElement)driver.FindElement(By.Id(locator));
            Thread.Sleep(1000);
            try
            {
                GreenMessage("Element " + name + " found.");
            }
            catch
            {
                RedMessage("Element " + name + " not found");
                webElement = null;
            }
            return webElement;
        }

        public void VerifyElementDisplayed(IWebElement element, string name)
        {
            try
            {
                if (element.Displayed)
                {
                    GreenMessage("Element " + name + " is displayed.");
                }
            }
            catch
            {
                RedMessage("Element " + name + " is NOT displayed");
            }
        }

        public void VerifyElementValue(IWebElement element, string textValue)
        {
            try
            {
                if (element.Text == textValue)
                {
                    GreenMessage("Element " + element.TagName + " has the value " + textValue);
                }
                else
                {
                    RedMessage("Element " + element.TagName + " has NOT the value " + textValue + ", " + element.Text);
                }
            }
            catch
            {
                RedMessage("Element " + element.TagName + " has NOT the value " + textValue);
            }
        }
    }
}
