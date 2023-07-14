namespace Xalise.Web.Enums
{
    /// <summary>
    /// Taille des boutons Bootstrap.
    /// </summary>
    public enum eBootstrapButtonStyle
    {
        /// <summary>
        /// <see cref="style_default"/> doit toujours être en première position.
        /// Pour une bonne gestion de <see cref="Helpers.TagHelpers.XaliseButtonTagHelper"/>.
        /// </summary>
        style_default, 
        btn_primary,
        btn_secondary
    }
}
