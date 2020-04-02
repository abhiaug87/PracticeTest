using RestSharp;
using Newtonsoft.Json.Linq;
using System.Net;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace APITests.Steps
{
    [Binding]
    public class Stepdefinition
    {
        [Given(@"I have forbidden access to the URL")]
        public void GivenIHaveForbiddenAccessToTheURL()
        {
            RestApiHelper.Url();
        }

        [When(@"I pass the values for (.*) and (.*)")]
        public void WhenIPassTheValuesForQakulkarniUnl_ShAndTestmycode(string id, string key)
        {
            RestApiHelper.CreateForbiddenRequest(id, key);
        }

        [Then(@"I can see the appropriate error message for (.*) and (.*)")]
        public void ThenICanSeeTheAppropriateErrorMessageForQakulkarniUnl_ShAndTestmycode(string id, string key)
        {
            var response = RestApiHelper.GetResponse(id, key);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Forbidden), "The response has failed");
            Assert.That(response.ContentType, Is.EqualTo("application/json; charset=utf-8"));
            Assert.NotNull(response.Content.Contains("The API Id parameter must be a GUID."), "The response has failed");

        }
    }
}
