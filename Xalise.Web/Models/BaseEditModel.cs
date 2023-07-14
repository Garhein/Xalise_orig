using System;
using Xalise.Core.Extensions;
using Xalise.Web.Enums;

namespace Xalise.Web.Models
{
    /// <summary>
    /// Modèle de données utilisé pour l'édition (création, modification, visualisation).
    /// </summary>
    [Serializable]
    public class BaseEditModel
    {
        private const string CONST_CONTINUER_SAISIE_TITRE = "Continuer la saisie";

        /// <summary>
        /// En mode <see cref="eModeOuverture.CREATION"/>, permet de saisir un nouvel élément après l'enregistrement.
        /// </summary>
        public bool             ContinuerSaisie { get; set; }

        /// <summary>
        /// Titre de la case à cocher permettant de saisir un nouvel élément après l'enregistrement.
        /// </summary>
        public string           ContinuerSaisieTitre { get; set; }

        /// <summary>
        /// Erreurs détectées pendant les traitements.
        /// </summary>
        public BaseAjaxReturnModel   ErrorModel { get; set; }

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
        public BaseEditModel() : this("", BaseEditModel.CONST_CONTINUER_SAISIE_TITRE) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="complTitre">Complément du titre de la page ou de la fenêtre de dialogue.</param>
        public BaseEditModel(string complTitre) : this(complTitre, BaseEditModel.CONST_CONTINUER_SAISIE_TITRE) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="complTitre">Complément du titre de la page ou de la fenêtre de dialogue.</param>
        /// <param name="continuerSaisieTitre">Titre de la case à cocher pour saisir un nouvel élément après enregistrement.</param>
        public BaseEditModel(string complTitre, string continuerSaisieTitre)
        {
            this.ContinuerSaisie        = false;
            this.ContinuerSaisieTitre   = string.IsNullOrWhiteSpace(continuerSaisieTitre) ? BaseEditModel.CONST_CONTINUER_SAISIE_TITRE : continuerSaisieTitre;
            this.ErrorModel             = new BaseAjaxReturnModel();
            this.ModeOuverture          = eModeOuverture.VISUALISATION;
            this.ComplementTitre        = complTitre;
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

                    retTitre += this.ModeOuverture.Description();
                }

                return retTitre;
            }
        }
    }
}
