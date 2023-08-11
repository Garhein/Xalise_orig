namespace Xalise.Core.Extensions
{
    /// <summary>
    /// Méthodes d'extension applicables aux <see cref="string"/>.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Retire l'ensemble des derniers caractères d'une chaîne si ceux-ci correspondent
        /// au caractère indiqué en paramètre.
        /// </summary>
        /// <param name="src">Chaîne d'origine.</param>
        /// <param name="charToRemove">Caractère à retirer.</param>
        /// <returns>Chaîne nettoyée des caractères.</returns>
        public static string RemoveCharsFromEnd(this string src, char charToRemove)
        {
            if (string.IsNullOrWhiteSpace(src))
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
        /// <param name="src">Chaîne à vérifier.</param>
        /// <returns>True si la chaîne ne contient pas de caractère en doublon, sinon False.</returns>
        /// <exception cref="ArgumentException">Si <paramref name="src"/> est NULL ou composé uniquement d'espaces.</exception>
        public static bool ContainsUniqueChars(this string src)
        {
            if (string.IsNullOrWhiteSpace(src))
            {
                throw new ArgumentException("La chaîne à vérifier ne peut pas être NULL ou composée uniquement d'espaces.", nameof(src));
            }

            char[] chars = src.ToCharArray();
            char[] distincts = chars.Distinct().ToArray();

            return chars.Length == distincts.Length;
        }
    }
}
