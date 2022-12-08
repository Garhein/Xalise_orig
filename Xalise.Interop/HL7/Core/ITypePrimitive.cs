namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Définition des comportements communs aux types de données primitifs.
    /// </summary>
    public interface ITypePrimitive
    {
        /// <summary>
        /// Affecte et récupère la valeur du type de données.
        /// </summary>
        string Value { get; set; }

        /// <summary>
        /// Affecte et récupère la valeur de la table HL7 associée au type de données.
        /// </summary>
        AbstractTable ValueTable { get; set; }
    }
}
