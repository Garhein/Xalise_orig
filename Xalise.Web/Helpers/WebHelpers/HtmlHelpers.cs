namespace Xalise.Web.Helpers.WebHelpers
{
    public static class HtmlHelpers
    {
        /// <summary>
        /// Définition des ID, class et nom des éléments HTML courants.
        /// </summary>
        public struct IdentifiantfHtmlElement
        {
            // Lien d'action
            public const string CLASS_ACTION_LINK = "ui-action-link";

            #region Formulaire

            // Case à cocher permettant de réaliser une saisie à la suite de l'enregistrement
            public const string ID_CHECKBOX_SAISIE_SUITE    = "ui-chk-saisie-suite";

            #endregion

            #region Texte

            // Justification de texte
            public const string CLASS_TXT_JUSTIFY           = "x-txt-justify";
            // Taille de police de 0.70rem
            public const string CLASS_FONT_SIZE_70          = "x-font-size-70";
            // Taille de police de 0.75rem
            public const string CLASS_FONT_SIZE_75          = "x-font-size-75";

            #endregion

            #region Tables HTML

            // Colonne contenant les icônes d'action
            public const string CLASS_COL_ACTIONS = "ui-col-actions";
            // Colonne contenant une case à cocher
            public const string CLASS_COL_CHECKBOX = "ui-col-check";

            #endregion
        }
    }
}
