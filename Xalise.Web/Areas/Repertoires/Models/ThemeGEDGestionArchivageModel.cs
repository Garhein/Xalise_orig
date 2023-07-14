using System;
using Xalise.Core.Entite.GED;
using Xalise.Web.Enums;
using Xalise.Web.Models;

namespace Xalise.Web.Areas.Repertoires.Models
{
    /// <summary>
    /// Modèle de données utilisé pour la gestion de l'archivage d'un thème GED.
    /// </summary>
    [Serializable]
    public class ThemeGEDGestionArchivageModel : BaseGestionArchivageModel
    {
        public ThemeDTO ThemeDTO { get; set; }
        public bool     EstParentAvecEnfants { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public ThemeGEDGestionArchivageModel() : base("Thème GED")
        {
            this.ThemeDTO             = new ThemeDTO();
            this.EstParentAvecEnfants = false;
            this.ModeGestion          = eModeGestionArchivage.ARCHIVAGE;
        }

        /// <summary>
        /// Complément du message de confirmation affiché à l'utilisateur.
        /// </summary>
        public string UMessageConfirmationComplement
        {
            get
            {
                string compl = " ";

                if (this.EstParentAvecEnfants)
                {
                    if (this.ModeGestion == eModeGestionArchivage.ARCHIVAGE)
                    {
                        compl = " et";
                    }
                    else if (this.ModeGestion == eModeGestionArchivage.ANNULATION_ARCHIVAGE)
                    {
                        compl = " et de";
                    }

                    compl += " l'ensemble de ses enfants";
                }

                return compl;
            }
        }
    }
}
