using Xalise.Core.Attributes;

namespace Xalise.Web.Enums
{
    /// <summary>
    /// Taille de l'icône FontAwesome.
    /// </summary>
    public enum eFontAwesomeIconSize
    {
        /// <summary>
        /// <see cref="size_default"/> doit toujours être en première position.
        /// Pour une bonne gestion des tags helpers personnalisés.
        /// </summary>
        size_default,
        [CssClassName("fa-xs")]
        xs,
        [CssClassName("fa-2xs")]
        double_xs,
        [CssClassName("fa-sm")]
        sm,
        [CssClassName("fa-lg")]
        lg,
        [CssClassName("fa-xl")]
        xl,
        [CssClassName("fa-2xl")]
        double_xl
    }
}
