using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0529 - Precision.
    /// </summary>
    [Serializable]
    public class Precision : AbstractTable
    {
        public static Precision DAY     = new Precision("D", "Day");
        public static Precision HOUR    = new Precision("H", "Hour");
        public static Precision MONTH   = new Precision("L", "Month");
        public static Precision MINUTE  = new Precision("M", "Minute");
        public static Precision SECOND  = new Precision("S", "Second");
        public static Precision YEAR    = new Precision("Y", "Year");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public Precision(string value, string description) : base(value, description) { }

        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public override string TableNumber
        {
            get
            {
                return "0529";
            }
        }
    }
}
