namespace Xalise.Core.Attributes
{
    /// <summary>
    /// Attribut personnalisé permettant de définir la valeur d'usage d'une énumération.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumUsageValueAttribute : Attribute
    {
        private string _value;

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
        /// <param name="value">Valeur affecter à l'énumération.</param>
        public EnumUsageValueAttribute(string value)
        {
            this._value = value;
        }
    }
}
