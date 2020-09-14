using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductVariantAttributeModelItem
    {
        [JsonProperty("data")]
        public ProductVariantAttributeModel Data { get; set; } = new ProductVariantAttributeModel();
    }
}