using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductStockStatusModelItem
    {
        [JsonProperty("data")]
        public ProductStockStatusModel Data { get; set; } = new ProductStockStatusModel();
    }
}