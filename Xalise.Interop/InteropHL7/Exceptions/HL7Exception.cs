using System;

namespace Xalise.Interop.InteropHL7.Exceptions
{
    /// <summary>
    /// Exceptions générique levées/interceptées au niveau des traitements généraux.
    /// </summary>
    [Serializable]
    public class HL7Exception : Exception
    {
        /// <summary>
        /// Constructeur vide.
        /// </summary>
        public HL7Exception() { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="message">Message de l'exception.</param>
        public HL7Exception(string message) : base(message) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="message">Message de l'exception.</param>
        /// <param name="inner">Exception interne.</param>
        public HL7Exception(string message, Exception inner) : base(message, inner) { }
    }
}
