namespace Xalise.Core.Attributes
{
    /// <summary>
    /// Définition de la valeur d'usage d'un élément.
    /// </summary>
    /// <remarks>
    /// Applicable aux <see cref="AttributeTargets.Field"/>.<br/>
    /// Exemple d'utilisation : valeur d'usage des membres d'une <see cref="Enum"/> pour définir le format des données.
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
