using Xalise.Core.Extensions;
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
            string ret = $"{style.CssClassName()} {icon.CssClassName()}";

            if (size != eFontAwesomeIconSize.size_default)
            {
                ret += $" {size.CssClassName()}";
            }

            if (animation != eFontAwesomeAnimation.animation_default)
            {
                ret += $" {animation.CssClassName()}";
            }

            return ret;
        }
    }
}
