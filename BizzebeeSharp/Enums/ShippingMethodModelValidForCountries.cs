using System.Runtime.Serialization;

namespace BizzebeeSharp.Enums
{
    public enum ShippingMethodModelValidForCountries
    {
        [EnumMember(Value = "all")] All = 0,

        [EnumMember(Value = "EU")] EU = 1,

        [EnumMember(Value = "non-EU")] NonEU = 2,

        [EnumMember(Value = "selected")] Selected = 3,

        [EnumMember(Value = "none")] None = 4
    }
}