using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductVariantAttributeValueModelCollection
    {
        /// <summary>A collection of attribute values</summary>
        [JsonProperty("data")]
        public ICollection<ProductVariantAttributeValueModel> Data { get; set; } =
            new Collection<ProductVariantAttributeValueModel>();
    }
}