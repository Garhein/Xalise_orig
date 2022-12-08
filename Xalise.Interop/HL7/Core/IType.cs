namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Définition des comportements communs aux types de données.
    /// </summary>
    public interface IType
    {
        /// <summary>
        /// Nom du type de données.
        /// </summary>
        string TypeName { get; }
    }
}
