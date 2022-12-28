namespace Xalise.Util.Extensions
{
    /// <summary>
    /// Méthodes d'extension applicables aux <see cref="string"/>.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Retire l'ensemble des derniers caractères d'une chaîne si ceux correspondent
        /// au caractère indiqué en paramètre.
        /// </summary>
        /// <param name="src">Chaîne d'origine.</param>
        /// <param name="delimiter">Caractère délimiteur à retirer.</param>
        /// <returns>Chaîne nettoyée des délimiteurs.</returns>
        public static string RemoveExtraDelimiters(this string src, char delimiter)
        {
            char[] chars = src.ToCharArray();

            // Recherche depuis la fin du 1er caractère qui ne correspond pas au délimiteur
            int length = chars.Length - 1;
            bool found = false;

            while (length >= 0 && !found)
            {
                if (chars[length] != delimiter)
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
}
