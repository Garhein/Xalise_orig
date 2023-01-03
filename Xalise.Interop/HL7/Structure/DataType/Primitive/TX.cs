﻿using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.DataType.Primitive
{
    /// <summary>
    /// TX - Text Data.
    /// </summary>
    [Serializable]
    public class TX : AbstractTypePrimitive
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>
        public TX(string description, int maxLength, bool required) : base(description, maxLength, required) { }
    }
}
