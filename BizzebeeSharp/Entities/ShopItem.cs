using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ShopItem
    {
        [JsonProperty("data")]
        public ShopModel Data { get; set; }
    }
}