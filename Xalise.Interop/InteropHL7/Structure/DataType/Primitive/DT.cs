using System;
using Xalise.Interop.InteropHL7.Core;

namespace Xalise.Interop.InteropHL7.Structure.DataType.Primitive
{
    /// <summary>
    /// DT - Date.
    /// </summary>
    [Serializable]
    public class DT : AbstractTypePrimitive
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée représentée par le type.</param>
        /// <param name="maxLength">Longueur maximale autorisée pour la donnée représentée par le type.</param>
        /// <param name="required">Indique si la donnée représentée par le type est obligatoire.</param>
        public DT(string description, int maxLength, bool required) : base(description, maxLength, required) { }
    }
}
