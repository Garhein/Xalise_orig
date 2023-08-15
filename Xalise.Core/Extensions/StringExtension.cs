namespace Xalise.Core.Extensions
{
    /// <summary>
    /// Méthodes d'extension applicables aux <see cref="string"/>.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Indique si la chaîne est <see langword="null"/> ou vide (<c>""</c>).
        /// </summary>
        /// <param name="src"></param>
        /// <returns><see langword="true"/> si la chaîne est <see langword="null"/> ou vide (<c>""</c>), sinon <see langword="false"/>.</returns>
        public static bool IsNullOrEmpty(this string src)
        {
            return string.IsNullOrEmpty(src);
        }

        /// <summary>
        /// Indique si la chaîne est <see langword="null"/>, vide (<c>""</c>) ou composée uniquement d'espaces.
        /// </summary>
        /// <param name="src"></param>
        /// <returns><see langword="true"/> si la chaîne est <see langword="null"/>, vide (<c>""</c>) ou composée uniquement d'espaces ; sinon <see langword="false"/>.</returns>
        public static bool IsNullOrWhiteSpace(this string src)
        {
            return string.IsNullOrWhiteSpace(src);
        }

        /// <summary>
        /// Retire l'ensemble des derniers caractères d'une chaîne si ceux-ci correspondent à <paramref name="charToRemove"/>.
        /// </summary>
        /// <remarks>
        /// La chaîne d'origine est renvoyée si elle est <seealso cref="StringExtension.IsNullOrWhiteSpace(string)"/>.
        /// </remarks>
        /// <param name="src">Chaîne d'origine.</param>
        /// <param name="charToRemove">Caractère à retirer.</param>
        /// <returns>La chaîne nettoyée si elle n'est pas <seealso cref="IsNullOrWhiteSpace(string)"/>, sinon la chaîne sans modification. </returns>
        public static string RemoveRepeatingCharsFromEnd(this string src, char charToRemove)
        {
            if (src.IsNullOrWhiteSpace())
            {
                return src;
            }
            else
            {
                char[] chars = src.ToCharArray();

                // Recherche depuis la fin du 1er caractère qui ne correspond pas au caractère à retirer
                int length = chars.Length - 1;
                bool found = false;

                while (length >= 0 && !found)
                {
                    if (chars[length] != charToRemove)
                    {
                        found = true;
                    }
                    else
                    {
                        length--;
                    }
                }

                string retVal = src;

                if (found)
                {
                    retVal = src.Remove(length + 1);
                }

                return retVal;
            }
        }

        /// <summary>
        /// Vérifie si les caractères présents dans la chaîne sont uniques.
        /// </summary>
        /// <remarks>
        /// Une exception <see cref="ArgumentException"/> est levée si <paramref name="src"/> est NULL, vide ou composé uniquement d'espaces.
        /// </remarks>
        /// <param name="src"></param>
        /// <returns><see langword="true"/> si les caractères  de <paramref name="src"/> sont uniques, sinon <see langword="false"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool ContainsUniqueChars(this string src)
        {
            if (src.IsNullOrWhiteSpace())
            {
                throw new ArgumentException("La chaîne à vérifier est NULL, vide ou composée uniquement d'espaces.", nameof(src));
            }

            char[] chars = src.ToCharArray();
            char[] distincts = chars.Distinct().ToArray();

            return chars.Length == distincts.Length;
        }
    }
}
