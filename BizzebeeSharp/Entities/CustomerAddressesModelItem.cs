using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class CustomerAddressesModelItem
    {
        [JsonProperty("data")]
        public AddressModel Data { get; set; } = new AddressModel();
    }
}