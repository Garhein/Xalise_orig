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
        public static string FontAwesomeClass(FontAwesomeIconStyle style, FontAwesomeIcon icon)
        {
            return FontAwesomeHelper.FontAwesomeClass(style, icon, FontAwesomeIconSize.size_default, FontAwesomeAnimation.animation_default);
        }

        /// <summary>
        /// Construction du nom des classes CSS.
        /// </summary>
        /// <param name="style">Style de l'icône.</param>
        /// <param name="icon">Icône.</param>
        /// <param name="size">Taille de l'icône.</param>
        /// <returns></returns>
        public static string FontAwesomeClass(FontAwesomeIconStyle style, FontAwesomeIcon icon, FontAwesomeIconSize size)
        {
            return FontAwesomeHelper.FontAwesomeClass(style, icon, size, FontAwesomeAnimation.animation_default);
        }

        /// <summary>
        /// Construction du nom des classes CSS.
        /// </summary>
        /// <param name="style">Style de l'icône.</param>
        /// <param name="icon">Icône.</param>
        /// <param name="animation">Animation de l'icône.</param>
        /// <returns></returns>
        public static string FontAwesomeClass(FontAwesomeIconStyle style, FontAwesomeIcon icon, FontAwesomeAnimation animation)
        {
            return FontAwesomeHelper.FontAwesomeClass(style, icon, FontAwesomeIconSize.size_default, animation);
        }

        /// <summary>
        /// Construction du nom des classes CSS.
        /// </summary>
        /// <param name="style">Style de l'icône.</param>
        /// <param name="icon">Icône.</param>
        /// <param name="size">Taille de l'icône.</param>
        /// <param name="animation">Animation de l'icône.</param>
        /// <returns></returns>
        public static string FontAwesomeClass(
                                        FontAwesomeIconStyle style, 
                                        FontAwesomeIcon icon,
                                        FontAwesomeIconSize size = FontAwesomeIconSize.size_default,
                                        FontAwesomeAnimation animation = FontAwesomeAnimation.animation_default)
        {
            string ret = $"fa-{style.ToString()} fa-{icon.ToString().Replace("_", "-")}";

            if (size != FontAwesomeIconSize.size_default)
            {
                ret += $" fa-{size.ToString().Replace("double_", "2")}";
            }

            if (animation != FontAwesomeAnimation.animation_default)
            {
                ret += $" fa-{animation.ToString().Replace("_", "-")}";
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
        spinner,
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

    /// <summary>
    /// Animation de l'icône.
    /// </summary>
    public enum FontAwesomeAnimation
    {
        animation_default,
        spin,
        spin_reverse,
        spin_pulse
    }
}
