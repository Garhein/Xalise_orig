using Microsoft.AspNetCore.Mvc.Rendering;
using Xalise.Web.Data;
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
        public ThemeEditModel() : base()
        {
            ListeThemesParents          = new List<SelectListItem>();
            ThemeDTO                    = new ThemeDTO();
            this.EstParentAvecEnfants   = false;
        }

        #region Utilitaires d'affichage

        /// <summary>
        /// Titre de la fenêtre de dialogue.
        /// </summary>
        public string UModalTitle
        {
            get
            {
                string title = string.Empty;

                if (AvecErreur)
                {
                    title = "Erreur";
                }
                else
                {
                    if (ThemeDTO.ID > 0)
                    {
                        title = "Modification du thème";
                    }
                    else
                    {
                        title = "Création d'un thème";
                    }
                }

                return title;
            }
        }

        #endregion
    }
}
