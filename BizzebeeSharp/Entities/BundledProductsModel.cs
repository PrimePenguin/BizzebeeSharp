﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class BundledProductsModel
    {
        /// <summary>Bundled product only valid for a single variant</summary>
        [JsonProperty("singleVariant")]
        public bool SingleVariant { get; set; }

        /// <summary>The bundled products id</summary>
        [JsonProperty("bundledProductId")]
        public int BundledProductId { get; set; }

        /// <summary>The sku of the variant the product is locked to in the variant</summary>
        [JsonProperty("variantSku")]
        public string VariantSku { get; set; }

        /// <summary>The quantity for this bundled product</summary>
        [JsonProperty("quantity")]
        [Range(1, 100000000)]
        public int? Quantity { get; set; }

        /// <summary>The sort index of this bundled product.</summary>
        [JsonProperty("sortIndex")]
        public int SortIndex { get; set; }

        /// <summary>A collection of bundled product prices</summary>
        [JsonProperty("prices")]
        public ProductBundleProductPriceModelCollection Prices { get; set; }
    }
}