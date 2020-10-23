using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

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
            // Clear the cookie popup
            driver.SwitchTo().Frame(0);
            IWebElement popup = driver.FindElement(By.CssSelector("#introAgreeButton"));
            popup.Click();
            // Find the text input 
            driver.SwitchTo().DefaultContent();
            IWebElement searchbox = driver.FindElement(By.CssSelector("[title^='Search']"));
            searchbox.SendKeys("hello world" + Keys.Enter);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement firstResult = wait.Until(e => e.FindElement(By.XPath("//a/h3")));

            Console.WriteLine(firstResult.Text);
            Console.ReadLine();

        }
    }
}
