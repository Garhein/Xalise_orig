using System;
using Xalise.Interop.HL7.Exceptions;

namespace Xalise.Interop.HL7.Core
{
    /// <summary>
    /// Représente un type de données composite, c'est-à-dire composé de plusieurs valeurs.
    /// </summary>
    [Serializable]
    public abstract class AbstractTypeComposite : AbstractType, ITypeComposite
    {
        private IType[] _components;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>
        /// <param name="nbComponents">Nombre de composants du type de données.</param>
        /// <exception cref="DataTypeException">Si le nombre de composants est inférieur ou égal à 0.</exception>
        public AbstractTypeComposite(string description, int maxLength, bool required, int nbComponents) : base(description, maxLength, required)
        {
            if (nbComponents <= 0)
            {
                throw new DataTypeException($"Le nombre de composants du type '{this.TypeName}' n'est pas valide.");
            }

            this._components = new IType[nbComponents];
        }

        #region Implémentations

        /// <summary>
        /// Composants du type de données.
        /// </summary>
        public IType[] Components
        {
            get
            {
                return this._components;
            }
        }

        /// <summary>
        /// Affecte et récupère un composant précis du type de données.
        /// Les composants sont stockés à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </summary>
        /// <param name="index">Index du composant.</param>
        /// <exception cref="DataTypeException">Si l'index d'accès est inférieur ou égal à 0 ou que l'index est hors bornes.</exception>
        /// <returns>Composant de type <see cref="IType"/>.</returns>
        public IType this[int index]
        {
            // Lecture
            get
            {
                try
                {
                    if (index > 0)
                    {
                        return this._components[index - 1];
                    }
                    else
                    {
                        throw new DataTypeException($"L'accès à un composant du type '{this.TypeName}' doit être réalisé à partir de l'index 1 (index utilisé : {index}).");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new DataTypeException($"Le composant à la position {index} n'existe pas pour le type '{this.TypeName}'.");
                }
            }
            // Affectation
            set
            {
                try
                {
                    if (index > 0)
                    {
                        this._components[index - 1] = value;
                    }
                    else
                    {
                        throw new DataTypeException($"L'accès à un composant du type '{this.TypeName}' doit être réalisé à partir de l'index 1 (index utilisé : {index}).");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new DataTypeException($"Le composant à la position {index} n'existe pas pour le type '{this.TypeName}'.");
                }
            }
        }

        #endregion
    }
}
