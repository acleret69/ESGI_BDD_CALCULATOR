using System;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
    
        private readonly ScenarioContext _scenarioContext;
        
        private readonly Calculator _calculator = new Calculator();
        
        private int _result;
        
        private Exception _actualException;
    
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
    
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }
    
        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }
        
        [Given("add number is (.*)")]
        public void GivenTheNumberIs(int number)
        {
            _calculator.nombres.Add(number);
        }
        
        [Given("add operante is (.*)")]
        public void GivenTheOperenteIs(string operante)
        {
            _calculator.operente.Add(operante);
        }
    
        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }
        
        [When("the two numbers are soustacted")]
        public void WhenTheTwoNumbersAreSoustract()
        {
            _result = _calculator.soustract();
        }
        
        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiplie();
        }
        
        [When("the two numbers are divised")]
        public void WhenTheTwoNumbersAreDivised()
        {
            try
            {
                _result = _calculator.Divise();
            }
            catch (Exception ex)
            {
                _actualException = ex;
            }
        }
        
        [When("the end opérations")]
        public void WhenOperation()
        {
            try
            {
                _result = _calculator.opérations();
            }
            catch (Exception ex)
            {
                _actualException = ex;
            }
        }
    
        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.Equal(result, _result);
        }
        
        [Then("the error '(.*)' should be raised")]
        public void ThenTheResultError(string resultError)
        {
            Assert.Equal(resultError,_actualException.Message);
        }
    }
}

