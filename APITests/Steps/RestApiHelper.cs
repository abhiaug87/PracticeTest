using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.IO;

namespace APITests.Steps
{
    public static class RestApiHelper
    {
        public static RestClient rc;
        public static RestRequest rq;
        public static string baseurl = "https://api.unleashedsoftware.com/";

        public static RestClient Url()
        {
            var url = "https://api.unleashedsoftware.com/";
            return rc = new RestClient(url);
        }
        public static RestRequest CreateForbiddenRequest(string id, string key)
        {
            rc = new RestClient(baseurl);
            rq = new RestRequest("Customers/?", Method.GET);
            rq.AddHeader("Content-Type", "application/json");
            rq.AddParameter(new Parameter("API Id", id, ParameterType.GetOrPost));
            rq.AddParameter(new Parameter("API Key", key, ParameterType.GetOrPost));
            return rq;
        }
        public static IRestResponse GetResponse(string id, string key)
        {
            var response = rc.Execute(rq);
            return response;
        }
    }
}
