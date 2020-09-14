using System.Runtime.Serialization;

namespace BizzebeeSharp.Enums
{
    public enum OrderItemModelDiscountType
    {
        [EnumMember(Value = "amount")] Amount = 0,

        [EnumMember(Value = "percent")] Percent = 1
    }
}