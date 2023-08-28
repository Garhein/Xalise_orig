namespace Xalise.Core.Helpers
{
    /// <summary>
    /// Fonctions utilitaires pour manipuler les <see cref="Enum"/>.
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Vérifie la validité d'une valeur d'énumération pour un <see cref="int"/>.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="valeurEnum">Valeur à vérifier.</param>
        /// <param name="nomParametre">Nom du paramètre.</param>
        /// <returns><see langword="true"/> si <paramref name="valeurEnum"/> appartient à l'énumération <typeparamref name="TEnum"/>, sinon <see langword="false"/>.</returns>
        /// <exception cref="ArgumentException">Si <paramref name="valeurEnum"/> est inférieur ou égal à zéro.</exception>
        public static bool VerifierValidite<TEnum>(int valeurEnum, string nomParametre) where TEnum : Enum
        {
            if (valeurEnum <= 0)
            {
                throw new ArgumentException("La valeur de l'énumération ne peut pas être inférieur ou égal à 0.", nomParametre);
            }
            else if (!Enum.IsDefined(typeof(TEnum), valeurEnum))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Vérifie la validité d'une valeur d'énumération pour un <see cref="short"/>.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="valeurEnum">Valeur à vérifier.</param>
        /// <param name="nomParametre">Nom du paramètre.</param>
        /// <returns><see langword="true"/> si <paramref name="valeurEnum"/> appartient à l'énumération <typeparamref name="TEnum"/>, sinon <see langword="false"/>.</returns>
        /// <exception cref="ArgumentException">Si <paramref name="valeurEnum"/> est inférieur ou égal à zéro.</exception>
        public static bool VerifierValidite<TEnum>(short valeurEnum, string nomParametre) where TEnum : Enum
        {
            if (valeurEnum <= 0)
            {
                throw new ArgumentException("La valeur de l'énumération ne peut pas être inférieur ou égal à 0.", nomParametre);
            }
            else if (!Enum.IsDefined(typeof(TEnum), valeurEnum))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Vérifie la valeur d'une valeur d'énumération.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="valeurEnum">Valeur à vérifier.</param>
        /// <returns><see langword="true"/> si <paramref name="valeurEnum"/> appartient à l'énumération <typeparamref name="TEnum"/>, sinon <see langword="false"/>.</returns>
        public static bool VerifierValidite<TEnum>(TEnum valeurEnum) where TEnum : Enum
        {
            return Enum.IsDefined(typeof(TEnum), valeurEnum);
        }
    }
}
