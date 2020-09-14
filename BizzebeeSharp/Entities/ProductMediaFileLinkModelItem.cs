using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductMediaFileLinkModelItem
    {
        [JsonProperty("data")]
        public ProductMediaFileLinkModel Data { get; set; } = new ProductMediaFileLinkModel();
    }
}