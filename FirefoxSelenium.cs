using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FooBaiFoo {
    class Program {
        static void Main(string[] args) {
            IWebDriver driver = new FirefoxDriver(); 

            driver.Navigate().GoToUrl("https://foo.bar.com/");  
            IWebElement query = driver.FindElement(By.Name("txtEmail"));

            query.SendKeys("Cheese");
            System.Console.WriteLine("Page title is: " + driver.Title);
            driver.Quit();
        }
    }
}
 
