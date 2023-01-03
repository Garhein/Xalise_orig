﻿using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Primitive;
using Xalise.Interop.HL7.Structure.Table;

namespace Xalise.Interop.HL7.Structure.DataType.Composite
{
    /// <summary>
    /// HD - Hierarchic Designator.
    /// </summary>
    [Serializable]
    public class HD : AbstractTypeComposite
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>        
        public HD(string description, int maxLength, bool required) : base(description, maxLength, required, 3)
        {
            this[1] = new IS("Namespace Id", 20, false);
            this[2] = new ST("Universal Id", 199, false);
            this[3] = new ID("Universal Id Type", 6, false);
        }

        /// <summary>
        /// HD.1 - Namespace Id.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public IS NamespaceId
        {
            get
            {
                IS ret = null;

                try
                {
                    ret = this[1] as IS;
                }
                catch (DataTypeException)
                {
                    throw;
                }

                return ret;
            }
            set
            {
                try
                {
                    this[1] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// HD.2 - Universal Id.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST UniversalId
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this[2] as ST;
                }
                catch (DataTypeException)
                {
                    throw;
                }

                return ret;
            }
            set
            {
                try
                {
                    this[2] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// HD.3 - Universal Id Type.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID UniversalIdType
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this[3] as ID;
                }
                catch (DataTypeException)
                {
                    throw;
                }

                return ret;
            }
            set
            {
                try
                {
                    this[3] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }
    }
}
