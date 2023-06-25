using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xalise.Core.Entite.GED
{
    [Serializable]
    public class ThemeDTO
    {
        public int      ID { get; set; }

        [Required(ErrorMessage = "Le libellé du thème est obligatoire.")]
        [DisplayName("Libellé")]
        [MaxLength(80)]
        public string   Libelle { get; set; }

        [DisplayName("Thème parent")]
        public int?     ParentID { get; set; }
        public string   ParentLibelle { get; set; }
        public int      NumOrdre { get; set; }

        [DisplayName("Référence interne")]
        public bool     EstInterne { get; set; }
        [DisplayName("Archivé")]
        public bool     EstArchive { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public ThemeDTO()
        {
            this.ID             = 0;
            this.Libelle        = string.Empty;
            this.ParentID       = null;
            this.ParentLibelle  = string.Empty;
            this.NumOrdre       = 0;
            this.EstInterne     = false;
            this.EstArchive     = false;
        }

        /// <summary>
        /// Construction à partir d'une entité.
        /// </summary>
        /// <param name="theme">Thème à transformer en DTO.</param>
        /// <param name="parentLibelle">Libellé du thème parent.</param>
        public ThemeDTO(Theme theme, string parentLibelle)
        {
            if (theme != null)
            {
                this.ID             = theme.ID;
                this.Libelle        = theme.Libelle;
                this.ParentID       = theme.ParentID;
                this.ParentLibelle  = parentLibelle;
                this.NumOrdre       = theme.NumOrdre;
                this.EstInterne     = theme.EstInterne;
                this.EstArchive     = theme.EstArchive;
            }
            else
            {
                this.ID             = 0;
                this.Libelle        = string.Empty;
                this.ParentID       = null;
                this.ParentLibelle  = string.Empty;
                this.NumOrdre       = 0;
                this.EstInterne     = false;
                this.EstArchive     = false;
            }
        }

        /// <summary>
        /// Construction du libellé affiché sur le répertoire des thèmes GED.
        /// </summary>
        public string ULibelleListeRepertoire
        {
            get
            {
                string retLibelle = "";

                if (this.ParentID.HasValue)
                {
                    retLibelle = "-- ";
                }

                retLibelle += this.Libelle;

                if (!string.IsNullOrWhiteSpace(this.ParentLibelle))
                {
                    retLibelle = $"{retLibelle} ({this.ParentLibelle})";
                }

                return retLibelle;
            }
        }
    }
}
