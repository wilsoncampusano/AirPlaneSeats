using System;
using TechTalk.SpecFlow;

namespace airplaneSeat.Specs
{
    [Binding]
    public class PresentAllListingSeatsSteps
    {
        [Given(@"the following listing of seats in db")]
        public void GivenTheFollowingListingOfSeatsInDb(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I search for all seats")]
        public void WhenISearchForAllSeats()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result shoulb be")]
        public void ThenTheResultShoulbBe(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
