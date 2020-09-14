using System.Runtime.Serialization;

namespace BizzebeeSharp.Entities
{
    public enum PaymentMethodModelValidForShippingMethods
    {
        [EnumMember(Value = @"all")] All = 0,

        [EnumMember(Value = @"selected")] Selected = 1
    }
}