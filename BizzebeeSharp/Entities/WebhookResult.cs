using System;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class WebhookResult
    {
        [JsonProperty("eventId")]
        public string EventId { get; set; }
        [JsonProperty("shopIdCode")]
        public string ShopIdCode { get; set; }
        [JsonProperty("eventTimeStamp")]
        public DateTime EventTimeStamp { get; set; }
    }
}
