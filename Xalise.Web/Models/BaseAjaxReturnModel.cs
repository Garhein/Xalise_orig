using System;
using System.Collections.Generic;

namespace Xalise.Web.Models
{
    /// <summary>
    /// Classe de base utilisée pour la gestion des retours des appels Ajax.
    /// Exemples d'utilisation : ouverture d'une fenêtre de dialogue, enregistrement Ajax, ...
    /// </summary>
    [Serializable]
    public class BaseAjaxReturnModel
    {
        public bool         AvecErreur { get; set; }
        public string       MessageErreur { get; set; }
        public List<string> MessageErreurs { get; set; }
        public string       MessageSucces { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public BaseAjaxReturnModel()
        {
            this.AvecErreur      = false;
            this.MessageErreur   = string.Empty;
            this.MessageErreurs  = new List<string>();
            this.MessageSucces   = string.Empty;
        }

        /// <summary>
        /// Ajout d'une erreur.
        /// </summary>
        /// <param name="messageErreur">Message de l'erreur.</param>
        public void AddErreur(string messageErreur)
        {
            this.AvecErreur      = true;
            this.MessageErreur   = messageErreur;
        }

        /// <summary>
        /// Ajout d'erreurs.
        /// </summary>
        /// <param name="messageErreurs">Liste des messages d'erreur.</param>
        public void AddErreurs(List<string> messageErreurs)
        {
            this.AvecErreur = true;
            this.MessageErreurs.AddRange(messageErreurs);
        }
    }
}
