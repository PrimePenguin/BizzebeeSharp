using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductUnitModelItem
    {
        [JsonProperty("data")]
        public ProductUnitModel Data { get; set; } = new ProductUnitModel();
    }
}