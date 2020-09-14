using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class CustomerTagModelItem
    {
        [JsonProperty("data")]
        public CustomerTagModel Data { get; set; } = new CustomerTagModel();
    }
}