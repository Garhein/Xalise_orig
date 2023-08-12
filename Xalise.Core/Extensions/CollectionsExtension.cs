namespace Xalise.Core.Extensions
{
    /// <summary>
    /// Extensions applicables aux <see cref="IEnumerable{T}</T>"/> et <see cref="IDictionary{TKey, TValue}"/>.
    /// </summary>
    public static class CollectionsExtension
    {
        /// <summary>
        /// Vérifie si <paramref name="source"/> est NULL ou ne contient aucune valeur.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns>True si <paramref name="source"/> est NULL ou ne contient aucune valeur, sinon False.</returns>
        public static bool IsEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }

        /// <summary>
        /// Vérifie si <paramref name="source"/> n'est pas NULL et contient au moins une valeur.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns>True si <paramref name="source"/> n'est pas NULL et contient au moins une valeur, sinon False.</returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> source)
        {
            return !IsEmpty(source);
        }

        /// <summary>
        /// Vérifie si <paramref name="liste"/> existe, contient des valeurs et si la valeur existe.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="liste"></param>
        /// <param name="value">Valeur recherchée.</param>
        /// <returns>True si <paramref name="liste"/> n'est pas vide et que la valeur recherchée est présente, sinon False.</returns>
        public static bool ExistAndContainsValue<TValue>(this IEnumerable<TValue> liste, TValue value)
        {
            return liste.IsNotEmpty() && value != null && liste.Contains(value);
        }

        /// <summary>
        /// Vérifie si <paramref name="dictionary"/> existe, contient des valeurs et si la clé existe.        
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key">Clé recherchée.</param>
        /// <returns>True si <paramref name="dictionary"/> n'est pas vide et que la clé recherchée est présente, sinon False.</returns>
        public static bool ExistAndContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            return dictionary.IsNotEmpty() && key != null && dictionary.ContainsKey(key);
        }
    }
}
