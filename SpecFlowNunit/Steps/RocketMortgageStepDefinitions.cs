using System.Threading;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowExample.Steps
{
    [Binding]
    public sealed class RocketMortgageStepDefinitions
    {
       
       // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

       private readonly ScenarioContext _scenarioContext;

       public RocketMortgageStepDefinitions(ScenarioContext scenarioContext)
       {
           _scenarioContext = scenarioContext;
       }

       [Given("chrome browser is launched")]
       public void Givenchromebrowserislaunched()
       {
            var options = new ChromeOptions();
            var driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.rocketmortgage.com/");
            Thread.Sleep(5000);
            driver.Quit();
       }

    //    [Given("the second number is (.*)")]
    //    public void GivenTheSecondNumberIs(int number)
    //    {
    //        //TODO: implement arrange (precondition) logic
    //        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
    //        // To use the multiline text or the table argument of the scenario,
    //        // additional string/Table parameters can be defined on the step definition
    //        // method. 

    //        _scenarioContext.Pending();
    //     }
        
    //    [When("the two numbers are added")]
    //    public void WhenTheTwoNumbersAreAdded()
    //    {
    //        //TODO: implement act (action) logic

    //        _scenarioContext.Pending();
    //    }

    //    [Then("the result should be (.*)")]
    //    public void ThenTheResultShouldBe(int result)
    //    {
    //        //TODO: implement assert (verification) logic

    //        _scenarioContext.Pending();
    //    }
    }
}
