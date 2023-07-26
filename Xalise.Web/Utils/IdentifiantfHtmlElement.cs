namespace Xalise.Web.Utils
{
    /// <summary>
    /// Définition des ID, classes et nom des éléments HTML courants.
    /// </summary>
    public struct IdentifiantfHtmlElement
    {
        #region Liens

        // Lien d'action
        public const string CLASS_LINK_ACTION   = "x-link-action";

        #endregion

        #region Formulaires

        // Case à cocher permettant de réaliser une saisie à la suite de la création d'un élément
        public const string ID_FORM_CHECKBOX_SAISIE_SUITE    = "x-form-chk-saisie-suite";
        // Formulaire de saisie d'un thème GED
        public const string ID_FORM_REP_THEME_GED_EDIT       = "form-rep-theme-ged-edit";
        // Formulaire des critères de recherche du répertoire des thèmes GED
        public const string ID_FORM_REP_THEME_GED_CRITERES   = "form-rep-theme-ged-criteres";

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
        public const string CLASS_TR_CENTER        = "x-tr-center";
        // Colonne contenant les icônes d'action
        public const string CLASS_TR_ACTIONS       = "x-tr-actions";
        // Colonne contenant une case à cocher
        public const string CLASS_TR_CHECKBOX      = "x-tr-check";
        // Colonne contenant une case à cocher
        public const string CLASS_TR_NUM_ORDRE     = "x-tr-num-ordre";

        #endregion
    }
}
