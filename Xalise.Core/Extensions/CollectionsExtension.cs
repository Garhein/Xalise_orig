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
        /// La collection est vide si elle est <c>null</c> ou ne contient aucune valeur.
        /// </remarks>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns><c>true</c> si la collection est vide, sinon <c>false</c>.</returns>
        public static bool IsEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }

        /// <summary>
        /// Vérifie si la collection n'est pas vide.
        /// </summary>
        /// <remarks>
        /// La collection n'est pas vide si elle n'est pas <c>null</c> et contient au moins une valeur.
        /// </remarks>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns><c>true</c> si la collection n'est pas vide, sinon <c>false</c>.</returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> source)
        {
            return !IsEmpty(source);
        }

        /// <summary>
        /// Vérifie si la collection contient une valeur.
        /// </summary>
        /// <remarks>
        /// La collection et la valeur recherchée ne doivent pas être <c>null</c>, et la collection doit contenir au moins une valeur.
        /// </remarks>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="liste"></param>
        /// <param name="value">Valeur recherchée.</param>
        /// <returns><c>true</c> si la collection contient la valeur, sinon <c>false</c>.</returns>
        public static bool ExistAndContainsValue<TValue>(this IEnumerable<TValue> liste, TValue value)
        {
            return liste.IsNotEmpty() && value != null && liste.Contains(value);
        }

        /// <summary>
        /// Vérifie si le dictionnaire contient une clé. 
        /// </summary>*
        /// <remarks>
        /// Le dictionnaire et la clé recherchée ne doivent pas être <c>null</c>, et le dictionnaire doit contenir au moins une valeur.
        /// </remarks>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key">Clé recherchée.</param>
        /// <returns><c>true</c> si le dictionnaire contient la clé, sinon <c>false</c>.</returns>
        public static bool ExistAndContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            return dictionary.IsNotEmpty() && key != null && dictionary.ContainsKey(key);
        }
    }
}
