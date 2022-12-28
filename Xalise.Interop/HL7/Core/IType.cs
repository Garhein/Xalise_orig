namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Déclaration des omportements communs aux types de données.
    /// </summary>
    public interface IType
    {
        /// <summary>
        /// Nom du type de données.
        /// </summary>
        string TypeName { get; }
    }
}
