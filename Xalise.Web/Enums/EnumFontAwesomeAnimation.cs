using Xalise.Core.Attributes;

namespace Xalise.Web.Enums
{
    /// <summary>
    /// Animation de l'icône FontAwesome.
    /// </summary>
    public enum eFontAwesomeAnimation
    {
        /// <summary>
        /// <see cref="animation_default"/> doit toujours être en première position.
        /// Pour une bonne gestion des tags helpers personnalisés.
        /// </summary>
        animation_default,
        [CssClassName("fa-spin")]
        spin,
        [CssClassName("fa-spin-reverse")]
        spin_reverse,
        [CssClassName("fa-spin-pulse")]
        spin_pulse
    }
}
