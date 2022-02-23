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
