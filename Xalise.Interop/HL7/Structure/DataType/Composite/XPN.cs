using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Primitive;
using Xalise.Interop.HL7.Structure.Table;

namespace Xalise.Interop.HL7.Structure.DataType.Composite
{
    /// <summary>
    /// XPN - Extended Person Name.
    /// </summary>
    [Serializable]
    public class XPN : AbstractTypeComposite
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>        
        public XPN(string description, int maxLength, bool required) : base(description, maxLength, required, 14)
        {
            this[1]  = new FN("Family Name", 194, false);
            this[2]  = new ST("Given Name", 30, false);
            this[3]  = new ST("Second And Further Given Names Or Initials Thereof", 30, false);
            this[4]  = new ST("Suffix (e.g., Jr Or Iii)", 20, false);
            this[5]  = new ST("Prefix (e.g., Dr)", 20, false);
            this[6]  = new IS("Degree (e.g., Md)", 6, false, typeof(DegreeLicenseCertificate));
            this[7]  = new ID("Name Type Code", 1, false, typeof(NameType));
            this[8]  = new ID("Name Representation Code", 1, false, typeof(NameAddressRepresentation));
            this[9]  = new CE("Name Context", 483, false);
            this[10] = new DR("Name Validity Range", 53, false);
            this[11] = new ID("Name Assembly Order", 1, false, typeof(NameAssemblyOrder));
            this[12] = new TS("Effective Date", 26, false);
            this[13] = new TS("Expiration Date", 26, false);
            this[14] = new ST("Professional Suffix", 199, false);
        }

        /// <summary>
        /// XPN.1 - Family Name.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public FN FamilyName
        {
            get
            {
                FN ret = null;

                try
                {
                    ret = this[1] as FN;
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
        /// XPN.2 - Given Name.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST GivenName
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
        /// XPN.3 - Second And Further Given Names Or Initials Thereof.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST SecondAndFurtherGivenNamesOrInitialsThereof
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
        /// XPN.4 - Suffix.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST Suffix
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
        /// XPN.5 - Prefix.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST Prefix
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

        /// <summary>
        /// XPN.6 - Degree.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public IS Degree
        {
            get
            {
                IS ret = null;

                try
                {
                    ret = this[6] as IS;
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
        /// XPN.7 - Name Type Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID NameTypeCode
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
        /// XPN.8 - Name Representation Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID NameRepresentationCode
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this[8] as ID;
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
        /// XPN.9 - Name Context.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public CE NameContext
        {
            get
            {
                CE ret = null;

                try
                {
                    ret = this[9] as CE;
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
        /// XPN.10 - Name Validity Range.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public DR NameValidityRange
        {
            get
            {
                DR ret = null;

                try
                {
                    ret = this[10] as DR;
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

        /// <summary>
        /// XPN.11 - Name Assembly Order.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID NameAssemblyOrder
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this[11] as ID;
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
                    this[11] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// XPN.12 - Effective Date.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public TS EffectiveDate
        {
            get
            {
                TS ret = null;

                try
                {
                    ret = this[12] as TS;
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
                    this[12] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// XPN.13 - Expiration Date.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public TS ExpirationDate
        {
            get
            {
                TS ret = null;

                try
                {
                    ret = this[13] as TS;
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
                    this[13] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// XPN.14 - Professional Suffix.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST ProfessionalSuffix
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this[14] as ST;
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
                    this[14] = value;
                }
                catch (DataTypeException)
                {
                    throw;
                }
            }
        }
    }
}
