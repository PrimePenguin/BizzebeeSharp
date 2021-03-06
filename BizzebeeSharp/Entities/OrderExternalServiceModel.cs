using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class OrderExternalServiceModel
    {
        /// <summary>
        ///     The service name that this external id is linked to. Please note that this service name has to be unique for
        ///     the order
        /// </summary>
        [JsonProperty("serviceName")]
        [StringLength(40)]
        public string ServiceName { get; set; }

        /// <summary>The external id</summary>
        [JsonProperty("externalIdValue")]
        [StringLength(40)]
        public string ExternalIdValue { get; set; }

        /// <summary>Some external services cannot be updated and they have readOnly set to true</summary>
        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }
    }
}