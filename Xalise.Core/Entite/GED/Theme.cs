namespace Xalise.Core.Entite.GED
{
    [Serializable]
    public class Theme
    {
        public int      ID { get; set; }
        public string   Libelle { get; set; }
        public int?     ParentID { get; set; }
        public int      NumOrdre { get; set; }
        public bool     EstInterne { get; set; }
        public bool     EstArchive { get; set; }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Theme()
        {
            this.ID         = 0;
            this.Libelle    = string.Empty;
            this.ParentID   = null;
            this.NumOrdre   = 0;
            this.EstInterne = false;
            this.EstArchive = false;
        }

        /// <summary>
        /// Construction à partir d'un DTO.
        /// </summary>
        /// <param name="dto">DTO à transformer en thème.</param>
        public Theme(ThemeDTO dto)
        {
            if (dto != null)
            {
                this.ID         = dto.ID;
                this.Libelle    = dto.Libelle;
                this.ParentID   = dto.ParentID;
                this.NumOrdre   = dto.NumOrdre;
                this.EstInterne = dto.EstInterne;
                this.EstArchive = dto.EstArchive;
            }
            else
            {
                this.ID         = 0;
                this.Libelle    = string.Empty;
                this.ParentID   = null;
                this.NumOrdre   = 0;
                this.EstInterne = false;
                this.EstArchive = false;
            }
        }
    }
}
