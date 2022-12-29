using System;
using System.Collections.Generic;
using System.Reflection;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Helpers;
using Xalise.Util.Helpers;

namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Représente un segment.
    /// </summary>
    public abstract class AbstractSegment : ISegment
    {
        private List<SegmentItem> _items;

        /// <summary>
        /// Constructeur vide.
        /// </summary>
        public AbstractSegment()
        {
            this._items = new List<SegmentItem>();
        }

        /// <summary>
        /// Initialise un champ du segment.
        /// </summary>
        /// <param name="type">Type du champ.</param>
        /// <param name="description">Description du champ.</param>
        /// <param name="maxLength">Longueur maximale de chaque répétition.</param>
        /// <param name="maxRepetitions">Nombre maximum de répétitions autorisées.</param>
        /// <param name="required">Indique si le champ est obligatoire.</param>
        protected void InitField(Type type,
                                 string description,
                                 int maxLength,
                                 int maxRepetitions,
                                 bool required)
        {
            if (!typeof(IType).IsAssignableFrom(type))
            {
                throw new DataTypeException($"Le type '{type.FullName}' n'hérite pas de '{typeof(IType).FullName}'.");
            }

            this._items.Add(new SegmentItem(type, description, maxLength, maxRepetitions, required));
        }

        /// <summary>
        /// Création d'un champ.
        /// Les champs sont stockés à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </summary>
        /// <param name="numField">Numéro du champ auquel ajouter la répétition.</param>
        /// <returns></returns>
        private IType CreateNewField(int numField)
        {
            IType newType   = null;
            Type typeRep    = this._items[numField - 1].Type;
            string descr    = this._items[numField - 1].Description;
            int maxLenght   = this._items[numField - 1].MaxLength;
            bool required   = this._items[numField - 1].IsRequired;

            try
            {
                //TODO: gérer le cas où il s'agit d'un type primitif avec une table de donnée
                Object[] args    = new Object[3] { descr, maxLenght, required };
                Type[] argsTypes = new Type[3] { descr.GetType(), maxLenght.GetType(), required.GetType() };
                newType          = (IType)typeRep.GetConstructor(argsTypes).Invoke(args);
            }
            catch (UnauthorizedAccessException authAccessEx)
            {
                throw new DataTypeException($"Impossible d'accéder à la classe '{typeRep.FullName}' ({authAccessEx.GetType().FullName}) : {authAccessEx.Message}", authAccessEx);
            }
            catch (TargetInvocationException targetIncovationEx)
            {
                throw new DataTypeException($"Impossible d'instancier la classe '{typeRep.FullName}' ({targetIncovationEx.GetType().FullName}) : {targetIncovationEx.Message}", targetIncovationEx);
            }
            catch (MethodAccessException methodAccessEx)
            {
                throw new DataTypeException($"Impossible d'instancier la classe '{typeRep.FullName}' ({methodAccessEx.GetType().FullName}) : {methodAccessEx.Message}", methodAccessEx);
            }
            catch (Exception ex)
            {
                throw new DataTypeException($"Impossible d'instancier la classe '{typeRep.FullName}' ({ex.GetType().FullName}) : {ex.Message}", ex);
            }

            return newType;
        }

        #region Implémentations

        /// <summary>
        /// Nom du segment.
        /// </summary>
        public string SegmentName
        {
            get
            {
                return TypeHelper.GetTypeName(this);
            }
        }

        /// <summary>
        /// Champs composant le segment.
        /// </summary>
        public List<SegmentItem> Items
        {
            get
            {
                return this._items;
            }
        }

        /// <summary>
        /// Récupère les donnés d'un champ.
        /// Les champs sont stockés à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </summary>
        /// <param name="numField">Numéro du champ.</param>
        /// <exception cref="SegmentException">Si le numéro du champ est inférieur ou égal à 0 ou qu'il est hors bornes.</exception>
        /// <returns>Tableau de type <see cref="IType"/> de longueur 1 pour les champs non répétables et de longueur supérieure à 1 pour les champs répétables.</returns>
        public IType[] GetField(int numField)
        {
            try
            {
                if (numField > 0)
                {
                    return this._items[numField - 1].ConvertRepetitionsToITypeArray;
                }
                else
                {
                    throw new SegmentException($"L'accès à un champ doit être réalisé à partir de l'index 1 (index utilisé : {numField}).");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new SegmentException($"Le champ {FieldHelper.ConstructFieldNumber(this.SegmentName, numField)} n'existe pas.");
            }
        }

        /// <summary>
        /// Récupère les données d'une répétition d'un champ.
        /// Les champs et répétitions sont stocké(e)s à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </summary>
        /// <param name="numField">Numéro du champ.</param>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si le numéro du champ est inférieur ou égal à 0 ou qu'il est hors bornes, que le numéro de répétition est inférieur ou égale à 0.</exception>
        /// <returns>Répétition de type <see cref="IType"/>.</returns>
        public IType GetField(int numField, int numRepetition)
        {
            if (numField <= 0)
            {
                throw new SegmentException($"L'accès à un champ doit être réalisé à partir de l'index 1 (index utilisé : {numField}).");
            }

            if (numField > this._items.Count)
            {
                throw new SegmentException($"Le champ {FieldHelper.ConstructFieldNumber(this.SegmentName, numField)} n'existe pas.");
            }

            if (numRepetition <= 0)
            {
                throw new SegmentException($"L'accès à une répétition du champ {FieldHelper.ConstructFieldNumber(this.SegmentName, numField)} doit être réalisé à partir de l'index 1 (index utilisé : {numRepetition}).");
            }

            int currentRep = this._items[numField - 1].Repetitions.Count;

            // Création d'une répétition si nécessaire et si limite maximale non atteinte
            if (numRepetition > currentRep)
            {
                if (numRepetition > this._items[numField - 1].MaxRepetitions)
                {
                    throw new SegmentException($"Impossible d'ajouter la répétition {FieldHelper.ConstructFieldNumber(this.SegmentName, numField, numRepetition)} : le nombre maximal autorisé de répétitions est de {this._items[numField - 1].MaxRepetitions}.");
                }
                else
                {
                    this._items[numField - 1].Repetitions.Add(this.CreateNewField(numField));
                }
            }

            return this._items[numField - 1][numRepetition - 1];
        }

        #endregion
    }
}
