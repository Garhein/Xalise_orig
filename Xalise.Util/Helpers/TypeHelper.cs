using System;

namespace Xalise.Util.Helpers
{
    /// <summary>
    /// Fonctions utilitaires pour manipuler les types de données.
    /// </summary>
    public static class TypeHelper
    {
        /// <summary>
        /// Récupère le nom du type d'une instance d'un objet.        
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetTypeName(Object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            return TypeHelper.GetTypeName(obj.GetType());
        }

        /// <summary>
        /// Récupère le nom d'un type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetTypeName(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            string className = type.FullName;
            return className.Substring(className.LastIndexOf('.') + 1);
        }
    }
}