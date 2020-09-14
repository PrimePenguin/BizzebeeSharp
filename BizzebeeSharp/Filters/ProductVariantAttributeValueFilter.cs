using Newtonsoft.Json;
using BizzebeeSharp.Infrastructure;

namespace BizzebeeSharp.Filters
{
    public class ProductVariantAttributeValueFilter : Parameterizable
    {
        /// <summary>
        ///     Page of results to be returned. Default is 1.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        ///     If you want to include child data in the result.
        ///     Example: ?include=prices (to include variants prices).
        ///     Available includes: prices, attributes, attributes.attribute
        /// </summary>
        [JsonProperty("include")]
        public string Include { get; set; }
    }
}