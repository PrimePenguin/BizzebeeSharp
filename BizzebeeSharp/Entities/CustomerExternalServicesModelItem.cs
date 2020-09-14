using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class CustomerExternalServicesModelItem
    {
        [JsonProperty("data")]
        public CustomerExternalServicesModel Data { get; set; } = new CustomerExternalServicesModel();
    }
}