namespace Xalise.Core.Attributes
{
    /// <summary>
    /// Attribut permettant de définir la valeur d'usage d'un <see cref="AttributeTargets.Field"/>.
    /// </summary>
    /// <remarks>
    /// Attribut utilisé par exemple pour définir la valeur d'usage des membres d'une <see cref="Enum"/>.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field)]
    public class UsageValueAttribute : Attribute
    {
        private string _value;

        /// <summary>
        /// Valeur d'usage.
        /// </summary>
        public string Value
        {
            get
            {
                return this._value;
            }
        }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur d'usage à affecter.</param>
        public UsageValueAttribute(string value)
        {
            this._value = value;
        }
    }
}
