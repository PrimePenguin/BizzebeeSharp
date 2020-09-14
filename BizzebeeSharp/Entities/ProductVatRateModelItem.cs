using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductVatRateModelItem
    {
        [JsonProperty("data")]
        public ProductVatRateModel Data { get; set; } = new ProductVatRateModel();
    }
}