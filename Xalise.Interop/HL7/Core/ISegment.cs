using System.Collections.Generic;

namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Définition des comportements communs aux segments.
    /// </summary>
    public interface ISegment
    {
        /// <summary>
        /// Nom du segment.
        /// </summary>
        string SegmentName { get; }

        /// <summary>
        /// Champs composant un segment.
        /// </summary>
        List<SegmentItem> Fields { get; }

        /// <summary>
        /// Récupère les données d'un champ précis du segment.
        /// Les champs sont stockés à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </summary>
        /// <param name="numField">Numéro du champ.</param>
        /// <returns>Tableau de <see cref="IType"/> de longueur 1 pour les champs non répétables, et > 1 pour les champs répétables.</returns>
        IType[] GetField(int numField);

        /// <summary>
        /// Récupère les données d'une répétition d'un champ précis du segment.
        /// Les champs et répétitions sont stocké(e)s à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </summary>
        /// <param name="numField">Numéro du champ.</param>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <returns></returns>
        IType GetField(int numField, int numRepetition);
    }
}
