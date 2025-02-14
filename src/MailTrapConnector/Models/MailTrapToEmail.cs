using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MailTrapConnector.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MailTrapToEmail
    {
        public MailTrapToEmail(string email)
        {
            Email = email;
        }

        [JsonProperty(propertyName: "email")]
        public string Email { get; private set; }
    }
}
