using System;
using System.Collections.Generic;
using System.Linq;

namespace Xalise.Util.Extensions
{
    /// <summary>
    /// Extensions applicables aux <see cref="IEnumerable{T}"/> et <see cref="IDictionary{TKey, TValue}"/>.
    /// </summary>
    public static class IEnumerableExtension
    {
        /// <summary>
        /// Vérifie si <paramref name="source"/> est NULL ou ne contient aucune valeur.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }

        /// <summary>
        /// Vérifie si <paramref name="source"/> n'est pas NULL et contient au moins une valeur.
        /// Retourne l'inverse de <see cref="IsEmpty{T}(IEnumerable{T})"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsNotEmpty<T>(this IEnumerable<T> source)
        {
            return !IsEmpty(source);
        }

        /// <summary>
        /// Vérifie si <paramref name="dictionary"/> existe, si le dictionnaire contient des valeurs et si la clé existe.        
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool ExistAndContainsKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            return dictionary.IsNotEmpty() && key != null && dictionary.ContainsKey(key);
        }

        /// <summary>
        /// Vérifie si <paramref name="liste"/> existe, si la liste contient des valeurs et si la valeur existe.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="liste"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ExistAndContainsValue<TValue>(this IEnumerable<TValue> liste, TValue value)
        {
            return liste.IsNotEmpty() && value != null && liste.Contains(value);
        }
    }
}