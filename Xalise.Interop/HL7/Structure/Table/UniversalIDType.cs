using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0301 - Universal ID Type.
    /// </summary>
    [Serializable]
    public class UniversalIDType : AbstractTable
    {
        public static UniversalIDType DNS       = new UniversalIDType("DNS", "An Internet dotted name. Either in ASCII or as integers.");
        public static UniversalIDType GUID      = new UniversalIDType("GUID", "Same as UUID.");
        public static UniversalIDType HCD       = new UniversalIDType("HCD", "The CEN Healthcare Coding Scheme Designator.");
        public static UniversalIDType HL7       = new UniversalIDType("HL7", "Reserved for future HL7 registration schemes.");
        public static UniversalIDType ISO       = new UniversalIDType("ISO", "An International Standards Organization Object Identifier.");
        public static UniversalIDType L         = new UniversalIDType("L", "Reserved for locally defined coding schemes.");
        public static UniversalIDType M         = new UniversalIDType("M", "Reserved for locally defined coding schemes.");
        public static UniversalIDType N         = new UniversalIDType("N", "Reserved for locally defined coding schemes.");
        public static UniversalIDType RANDOM    = new UniversalIDType("Random", "Usually a base64 encoded string of random bits.");
        public static UniversalIDType URI       = new UniversalIDType("URI", "Uniform Resource Identifier.");
        public static UniversalIDType UUID      = new UniversalIDType("UUID", "The DCE Universal Unique Identifier.");
        public static UniversalIDType X400      = new UniversalIDType("x400", "An X.400 MHS format identifier.");
        public static UniversalIDType X500      = new UniversalIDType("x500", "An X.500 directory name.");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public UniversalIDType(string value, string description) : base(value, description) { }

        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public override string TableNumber
        {
            get
            {
                return "0301";
            }
        }
    }
}
