using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class OrderExternalServicesModelItem
    {
        [JsonProperty("data")]
        public OrderExternalServiceModel Data { get; set; } = new OrderExternalServiceModel();
    }
}