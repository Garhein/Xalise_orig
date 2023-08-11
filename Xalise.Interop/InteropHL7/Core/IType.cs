namespace Xalise.Interop.InteropHL7.Core
{
    /// <summary>
    /// Déclaration des comportements communs à l'ensemble des types de données.
    /// </summary>
    public interface IType
    {
        /// <summary>
        /// Description de la donnée représentée par le type.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Longueur maximale autorisée de la donnée représentée par le type.
        /// Si longueur égale à 0, la valeur de <see cref="int.MaxValue"/> est utilisée.
        /// </summary>
        int MaxLength { get; }

        /// <summary>
        /// Indique si la donnée représentée par le type est obligatoire.
        /// </summary>
        bool IsRequired { get; }

        /// <summary>
        /// Nom du type de la donnée.
        /// </summary>
        string TypeName { get; }
    }
}
