﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class OrderStatusModelCollection
    {
        /// <summary>A list of order statuses</summary>
        [JsonProperty("data")]
        public ICollection<OrderStatusModel> Data { get; set; }
    }
}