using OpenQA.Selenium;

namespace SpecFlowExample.Hooks
{
    public abstract class Base
    {
        public static IWebDriver Driver { get; internal set;}
    }
}