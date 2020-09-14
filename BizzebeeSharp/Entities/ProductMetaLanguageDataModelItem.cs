using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductMetaLanguageDataModelItem
    {
        [JsonProperty("data")]
        public ProductMetaLanguageDataModel Data { get; set; } = new ProductMetaLanguageDataModel();
    }
}