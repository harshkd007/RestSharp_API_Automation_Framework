using ClassLibrary1.DataModel;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MethodImplementationSteps
    {
        public string baseURL = "https://reqres.in";
        public string getURL = "/api/users?page=2";
        public string postURL = "/api/users";

        public GetResponseModel GetUsers()
        {
            var restClient = new RestClient(baseURL);
            var request = new RestRequest(getURL, Method.GET);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;


            IRestResponse response = restClient.Execute(request);
            var content = response.Content;

            //Conver the string into json format
            var users = JsonConvert.DeserializeObject<GetResponseModel>(content);
            return users;
        }

        public PostResponseModel CreateUsers()
        {
            var restClient = new RestClient(baseURL);
            var request = new RestRequest(postURL, Method.POST);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;


            IRestResponse response = restClient.Execute(request);
            var content = response.Content;

            //Conver the string into json format
            var users = JsonConvert.DeserializeObject<PostResponseModel>(content);
            return users;
        }
    }
}
