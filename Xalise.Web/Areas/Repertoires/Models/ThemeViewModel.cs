using System;
using System.Collections.Generic;
using System.Linq;
using Xalise.Core.Entite.GED;
using Xalise.Web.Enums;

namespace Xalise.Web.Areas.Repertoires.Models
{
    [Serializable]
    public class ThemeViewModel
    {
        public ThemeCriteresRechercheModel  CriteresRecherche { get; set; }
        public IEnumerable<ThemeDTO>        ListeThemes { get; set; }

        /// <summary>
        /// Constructeur vide.
        /// </summary>
        public ThemeViewModel()
        {
            CriteresRecherche   = new ThemeCriteresRechercheModel();
            ListeThemes         = new List<ThemeDTO>();
        }

        /// <summary>
        /// Définition du mode d'ouverture du thème.
        /// </summary>
        /// <param name="estArchive"></param>
        /// <param name="parentID"></param>
        /// <returns></returns>
        public int DefinirModeOuverture(bool estArchive, int? parentID)
        {
            int modeOuverture = (int)eModeOuverture.MODIFICATION;

            // La fenêtre de dialogue est ouverte en mode 'VISUALISATION' si
            //  - le thème lui-même (parent ou fils) est archivé
            //  - le thème parent est archivé
            if (estArchive || (parentID.HasValue && this.ListeThemes.Any(x => x.ID.Equals(parentID.Value) && x.EstArchive)))
            {
                modeOuverture = (int)eModeOuverture.VISUALISATION;
            }

            return modeOuverture;
        }
    }
}