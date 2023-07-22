namespace Xalise.Core.Attributes
{
    /// <summary>
    /// Attribut personnalisé permettant de définir la/les classes d'un élément.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class CssClassNameAttribute : Attribute
    {
        private string _className;

        public string ClassName
        {
            get
            {
                return this._className;
            }
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="className">La ou les classes CSS de l'élément.</param>
        public CssClassNameAttribute(string className)
        {
            this._className = className;
        }
    }
}
