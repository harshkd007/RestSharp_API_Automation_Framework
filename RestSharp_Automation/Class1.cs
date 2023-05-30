using Newtonsoft.Json;
using RestSharp;
using RestSharp_Automation.DataModel;

namespace RestSharp_Automation
{
    public class Class1
    {
        public string baseURL = "https://reqres.in";
        public string getURL = "/api/users?page=2";

        public ResponseModel GetUsers(string getURL)
        {
            var restClient = new RestClient(baseURL);
            var request = new RestRequest(getURL, Method.GET);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;


            IRestResponse response = restClient.Execute(request);
            var content = response.Content;

            //Conver the string into json format
            var users = JsonConvert.DeserializeObject<ResponseModel>(content);
            return users;
        }

    }
}