using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class OrderModelItem
    {
        [JsonProperty("data")]
        public OrderModel Data { get; set; } = new OrderModel();
    }
}