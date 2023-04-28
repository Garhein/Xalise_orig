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

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public ThemeEditModel() : base("Thème GED")
        {
            ListeThemesParents          = new List<SelectListItem>();
            ThemeDTO                    = new ThemeDTO();
            this.EstParentAvecEnfants   = false;
        }

        #region Utilitaires d'affichage

        /// <summary>
        /// Titre de la case à cocher permettant de saisir un
        /// nouvel élément à la suite.
        /// </summary>
        public new string UTitreContinuerSaisie
        {
            get
            {
                return "Saisir un thème à la suite";
            }
        }

        #endregion
    }
}
