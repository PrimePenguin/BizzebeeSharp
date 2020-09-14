using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BizzebeeSharp.Entities;
using BizzebeeSharp.Extensions;
using BizzebeeSharp.Filters;

namespace BizzebeeSharp.Services.ProductMetaDataTypes
{
    public class ProductMetaDataTypeService : BizzebeeService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ProductMetaDataTypeService" />.
        /// </summary>
        /// <param name="myBizzebeeUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductMetaDataTypeService(string myBizzebeeUrl, string shopAccessToken) : base(myBizzebeeUrl,
            shopAccessToken)
        {
        }


        /// <summary>
        ///     Gets a list of product meta  data type. Max 100 per call.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ProductMetaDataTypeModel>> ListAsync(
            ProductMetaDataTypeFilter filter = null)
        {
            var req = PrepareRequest("product-meta-data-types");

            if (filter != null) req.QueryParams.AddRange(filter.ToParameters());

            return await ExecuteRequestAsync<List<ProductMetaDataTypeModel>>(req, HttpMethod.Get,
                rootElement: "data");
        }


        /// <summary>
        ///     Retrieves the <see cref="ProductMetaDataTypeModel" /> with the given metaDataTypeId.
        /// </summary>
        /// <param name="metaDataTypeId">The attribute id of the product variant.</param>
        /// <param name="include">
        ///     If you want to include child data in the result. Example: ?include=prices (to include variants
        ///     prices). Available includes: prices, attributes, attributes.attribute
        /// </param>
        /// <returns>The <see cref="ProductMetaDataTypeModel" />.</returns>
        public virtual async Task<ProductMetaDataTypeModel> GetAsync(int metaDataTypeId, string include = null)
        {
            var req = PrepareRequest($"products-meta-data-types/{metaDataTypeId}");
            ;
            if (!string.IsNullOrEmpty(include)) req.QueryParams.Add("include", include);

            return await ExecuteRequestAsync<ProductMetaDataTypeModel>(req, HttpMethod.Get,
                rootElement: "data");
        }
    }
}