using System;
using Xalise.Interop.InteropHL7.Exceptions;

namespace Xalise.Interop.InteropHL7.Core
{
    /// <summary>
    /// Représentation d'un type de données composite, c'est-à-dire composé de plusieurs valeurs.
    /// </summary>
    [Serializable]
    public abstract class AbstractTypeComposite : AbstractType, ITypeComposite
    {
        private IType[] _components;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée de la donnée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>
        /// <param name="nbComponents">Nombre de composants du type de données.</param>
        /// <exception cref="DataTypeException">Si <paramref name="nbComponents"/> est inférieur ou égal à 0.</exception>
        public AbstractTypeComposite(string description, int maxLength, bool required, int nbComponents) : base(description, maxLength, required)
        {
            if (nbComponents <= 0)
            {
                throw new DataTypeException($"Le nombre de composant du type '{this.TypeName}' n'est pas valide.");
            }

            this._components= new IType[nbComponents];
        }

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
        /// Accès, en lecture et écriture, à un composant précis du type de données.
        /// </summary>
        /// <remarks>
        /// Les composants sont stockés à partir de l'indice 0 mais une base 1 est utilisée pour les accès.
        /// </remarks>
        /// <param name="index">Index du composant auquel accéder.</param>
        /// <returns>Un composant de type <see cref="IType"/>.</returns>
        /// <exception cref="DataTypeException">Si <paramref name="index"/> est inférieur ou égal à 0.</exception>
        public IType this[int index] 
        { 
            get
            {
                try
                {
                    if (index <= 0)
                    {
                        throw new DataTypeException($"L'accès à un composant du type '{this.TypeName}' doit être réalisé à partir de l'index 1 (index utilisé : {index}).");
                    }
                    else
                    {
                        return this._components[index - 1];
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    throw new DataTypeException($"Le composant à la position {index} n'existe pas pour le type '{this.TypeName}'.", ex);
                }
            }
            set
            {
                try
                {
                    if (index <= 0)
                    {
                        throw new DataTypeException($"L'accès à un composant du type '{this.TypeName}' doit être réalisé à partir de l'index 1 (index utilisé : {index}).");
                    }
                    else
                    {
                        this._components[index - 1] = value;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    throw new DataTypeException($"Le composant à la position {index} n'existe pas pour le type '{this.TypeName}'.", ex);
                }
            }
        }
    }
}
