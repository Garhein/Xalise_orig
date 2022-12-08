using System;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Util.Helpers;

namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Représente un type de données primitif, c'est-à-dire composé d'une seule valeur.
    /// </summary>
    [Serializable]
    public abstract class AbstractTypePrimitive : AbstractType, ITypePrimitive
    {
        private string          _value;
        private Type            _typeTable;
        private AbstractTable   _valueTable;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>
        public AbstractTypePrimitive(string description, int maxLength, bool required) : this(description, maxLength, required, null) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>
        /// <param name="typeTable">Type de la table HL7 autorisée.</param>
        public AbstractTypePrimitive(string description, int maxLength, bool required, Type typeTable) : base(description, maxLength, required)
        {
            this._typeTable = typeTable;
        }

        #region Implémentations

        /// <summary>
        /// Affecte et récupère la valeur du type de données.
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

        /// <summary>
        /// Affecte et récupère la valeur de la table HL7 associée au type de données.
        /// </summary>
        /// <exception cref="DataTypeException">Si la table HL7 ne correspond pas à celle attendue.</exception>
        public AbstractTable ValueTable 
        { 
            get
            {
                return this._valueTable;
            }
            set
            {
                if (value != null && !(this._typeTable.IsInstanceOfType(value) || value.GetType().IsSubclassOf(typeof(AbstractTable))))
                {
                    throw new DataTypeException($"Le type '{this.TypeName}' attend une valeur de la table '{TypeHelper.GetTypeName(this._typeTable)}' (table utilisée : '{TypeHelper.GetTypeName(value)}').");
                }

                this._valueTable = value;
                this._value      = value != null ? value.Value : string.Empty;
            }
        }

        #endregion
    }
}
