using System;
using TechTalk.SpecFlow;

namespace SpecFlowExample.Hooks
{
    [Binding]
    public class Hooks : TestHook
    {
        [BeforeScenario(Order = 1)]
        public void RegisterDependencies()
        {
            InitBrowser();
        }       
    }
}
