namespace Xalise.Interop.InteropHL7.Core
{
    /// <summary>
    /// Déclaration des comportements communs à l'ensemble des types de données.
    /// </summary>
    public interface IType
    {
        /// <summary>
        /// Description de la donnée.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Longueur maximale autorisée de la donnée.
        /// </summary>
        /// <remarks>
        /// Si la longueur est inférieure ou égale à 0, la valeur de <see cref="int.MaxValue"/> est utilisée.
        /// </remarks>
        int MaxLength { get; }

        /// <summary>
        /// Indique si la donnée est obligatoire.
        /// </summary>
        bool IsRequired { get; }

        /// <summary>
        /// Nom du type de la donnée.
        /// </summary>
        string TypeName { get; }
    }
}
