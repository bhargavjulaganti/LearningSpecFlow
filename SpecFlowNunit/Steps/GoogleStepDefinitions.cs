using System.Threading;
using OpenQA.Selenium.Chrome;
using SpecFlowExample.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowExample.Steps
{
    [Binding]
    public sealed class GoogleStepDefinitions
    {
       
       // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

       private readonly ScenarioContext _scenarioContext;

       public GoogleStepDefinitions(ScenarioContext scenarioContext)
       {
           _scenarioContext = scenarioContext;
       }

       [Given("browser is launched")]
       public void GivenBrowserIsLaunched()
       {
           var page = new GoogleHomePage();
           page.SearchForSelenium();
       }
    }
}
