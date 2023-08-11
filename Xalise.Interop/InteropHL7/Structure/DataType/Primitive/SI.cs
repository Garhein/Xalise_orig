using System;
using Xalise.Interop.InteropHL7.Core;

namespace Xalise.Interop.InteropHL7.Structure.DataType.Primitive
{
    /// <summary>
    /// SI - Sequence ID.
    /// Entier non négatif de la forme d'un champ <see cref="NM"/>.
    /// </summary>
    [Serializable]
    public class SI : AbstractTypePrimitive
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée représentée par le type.</param>
        /// <param name="maxLength">Longueur maximale autorisée de la donnée représentée par le type.</param>
        /// <param name="required">Indique si la donnée représentée par le type est obligatoire.</param>
        public SI(string description, int maxLength, bool required) : base(description, maxLength, required) { }
    }
}
