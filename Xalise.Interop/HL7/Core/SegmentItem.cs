using System;
using System.Collections.Generic;
using Xalise.Interop.HL7.Exceptions;

namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Représente un champ d'un segment.
    /// </summary>
    [Serializable]
    public class SegmentItem
    {
        private List<IType> _repetitions;
        private Type        _type;
        private string      _description;
        private int         _maxLength;
        private int         _maxRepetitions;
        private bool        _required;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="type">Type du champ.</param>
        /// <param name="description">Description du champ.</param>
        /// <param name="maxLength">Longueur maximale de chaque répétition du champ.</param>
        /// <param name="maxRepetitions">Nombre maximum de répétitions autorisées.</param>
        /// <param name="required">Indique si le champ est obligatoire.</param>
        public SegmentItem(Type type, string description, int maxLength, int maxRepetitions, bool required)
        {
            if (!typeof(IType).IsAssignableFrom(type))
            {
                throw new DataTypeException($"Le type '{type.FullName}' n'hérite pas de '{typeof(IType).FullName}'.");
            }

            this._repetitions       = new List<IType>();
            this._type              = type;
            this._description       = description;
            this._maxLength         = maxLength;
            this._maxRepetitions    = maxRepetitions;
            this._required          = required;
        }

        /// <summary>
        /// Répétitions du champ.
        /// </summary>
        public List<IType> Repetitions
        {
            get
            {
                return this._repetitions;
            }
        }

        /// <summary>
        /// Type du champ.
        /// </summary>
        public Type Type
        {
            get
            {
                return this._type;
            }
        }
    
        /// <summary>
        /// Description du champ.
        /// </summary>
        public string Description
        {
            get
            {
                return this._description;
            }
        }
    
        /// <summary>
        /// Longueur maximale de chaque répétition du champ.
        /// </summary>
        public int MaxLength
        {
            get
            {
                return this._maxLength > 0 ? this._maxLength : int.MaxValue;
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
        /// Indique si le champ est obligatoire.
        /// </summary>
        public bool IsRequired
        {
            get
            {
                return this._required;
            }
        }

        /// <summary>
        /// Récupère une répétition du champ.
        /// Les répétitions sont stockées à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </summary>
        /// <param name="index">Index de la répétition à récupérer.</param>
        /// <exception cref="DataTypeException">Si l'index d'accès est inférieur ou égal à 0 ou qu'il est hors bornes.</exception>
        /// <returns>Répétition de type <see cref="IType"/>.</returns>
        public IType this[int index]
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
                        throw new DataTypeException($"L'accès à une répétition doit être réalisé à partir de l'index 1 (index utilisé : {index}).");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new DataTypeException($"La répétition à la position {index} n'existe pas.");
                }
            }
        }

        /// <summary>
        /// Convertit la liste des répétitions en un tableau de <see cref="IType"/>.
        /// </summary>
        /// <returns>Tableau de <see cref="IType"/>.</returns>
        public IType[] ConvertRepetitionsToITypeArray
        {
            get
            {
                return this._repetitions.ToArray();
            }
        }
    }
}
