using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductModelItem
    {
        [JsonProperty("data")]
        public ProductModel Data { get; set; } = new ProductModel();
    }
}