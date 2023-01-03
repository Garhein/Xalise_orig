using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0103 - Processing ID.
    /// </summary>
    [Serializable]
    public class T0103_ProcessingID : AbstractTable
    {
        public static T0103_ProcessingID DEBUGGING    = new T0103_ProcessingID("D", "Debugging");
        public static T0103_ProcessingID PRODUCTION   = new T0103_ProcessingID("P", "Production");
        public static T0103_ProcessingID TRAINING     = new T0103_ProcessingID("T", "Training");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public T0103_ProcessingID(string value, string description) : base(value, description) { }

        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public override string TableNumber
        {
            get
            {
                return "0103";
            }
        }
    }
}
