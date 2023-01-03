using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0200 - Name type.
    /// </summary>
    [Serializable]
    public class T0200_NameType : AbstractTable
    {
        public static T0200_NameType ALIAS_NAME                   = new T0200_NameType("A", "Alias Name");
        public static T0200_NameType NAME_AT_BIRTH                = new T0200_NameType("B", "Name at Birth");
        public static T0200_NameType ADOPTED_NAME                 = new T0200_NameType("C", "Adopted Name");
        public static T0200_NameType DISPLAY_NAME                 = new T0200_NameType("D", "Display Name");
        public static T0200_NameType LICENSING_NAME               = new T0200_NameType("I", "Licensing Name");
        public static T0200_NameType LEGAL_NAME                   = new T0200_NameType("L", "Legal Name");
        public static T0200_NameType MAIDEN_NAME                  = new T0200_NameType("M", "Maiden Name");
        public static T0200_NameType NICKNAME                     = new T0200_NameType("N", "Nickname");
        public static T0200_NameType NAME_OF_PARTNER_SPOUSE       = new T0200_NameType("P", "Name Of Partner/Spouse");
        public static T0200_NameType REGISTERED_NAME              = new T0200_NameType("R", "Registered Name (animals only)");
        public static T0200_NameType CODED_PSEUDO_NAME            = new T0200_NameType("S", "Coded Pseudo-Name to ensure anonymity");
        public static T0200_NameType INDIGENOUS_TRIBAL_COMMUNITY  = new T0200_NameType("T", "Indigenous/Tribal/Community Name");
        public static T0200_NameType UNSPECIFIED                  = new T0200_NameType("U", "Unspecified");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public T0200_NameType(string value, string description) : base(value, description) { }

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
