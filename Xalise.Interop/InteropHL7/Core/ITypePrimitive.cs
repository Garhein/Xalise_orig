namespace Xalise.Interop.InteropHL7.Core
{
    /// <summary>
    /// Déclaration des comportements communs à l'ensemble des types de données primitives.
    /// </summary>
    public interface ITypePrimitive
    {
        /// <summary>
        /// Accès, en lecture et écriture, à la valeur du type de données.
        /// </summary>
        string Value { get; set; }
    }
}
