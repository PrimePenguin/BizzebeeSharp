using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class CurrencyModelItem
    {
        [JsonProperty("data")]
        public CurrencyModel Data { get; set; }
    }
}