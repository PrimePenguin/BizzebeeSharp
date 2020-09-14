using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductBundleProductPriceModelItem
    {
        [JsonProperty("data")]
        public ProductBundleProductPriceModel Data { get; set; }
    }
}