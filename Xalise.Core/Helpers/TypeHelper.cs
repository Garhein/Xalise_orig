namespace Xalise.Core.Helpers
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
            ArgumentHelper.ThrowIfNull(obj, nameof(obj));

            return TypeHelper.GetTypeName(obj.GetType());
        }

        /// <summary>
        /// Récupère le nom d'un type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetTypeName(Type type)
        {
            ArgumentHelper.ThrowIfNull(type, nameof(type));

            string className = type.FullName;
            return className.Substring(className.LastIndexOf('.') + 1);
        }
    }
}
