using System;
using TechTalk.SpecFlow;

namespace airplaneSeat.Specs
{
    [Binding]
    public class OrderingAnswersSteps
    {
        [Given(@"there is a question ""(.*)"" with the answers")]
        public void GivenThereIsAQuestionWithTheAnswers(string p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"you upvote answer Cucumber Green""")]
        public void WhenYouUpvoteAnswerCucumberGreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the answer ""(.*)"" should be on top")]
        public void ThenTheAnswerShouldBeOnTop(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
