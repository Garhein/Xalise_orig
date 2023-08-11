using System.Globalization;

namespace Xalise.Core.Helpers
{
    /// <summary>
    /// Fonctions utilitaires pour manipuler les numériques, quel que soit leur type (<seealso cref="int"/>, <seealso cref="decimal"/>, ...).
    /// </summary>
    public static class NumberHelper
    {
        #region Valeurs par défaut des formats numériques

        /// <summary>
        /// Signe négatif.
        /// </summary>
        public const string CSTS_DEFAULT_NEGATIVE_SIGN      = "-";

        /// <summary>
        /// Signe positif.
        /// </summary>
        public const string CSTS_DEFAULT_POSITIVE_SIGN      = "+";
        
        /// <summary>
        /// Séparateur de décimales.
        /// </summary>
        public const string CSTS_DEFAULT_DECIMAL_SEPARATOR  = ".";
        
        /// <summary>
        /// Séparateur des groupes de chiffres à gauche du séparateur de décimales.
        /// </summary>
        public const string CSTS_DEFAULT_GROUP_SEPARATOR    = " ";

        #endregion

        /// <summary>
        /// Construction du format à appliquer l'export <see cref="object.ToString()"/> d'un numérique.
        /// Les valeurs par défaut sont utilisés pour le séparateur de décimales et de groupes, à savoir :
        ///  - <seealso cref="NumberHelper.CSTS_DEFAULT_DECIMAL_SEPARATOR"/>
        ///  - <seealso cref="NumberHelper.CSTS_DEFAULT_GROUP_SEPARATOR"/>
        /// </summary>
        /// <param name="nbDecimales">Nombre de décimales à conserver.</param>
        /// <returns>Une instance de <seealso cref="NumberFormatInfo"/>.</returns>
        public static NumberFormatInfo GetFormatNumerique(int nbDecimales)
        {
            return NumberHelper.GetFormatNumerique(nbDecimales, NumberHelper.CSTS_DEFAULT_DECIMAL_SEPARATOR, NumberHelper.CSTS_DEFAULT_GROUP_SEPARATOR);
        }

        /// <summary>
        /// Construction du format à appliquer l'export <see cref="object.ToString()"/> d'un numérique.
        /// La valeur par défaut <seealso cref="NumberHelper.CSTS_DEFAULT_DECIMAL_SEPARATOR"/> est utilisée.
        /// </summary>
        /// <param name="nbDecimales">Nombre de décimales à conserver.</param>
        /// <param name="sepGroupes">Séparateur des groupes de chiffres à gauche du séparateur de décimales.</param>
        /// <returns>Une instance de <seealso cref="NumberFormatInfo"/>.</returns>
        public static NumberFormatInfo GetFormatNumerique(int nbDecimales, string sepGroupes)
        {
            return NumberHelper.GetFormatNumerique(nbDecimales, NumberHelper.CSTS_DEFAULT_DECIMAL_SEPARATOR, sepGroupes);
        }

        /// <summary>
        /// Construction du format à appliquer l'export <see cref="object.ToString()"/> d'un numérique.
        /// </summary>
        /// <param name="nbDecimales">Nombre de décimales.</param>
        /// <param name="sepDecimales">Séparateur de décimales à conserver.</param>
        /// <param name="sepGroupes">Séparateur des groupes de chiffres à gauche du séparateur de décimales.</param>
        /// <returns>Une instance de <seealso cref="NumberFormatInfo"/>.</returns>
        public static NumberFormatInfo GetFormatNumerique(int nbDecimales, string sepDecimales, string sepGroupes)
        {
            NumberFormatInfo nfi = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name).NumberFormat;
            nfi.NegativeSign            = NumberHelper.CSTS_DEFAULT_NEGATIVE_SIGN;
            nfi.PositiveSign            = NumberHelper.CSTS_DEFAULT_POSITIVE_SIGN;
            nfi.NumberDecimalDigits     = nbDecimales;
            nfi.NumberDecimalSeparator  = sepDecimales;
            nfi.NumberGroupSeparator    = sepGroupes;

            return nfi;
        }
    }
}
