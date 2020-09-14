using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductStockStatusLanguageModelCollection
    {
        /// <summary>A list of product stock statuses</summary>
        [JsonProperty("data")]
        public ICollection<ProductStockStatusLanguageModel> Data { get; set; } =
            new Collection<ProductStockStatusLanguageModel>();
    }
}