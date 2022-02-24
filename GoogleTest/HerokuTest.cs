using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTest
{
    
    public class Test1
    {
        IWebDriver driver;
        public Test1()
        {


        }

        [Test]
        public void GoogleTest2()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://www.google.com/");
            string item = "iphone 7 case".ToLower();

            //driver.FindElement(By.Name("q")).SendKeys(item + Keys.Enter);
            IWebElement searchField = driver.FindElement(By.Name("q"));
            searchField.SendKeys(item + Keys.Enter);

            IList<IWebElement> list1 = driver.FindElements(By.XPath("//h3[@class='LC20lb MBeuO DKV0Md']"));
            string firstItem = list1[0].Text;
            Console.WriteLine(firstItem);

            Assert.IsTrue(firstItem.ToLower().Contains(item));

            CloseDriver();
        }

        public void CloseDriver()
        {
            if(driver != null)
            {
                driver.Quit();
                _ = driver == null;
            }           
        }

       
    }
}
