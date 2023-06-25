using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using Xalise.Core.Entite.GED;
using Xalise.Web.Models;

namespace Xalise.Web.Areas.Repertoires.Models
{
    /// <summary>
    /// Modèle de données utilisé pour la saisie d'un thème.
    /// </summary>
    [Serializable]
    public class ThemeEditModel : BaseEditModel
    {
        public List<SelectListItem> ListeThemesParents { get; set; }
        public ThemeDTO             ThemeDTO { get; set; }
        public bool                 EstParentAvecEnfants { get; set; }
        public bool                 EstEnfantAvecParentArchive { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public ThemeEditModel() : base("Thème GED")
        {
            this.ListeThemesParents         = new List<SelectListItem>();
            this.ThemeDTO                   = new ThemeDTO();
            this.EstParentAvecEnfants       = false;
            this.EstEnfantAvecParentArchive = false;
        }

        #region Utilitaires d'affichage

        /// <summary>
        /// Titre de la case à cocher permettant de saisir un nouvel élément à la suite.
        /// </summary>
        public new string UTitreContinuerSaisie
        {
            get
            {
                return "Saisir un thème à la suite";
            }
        }

        /// <summary>
        /// Information sur l'archivage du thème.
        /// </summary>
        public string UInfoArchivage
        {
            get
            {
                string retVal = string.Empty;

                if (this.ThemeDTO.EstArchive)
                {
                    retVal = "Thème archivé";
                }
                else if (this.EstEnfantAvecParentArchive)
                {
                    retVal = "Thème parent archivé";
                }

                return retVal;
            }
        }

        #endregion
    }
}
