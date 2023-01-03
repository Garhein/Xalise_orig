using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0207 - Processing mode.
    /// </summary>
    [Serializable]
    public class T0207_ProcessingMode : AbstractTable
    {
        public static T0207_ProcessingMode ARCHIVE                = new T0207_ProcessingMode("A", "Archive");
        public static T0207_ProcessingMode INITIAL_LOAD           = new T0207_ProcessingMode("I", "Initial load");
        public static T0207_ProcessingMode NOT_PRESENT            = new T0207_ProcessingMode("Not present", "Not present (the default, meaning current processing)");
        public static T0207_ProcessingMode RESTORE_FROM_ARCHIVE   = new T0207_ProcessingMode("R", "Restore from archive");
        public static T0207_ProcessingMode CURRENT_PROCESSING     = new T0207_ProcessingMode("T", "Current processing, transmitted at intervals (scheduled or on demand)");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public T0207_ProcessingMode(string value, string description) : base(value, description) { }

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
