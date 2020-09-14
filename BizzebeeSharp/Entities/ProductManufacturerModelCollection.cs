using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductManufacturerModelCollection
    {
        /// <summary>A collection of product manufacturers</summary>
        [JsonProperty("data")]
        public ICollection<ProductManufacturerModel> Data { get; set; } =
            new Collection<ProductManufacturerModel>();
    }
}