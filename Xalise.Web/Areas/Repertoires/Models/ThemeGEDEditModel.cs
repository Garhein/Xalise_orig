using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using Xalise.Core.Entite.GED;
using Xalise.Web.Models;

namespace Xalise.Web.Areas.Repertoires.Models
{
    /// <summary>
    /// Modèle de données utilisé pour la saisie d'un thème GED.
    /// </summary>
    [Serializable]
    public class ThemeGEDEditModel : BaseEditModel
    {
        public List<SelectListItem> ListeThemesParents { get; set; }
        public ThemeDTO             ThemeDTO { get; set; }
        public bool                 EstParentAvecEnfants { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public ThemeGEDEditModel() : base("Thème GED", "Saisir un thème à la suite")
        {
            this.ListeThemesParents         = new List<SelectListItem>();
            this.ThemeDTO                   = new ThemeDTO();
            this.EstParentAvecEnfants       = false;
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

                return retVal;
            }
        }
    }
}
