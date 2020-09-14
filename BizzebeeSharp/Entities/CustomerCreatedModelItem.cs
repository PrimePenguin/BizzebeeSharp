using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class CustomerCreatedModelItem
    {
        [JsonProperty("data")]
        public CustomerCreatedModel Data { get; set; }
    }
}