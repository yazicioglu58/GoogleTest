using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoogleTest
{

    public class HerokuTest
    {
        IWebDriver driver;

        public HerokuTest()
        {
        }

        [Test]
        public void GoogleTest2()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");

            int expectedNumberOfElements = 44;

            IList<IWebElement> availableElements = driver.FindElements(By.XPath("//div[@id='content']//a"));

           
            Console.WriteLine("Number of elements: " + availableElements.Count);

            Assert.IsTrue(availableElements.Count.Equals(expectedNumberOfElements));
            Thread.Sleep(3000);

            CloseDriver();
        }

        public void CloseDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                _ = driver == null;
            }
        }

    }
}
