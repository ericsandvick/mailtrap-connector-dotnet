using Newtonsoft.Json;

namespace MailTrapConnector.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MailTrapFromEmail
    {
        public MailTrapFromEmail(string email, string name)
        {
            Email = email;
            Name = name;
        }

        [JsonProperty(propertyName: "email")]
        public string Email { get; private set; }

        [JsonProperty(propertyName: "name")]
        public string Name { get; private set; }
    }
}
