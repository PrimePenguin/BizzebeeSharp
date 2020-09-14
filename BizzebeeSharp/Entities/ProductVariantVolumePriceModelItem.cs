using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductVariantVolumePriceModelItem
    {
        [JsonProperty("data")]
        public ProductVariantVolumePriceModel Data { get; set; }
    }
}