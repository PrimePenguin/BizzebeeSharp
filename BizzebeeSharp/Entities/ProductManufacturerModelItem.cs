using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductManufacturerModelItem
    {
        [JsonProperty("data")]
        public ProductManufacturerModel Data { get; set; } = new ProductManufacturerModel();
    }
}