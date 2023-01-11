using System;

namespace Xalise.Util.Helpers
{
    /// <summary>
    /// Fonctions utilitaires pour manipuler les arguments.
    /// </summary>
    public static class ArgumentHelper
    {
        #region NULL/Empty

        /// <summary>
        /// Vérifie si le paramètre est NULL.
        /// </summary>
        /// <param name="value">Valeur du paramètre.</param>
        /// <param name="parameterName">Nom du paramètre.</param>
        /// <exception cref="ArgumentNullException">Le paramètre est NULL.</exception>
        public static void ThrowIfNull(object value, string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }

        /// <summary>
        /// Vérifie si le paramètre est NULL ou vide.
        /// </summary>
        /// <param name="value">Valeur du paramètre.</param>
        /// <param name="parameterName">Nom du paramètre.</param>
        /// <exception cref="ArgumentNullException">Le paramètre est NULL.</exception>
        /// <exception cref="ArgumentException">Le paramètre est vide.</exception>
        public static void ThrowIfNullOrEmpty(string value, string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName);
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"Le paramètre '{parameterName}' ne peut pas être une chaîne vide.");
            }
        }

        /// <summary>
        /// Vérifie si le paramètre est NULL, vide ou composé uniquement d'espaces.
        /// </summary>
        /// <param name="value">Valeur du paramètre.</param>
        /// <param name="parameterName">Nom du paramètre.</param>
        /// <exception cref="ArgumentNullException">Le paramètre est NULL.</exception>
        /// <exception cref="ArgumentException">Le paramètre est vide ou composé uniquement d'espaces.</exception>
        public static void ThrowIfNullOrWhiteSpace(string value, string parameterName)
        {
            ArgumentHelper.ThrowIfNull(value, parameterName);

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException($"Le paramètre '{parameterName}' ne pas être composé uniquement d'espaces.");
            }
        }

        #endregion
    }
}
