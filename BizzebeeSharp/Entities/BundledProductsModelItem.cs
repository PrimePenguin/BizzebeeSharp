using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class BundledProductsModelItem
    {
        [JsonProperty("data")]
        public BundledProductsModel Data { get; set; }
    }
}