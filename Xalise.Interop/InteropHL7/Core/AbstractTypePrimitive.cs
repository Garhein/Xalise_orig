using System;

namespace Xalise.Interop.InteropHL7.Core
{
    /// <summary>
    /// Représentation d'un type de données primitives, c'est-à-dire composé d'une seule valeur.
    /// </summary>
    [Serializable]
    public abstract class AbstractTypePrimitive : AbstractType, ITypePrimitive
    {
        private string _value;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée représentée par le type.</param>
        /// <param name="maxLength">Longueur maximale autorisée de la donnée représentée par le type.</param>
        /// <param name="required">Indique si la donnée représentée par le type est obligatoire.</param>
        public AbstractTypePrimitive(string description, int maxLength, bool required) : base(description, maxLength, required) { }

        /// <summary>
        /// Accès, en lecture et écriture, à la valeur du type de données.
        /// </summary>
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}
