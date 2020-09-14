using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductMetaDataModelItem
    {
        [JsonProperty("data")]
        public ProductMetaDataModel Data { get; set; } = new ProductMetaDataModel();
    }
}