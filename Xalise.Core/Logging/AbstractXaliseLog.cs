namespace Xalise.Core.Logging
{
    /// <summary>
    /// Classe de base pour la gestion des logs.
    /// </summary>
    /// <typeparam name="TEnum"></typeparam>
    public abstract class AbstractXaliseLog<TEnum> where TEnum : Enum
    {
        private TEnum _niveauMinimum;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="niveauMin">Niveau minimum d'écriture.</param>
        public AbstractXaliseLog(TEnum niveauMin)
        {
            this._niveauMinimum = niveauMin;
        }

        /// <summary>
        /// Récupère le niveau minimum d'écriture des messages de log.
        /// </summary>
        public TEnum NiveauMinimum
        {
            get
            {
                return this._niveauMinimum;
            }
        }

        /// <summary>
        /// Modifie le niveau minimum d'écriture des messages de log.
        /// </summary>
        /// <param name="niveauMin"></param>
        public void SetNiveauMinimum(TEnum niveauMin)
        {
            this._niveauMinimum = niveauMin;
        }

        #region Méthodes abstraites

        /// <summary>
        /// Écriture d'un message de log.
        /// </summary>
        /// <param name="niveau">Niveau du message.</param>
        /// <param name="emetteur">Émetteur du message.</param>
        /// <param name="log">Message de log.</param>
        /// <exception cref="ArgumentNullException">L'émetteur du log est NULL.</exception>
        /// <exception cref="ArgumentException">L'émetteur du log est vide ou composé uniquement d'espaces.</exception>
        public abstract void EcrireMessage(TEnum niveau, string emetteur, string log);

        #endregion
    }
}
