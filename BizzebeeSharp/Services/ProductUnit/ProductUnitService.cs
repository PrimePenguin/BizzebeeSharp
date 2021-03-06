﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BizzebeeSharp.Entities;
using BizzebeeSharp.Extensions;
using BizzebeeSharp.Filters;

namespace BizzebeeSharp.Services.ProductUnit
{
    public class ProductUnitService : BizzebeeService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ProductUnitService" />.
        /// </summary>
        /// <param name="myBizzebeeUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductUnitService(string myBizzebeeUrl, string shopAccessToken) : base(myBizzebeeUrl,
            shopAccessToken)
        {
        }


        /// <summary>
        ///     Gets a list of product units. Max 100 per call.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ProductUnitModel>> ListAsync(ProductUnitFilter filter = null)
        {
            var req = PrepareRequest("product-units");

            if (filter != null) req.QueryParams.AddRange(filter.ToParameters());

            return await ExecuteRequestAsync<List<ProductUnitModel>>(req, HttpMethod.Get,
                rootElement: "data");
        }


        /// <summary>
        ///     Retrieves the <see cref="ProductUnitModel" /> with the given uniId.
        /// </summary>
        /// <param name="unitId">The unit id of the product unit.</param>
        /// <param name="include">
        ///     If you want to include child data in the result. Example: ?include=prices (to include variants
        ///     prices). Available includes: prices, attributes, attributes.attribute
        /// </param>
        /// <returns>The <see cref="ProductVariantModel" />.</returns>
        public virtual async Task<ProductUnitModel> GetAsync(int unitId, string include = null)
        {
            var req = PrepareRequest($"products-units/{unitId}");
            ;
            if (!string.IsNullOrEmpty(include)) req.QueryParams.Add("include", include);

            return await ExecuteRequestAsync<ProductUnitModel>(req, HttpMethod.Get,
                rootElement: "data");
        }
    }
}