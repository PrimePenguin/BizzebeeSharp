using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductCategoryModelItem
    {
        [JsonProperty("data")]
        public ProductCategoryModel Data { get; set; } = new ProductCategoryModel();
    }
}