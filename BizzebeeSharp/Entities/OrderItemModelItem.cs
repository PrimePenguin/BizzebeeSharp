using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class OrderItemModelItem
    {
        [JsonProperty("data")]
        public OrderItemModel Data { get; set; } = new OrderItemModel();
    }
}