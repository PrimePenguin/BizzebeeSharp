using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class PricelistModelItem
    {
        [JsonProperty("data")]
        public PricelistModel Data { get; set; } = new PricelistModel();
    }
}