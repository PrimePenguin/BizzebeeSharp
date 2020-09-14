using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductVariantPriceModelItem
    {
        [JsonProperty("data")]
        public ProductVariantPriceModel Data { get; set; } = new ProductVariantPriceModel();
    }
}