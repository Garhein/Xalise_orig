using System;
using System.Collections.Generic;
using Xalise.Interop.HL7.Structure;

namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Déclaration des comportements communs aux messages HL7.
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Groupements de segments composant le message.
        /// </summary>
        List<MessageItem> Items { get; }

        /// <summary>
        /// Séparateur de champs et caractères d'encodage utilisés par le message.
        /// </summary>
        EncodingCharacters EncodingCharacters { get; }

        /// <summary>
        /// Nombre de structure contenu par le message.
        /// </summary>
        int CountStructure { get; }

        /// <summary>
        /// Récupère une répétition d'un groupement de segments.
        /// Les groupements sont stockés à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </summary>
        /// <param name="name">Nom du type de segment.</param>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <returns></returns>
        ISegment GetSegment(string name, int numRepetition);

        /// <summary>
        /// Récupère un groupement de segments.
        /// </summary>
        /// <param name="name">Nom du type de segment.</param>
        /// <returns></returns>
        MessageItem GetStructure(string name);

        /// <summary>
        /// Initialisation des valeurs par défaut du message.
        /// </summary>
        void InitDefaultValues();
    }
}
