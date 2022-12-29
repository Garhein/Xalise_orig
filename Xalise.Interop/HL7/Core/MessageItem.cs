using System;
using System.Collections.Generic;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Util.Helpers;

namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Représente un groupement de segments de même type.
    /// </summary>
    [Serializable]
    public class MessageItem
    {
        private List<ISegment>  _repetitions;
        private Type            _type;
        private string          _description;
        private int             _maxRepetitions;
        private bool            _required;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="type">Type des segments composant le groupement.</param>
        /// <param name="description">Description des segments.</param>
        /// <param name="maxRepetitions">Nombre maximum de répétitions autorisées.</param>
        /// <param name="required">Indique si au moins un segment est obligatoire dans le groupement.</param>
        public MessageItem(Type type, string description, int maxRepetitions, bool required)
        {
            if (!typeof(ISegment).IsAssignableFrom(type))
            {
                throw new SegmentException($"Le segment '{type.FullName}' n'hérite pas de '{typeof(ISegment).FullName}'.");
            }

            this._repetitions       = new List<ISegment>();
            this._type              = type;
            this._description       = description;
            this._maxRepetitions    = maxRepetitions;
            this._required          = required;
        }

        /// <summary>
        /// Nom des segments composant le groupement.
        /// </summary>
        public string SegmentName
        {
            get
            {
                return TypeHelper.GetTypeName(this._type);
            }
        }

        /// <summary>
        /// Liste des répétitions.
        /// </summary>
        public List<ISegment> Repetitions
        {
            get
            {
                return this._repetitions;
            }
        }

        /// <summary>
        /// Type des segments composant le groupement.
        /// </summary>
        public Type Type
        {
            get
            {
                return this._type;
            }
        }

        /// <summary>
        /// Description des segments.
        /// </summary>
        public string Description
        {
            get
            {
                return this._description;
            }
        }

        /// <summary>
        /// Nombre maximum de répétitions autorisées.
        /// </summary>
        public int MaxRepetitions
        {
            get
            {
                return this._maxRepetitions > 0 ? this._maxRepetitions : int.MaxValue;
            }
        }

        /// <summary>
        /// Indique si au moins un segment est obligatoire dans le groupement.
        /// </summary>
        public bool IsRequired
        {
            get
            {
                return this._required;
            }
        }

        /// <summary>
        /// Récupère une répétition du groupement de segments.
        /// Les répétitions sont stockées à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </summary>
        /// <param name="index">Index de la répétition à récupérer.</param>
        /// <exception cref="SegmentException">Si l'index d'accès est inférieur ou égal à 0 ou qu'il est hors bornes.</exception>
        /// <returns>Segment de type <see cref="ISegment"/>.</returns>
        public ISegment this[int index]
        {
            get
            {
                try
                {
                    if (index > 0)
                    {
                        return this._repetitions[index - 1];
                    }
                    else
                    {
                        throw new SegmentException($"L'accès à une répétition des segments '{this.SegmentName}' doit être réalisé à partir de l'index 1 (index utilisé : {index}).");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new SegmentException($"La répétition à la position {index} n'existe pas pour le segment '{this.SegmentName}'.");
                }
            }
        }

        /// <summary>
        /// Convertit la liste des répétitions en un tableau de <see cref="ISegment"/>.
        /// </summary>
        /// <returns>Tableau de <see cref="ISegment"/>.</returns>
        public ISegment[] ConvertRepetitionsToISegmentArray
        {
            get
            {
                return this._repetitions.ToArray();
            }
        }
    }
}
