namespace Xalise.Web.Models
{
    /// <summary>
    /// Classe de base utilisée pour la gestion des erreurs.
    /// Exemples d'utilisation : ouverture d'une fenêtre de dialogue, enregistrement Ajax, ...
    /// </summary>
    [Serializable]
    public class BaseErrorModel
    {
        public bool         AvecErreur { get; set; }
        public string       MessageErreur { get; set; }
        public List<string> MessageErreurs { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public BaseErrorModel()
        {
            AvecErreur      = false;
            MessageErreur   = string.Empty;
            MessageErreurs  = new List<string>();
        }

        /// <summary>
        /// Ajout d'une erreur.
        /// </summary>
        /// <param name="messageErreur">Message de l'erreur.</param>
        public void AddErreur(string messageErreur)
        {
            AvecErreur      = true;
            MessageErreur   = messageErreur;
        }

        /// <summary>
        /// Ajout d'erreurs.
        /// </summary>
        /// <param name="messageErreurs">Liste des messages d'erreur.</param>
        public void AddErreurs(List<string> messageErreurs)
        {
            AvecErreur = true;
            MessageErreurs.AddRange(messageErreurs);
        }
    }
}
