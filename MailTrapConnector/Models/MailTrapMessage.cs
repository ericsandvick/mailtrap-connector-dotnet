using Newtonsoft.Json;
using System.Collections.Generic;

namespace MailTrapConnector.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MailTrapMessage
    {
        [JsonProperty(propertyName: "from")]
        public MailTrapFromEmail From { get; set; }

        [JsonProperty(propertyName: "to")]
        public List<MailTrapToEmail> ToEmails { get; set; }

        [JsonProperty(propertyName: "subject")]
        public string Subject { get; set; }

        [JsonProperty(propertyName: "text")]
        public string Text { get; set; }

        [JsonProperty(propertyName: "category")]
        public string Category { get; set; }
    }
}
