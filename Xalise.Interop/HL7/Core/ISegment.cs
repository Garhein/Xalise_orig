using System.Collections.Generic;

namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Déclaration des comportements communs aux segments.
    /// </summary>
    public interface ISegment
    {
        /// <summary>
        /// Nom du segment.
        /// </summary>
        string SegmentName { get; }

        /// <summary>
        /// Champs composant le segment.
        /// </summary>
        List<SegmentItem> Items { get; }

        /// <summary>
        /// Récupère les donnés d'un champ.
        /// Les champs sont stockés à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </summary>
        /// <param name="numField">Numéro du champ.</param>
        /// <exception cref="SegmentException">Si le numéro du champ est inférieur ou égal à 0 ou qu'il est hors bornes.</exception>
        /// <returns>Tableau de type <see cref="IType"/> de longueur 1 pour les champs non répétables et de longueur supérieure à 1 pour les champs répétables.</returns>
        IType[] GetField(int numField);

        /// <summary>
        /// Récupère les données d'une répétition d'un champ.
        /// Les champs et répétitions sont stocké(e)s à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </summary>
        /// <param name="numField">Numéro du champ.</param>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si le numéro du champ est inférieur ou égal à 0 ou qu'il est hors bornes, que le numéro de répétition est inférieur ou égale à 0.</exception>
        /// <returns>Répétition de type <see cref="IType"/>.</returns>
        IType GetField(int numField, int numRepetition);
    }
}
