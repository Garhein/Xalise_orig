using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0190 - Address type.
    /// </summary>
    [Serializable]
    public class T0190_AddressType : AbstractTable
    {
        public static T0190_AddressType FIRM_BUSINESS             = new T0190_AddressType("B", "Firm/Business");
        public static T0190_AddressType BAD_ADDRESS               = new T0190_AddressType("BA", "Bad address");
        public static T0190_AddressType BIRTH_DELIVERY_LOCATION   = new T0190_AddressType("BDL", "Birth delivery location (address where birth occurred)");
        public static T0190_AddressType RESIDENCE_AT_BIRTH        = new T0190_AddressType("BR", "Residence at birth (home address at time of birth)");
        public static T0190_AddressType CURRENT_TEMPORARY         = new T0190_AddressType("C", "Current Or Temporary");
        public static T0190_AddressType COUNTRY_ORIGIN            = new T0190_AddressType("F", "Country Of Origin");
        public static T0190_AddressType HOME                      = new T0190_AddressType("H", "Home");
        public static T0190_AddressType LEGAL_ADDRESS             = new T0190_AddressType("L", "Legal Address");
        public static T0190_AddressType MAILING                   = new T0190_AddressType("M", "Mailing");
        public static T0190_AddressType BIRTH                     = new T0190_AddressType("N", "Birth (nee) (birth address, not otherwise specified)");
        public static T0190_AddressType OFFICE                    = new T0190_AddressType("O", "Office");
        public static T0190_AddressType PERMANENT                 = new T0190_AddressType("P", "Permanent");
        public static T0190_AddressType REGISTRY_HOME             = new T0190_AddressType("RH", "Registry home");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public T0190_AddressType(string value, string description) : base(value, description) { }

        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public override string TableNumber
        {
            get
            {
                return "0190";
            }
        }
    }
}
