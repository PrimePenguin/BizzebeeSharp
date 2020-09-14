using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductVariantModelItem
    {
        [JsonProperty("data")]
        public ProductVariantModel Data { get; set; } = new ProductVariantModel();
    }
}