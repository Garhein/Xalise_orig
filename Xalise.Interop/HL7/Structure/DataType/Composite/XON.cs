using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Primitive;
using Xalise.Interop.HL7.Structure.Table;

namespace Xalise.Interop.HL7.Structure.DataType.Composite
{
    /// <summary>
    /// XON - Extended Composite Name and Identification Number for Organizations.
    /// </summary>
    [Serializable]
    public class XON : AbstractTypeComposite
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>        
        public XON(string description, int maxLength, bool required) : base(description, maxLength, required, 10)
        {
            this[1]  = new ST("Organization Name", 50, false);
            this[2]  = new IS("Organization Name Type Code", 20, false);
            this[3]  = new NM("Id Number", 3, false);
            this[4]  = new NM("Check Digit", 1, false);
            this[5]  = new ID("Check Digit Scheme", 3, false, typeof(CheckDigitScheme));
            this[6]  = new HD("Assigning Authority", 227, false);
            this[7]  = new ID("Identifier Type Code", 5, false, typeof(IdentifierType));
            this[8]  = new HD("Assigning Facility", 227, false);
            this[9]  = new ID("Name Representation Code", 1, false, typeof(NameAddressRepresentation));
            this[10] = new ST("Organization Identifier", 20, false);
        }

        /// <summary>
        /// XON.1 - Organization Name.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST OrganizationName
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
        /// XON.2 - Organization Name Type Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public IS OrganizationNameTypeCode
        {
            get
            {
                IS ret = null;

                try
                {
                    ret = this[2] as IS;
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
        /// XON.3 - Id Number.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public NM IdNumber
        {
            get
            {
                NM ret = null;

                try
                {
                    ret = this[3] as NM;
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
        /// XON.4 - Check Digit.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public NM CheckDigit
        {
            get
            {
                NM ret = null;

                try
                {
                    ret = this[4] as NM;
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
        /// XON.5 - Check Digit Scheme.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID CheckDigitScheme
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this[5] as ID;
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

        /// <summary>
        /// XON.6 - Assigning Authority.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public HD AssigningAuthority
        {
            get
            {
                HD ret = null;

                try
                {
                    ret = this[6] as HD;
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
                    this[6] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// XON.7 - Identifier Type Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID IdentifierTypeCode
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this[7] as ID;
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
                    this[7] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// XON.8 - Assigning Facility.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public HD AssigningFacility
        {
            get
            {
                HD ret = null;

                try
                {
                    ret = this[8] as HD;
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
                    this[8] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// XON.9 - Name Representation Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID NameRepresentationCode
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this[9] as ID;
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
                    this[9] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// XON.10 - Organization Identifier.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST OrganizationIdentifier
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this[10] as ST;
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
                    this[10] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }
    }
}
