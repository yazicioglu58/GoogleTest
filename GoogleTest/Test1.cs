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

            IList<string> elementText = new List<string>();

            foreach(IWebElement ele in availableElements)
            {
                elementText.Add(ele.Text);
                Console.WriteLine(ele.Text);
            }


            // string elementTextOnMainPage4 = availableElements[4].Text;
            //IWebElement ele4 = driver.FindElement(By.XPath("dfd"));

            //Assert.AreEqual(elementTextOnMainPage4, ele4.Text);



            Console.WriteLine("Number of elements: " + availableElements.Count);

            Assert.IsTrue(availableElements.Count.Equals(expectedNumberOfElements));
            
            availableElements[4].Click();

           

          

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
