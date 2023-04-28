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
        // En mode création, permet de saisir un nouvel élément après l'enregistrement
        public bool             ContinuerSaisie { get; set; }

        public BaseErrorModel   ErrorModel { get; set; }

        public eModeOuverture   ModeOuverture { get; set; }

        public string           ComplementTitre { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public BaseEditModel() : this("") { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="complTitre">Complément du titre de la page/fenêtre de dialogue.</param>
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
                return ErrorModel.AvecErreur;
            }
        }

        #region Utilitaires d'affichage

        /// <summary>
        /// Titre de la case à cocher permettant de saisir un
        /// nouvel élément à la suite.
        /// </summary>
        public string UTitreContinuerSaisie
        { 
            get
            {
                return "Continuer la saisie";
            }
        }

        /// <summary>
        /// Titre de la fenêtre de dialogue.
        /// </summary>
        public string UModalTitle
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
