using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductMetaDataTypeModelItem
    {
        [JsonProperty("data")]
        public ProductMetaDataTypeModel Data { get; set; } = new ProductMetaDataTypeModel();
    }
}