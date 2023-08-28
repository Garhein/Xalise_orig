using Xalise.Core.Helpers;

namespace Xalise.Core.Extensions
{
    /// <summary>
    /// Méthodes d'extension applicables aux numériques (<seealso cref="int"/>, <seealso cref="short"/>, <seealso cref="decimal"/>, <seealso cref="double"/> ...).
    /// </summary>
    public static class NumberExtension
    {
        #region Int

        /// <summary>
        /// Formate un <see cref="int"/> en appliquant le séparateur de groupes de chiffres par défaut.
        /// </summary>
        /// <param name="value">Valeur à formater.</param>
        /// <returns>Valeur <paramref name="value"/> formatée.</returns>
        public static string ToStringFormat(this int value)
        {
            return value.ToString("N0", NumberHelper.GetFormatNumerique(0));
        }

        /// <summary>
        /// Formate un <see cref="int"/> en appliquant un séparateur de groupes de chiffres spécifique.
        /// </summary>
        /// <param name="value">Valeur à formater.</param>
        /// <param name="sepGroupes">Séparateur des groupes de chiffres à utiliser.</param>
        /// <returns>Valeur <paramref name="value"/> formatée.</returns>
        public static string ToStringFormat(this int value, string sepGroupes)
        {
            return value.ToString("N0", NumberHelper.GetFormatNumerique(0, sepGroupes));
        }

        #endregion

        #region Short

        /// <summary>
        /// Formate un <see cref="short"/> en appliquant le séparateur de groupes de chiffres par défaut.
        /// </summary>
        /// <param name="value">Valeur à formater.</param>
        /// <returns>Valeur <paramref name="value"/> formatée.</returns>
        public static string ToStringFormat(this short value)
        {
            return value.ToString("N0", NumberHelper.GetFormatNumerique(0));
        }

        /// <summary>
        /// Formate un <see cref="short"/> en appliquant un séparateur de groupes de chiffres spécifique.
        /// </summary>
        /// <param name="value">Valeur à formater.</param>
        /// <param name="sepGroupes">Séparateur des groupes de chiffres à utiliser.</param>
        /// <returns>Valeur <paramref name="value"/> formatée.</returns>
        public static string ToStringFormat(this short value, string sepGroupes)
        {
            return value.ToString("N0", NumberHelper.GetFormatNumerique(0, sepGroupes));
        }

        #endregion

        #region Decimal

        /// <summary>
        /// Formate un <seealso cref="decimal"/> en appliquant le séparateur de décimales et de groupes par défaut.
        /// </summary>
        /// <param name="value">Valeur à formater.</param>
        /// <param name="nbDecimales">Nombre de décimales à conserver.</param>
        /// <returns>Valeur formatée.</returns>
        public static string ToStringFormat(this decimal value, int nbDecimales)
        {
            return value.ToString($"N{nbDecimales}", NumberHelper.GetFormatNumerique(nbDecimales));
        }

        /// <summary>
        /// Formate un <seealso cref="decimal"/> en appliquant un séparateur de groupes spécifique.
        /// </summary>
        /// <param name="value">Valeur à formater.</param>
        /// <param name="nbDecimales">Nombre de décimales à conserver.</param>
        /// <param name="sepGroupes">Séparateur des groupes de chiffres à gauche du séparateur de décimales.</param>
        /// <returns>Valeur formatée.</returns>
        public static string ToStringFormat(this decimal value, int nbDecimales, string sepGroupes)
        {
            return value.ToString($"N{nbDecimales}", NumberHelper.GetFormatNumerique(nbDecimales, sepGroupes));
        }

        /// <summary>
        /// Formate un <seealso cref="decimal"/> en appliquant un séparateur de décimales et de groupes spécifiques.
        /// </summary>
        /// <param name="value">Valeur à formater.</param>
        /// <param name="nbDecimales">Nombre de décimales à conserver.</param>
        /// <param name="sepDecimales">Séparateur de décimales.</param>
        /// <param name="sepGroupes">Séparateur des groupes de chiffres à gauche du séparateur de décimales.</param>
        /// <returns></returns>
        public static string ToStringFormat(this decimal value, int nbDecimales, string sepDecimales, string sepGroupes)
        {
            return value.ToString($"N{nbDecimales}", NumberHelper.GetFormatNumerique(nbDecimales, sepDecimales, sepGroupes));
        }

        #endregion

        #region Double

        /// <summary>
        /// Formate un <seealso cref="double"/> en appliquant le séparateur de décimales et de groupes par défaut.
        /// </summary>
        /// <param name="value">Valeur à formater.</param>
        /// <param name="nbDecimales">Nombre de décimales à conserver.</param>
        /// <returns>Valeur formatée.</returns>
        public static string ToStringFormat(this double value, int nbDecimales)
        {
            return value.ToString($"N{nbDecimales}", NumberHelper.GetFormatNumerique(nbDecimales));
        }

        /// <summary>
        /// Formate un <seealso cref="double"/> en appliquant un séparateur de groupes spécifique.
        /// </summary>
        /// <param name="value">Valeur à formater.</param>
        /// <param name="nbDecimales">Nombre de décimales à conserver.</param>
        /// <param name="sepGroupes">Séparateur des groupes de chiffres à gauche du séparateur de décimales.</param>
        /// <returns>Valeur formatée.</returns>
        public static string ToStringFormat(this double value, int nbDecimales, string sepGroupes)
        {
            return value.ToString($"N{nbDecimales}", NumberHelper.GetFormatNumerique(nbDecimales, sepGroupes));
        }

        /// <summary>
        /// Formate un <seealso cref="double"/> en appliquant un séparateur de décimales et de groupes spécifiques.
        /// </summary>
        /// <param name="value">Valeur à formater.</param>
        /// <param name="nbDecimales">Nombre de décimales à conserver.</param>
        /// <param name="sepDecimales">Séparateur de décimales.</param>
        /// <param name="sepGroupes">Séparateur des groupes de chiffres à gauche du séparateur de décimales.</param>
        /// <returns></returns>
        public static string ToStringFormat(this double value, int nbDecimales, string sepDecimales, string sepGroupes)
        {
            return value.ToString($"N{nbDecimales}", NumberHelper.GetFormatNumerique(nbDecimales, sepDecimales, sepGroupes));
        }

        #endregion
    }
}
