﻿using System.Net.Http;
using System.Threading.Tasks;
using BizzebeeSharp.Entities;
using BizzebeeSharp.Extensions;
using BizzebeeSharp.Filters;
using BizzebeeSharp.Infrastructure;

namespace BizzebeeSharp.Services.Customer
{
    /// <summary>
    /// A service for manipulating Bizzebee customers.
    /// </summary>
    public class CustomerService : BizzebeeService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CustomerService" />.
        /// </summary>
        /// <param name="myBizzebeeUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomerService(string myBizzebeeUrl, string shopAccessToken) : base(myBizzebeeUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of customers. Max 100 per call.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<CustomerModelCollection> ListAsync(CustomerFilter filter = null)
        {
            var req = PrepareRequest("customers");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<CustomerModelCollection>(req, HttpMethod.Get, rootElement: "");
        }

        /// <summary>
        /// Count customers.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<int> CountAsync()
        {
            var req = PrepareRequest("customers");
            var filter = new CustomerFilter { Page = 1000 };
            req.QueryParams.AddRange(filter.ToParameters());
            var customerMeta = await ExecuteRequestAsync<CustomerModelCollection>(req, HttpMethod.Get, rootElement: "");
            return customerMeta.Meta.Pagination.Total.GetValueOrDefault(0);
        }

        /// <summary>
        /// Retrieves the <see cref="CustomerModel"/> with the given id.
        /// </summary>
        /// <param name="customerId">The id of the customer to retrieve.</param>
        /// <param name="include">If you want to include child data in the result. Example: ?include=tags (to include customer tags); ?include=tags,addresses (to include both customer tags and addresses). Available includes: tags, externalServices, addresses</param>
        /// <returns>The <see cref="CustomerModel"/>.</returns>
        public virtual async Task<CustomerModel> GetAsync(int customerId, string include = null)
        {
            var req = PrepareRequest($"customers/{customerId}");

            if (!string.IsNullOrEmpty(include))
            {
                req.QueryParams.Add("include", include);
            }

            return await ExecuteRequestAsync<CustomerModel>(req, HttpMethod.Get, rootElement: "data");
        }

        /// <summary>
        /// Creates a new <see cref="CustomerModel"/> on the store.
        /// </summary>
        /// <param name="customer">A new <see cref="CustomerModel"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="CustomerModel"/>.</returns>
        public virtual async Task<CustomerModel> CreateAsync(CustomerCreateUpdateModel customer)
        {
            var req = PrepareRequest("customers");
            var body = customer.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<CustomerModel>(req, HttpMethod.Post, content, "data");
        }

        /// <summary>
        /// Updates the given <see cref="Customer"/>.
        /// </summary>
        /// <param name="customerId">Id of the object being updated.</param>
        /// <param name="customer">The <see cref="CustomerCreateUpdateModel"/> to update.</param>
        /// <returns>The updated <see cref="CustomerModel"/>.</returns>
        public virtual async Task<CustomerModel> UpdateAsync(int customerId, CustomerCreateUpdateModel customer)
        {
            var req = PrepareRequest($"customers/{customerId}");
            var body = customer.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<CustomerModel>(req, HttpMethod.Put, content, "data");
        }


#if NETCORE
        /// <summary>
        /// Updates the given <see cref="Customer"/>.
        /// </summary>
        /// <param name="customerId">Id of the object being updated.</param>
        /// <param name="customer">The <see cref="CustomerCreateUpdateModel"/> to update.</param>
        /// <returns>The updated <see cref="CustomerModel"/>.</returns>
        public virtual async Task<CustomerModel> PatchAsync(int customerId, CustomerCreateUpdateModel customer)
        {
            var req = PrepareRequest($"customers/{customerId}");
            var body = customer.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<CustomerModel>(req, HttpMethod.Patch, content, "data");
        }
#endif

        /// <summary>
        /// Deletes a customer with the given Id.
        /// </summary>
        /// <param name="customerId">The customer object's Id.</param>
        public virtual async Task DeleteAsync(int customerId)
        {
            var req = PrepareRequest($"customers/{customerId}");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
