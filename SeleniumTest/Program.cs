using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver("C:/WebDriver/bin");
            // Load up Google and print out the URL
            driver.Navigate().GoToUrl(@"https://www.google.com");
            Console.WriteLine(driver.Url);
        }
    }
}
