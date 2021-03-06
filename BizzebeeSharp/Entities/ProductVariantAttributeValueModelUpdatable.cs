using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductVariantAttributeValueModelUpdatable
    {
        /// <summary>A collection of attribute value languages</summary>
        [JsonProperty("languages")]
        public ICollection<ProductVariantAttributeValueLanguageModel> Languages { get; set; } =
            new Collection<ProductVariantAttributeValueLanguageModel>();
    }
}