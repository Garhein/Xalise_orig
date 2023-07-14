using System;
using System.Collections.Generic;
using Xalise.Core.Entite.GED;

namespace Xalise.Web.Areas.Repertoires.Models
{
    /// <summary>
    /// Modèle de données utilisé pour le répertoire des thèmes GED.
    /// </summary>
    [Serializable]
    public class ThemeGEDViewModel
    {
        public ThemeCriteresRechercheModel  CriteresRecherche { get; set; }
        public IEnumerable<ThemeDTO>        ListeThemes { get; set; }

        /// <summary>
        /// Constructeur vide.
        /// </summary>
        /// <param name="criteres">Critères de recherche.</param>
        public ThemeGEDViewModel(ThemeCriteresRechercheModel criteres)
        {
            this.CriteresRecherche   = criteres;
            this.ListeThemes         = new List<ThemeDTO>();
        }
    }
}