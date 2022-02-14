using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowExample.Hooks;

namespace SpecFlowExample.Pages
{
    public class GoogleHomePage : BasePage
    {
        // private readonly IWebDriver driver;

        public GoogleHomePage()
        {
            // driver = webDriver;
        }

        public void SearchForSelenium()
        {
            // var options = new ChromeOptions();
            // var driver = new ChromeDriver(options);
            Driver.Navigate().GoToUrl("https://www.google.com/");
            Driver.FindElement(By.Name("q")).SendKeys("selenium");
            Thread.Sleep(5000);
            Driver.Quit();
        }
    }
}