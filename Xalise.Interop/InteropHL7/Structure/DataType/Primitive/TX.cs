using System;
using Xalise.Interop.InteropHL7.Core;

namespace Xalise.Interop.InteropHL7.Structure.DataType.Primitive
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
        /// <param name="maxLength">Longueur maximale autorisée de la donnée .</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>
        public TX(string description, int maxLength, bool required) : base(description, maxLength, required) { }
    }
}
