using Xalise.Core.Attributes;

namespace Xalise.Interop.InteropHL7.Enums
{
    /// <summary>
    /// Formats des dates supportées par les champs HL7 <seealso cref="Structure.DataType.Primitive.DTM"/> et <seealso cref="Structure.DataType.Primitive.DT"/>.
    /// </summary>
    public enum ePrecisionFormatDate : short
    {
        [UsageValue("yyyy")]
        YEAR    = 0,
        [UsageValue("yyyyMM")]
        MONTH   = 1,
        [UsageValue("yyyyMMdd")]
        DAY     = 2,
        [UsageValue("yyyyMMddHH")]
        HOUR    = 3,
        [UsageValue("yyyyMMddHHmm")]
        MINUTE  = 4,
        [UsageValue("yyyyMMddHHmmss")]
        SECOND  = 5
    }
}
