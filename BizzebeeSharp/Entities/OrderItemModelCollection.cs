using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class OrderItemModelCollection
    {
        /// <summary>A list of order items</summary>
        [JsonProperty("data")]
        public ICollection<OrderItemModel> Data { get; set; } =
            new Collection<OrderItemModel>();
    }
}