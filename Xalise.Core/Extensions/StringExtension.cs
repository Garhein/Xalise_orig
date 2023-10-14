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
        /// <param name="src">Chaîne à tester.</param>
        /// <returns><see langword="true"/> si la chaîne est <see langword="null"/> ou vide (<c>""</c>) ; sinon <see langword="false"/>.</returns>
        public static bool IsNullOrEmpty(this string src)
        {
            return string.IsNullOrEmpty(src);
        }

        /// <summary>
        /// Indique si la chaîne n'est pas <see langword="null"/> ou vide (<c>""</c>).
        /// </summary>
        /// <param name="src">Chaîne à tester.</param>
        /// <returns><see langword="true"/> si la chaîne n'est pas <see langword="null"/> ou vide (<c>""</c>) ; sinon <see langword="false"/>.</returns>
        public static bool IsNotNullOrEmpty(this string src)
        {
            return !string.IsNullOrEmpty(src);
        }

        /// <summary>
        /// Indique si la chaîne est <see langword="null"/>, vide (<c>""</c>) ou composée uniquement d'espaces.
        /// </summary>
        /// <param name="src">Chaîne à tester.</param>
        /// <returns><see langword="true"/> si la chaîne est <see langword="null"/>, vide (<c>""</c>) ou composée uniquement d'espaces ; sinon <see langword="false"/>.</returns>
        public static bool IsNullOrWhiteSpace(this string src)
        {
            return string.IsNullOrWhiteSpace(src);
        }

        /// <summary>
        /// Indique si la chaîne n'est pas <see langword="null"/>, vide (<c>""</c>) ou composée uniquement d'espaces.
        /// </summary>
        /// <param name="src">Chaîne à tester.</param>
        /// <returns><see langword="true"/> si la chaîne n'est pas <see langword="null"/>, vide (<c>""</c>) ou composée uniquement d'espaces ; sinon <see langword="false"/>.</returns>
        public static bool IsNotNullOrWhiteSpace(this string src)
        {
            return !string.IsNullOrWhiteSpace(src);
        }

        /// <summary>
        /// Retire l'ensemble des premiers ou derniers caractères d'une chaîne si ceux-ci correspondent à <paramref name="charToRemove"/>.
        /// </summary>
        /// <remarks>
        /// <paramref name="src"/> est renvoyée si elle est <seealso cref="StringExtension.IsNullOrEmpty(string)"/>.
        /// </remarks>
        /// <param name="src">Chaîne à nettoyer.</param>
        /// <param name="charToRemove">Caractère à retirer.</param>
        /// <param name="fromStart"><see langword="true"/> si le nettoyage doit être réalisé sur le début de la chaîne, sinon <see langword="false"/>.</param>
        /// <returns>La chaîne nettoyée si elle n'est pas <seealso cref="StringExtension.IsNullOrEmpty(string)"/> ; sinon <paramref name="src"/> sans modification.</returns>
        private static string RemoveRepeatingChars(this string src, char charToRemove, bool fromStart)
        {
            if (src.IsNullOrEmpty())
            {
                return src;
            }
            else
            {
                char[] chars    = src.ToCharArray();
                int pos         = 0;
                bool found      = false;
                string retVal   = src;

                // Depuis le début : recherche du 1er caractère qui ne correspond pas au caractère à retirer
                if (fromStart)
                {
                    while (pos < chars.Length - 1 && !found)
                    {
                        if (chars[pos] != charToRemove)
                        {
                            found = true;
                        }
                        else
                        {
                            pos++;
                        }
                    }

                    if (found)
                    {
                        retVal = src.Remove(0, pos);
                    }
                }
                // Depuis la fin : recherche du 1er caractère qui ne correspond pas au caractère à retirer
                else
                {
                    pos = chars.Length - 1;

                    while (pos >= 0 && !found)
                    {
                        if (chars[pos] != charToRemove)
                        {
                            found = true;
                        }
                        else
                        {
                            pos--;
                        }
                    }

                    if (found)
                    {
                        retVal = src.Remove(pos + 1);
                    }
                }

                return retVal;
            }
        }

        /// <summary>
        /// Retire l'ensemble des premiers caractères d'une chaîne si ceux-ci correspondent à <paramref name="charToRemove"/>.
        /// </summary>
        /// <remarks>
        /// <paramref name="src"/> est renvoyée si elle est <seealso cref="StringExtension.IsNullOrWhiteSpace(string)"/>.
        /// </remarks>
        /// <param name="src">Chaîne à nettoyer.</param>
        /// <param name="charToRemove">Caractère à retirer.</param>
        /// <returns>La chaîne nettoyée si elle n'est pas <seealso cref="StringExtension.IsNullOrWhiteSpace(string)"/> ; sinon <paramref name="src"/> sans modification.</returns>
        public static string RemoveRepeatingCharsFromStart(this string src, char charToRemove)
        {
            return src.RemoveRepeatingChars(charToRemove, true);
        }

        /// <summary>
        /// Retire l'ensemble des derniers caractères d'une chaîne si ceux-ci correspondent à <paramref name="charToRemove"/>.
        /// </summary>
        /// <remarks>
        /// <paramref name="src"/> est renvoyée si elle est <seealso cref="StringExtension.IsNullOrWhiteSpace(string)"/>.
        /// </remarks>
        /// <param name="src">Chaîne à nettoyer.</param>
        /// <param name="charToRemove">Caractère à retirer.</param>
        /// <returns>La chaîne nettoyée si elle n'est pas <seealso cref="StringExtension.IsNullOrWhiteSpace(string)"/> ; sinon <paramref name="src"/> sans modification.</returns>
        public static string RemoveRepeatingCharsFromEnd(this string src, char charToRemove)
        {
            return src.RemoveRepeatingChars(charToRemove, false);
        }

        /// <summary>
        /// Vérifie si les caractères présents dans <paramref name="src"/> sont uniques.
        /// </summary>
        /// <param name="src">Chaîne à vérifier</param>
        /// <returns><see langword="true"/> si les caractères de <paramref name="src"/> sont uniques ; sinon <see langword="false"/>.</returns>
        /// <exception cref="ArgumentException">Si <paramref name="src"/> est NULL, vide ou composé uniquement d'espaces.</exception>
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
