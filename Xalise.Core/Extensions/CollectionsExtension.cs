namespace Xalise.Core.Extensions
{
    /// <summary>
    /// Extensions applicables aux <see cref="IEnumerable{T}"/> et <see cref="IDictionary{TKey, TValue}"/>.
    /// </summary>
    public static class CollectionsExtension
    {
        /// <summary>
        /// Vérifie si la collection est vide.
        /// </summary>
        /// <remarks>
        /// La collection est vide si elle est <see langword="null"/> ou ne contient aucune valeur.
        /// </remarks>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns><see langword="true"/> si la collection est vide, sinon <see langword="false"/>.</returns>
        public static bool IsEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }

        /// <summary>
        /// Vérifie si la collection n'est pas vide.
        /// </summary>
        /// <remarks>
        /// La collection n'est pas vide si elle n'est pas <see langword="null"/> et contient au moins une valeur.
        /// </remarks>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns><see langword="true"/> si la collection n'est pas vide, sinon <see langword="false"/>.</returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> source)
        {
            return !IsEmpty(source);
        }

        /// <summary>
        /// Vérifie si la collection contient une valeur.
        /// </summary>
        /// <remarks>
        /// La collection et <paramref name="value"/> ne doivent pas être <see langword="null"/>, et la collection doit contenir au moins une valeur.
        /// </remarks>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="liste"></param>
        /// <param name="value">Valeur recherchée.</param>
        /// <returns><see langword="true"/> si la collection contient <paramref name="value"/>, sinon <see langword="false"/>.</returns>
        public static bool ExistAndContainsValue<TValue>(this IEnumerable<TValue> liste, TValue value)
        {
            return liste.IsNotEmpty() && value != null && liste.Contains(value);
        }

        /// <summary>
        /// Vérifie si le dictionnaire contient une clé. 
        /// </summary>*
        /// <remarks>
        /// Le dictionnaire et <paramref name="key"/> ne doivent pas être <see langword="null"/>, et le dictionnaire doit contenir au moins une valeur.
        /// </remarks>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key">Clé recherchée.</param>
        /// <returns><see langword="true"/> si le dictionnaire contient <paramref name="key"/>, sinon <see langword="false"/>.</returns>
        public static bool ExistAndContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            return dictionary.IsNotEmpty() && key != null && dictionary.ContainsKey(key);
        }
    }
}
