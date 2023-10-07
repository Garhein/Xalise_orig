using System.Text.RegularExpressions;
using Xalise.Core.Extensions;
using Xalise.Core.Helpers;
using Xalise.Interop.InteropHL7.Exceptions;
using Xalise.Interop.InteropHL7.Structure.DataType.Primitive;

namespace Xalise.Interop.InteropHL7.Helpers
{
    /// <summary>
    /// Fonctions pour manipuler les numériques, notamment le type de données <seealso cref="NM"/>.
    /// </summary>
    public static class NumberHelperHL7
    {
        /// <summary>
        /// Nettoie et vérifie la valeur d'un type de données <see cref="NM"/>.
        /// </summary>
        /// <remarks>
        ///  - Les espaces sont retirés.<br/>
        ///  - Si un signe arithmétique est présent en début, la longueur de <paramref name="value"/> doit être supérieure à 1 caractère.<br/>
        ///  - Vérification du format de la chaîne nettoyée.
        /// </remarks>
        /// <param name="value">Valeur à nettoyer et vérifier.</param>
        /// <returns>Valeur nettoyée et vérifiée.</returns>
        /// <exception cref="DataTypeException">Si la chaîne nettoyée ne respecte pas le format où si elle contient uniquement le signe arithmétique.</exception>
        public static string SanitizeAndCheckNM(string value)
        {
            string ret = value;

            if (!ret.IsNullOrWhiteSpace())
            {
                ret = ret.Trim().Replace(" ", "");

                if ((ret.StartsWith(NumberHelper.CSTS_DEFAULT_POSITIVE_SIGN) || ret.StartsWith(NumberHelper.CSTS_DEFAULT_NEGATIVE_SIGN)) && ret.Length == 1)
                {
                    throw new DataTypeException($"La valeur est composée uniquement du signe arithmétique.");
                }

                Regex regexChars = new Regex("^((\\+|\\-)?[0-9]+)(\\.[0-9]+)?$");
                if (!regexChars.IsMatch(ret))
                {
                    throw new DataTypeException($"La valeur '{ret}' ne respecte pas les conditions de validité du type de données '{TypeHelper.GetTypeName(typeof(NM))}'.");
                }
            }

            return ret;
        }
    }
}
