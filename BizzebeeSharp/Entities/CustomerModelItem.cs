using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class CustomerModelItem
    {
        [JsonProperty("data")]
        public CustomerModel Data { get; set; } = new CustomerModel();
    }
}