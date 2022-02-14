using System;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowExample.Hooks
{
    public class TestHook : Base
    {
        public void InitBrowser()
        {
            OpenBrowser();
        }

        private void OpenBrowser()
        {
            var options = new ChromeOptions();
            var driver = new ChromeDriver(options);    
        }   
    }
}
