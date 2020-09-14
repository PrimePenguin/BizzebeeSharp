using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BizzebeeSharp.Entities
{
    public class AddressModel
    {
        /// <summary>Company name</summary>
        [JsonProperty("companyName")]
        [StringLength(80)]
        public string CompanyName { get; set; }

        /// <summary>First name</summary>
        [JsonProperty("firstName")]
        [StringLength(35)]
        public string FirstName { get; set; }

        /// <summary>Last name</summary>
        [JsonProperty("lastName")]
        [StringLength(35)]
        public string LastName { get; set; }

        /// <summary>Care Of</summary>
        [JsonProperty("careOf")]
        [StringLength(80)]
        public string CareOf { get; set; }

        /// <summary>Attention</summary>
        [JsonProperty("attention")]
        [StringLength(80)]
        public string Attention { get; set; }

        /// <summary>Reference</summary>
        [JsonProperty("reference")]
        [StringLength(80)]
        public string Reference { get; set; }

        /// <summary>Address</summary>
        [JsonProperty("address")]
        [StringLength(50)]
        public string Address { get; set; }

        /// <summary>Postal Code</summary>
        [JsonProperty("postalCode")]
        [StringLength(12)]
        public string PostalCode { get; set; }

        /// <summary>City</summary>
        [JsonProperty("city")]
        [StringLength(30)]
        public string City { get; set; }

        /// <summary>State</summary>
        [JsonProperty("state")]
        [StringLength(30)]
        public string State { get; set; }

        /// <summary>Country code in ISO 3166-1 alpha-2 format</summary>
        [JsonProperty("countryCode")]
        [MinLength(2)]
        public string CountryCode { get; set; }

        /// <summary>Phone number in an international format</summary>
        [JsonProperty("phoneNo")]
        [StringLength(30)]
        public string PhoneNo { get; set; }

        /// <summary>Mobile phone number in an international format</summary>
        [JsonProperty("mobilePhoneNo")]
        [StringLength(30)]
        public string MobilePhoneNo { get; set; }
    }
}