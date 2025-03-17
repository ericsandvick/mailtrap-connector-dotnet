using Newtonsoft.Json;
using System.Collections.Generic;

namespace MailTrapConnector.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MailTrapTemplateMessage
    {
        [JsonProperty(propertyName: "attachments")]
        public List<MailTrapAttachment> Attachments { get; set; }

        [JsonProperty(propertyName: "bcc")]
        public List<MailTrapToEmail> BccEmails { get; set; }

        [JsonProperty(propertyName: "cc")]
        public List<MailTrapToEmail> CcEmails { get; set; }

        [JsonProperty(propertyName: "from")]
        public MailTrapFromEmail From { get; set; }

        [JsonProperty(propertyName: "template_uuid")]
        public string TemplateUuid { get; set; }

        [JsonProperty(propertyName: "template_variables")]
        public object TemplateVariables { get; set; }

        [JsonProperty(propertyName: "to")]
        public List<MailTrapToEmail> ToEmails { get; set; }
    }
}
