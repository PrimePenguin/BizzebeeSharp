using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ShippingMethodModelItem
    {
        [JsonProperty("data")]
        public ShippingMethodModel Data { get; set; } = new ShippingMethodModel();
    }
}