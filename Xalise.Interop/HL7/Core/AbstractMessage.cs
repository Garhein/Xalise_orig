using System;
using System.Collections.Generic;
using System.Reflection;
using Xalise.Core.Helpers;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure;

namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Représente un message HL7.
    /// </summary>
    public abstract class AbstractMessage : IMessage
    {
        private List<MessageItem>   _items;
        private EncodingCharacters  _encodingCharacters;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="encodingChars">Séparateur de champ et caractères d'encodage utilisés pour le message.</param>
        public AbstractMessage(EncodingCharacters encodingChars)
        {
            this._items                 = new List<MessageItem>();
            this._encodingCharacters    = encodingChars;
        }

        /// <summary>
        /// Initialisation d'un groupement de segments.
        /// </summary>
        /// <param name="type">Type des segments du groupement.</param>
        /// <param name="description">Description des segments.</param>
        /// <param name="maxRepetitions">Nombre maximum de répétitions autorisées.</param>
        /// <param name="required">Indique si le groupement doit contenir au moins un segment.</param>
        protected void InitMessageItem(Type type, string description, int maxRepetitions, bool required)
        {
            if (!typeof(ISegment).IsAssignableFrom(type))
            {
                throw new DataTypeException($"Le segment '{type.FullName}' n'hérite pas de '{typeof(ISegment).FullName}'.");
            }

            this._items.Add(new MessageItem(type, description, maxRepetitions, required));
        }

        /// <summary>
        /// Création d'un segment.
        /// </summary>
        /// <param name="numGroupement">Numéro du groupement auquel ajouter le nouveau segment.</param>
        /// <returns></returns>
        private ISegment CreateNewSegment(int numGroupement)
        {
            ISegment newSegment = null;
            Type typeSegment    = this._items[numGroupement].Type;

            try
            {
                Object[] args    = new Object[0] { };
                Type[] argsTypes = new Type[0] { };
                newSegment       = (ISegment)typeSegment.GetConstructor(argsTypes).Invoke(args);
            }
            catch (UnauthorizedAccessException authAccessEx)
            {
                throw new MessageException($"Impossible d'accéder à la classe '{typeSegment.FullName}' ({authAccessEx.GetType().FullName}) : {authAccessEx.Message}", authAccessEx);
            }
            catch (TargetInvocationException targetIncovationEx)
            {
                throw new MessageException($"Impossible d'instancier la classe '{typeSegment.FullName}' ({targetIncovationEx.GetType().FullName}) : {targetIncovationEx.Message}", targetIncovationEx);
            }
            catch (MethodAccessException methodAccessEx)
            {
                throw new MessageException($"Impossible d'instancier la classe '{typeSegment.FullName}' ({methodAccessEx.GetType().FullName}) : {methodAccessEx.Message}", methodAccessEx);
            }
            catch (Exception ex)
            {
                throw new MessageException($"Impossible d'instancier la classe '{typeSegment.FullName}' ({ex.GetType().FullName}) : {ex.Message}", ex);
            }

            return newSegment;
        }

        #region Implémentations

        /// <summary>
        /// Groupements de segments composant le message.
        /// </summary>
        public List<MessageItem> Items
        { 
            get
            {
                return this._items;
            }
        }

        /// <summary>
        /// Séparateur de champs et caractères d'encodage utilisés par le message.
        /// </summary>
        public EncodingCharacters EncodingCharacters 
        { 
            get
            {
                return this._encodingCharacters;
            }
        }

        /// <summary>
        /// Nombre de structure contenu par le message.
        /// </summary>
        public int CountStructure 
        { 
            get
            {
                return this._items.Count;
            }
        }

        /// <summary>
        /// Récupère une répétition d'un groupement de segments.
        /// Les groupements sont stockés à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </summary>
        /// <param name="name">Nom du type de segment.</param>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="ArgumentException">Si <paramref name="name"/> est null ou composé d'espaces.</exception>
        /// <exception cref="MessageException">Si groupement non trouvé ou que le numéro de répétition est inférieur ou égal à 0.</exception>
        /// <returns></returns>
        public ISegment GetSegment(string name, int numRepetition)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameof(name));
            }

            int grpPosition = this._items.FindIndex(x => x.SegmentName.Equals(name));

            if (grpPosition < 0)
            {
                throw new MessageException($"Le message '{TypeHelper.GetTypeName(this)}' ne contient aucun groupement de segment '{name}'.");
            }

            if (numRepetition <= 0)
            {
                new MessageException($"L'accès à un segment doit être réalisé à partir de l'index 1 (index utilisé : {numRepetition}).");
            }

            int currentRep = this._items[grpPosition].Repetitions.Count;

            // Création d'une répétition si nécessaire et si limite maximale non atteinte
            if (numRepetition > currentRep)
            {
                if (numRepetition > this._items[grpPosition].MaxRepetitions)
                {
                    throw new MessageException($"Impossible d'ajouter une répétition du segment '{TypeHelper.GetTypeName(this)}' : le nombre maximal autorisé de répétitions est de {this._items[grpPosition].MaxRepetitions}.");
                }
                else
                {
                    this._items[grpPosition].Repetitions.Add(this.CreateNewSegment(grpPosition));
                }
            }

            return this._items[grpPosition][numRepetition];
        }

        /// <summary>
        /// Récupère un groupement de segments.
        /// </summary>
        /// <param name="name">Nom du type de segment.</param>
        /// <returns></returns>
        public MessageItem GetStructure(string name)
        {
            int grpPosition = this._items.FindIndex(x => x.SegmentName.Equals(name));

            if (grpPosition < 0)
            {
                throw new MessageException($"Le message '{TypeHelper.GetTypeName(this)}' ne contient aucun groupement de segment '{name}'.");
            }

            return this._items[grpPosition];
        }

        #endregion

        #region Méthodes abstraites

        /// <summary>
        /// Initialisation des valeurs par défaut du message.
        /// </summary>
        public abstract void InitDefaultValues();

        #endregion
    }
}
