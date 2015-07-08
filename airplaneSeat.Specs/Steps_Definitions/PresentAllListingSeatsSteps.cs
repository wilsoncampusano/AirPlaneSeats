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
        [Given(@"There are some reservations")]
        public void GivenThereAreSomeReservations()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I search for a list of all reservations")]
        public void WhenISearchForAListOfAllReservations()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The user can see the following list")]
        public void ThenTheUserCanSeeTheFollowingList(Table table)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
