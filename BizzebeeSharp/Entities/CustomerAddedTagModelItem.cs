using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class CustomerAddedTagModelItem
    {
        [JsonProperty("data")]
        public CustomerAddedTagModel Data { get; set; } = new CustomerAddedTagModel();
    }
}