using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0061 - Check digit scheme.
    /// </summary>
    [Serializable]
    public class CheckDigitScheme : AbstractTable
    {
        public static CheckDigitScheme ISO = new CheckDigitScheme("ISO", "ISO 7064: 1983");
        public static CheckDigitScheme M10 = new CheckDigitScheme("M10", "Mod 10 algorithm");
        public static CheckDigitScheme M11 = new CheckDigitScheme("M11", "Mod 11 algorithm");
        public static CheckDigitScheme NPI = new CheckDigitScheme("NPI", "Check digit algorithm in the US National Provider Identifier");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public CheckDigitScheme(string value, string description) : base(value, description) { }

        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public override string TableNumber
        {
            get
            {
                return "0061";
            }
        }
    }
}
