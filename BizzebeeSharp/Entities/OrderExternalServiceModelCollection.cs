using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class OrderExternalServiceModelCollection
    {
        /// <summary>A list of order external services</summary>
        [JsonProperty("data")]
        public ICollection<OrderExternalServiceModel> Data { get; set; } =
            new Collection<OrderExternalServiceModel>();
    }
}