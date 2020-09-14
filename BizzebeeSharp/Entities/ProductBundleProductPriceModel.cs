using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class ProductBundleProductPriceModel
    {
        /// <summary>The pricelist this price is for</summary>
        [JsonProperty("pricelistId")]
        public int PricelistId { get; set; }

        /// <summary>The special price excluding vat (a discounted price)</summary>
        [JsonProperty("specialPriceExVat")]
        public double? SpecialPriceExVat { get; set; }
    }
}