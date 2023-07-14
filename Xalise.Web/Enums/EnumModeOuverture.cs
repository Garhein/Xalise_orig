using System.ComponentModel;

namespace Xalise.Web.Enums
{
    /// <summary>
    /// Mode d'ouverture des pages et des fenêtres de dialogue.
    /// </summary>
    public enum eModeOuverture : int
    {
        [Description("Création")]
        CREATION        = 1,
        [Description("Modification")]
        MODIFICATION    = 2,
        [Description("Visualisation")]
        VISUALISATION   = 3
    }
}
