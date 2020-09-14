using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductMetaDataModelCollection
    {
        /// <summary>A collection of product meta data</summary>
        [JsonProperty("data")]
        public ICollection<ProductMetaDataModel> Data { get; set; } =
            new Collection<ProductMetaDataModel>();
    }
}