using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductVatRateModelCollection
    {
        /// <summary>A collection of product vat rates</summary>
        [JsonProperty("data")]
        public ICollection<ProductVatRateModel> Data { get; set; } =
            new Collection<ProductVatRateModel>();
    }
}