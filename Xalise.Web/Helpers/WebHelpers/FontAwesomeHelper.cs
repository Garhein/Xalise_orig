using Xalise.Web.Enums;

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
        public static string FontAwesomeClass(eFontAwesomeIconStyle style, eFontAwesomeIcon icon)
        {
            return FontAwesomeHelper.FontAwesomeClass(style, icon, eFontAwesomeIconSize.size_default, eFontAwesomeAnimation.animation_default);
        }

        /// <summary>
        /// Construction du nom des classes CSS.
        /// </summary>
        /// <param name="style">Style de l'icône.</param>
        /// <param name="icon">Icône.</param>
        /// <param name="size">Taille de l'icône.</param>
        /// <returns></returns>
        public static string FontAwesomeClass(eFontAwesomeIconStyle style, eFontAwesomeIcon icon, eFontAwesomeIconSize size)
        {
            return FontAwesomeHelper.FontAwesomeClass(style, icon, size, eFontAwesomeAnimation.animation_default);
        }

        /// <summary>
        /// Construction du nom des classes CSS.
        /// </summary>
        /// <param name="style">Style de l'icône.</param>
        /// <param name="icon">Icône.</param>
        /// <param name="animation">Animation de l'icône.</param>
        /// <returns></returns>
        public static string FontAwesomeClass(eFontAwesomeIconStyle style, eFontAwesomeIcon icon, eFontAwesomeAnimation animation)
        {
            return FontAwesomeHelper.FontAwesomeClass(style, icon, eFontAwesomeIconSize.size_default, animation);
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
                                        eFontAwesomeIconStyle style, 
                                        eFontAwesomeIcon icon,
                                        eFontAwesomeIconSize size = eFontAwesomeIconSize.size_default,
                                        eFontAwesomeAnimation animation = eFontAwesomeAnimation.animation_default)
        {
            string iconClass = string.Empty;

            if (icon == eFontAwesomeIcon.lockk)
            {
                // Traitement nécessaire car 'lock' est un mot-clé du language
                iconClass = "lock";
            }
            else
            {
                iconClass = icon.ToString().Replace("_", "-");
            }

            string ret = $"fa-{style.ToString()} fa-{iconClass}";

            if (size != eFontAwesomeIconSize.size_default)
            {
                ret += $" fa-{size.ToString().Replace("double_", "2")}";
            }

            if (animation != eFontAwesomeAnimation.animation_default)
            {
                ret += $" fa-{animation.ToString().Replace("_", "-")}";
            }

            return ret;
        }
    }
}
