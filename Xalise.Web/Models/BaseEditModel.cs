using System;
using Xalise.Web.Enums;

namespace Xalise.Web.Models
{
    /// <summary>
    /// Modèle de données utilisé pour l'édition (création, modification, visualisation).
    /// </summary>
    [Serializable]
    public class BaseEditModel
    {
        /// <summary>
        /// En mode <see cref="eModeOuverture.CREATION"/>, permet de saisir un nouvel élément après l'enregistrement
        /// </summary>
        public bool             ContinuerSaisie { get; set; }

        /// <summary>
        /// Erreurs détectées pendant les traitements.
        /// </summary>
        public BaseErrorModel   ErrorModel { get; set; }

        /// <summary>
        /// Mode d'ouverture de la page ou de la fenêtre de dialogue.
        /// </summary>
        public eModeOuverture   ModeOuverture { get; set; }

        /// <summary>
        /// Complément du titre de la page ou de la fenêtre de dialogue.
        /// </summary>
        public string           ComplementTitre { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public BaseEditModel() : this("") { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="complTitre">Complément du titre de la page ou de la fenêtre de dialogue.</param>
        public BaseEditModel(string complTitre)
        {
            this.ContinuerSaisie    = false;
            this.ErrorModel         = new BaseErrorModel();
            this.ModeOuverture      = eModeOuverture.VISUALISATION;
            this.ComplementTitre    = complTitre;
        }

        /// <summary>
        /// Indique s'il y a une erreur dans le modèle de données.
        /// </summary>
        public bool AvecErreur
        {
            get
            {
                return this.ErrorModel.AvecErreur;
            }
        }

        #region Utilitaires d'affichage

        /// <summary>
        /// Titre de la case à cocher permettant de saisir un nouvel élément à la suite.
        /// </summary>
        public string UTitreContinuerSaisie
        { 
            get
            {
                return "Continuer la saisie";
            }
        }

        /// <summary>
        /// Titre de la page ou de la fenêtre de dialogue.
        /// </summary>
        public string UTitre
        {
            get
            {
                string retTitre = "";

                if (this.AvecErreur)
                {
                    retTitre = "Erreur";
                }
                else
                {
                    retTitre = this.ComplementTitre;

                    if (!string.IsNullOrWhiteSpace(this.ComplementTitre))
                    {
                        retTitre += " - ";
                    }

                    if (this.ModeOuverture == eModeOuverture.CREATION)
                    {
                        retTitre += "Création";
                    }
                    else if (this.ModeOuverture == eModeOuverture.MODIFICATION)
                    {
                        retTitre += "Modification";
                    }
                    else if (this.ModeOuverture == eModeOuverture.VISUALISATION)
                    {
                        retTitre += "Visualisation";
                    }
                }

                return retTitre;
            }
        }

        #endregion
    }
}
