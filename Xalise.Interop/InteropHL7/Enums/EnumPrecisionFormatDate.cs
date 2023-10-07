using Xalise.Core.Attributes;

namespace Xalise.Interop.InteropHL7.Enums
{
    /// <summary>
    /// Formats supportés par les types de données représentant des dates/heures.
    /// </summary>
    /// <remarks>
    /// Applicable aux types de données <seealso cref="Structure.DataType.Primitive.DTM"/> et <seealso cref="Structure.DataType.Primitive.DT"/>.
    /// </remarks>
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
