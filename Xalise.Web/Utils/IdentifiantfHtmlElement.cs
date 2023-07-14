namespace Xalise.Web.Utils
{
    /// <summary>
    /// Définition des ID, classes et nom des éléments HTML courants.
    /// </summary>
    public struct IdentifiantfHtmlElement
    {
        // Lien d'action
        public const string CLASS_ACTION_LINK   = "x-action-link";

        #region Formulaires

        // Case à cocher permettant de réaliser une saisie à la suite de la création d'un élément
        public const string ID_CHECKBOX_SAISIE_SUITE    = "x-chk-saisie-suite";
        // Formulaire de saisie d'un thème GED
        public const string ID_FORM_THEME_GED_EDIT      = "form-theme-ged-edit";
        // Formulaire des critères de recherche du répertoire des thèmes GED
        public const string ID_FORM_THEME_GED_CRITERES  = "form-theme-ged-criteres";

        #endregion

        #region Texte

        // Justification de texte
        public const string CLASS_TXT_JUSTIFY   = "x-txt-justify";
        // Taille de police de 0.70rem
        public const string CLASS_FONT_SIZE_70  = "x-font-size-70";
        // Taille de police de 0.75rem
        public const string CLASS_FONT_SIZE_75  = "x-font-size-75";

        #endregion

        #region Tables HTML

        // Colonne dont le contenu est centré
        public const string CLASS_COL_CENTER        = "x-col-center";
        // Colonne contenant les icônes d'action
        public const string CLASS_COL_ACTIONS       = "x-col-actions";
        // Colonne contenant une case à cocher
        public const string CLASS_COL_CHECKBOX      = "x-col-check";
        // Colonne contenant une case à cocher
        public const string CLASS_COL_NUM_ORDRE     = "x-col-num-ordre";

        #endregion
    }
}
