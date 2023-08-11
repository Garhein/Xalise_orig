using System.Text.RegularExpressions;
using Xalise.Core.Helpers;
using Xalise.Interop.InteropHL7.Exceptions;

namespace Xalise.Interop.InteropHL7.Helpers
{
    /// <summary>
    /// Fonctions utilitaires pour manipuler les numériques, notamment le type de données <seealso cref="Structure.DataType.Primitive.NM"/>.
    /// </summary>
    public static class NumberHelperHL7
    {
        /// <summary>
        /// Nettoie et vérifie la valeur d'un type de données <see cref="Structure.DataType.Primitive.NM"/>.
        /// - Les espaces sont retirés.
        ///  - Si un signe est présent en début, la valeur doit faire plus de 1 caractère.
        ///  - Vérification du format de la chaîne nettoyée.
        /// </summary>
        /// <param name="value">Valeur à nettoyer et vérifier.</param>
        /// <returns>Valeur nettoyée et vérifiée.</returns>
        /// <exception cref="DataTypeException">Si la chaîne nettoyée ne respecte pas le format où si elle contient uniquement le signe.</exception>
        public static string CheckAndSanitizeNM(string value)
        {
            string ret = value;

            if (!string.IsNullOrWhiteSpace(value))
            {
                ret = value.Trim().Replace(" ", "");

                if ((ret.StartsWith(NumberHelper.CSTS_DEFAULT_POSITIVE_SIGN) || ret.StartsWith(NumberHelper.CSTS_DEFAULT_NEGATIVE_SIGN)) && ret.Length == 1)
                {
                    throw new DataTypeException($"La valeur ne peut pas être composée uniquement du signe.");
                }

                Regex regexChars = new Regex("^((\\+|\\-)?[0-9]+)(\\.[0-9]+)?$");
                if (!regexChars.IsMatch(ret))
                {
                    throw new DataTypeException($"La valeur {value} ne respecte pas les conditions de validité du type de données.");
                }
            }

            return ret;
        }
    }
}
