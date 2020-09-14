using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class AddressModelItem
    {
        [JsonProperty("data")]
        public AddressModel Data { get; set; } = new AddressModel();
    }
}