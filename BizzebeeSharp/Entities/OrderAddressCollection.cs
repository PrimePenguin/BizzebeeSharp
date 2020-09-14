using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class OrderAddressCollection
    {
        [JsonProperty("data")]
        public OrderAddressModel Data { get; set; } = new OrderAddressModel();
    }
}