using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0207 - Processing mode.
    /// </summary>
    [Serializable]
    public class ProcessingMode : AbstractTable
    {
        public static ProcessingMode ARCHIVE                = new ProcessingMode("A", "Archive");
        public static ProcessingMode INITIAL_LOAD           = new ProcessingMode("I", "Initial load");
        public static ProcessingMode NOT_PRESENT            = new ProcessingMode("Not present", "Not present (the default, meaning current  processing)");
        public static ProcessingMode RESTORE_FROM_ARCHIVE   = new ProcessingMode("R", "Restore from archive");
        public static ProcessingMode CURRENT_PROCESSING     = new ProcessingMode("T", "Current processing, transmitted at intervals (scheduled or on demand)");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public ProcessingMode(string value, string description) : base(value, description) { }

        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public override string TableNumber
        {
            get
            {
                return "0207";
            }
        }
    }
}
