using System;
using Xalise.Core.Extensions;
using Xalise.Web.Enums;

namespace Xalise.Web.Models
{
    /// <summary>
    /// Modèle de données utilisé pour la gestion de l'archivage d'éléments (archivage et annulation de l'archivage).
    /// </summary>
    [Serializable]
    public abstract class BaseGestionArchivageModel
    {
        /// <summary>
        /// Erreurs détectées pendant les traitements.
        /// </summary>
        public BaseAjaxReturnModel      ErrorModel { get; set; }

        /// <summary>
        /// Mode de gestion.
        /// </summary>
        public eModeGestionArchivage    ModeGestion { get; set; }

        /// <summary>
        /// Complément du titre de la page ou de la fenêtre de dialogue utilisée pour la gestion.
        /// </summary>
        public string                   ComplementTitre { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public BaseGestionArchivageModel() : this("") { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="complTitre">Complément du titre de la page ou de la fenêtre de dialogue utilisée pour la gestion.</param>
        public BaseGestionArchivageModel(string complTitre)
        {
            this.ErrorModel         = new BaseAjaxReturnModel();
            this.ModeGestion        = eModeGestionArchivage.ARCHIVAGE;
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

        /// <summary>
        /// Titre de la page ou de la fenêtre de dialogue utilisée pour la gestion.
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

                    retTitre += this.ModeGestion.Description();
                }

                return retTitre;
            }
        }

        /// <summary>
        /// Description du titre de l'action affichée sur la page ou fenêtre de dialogue utilisée pour la gestion.
        /// </summary>
        public string UTitreAction
        {
            get
            {
                string retAction = "";

                if (this.ModeGestion == eModeGestionArchivage.ARCHIVAGE)
                {
                    retAction = "Archiver";
                }
                else if (this.ModeGestion == eModeGestionArchivage.ANNULATION_ARCHIVAGE)
                {
                    retAction = "Annuler l'archivage";
                }

                return retAction;
            }
        }

        /// <summary>
        /// Action du message de confirmation affiché à l'utilisateur.
        /// </summary>
        public string UMessageConfirmationAction
        {
            get
            {
                string msgConfirmation = this.UTitreAction.ToLower();

                if (this.ModeGestion == eModeGestionArchivage.ARCHIVAGE)
                {
                    msgConfirmation += " le ";
                }
                else if (this.ModeGestion == eModeGestionArchivage.ANNULATION_ARCHIVAGE)
                {
                    msgConfirmation += " du ";
                }

                return msgConfirmation;
            }
        }
    }
}
