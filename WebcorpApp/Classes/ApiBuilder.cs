using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebcorpApp.Classes
{
    class ApiBuilder
    {
        private static string rootUrl = "http://gopher-server.xyz:49154/api/";
        private static RestClient restClient;

        public static RestClient GetInstance()
        {
            if(restClient == null)
            {
                restClient = new RestClient(rootUrl);
            }

            return restClient;
        }
    }
}
