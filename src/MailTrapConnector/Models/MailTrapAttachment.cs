using Newtonsoft.Json;

namespace MailTrapConnector.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MailTrapAttachment
    {
        [JsonProperty(propertyName: "content")]
        public string Content { get; set; }

        [JsonProperty(propertyName: "content_id")]
        public string ContentId { get; set; }

        [JsonProperty(propertyName: "disposition")]
        public string Disposition { get; set; }

        [JsonProperty(propertyName: "fileName")]
        public string FileName { get; set; }

        [JsonProperty(propertyName: "type")]
        public string Type { get; set; }
    }
}
