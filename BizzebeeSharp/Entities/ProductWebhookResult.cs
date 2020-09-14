using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductWebhookResult : WebhookResult
    {
        [JsonProperty("productId")]
        public int ProductId { get; set; }
    }
}
