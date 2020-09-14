using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductCategoryLinkModelItem
    {
        [JsonProperty("data")]
        public ProductCategoryLinkModel Data { get; set; } = new ProductCategoryLinkModel();
    }
}