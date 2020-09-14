using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class CustomerAddressesModelCollection
    {
        [JsonProperty("data")]
        public Data Data { get; set; } = new Data();
    }
}