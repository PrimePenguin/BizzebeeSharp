using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class PaymentMethodModelCollection
    {
        /// <summary>A collection of payment methods</summary>
        [JsonProperty("data")]
        public ICollection<PaymentMethodModel> Data { get; set; } =
            new Collection<PaymentMethodModel>();
    }
}