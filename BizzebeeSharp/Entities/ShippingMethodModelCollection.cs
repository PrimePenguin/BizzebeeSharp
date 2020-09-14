using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ShippingMethodModelCollection
    {
        /// <summary>A collection of shipping methods</summary>
        [JsonProperty("data")]
        public ICollection<ShippingMethodModel> Data { get; set; } =
            new Collection<ShippingMethodModel>();
    }
}