using Newtonsoft.Json;
using System.Collections.Generic;

namespace MailTrapConnector.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MailTrapTemplateMessage
    {
        [JsonProperty(propertyName: "from")]
        public MailTrapFromEmail From { get; set; }

        [JsonProperty(propertyName: "to")]
        public List<MailTrapToEmail> ToEmails { get; set; }

        [JsonProperty(propertyName: "template_uuid")]
        public string TemplateUuid { get; set; }

        [JsonProperty(propertyName: "template_variables")]
        public object TemplateVariables { get; set; }
    }
}
