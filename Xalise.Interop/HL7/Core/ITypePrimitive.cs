namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Déclaration des comportements communs aux types de données primitifs.
    /// </summary>
    public interface ITypePrimitive
    {
        /// <summary>
        /// Affecte et récupère la valeur du type de données.
        /// </summary>
        string Value { get; set; }
    }
}
