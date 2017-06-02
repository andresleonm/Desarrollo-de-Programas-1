using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace WindowsFormsApp1.Services
{
    class MailService
    {
        private string api_key = "key-b85d92ae2f6e50008da54e45d4641e66";
        private string domain = "sandboxca78d7ecb354495abe373468f5b9ad01.mailgun.org";

        public MailService()
        {

        }

        public Controller.Result sendMail(string to, string content, string subject = "")
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");
            client.Authenticator = new HttpBasicAuthenticator("api", api_key);
            RestRequest request = new RestRequest();
            request.AddParameter("domain", domain, ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "Administracion <postmaster@" + domain + ">");
            request.AddParameter("to", to); 
            request.AddParameter("subject", subject);
            request.AddParameter("text", content);
            request.Method = Method.POST;

            IRestResponse response = client.Execute(request);

            if (response.StatusDescription == "OK")
            {
                return new Controller.Result(response.StatusDescription, true, "");
            }
            else
            {
                return new Controller.Result("", false, response.StatusDescription + "\n" + response.Content);
            }
        }
    }
}
