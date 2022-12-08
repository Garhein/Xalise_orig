using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0103 - Processing ID.
    /// </summary>
    [Serializable]
    public class ProcessingID : AbstractTable
    {
        public static ProcessingID DEBUGGING    = new ProcessingID("D", "Debugging");
        public static ProcessingID PRODUCTION   = new ProcessingID("P", "Production");
        public static ProcessingID TRAINING     = new ProcessingID("T", "Training");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public ProcessingID(string value, string description) : base(value, description) { }

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
