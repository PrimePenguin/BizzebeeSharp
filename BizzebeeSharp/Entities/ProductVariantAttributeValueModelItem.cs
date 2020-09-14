using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductVariantAttributeValueModelItem
    {
        [JsonProperty("data")]
        public ProductVariantAttributeValueModel Data { get; set; } = new ProductVariantAttributeValueModel();
    }
}