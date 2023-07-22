﻿using Xalise.Core.Attributes;

namespace Xalise.Web.Enums
{
    /// <summary>
    /// Icône FontAwesome.
    /// </summary>
    public enum eFontAwesomeIcon
    {
        /// <summary>
        /// <see cref="icon_default"/> doit toujours être en première position.
        /// Pour une bonne gestion des tags helpers personnalisés.
        /// </summary>
        icon_default,
        [CssClassName("fa-arrow-rotate-left")]
        arrow_rotate_left,
        [CssClassName("fa-check")]
        check,
        [CssClassName("fa-eye")]
        eye,
        [CssClassName("fa-lock")]
        lockk,
        [CssClassName("fa-magnifying-glass")]
        magnifying_glass,
        [CssClassName("fa-pencil")]
        pencil,
        [CssClassName("fa-plus")]
        plus,
        [CssClassName("fa-spinner")]
        spinner,
        [CssClassName("fa-trash-can")]
        trash_can,
        [CssClassName("fa-triangle-exclamation")]
        triangle_exclamation,
        [CssClassName("fa-unlock")]
        unlock,
        [CssClassName("fa-xmark")]
        xmark,
    }
}
