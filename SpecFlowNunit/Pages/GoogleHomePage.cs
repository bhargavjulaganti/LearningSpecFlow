using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowExample.Pages
{
    public class GoogleHomePage
    {
        public GoogleHomePage()
        {}

        public void SearchForSelenium()
        {
            var options = new ChromeOptions();
            var driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q")).SendKeys("selenium");
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}