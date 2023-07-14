using System.ComponentModel;

namespace Xalise.Web.Enums
{
    /// Mode de gestion d'archivage d'éléments (archivage et annulation de l'archivage).
    /// </summary>
    public enum eModeGestionArchivage : short
    {
        [Description("Archivage")]
        ARCHIVAGE               = 1,
        [Description("Annulation de l'archivage")]
        ANNULATION_ARCHIVAGE    = 2
    }
}
