using Xalise.Core.Attributes;

namespace Xalise.Interop.InteropHL7.Enums
{
    /// <summary>
    /// Formats des dates supportées par les champs HL7 <seealso cref="Structure.DataType.Primitive.DTM"/> et <seealso cref="Structure.DataType.Primitive.DT"/>.
    /// </summary>
    public enum ePrecisionFormatDate : short
    {
        [EnumUsageValue("yyyy")]
        YEAR    = 0,
        [EnumUsageValue("yyyyMM")]
        MONTH   = 1,
        [EnumUsageValue("yyyyMMdd")]
        DAY     = 2,
        [EnumUsageValue("yyyyMMddHH")]
        HOUR    = 3,
        [EnumUsageValue("yyyyMMddHHmm")]
        MINUTE  = 4,
        [EnumUsageValue("yyyyMMddHHmmss")]
        SECOND  = 5
    }
}
