using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0200 - Name type.
    /// </summary>
    [Serializable]
    public class NameType : AbstractTable
    {
        public static NameType ALIAS_NAME                   = new NameType("A", "Alias Name");
        public static NameType NAME_AT_BIRTH                = new NameType("B", "Name at Birth");
        public static NameType ADOPTED_NAME                 = new NameType("C", "Adopted Name");
        public static NameType DISPLAY_NAME                 = new NameType("D", "Display Name");
        public static NameType LICENSING_NAME               = new NameType("I", "Licensing Name");
        public static NameType LEGAL_NAME                   = new NameType("L", "Legal Name");
        public static NameType MAIDEN_NAME                  = new NameType("M", "Maiden Name");
        public static NameType NICKNAME                     = new NameType("N", "Nickname");
        public static NameType NAME_OF_PARTNER_SPOUSE       = new NameType("P", "Name Of Partner/Spouse");
        public static NameType REGISTERED_NAME              = new NameType("R", "Registered Name (animals only)");
        public static NameType CODED_PSEUDO_NAME            = new NameType("S", "Coded Pseudo-Name to ensure anonymity");
        public static NameType INDIGENOUS_TRIBAL_COMMUNITY  = new NameType("T", "Indigenous/Tribal/Community Name");
        public static NameType UNSPECIFIED                  = new NameType("U", "Unspecified");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public NameType(string value, string description) : base(value, description) { }

        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public override string TableNumber
        {
            get
            {
                return "0200";
            }
        }
    }
}
