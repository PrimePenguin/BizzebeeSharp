using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class OrderStatusModelItem
    {
        [JsonProperty("data")]
        public OrderStatusModel Data { get; set; } = new OrderStatusModel();
    }
}