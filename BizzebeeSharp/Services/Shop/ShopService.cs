using System.Net.Http;
using System.Threading.Tasks;
using BizzebeeSharp.Entities;

namespace BizzebeeSharp.Services.Shop
{
    /// <summary>
    /// A service for Bizzebee Shop details.
    /// </summary>
    public class ShopService : BizzebeeService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopService" />.
        /// </summary>
        /// <param name="myBizzebeeUrl">The shop's *.mystrweb.se/api/vX URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopService(string myBizzebeeUrl, string shopAccessToken) : base(myBizzebeeUrl, shopAccessToken) { }

        /// <summary>
        /// Retrieves the <see cref="ShopModel"/>.
        /// </summary>
        /// <returns>The <see cref="ShopModel"/>.</returns>
        public virtual async Task<ShopModel> GetAsync()
        {
            var req = PrepareRequest("shop");
            return await ExecuteRequestAsync<ShopModel>(req, HttpMethod.Get, rootElement: "data");
        }
    }
}
