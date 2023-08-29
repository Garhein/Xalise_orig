using Xalise.Core.Extensions;

namespace Xalise.Core.Helpers
{
    /// <summary>
    /// Fonctions utilitaires pour manipuler les arguments.
    /// </summary>
    public static class ArgumentHelper
    {
        #region NULL/Empty

        /// <summary>
        /// Vérifie si <paramref name="value"/> est <seealso langword="null"/>.
        /// </summary>
        /// <param name="value">Valeur du paramètre.</param>
        /// <param name="parameterName">Nom du paramètre.</param>
        /// <exception cref="ArgumentNullException">Si <paramref name="value"/> est <seealso langword="null"/>.</exception>
        public static void ThrowIfNull(object value, string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }

        /// <summary>
        /// Vérifie si <paramref name="value"/> est <seealso langword="null"/>.
        /// </summary>
        /// <param name="value">Valeur du paramètre.</param>
        /// <param name="parameterName">Nom du paramètre.</param>
        /// <exception cref="ArgumentNullException">Si <paramref name="value"/> est <seealso langword="null"/>.</exception>
        /// <exception cref="ArgumentException">Si <paramref name="value"/> est vide.</exception>
        public static void ThrowIfNullOrEmpty(string value, string parameterName)
        {
            ArgumentHelper.ThrowIfNull(value, parameterName);

            if (value.IsNullOrEmpty())
            {
                throw new ArgumentException($"Le paramètre '{parameterName}' ne peut pas être une chaîne vide.");
            }
        }

        /// <summary>
        /// Vérifie si le paramètre est NULL, vide ou composé uniquement d'espaces.
        /// </summary>
        /// <param name="value">Valeur du paramètre.</param>
        /// <param name="parameterName">Nom du paramètre.</param>
        /// <exception cref="ArgumentNullException">Si <paramref name="value"/> est <seealso langword="null"/>.</exception>
        /// <exception cref="ArgumentException">Si <paramref name="value"/> est vide ou composé uniquement d'espaces.</exception>
        public static void ThrowIfNullOrWhiteSpace(string value, string parameterName)
        {
            ArgumentHelper.ThrowIfNull(value, parameterName);

            if (value.IsNullOrWhiteSpace())
            {
                throw new ArgumentException($"Le paramètre '{parameterName}' ne pas être composé uniquement d'espaces.");
            }
        }

        #endregion

        #region Répertoires et fichiers

        /// <summary>
        /// Vérifie si le répertoire <paramref name="directory"/> n'existe pas.
        /// </summary>
        /// <param name="directory">Chemin du répertoire.</param>
        /// <exception cref="ArgumentNullException">Si <paramref name="directory"/> est <seealso langword="null"/>.</exception>
        /// <exception cref="ArgumentException">Si <paramref name="directory"/> est vide ou composé uniquement d'espaces.</exception>
        /// <exception cref="DirectoryNotFoundException">Si le répertoire <paramref name="directory"/> n'existe pas.</exception>
        public static void ThrowIfDirectoryNotFound(string directory)
        {
            ArgumentHelper.ThrowIfNullOrWhiteSpace(directory, nameof(directory));

            if (!Directory.Exists(directory))
            {
                throw new DirectoryNotFoundException($"Le répertoire <{directory}> n'a pas été trouvé.");
            }
        }

        /// <summary>
        /// Vérifier si le fichier <paramref name="filePath"/> n'existe pas.
        /// </summary>
        /// <param name="filePath">Chemin du fichier.</param>
        /// <exception cref="ArgumentNullException">Si <paramref name="filePath"/> est <seealso langword="null"/>.</exception>
        /// <exception cref="ArgumentException">Si <paramref name="filePath"/> est vide ou composé uniquement d'espaces.</exception>
        /// <exception cref="FileNotFoundException">Si le fichier <paramref name="filePath"/> n'existe pas.</exception>
        public static void ThrowIfFileNotFound(string filePath)
        {
            ArgumentHelper.ThrowIfNullOrWhiteSpace(filePath, nameof(filePath));

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Le fichier <{filePath}> n'a pas été trouvé.");
            }
        }

        #endregion
    }
}
