using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class VatRateModelItem
    {
        [JsonProperty("data")]
        public VatRateModel Data { get; set; } = new VatRateModel();
    }
}