﻿using System;
using Xalise.Interop.InteropHL7.Core;

namespace Xalise.Interop.InteropHL7.Structure.DataType.Primitive
{
    /// <summary>
    /// ID - Coded values for HL7 tables.
    /// </summary>
    [Serializable]
    public class ID : AbstractTypePrimitive
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée de la donnée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>
        public ID(string description, int maxLength, bool required) : base(description, maxLength, required) { }
    }
}
