using System;
using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using airplaneSeats;

namespace airplaneSeat.Specs
{
    [Binding]
    public class PresentAllListingSeatsSteps
    {
        [Given(@"the following listing of seats in db")]
        public void GivenTheFollowingListingOfSeatsInDb(Table table)
        {
            var presentableSeats = table.CreateSet<PresentableSeat>();
            
            Assert.That(presentableSeats, Is.Not.Null);
            
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
