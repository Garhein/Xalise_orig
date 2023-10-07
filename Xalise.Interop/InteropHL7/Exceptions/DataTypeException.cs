using System;

namespace Xalise.Interop.InteropHL7.Exceptions
{
    /// <summary>
    /// Exception levée/interceptée au niveau de la gestion des types de données.
    /// </summary>
    [Serializable]
    public class DataTypeException : Exception
    {
        /// <summary>
        /// Constructeur vide.
        /// </summary>
        public DataTypeException() { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="message">Message de l'exception.</param>
        public DataTypeException(string message) : base(message) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="message">Message de l'exception.</param>
        /// <param name="inner">Exception interne.</param>
        public DataTypeException(string message, Exception inner) : base(message, inner) { }
    }
}
