using System;
using System.ComponentModel;

namespace Xalise.Web.Areas.Repertoires.Models
{
    [Serializable]
    public class ThemeCriteresRechercheModel
    {
        [DisplayName("Libellé")]
        public string Libelle { get; set; }

        [DisplayName("Réf. interne")]
        public bool EstInterne { get; set; }

        [DisplayName("Réf. externe")]
        public bool EstNonInterne { get; set; }

        [DisplayName("Thèmes archivés")]
        public bool EstArchive { get; set; }

        [DisplayName("Thèmes non archivés")]
        public bool EstNonArchive { get; set; }

        /// <summary>
        /// Constructeur vide.
        /// </summary>
        public ThemeCriteresRechercheModel()
        {
            Libelle         = string.Empty;
            EstInterne      = false;
            EstNonInterne   = false;
            EstArchive      = false;
            EstNonArchive   = false;
        }
    }
}
