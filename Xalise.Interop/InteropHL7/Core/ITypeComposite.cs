using Xalise.Interop.InteropHL7.Exceptions;

namespace Xalise.Interop.InteropHL7.Core
{
    /// <summary>
    /// Déclaration des comportements communs à l'ensemble des types de données composites.
    /// </summary>
    public interface ITypeComposite
    {
        /// <summary>
        /// Composants du type de données.
        /// </summary>
        IType[] Components { get; }

        /// <summary>
        /// Accès, en lecture et écriture, à un composant précis du type de données.
        /// </summary>
        /// <remarks>
        /// Les composants sont stockés à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </remarks>
        /// <param name="index">Index du composant auquel accéder.</param>
        /// <returns>Un composant de type <see cref="IType"/>.</returns>
        /// <exception cref="DataTypeException">Si <paramref name="index"/> est inférieur ou égal à 0.</exception>
        IType this[int index] { get; set; }
    }
}
