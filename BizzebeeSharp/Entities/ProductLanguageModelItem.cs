using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductLanguageModelItem
    {
        [JsonProperty("data")]
        public ProductLanguageModel Data { get; set; } = new ProductLanguageModel();
    }
}