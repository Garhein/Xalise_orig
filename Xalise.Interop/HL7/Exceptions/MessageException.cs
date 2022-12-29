using System;

namespace Xalise.Interop.HL7.Exceptions
{
    /// <summary>
    /// Exceptions levées/interceptées au niveau de la gestion des messages.
    /// </summary>
    public class MessageException : Exception
    {
        /// <summary>
        /// Constructeur vide.
        /// </summary>
        public MessageException() { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="message">Message de l'exception.</param>
        public MessageException(string message) : base(message) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="message">Message de l'exception.</param>
        /// <param name="inner">Exception interne.</param>
        public MessageException(string message, Exception inner) : base(message, inner) { }
    }
}
