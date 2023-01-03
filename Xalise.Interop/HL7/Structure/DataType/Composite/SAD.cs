using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.DataType.Composite
{
    /// <summary>
    /// SAD - Street Address.
    /// </summary>
    [Serializable]
    public class SAD : AbstractTypeComposite
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>        
        public SAD(string description, int maxLength, bool required) : base(description, maxLength, required, 3)
        {
            this[1] = new ST("Street Or Mailing Address", 120, false);
            this[2] = new ST("Street Name", 50, false);
            this[3] = new ST("Dwelling Number", 12, false);
        }

        /// <summary>
        /// SAD.1 - Street Or Mailing Address.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST StreetOrMailingAddress
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this[1] as ST;
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
        /// SAD.2 - Street Name.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST StreetName
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
        /// SAD.3 - Dwelling Number.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST DwellingNumber
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this[3] as ST;
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
