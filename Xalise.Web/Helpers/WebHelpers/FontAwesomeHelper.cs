namespace Xalise.Web.Helpers.WebHelpers
{
    /// <summary>
    /// Construction des classes CSS FontAwesome.
    /// </summary>
    public static class FontAwesomeHelper
    {
        /// <summary>
        /// Construction du nom des classes CSS.
        /// </summary>
        /// <param name="style">Style de l'icône.</param>
        /// <param name="icon">Icône.</param>
        /// <returns></returns>
        public static string FontAwesomeClass(FontAwesomeIconStyle style, FontAwesomeIcon icon, FontAwesomeIconSize size = FontAwesomeIconSize.size_default)
        {
            string ret = $"fa-{style.ToString()} fa-{icon.ToString().Replace("_", "-")}";

            if (size != FontAwesomeIconSize.size_default)
            {
                ret += $" fa-{size.ToString().Replace("double_", "2")}";
            }

            return ret;
        }
    }

    /// <summary>
    /// Style de l'icône.
    /// </summary>
    public enum FontAwesomeIconStyle
    {
        solid,
        regular,
        light
    }

    /// <summary>
    /// Icône FontAwesome.
    /// </summary>
    public enum FontAwesomeIcon
    {
        icon_default,       // Doit toujours être en première position (pour le tag helper 'XaliseButton')
        check,
        eye,
        eye_slash,
        pen_to_square,
        plus,
        trash_can,
        triangle_exclamation,
        xmark
    }

    /// <summary>
    /// Taille de l'icône.
    /// </summary>
    public enum FontAwesomeIconSize
    {
        size_default,
        xs,
        double_xs,
        sm,
        lg,
        xl,
        double_xl
    }
}
