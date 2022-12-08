using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0465 - Name/address representation.
    /// </summary>
    [Serializable]
    public class NameAddressRepresentation : AbstractTable
    {
        public static NameAddressRepresentation ALPHABETIC  = new NameAddressRepresentation("A", "Alphabetic");
        public static NameAddressRepresentation IDEOGRAPHIC = new NameAddressRepresentation("I", "Ideographic");
        public static NameAddressRepresentation PHONETIC    = new NameAddressRepresentation("P", "Phonetic");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public NameAddressRepresentation(string value, string description) : base(value, description) { }

        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public override string TableNumber
        {
            get
            {
                return "0465";
            }
        }
    }
}
