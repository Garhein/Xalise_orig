﻿using System;
using Xalise.Core.Helpers;

namespace Xalise.Interop.InteropHL7.Core
{
    /// <summary>
    /// Représentation d'un type de donnée.
    /// </summary>
    [Serializable]
    public abstract class AbstractType : IType
    {
        private string  _description;
        private int     _maxLength;
        private bool    _required;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée représentée par le type.</param>
        /// <param name="maxLength">Longueur maximale autorisée de la donnée représentée par le type.</param>
        /// <param name="required">Indique si la donnée représentée par le type est obligatoire.</param>
        public AbstractType(string description, int maxLength, bool required)
        {
            this._description   = description;
            this._maxLength     = maxLength;
            this._required      = required;
        }

        /// <summary>
        /// Description de la donnée représentée par le type.
        /// </summary>
        public string Description
        {
            get
            {
                return this._description;
            }
        }

        /// <summary>
        /// Longueur maximale autorisée de la donnée représentée par le type.
        /// Si longueur égale à 0, la valeur de <see cref="int.MaxValue"/> est utilisée.
        /// </summary>
        public int MaxLength
        {
            get
            {
                return this._maxLength > 0 ? this._maxLength : int.MaxValue;
            }
        }

        /// <summary>
        /// Indique si la donnée représentée par le type est obligatoire.
        /// </summary>
        public bool IsRequired
        {
            get
            {
                return this._required;
            }
        }

        /// <summary>
        /// Nom du type de la donnée.
        /// </summary>
        public string TypeName
        {
            get
            {
                return TypeHelper.GetTypeName(this);
            }
        }
    }
}
