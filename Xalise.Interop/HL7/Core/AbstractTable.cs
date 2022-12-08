using System;

namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Représente une table de données HL7.
    /// </summary>
    [Serializable]
    public abstract class AbstractTable
    {
        private string _value;
        private string _description;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public AbstractTable(string value, string description)
        {
            this._value         = value;
            this._description   = description;
        }

        /// <summary>
        /// Valeur de la table.
        /// </summary>
        public string Value
        {
            get
            {
                return this._value;
            }
        }

        /// <summary>
        /// Description de la donnée.
        /// </summary>
        public string Description
        {
            get
            {
                return this._description;
            }
        }
    
        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public abstract string TableNumber { get; }
    }
}
