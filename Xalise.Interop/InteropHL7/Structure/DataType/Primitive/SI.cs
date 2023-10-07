using System;
using Xalise.Interop.InteropHL7.Core;

namespace Xalise.Interop.InteropHL7.Structure.DataType.Primitive
{
    /// <summary>
    /// SI - Sequence ID.
    /// </summary>
    /// <remarks>
    /// Entier non négatif de la forme d'un champ <see cref="NM"/>.
    /// </remarks>
    [Serializable]
    public class SI : AbstractTypePrimitive
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée de la donnée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>
        public SI(string description, int maxLength, bool required) : base(description, maxLength, required) { }
    }
}
