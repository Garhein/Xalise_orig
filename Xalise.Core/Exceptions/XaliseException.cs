namespace Xalise.Core.Exceptions
{
    /// <summary>
    /// Exceptions levées/interceptées manuellement.
    /// </summary>
    public class XaliseException : Exception
    {
        /// <summary>
        /// Constructeur vide.
        /// </summary>
        public XaliseException() { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="message">Message de l'exception.</param>
        public XaliseException(string message) : base(message) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="message">Message de l'exception.</param>
        /// <param name="inner">Exception interne.</param>
        public XaliseException(string message, Exception inner) : base(message, inner) { }
    }
}
