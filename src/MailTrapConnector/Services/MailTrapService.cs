using MailTrapConnector.Models;
using Newtonsoft.Json;
using RestSharp;

namespace MailTrapConnector.Services
{
    public class MailTrapService
    {
        private readonly string _apiToken;
        private readonly string _sendUrl;

        public MailTrapService(string apiToken, string sendUrl)
        {
            _apiToken = apiToken;
            _sendUrl = sendUrl;
        }

        /// <summary>
        /// Sends an email with subject and body.
        /// </summary>
        /// <param name="mailTrapMessage"></param>
        /// <returns></returns>
        public string SendEmail(MailTrapMessage mailTrapMessage)
        {
            return SendEmail(JsonConvert.SerializeObject(mailTrapMessage));
        }

        /// <summary>
        /// Sends an email using a template.
        /// </summary>
        /// <param name="mailTrapTemplateMessage"></param>
        /// <returns></returns>
        public string SendEmail(MailTrapTemplateMessage mailTrapTemplateMessage)
        {
            return SendEmail(JsonConvert.SerializeObject(mailTrapTemplateMessage));
        }

        /// <summary>
        /// Sends an with the supplied json message body using the MailTrap API
        /// </summary>
        /// <param name="jsonMessage"></param>
        /// <returns></returns>
        private string SendEmail(string jsonMessage)
        {
            // Initialize the REST request to the MailTrap API
            var client = new RestClient(_sendUrl);
            var request = new RestRequest();

            // Add the authorization header and content type
            request.AddHeader("Authorization", $"Bearer {_apiToken}");
            request.AddHeader("Content-Type", "application/json");

            // Add the message as the request body
            request.AddParameter("application/json",
                jsonMessage,
                ParameterType.RequestBody);

            // Send the request and retrieve the response
            var response = client.Post(request);

            return response.Content;
        }
    }
}
