﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BizzebeeSharp.Entities;

namespace BizzebeeSharp.Services.ShippingTrackingType
{
    /// <summary>
    /// A service for manipulating Bizzebee shipping tracking types.
    /// </summary>
    public class ShippingTrackingTypeService : BizzebeeService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShippingTrackingTypeService" />.
        /// </summary>
        /// <param name="myBizzebeeUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShippingTrackingTypeService(string myBizzebeeUrl, string shopAccessToken) : base(myBizzebeeUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of shipping tracking types.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ShippingTrackingTypeModel>> ListAsync()
        {
            var req = PrepareRequest("shipping-tracking-types");
            return await ExecuteRequestAsync<List<ShippingTrackingTypeModel>>(req, HttpMethod.Get, rootElement: "data");
        }
    }
}
