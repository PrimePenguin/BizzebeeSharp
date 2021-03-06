﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BizzebeeSharp.Entities;
using BizzebeeSharp.Extensions;
using BizzebeeSharp.Filters;
using BizzebeeSharp.Infrastructure;

namespace BizzebeeSharp.Services.ProductLanguage
{
    public class ProductLanguageService : BizzebeeService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ProductLanguageService" />.
        /// </summary>
        /// <param name="myBizzebeeUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductLanguageService(string myBizzebeeUrl, string shopAccessToken) : base(myBizzebeeUrl,
            shopAccessToken)
        {
        }


        /// <summary>
        ///     Gets a list of product  languages . Max 100 per call.
        /// </summary>
        /// ///
        /// <param name="productId">The product Id of the product</param>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ProductLanguageModelCollection>> ListAsync(int productId)
        {
            var req = PrepareRequest($"products/{productId}/languages");

            return await ExecuteRequestAsync<List<ProductLanguageModelCollection>>(req, HttpMethod.Get, rootElement: "");
        }


        /// <summary>
        ///     Retrieves the <see cref="ProductLanguageModel" /> with the given language code.
        /// </summary>
        /// <param name="productId">The product id of the product </param>
        /// <param name="langCode">The language code of the product.</param>
        /// <param name="include">
        ///     If you want to include child data in the result. Example: ?include=prices (to include variants
        ///     prices). Available includes: prices, attributes, attributes.attribute
        /// </param>
        /// <returns>The <see cref="ProductLanguageModel" />.</returns>
        public virtual async Task<ProductLanguageModel> GetAsync(int productId, string langCode,
            string include = null)
        {
            var req = PrepareRequest($"products/{productId}/languages/{langCode}");
            ;
            if (!string.IsNullOrEmpty(include)) req.QueryParams.Add("include", include);

            return await ExecuteRequestAsync<ProductLanguageModel>(req, HttpMethod.Get,
                rootElement: "data");
        }


        /// <summary>
        ///     Creates a new <see cref="ProductLanguageModel" /> on the store.
        /// </summary>
        /// <param name="productId">The product id of the product.</param>
        /// <param name="model">A new <see cref="ProductLanguageModel" />. Id should be set to null.</param>
        /// <returns>The new <see cref="ProductLanguageModel" />.</returns>
        public virtual async Task<ProductLanguageModel> CreateAsync(int productId, ProductLanguageModel model)
        {
            var req = PrepareRequest($"products/{productId}/languages");
            var body = model.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductLanguageModel>(req, HttpMethod.Post, content, "data");
        }

        /// <summary>
        ///     Updates the given <see cref="ProductLanguageModel" />.
        /// </summary>
        /// <param name="productId">The  product id of the product.</param>
        /// <param name="langCode">The language code of the product.</param>
        /// <param name="model">The <see cref="ProductLanguageModel" /> to update.</param>
        /// <returns>The updated <see cref="ProductLanguageModel" />.</returns>
        public virtual async Task<ProductLanguageModel> UpdateAsync(int productId, string langCode,
            ProductMetaDataModel model)
        {
            var req = PrepareRequest($"products/{productId}/languages/{langCode}");
            var body = model.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<ProductLanguageModel>(req, HttpMethod.Put, content, "data");
        }

        /// <summary>
        ///     Deletes a product language with given lang code.
        /// </summary>
        /// <param name="langCode">The  langCode of the product.</param>
        /// <param name="productId">The product Id of product</param>
        public virtual async Task DeleteAsync(int productId, string langCode)
        {
            var req = PrepareRequest($"products/{productId}/languages/{langCode}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}