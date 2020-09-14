using System.Collections.Generic;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductVariantVolumePriceModelCollection
    {
        /// <summary>A collection of variant volume prices</summary>
        [JsonProperty("data")]
        public ICollection<ProductVariantVolumePriceModel> Data { get; set; }
    }
}