using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class PaymentMethodModelItem
    {
        [JsonProperty("data")]
        public PaymentMethodModel Data { get; set; } = new PaymentMethodModel();
    }
}