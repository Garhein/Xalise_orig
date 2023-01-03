using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0529 - Precision.
    /// </summary>
    [Serializable]
    public class T0529_Precision : AbstractTable
    {
        public static T0529_Precision DAY     = new T0529_Precision("D", "Day");
        public static T0529_Precision HOUR    = new T0529_Precision("H", "Hour");
        public static T0529_Precision MONTH   = new T0529_Precision("L", "Month");
        public static T0529_Precision MINUTE  = new T0529_Precision("M", "Minute");
        public static T0529_Precision SECOND  = new T0529_Precision("S", "Second");
        public static T0529_Precision YEAR    = new T0529_Precision("Y", "Year");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public T0529_Precision(string value, string description) : base(value, description) { }

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
