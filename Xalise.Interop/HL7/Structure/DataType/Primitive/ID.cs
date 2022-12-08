using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.DataType.Primitive
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
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>
        public ID(string description, int maxLength, bool required) : this(description, maxLength, required, null) { }

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>
        /// <param name="typeTable">Type de la table HL7 autorisée.</param>
        public ID(string description, int maxLength, bool required, Type typeTable) : base(description, maxLength, required, typeTable) { }
    }
}
