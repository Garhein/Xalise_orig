namespace Xalise.Core.Helpers
{
    /// <summary>
    /// Fonctions utiles pour manipuler les énumérations.
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Vérifie la validité d'une valeur d'énumération.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="valeurEnum">Valeur à vérifier.</param>
        /// <param name="nomParametre">Nom du paramètre.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool VerifierValidite<TEnum>(short valeurEnum, string nomParametre) where TEnum : Enum
        {
            if (valeurEnum <= 0)
            {
                throw new ArgumentException("La valeur de l'énumération ne peut pas être inférieur ou égal à 0.", nomParametre);
            }
            else if (!Enum.IsDefined(typeof(TEnum), valeurEnum))
            {
                throw new ArgumentException("La valeur de l'énumération n'est pas valide.", nomParametre);
            }

            return true;
        }

        /// <summary>
        /// Vérifie la valeur d'une valeur d'énumération.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="valeurEnum">Valeur à vérifier.</param>
        /// <param name="nomParametre">Nom du paramètre.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool VerifierValidite<TEnum>(TEnum valeurEnum, string nomParametre) where TEnum : Enum
        {
            if (!Enum.IsDefined(typeof(TEnum), valeurEnum))
            {
                throw new ArgumentException("La valeur de l'énumération n'est pas valide.", nomParametre);
            }

            return true;
        }
    }
}
