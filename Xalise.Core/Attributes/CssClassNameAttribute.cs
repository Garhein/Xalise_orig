namespace Xalise.Core.Attributes
{
    /// <summary>
    /// Attribut permettant de définir la ou les classe(s) CSS applicable(s) à un <see cref="AttributeTargets.Field"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class CssClassNameAttribute : Attribute
    {
        private string _className;

        /// <summary>
        /// Classe(s) CSS applicable(s).
        /// </summary>
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
        /// <param name="className">La ou les classes CSS applicable(s).</param>
        public CssClassNameAttribute(string className)
        {
            this._className = className;
        }
    }
}
