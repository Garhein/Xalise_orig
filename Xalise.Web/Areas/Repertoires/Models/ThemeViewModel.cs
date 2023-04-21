using Xalise.Web.Data;

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
    }
}