using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.DataType.Composite
{
    /// <summary>
    /// FN - Family Name.
    /// </summary>
    [Serializable]
    public class FN : AbstractTypeComposite
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>        
        public FN(string description, int maxLength, bool required) : base(description, maxLength, required, 5)
        {
            this[1] = new ST("Surname", 50, true);
            this[2] = new ST("Own Surname Prefix", 20, false);
            this[3] = new ST("Own Surname", 50, false);
            this[4] = new ST("Surname Prefix From Partner/Spouse", 20, false);
            this[5] = new ST("Surname From Partner/Spouse", 50, false);
        }

        /// <summary>
        /// FN.1 - Surname.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST Surname
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
        /// FN.2 - Own Surname Prefix.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST OwnSurnamePrefix
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
        /// FN.3 - Own Surname.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST OwnSurname
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

        /// <summary>
        /// FN.4 - Surname Prefix From Partner/Spouse.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST SurnamePrefixFromPartnerSpouse
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this[4] as ST;
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
                    this[4] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// FN.5 - Surname From Partner/Spouse.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST SurnameFromPartnerSpouse
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this[5] as ST;
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
                    this[5] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }
    }
}
