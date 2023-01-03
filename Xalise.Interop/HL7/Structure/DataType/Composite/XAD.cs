using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Primitive;
using Xalise.Interop.HL7.Structure.Table;

namespace Xalise.Interop.HL7.Structure.DataType.Composite
{
    /// <summary>
    /// XAD - Extended Address.
    /// </summary>
    [Serializable]
    public class XAD : AbstractTypeComposite
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>        
        public XAD(string description, int maxLength, bool required) : base(description, maxLength, required, 14)
        {
            this[1]  = new SAD("Street Address", 184, false);
            this[2]  = new ST("Other Designation", 120, false);
            this[3]  = new ST("City", 50, false);
            this[4]  = new ST("State Or Province", 50, false);
            this[5]  = new ST("Zip Or Postal Code", 12, false);
            this[6]  = new ID("Country", 3, false, typeof(CountryCode));
            this[7]  = new ID("Address Type", 3, false, typeof(AddressType));
            this[8]  = new ST("Other Geographic Designation", 50, false);
            this[9]  = new IS("County/Parish Code", 20, false, typeof(CountyParish));
            this[10] = new IS("Census Tract", 20, false, typeof(CensusTract));
            this[11] = new ID("Address Representation Code", 1, false, typeof(NameAddressRepresentation));
            this[12] = new DR("Address Validity Range", 53, false);
            this[13] = new TS("Effective Date", 26, false);
            this[14] = new TS("Expiration Date", 26, false);
        }

        /// <summary>
        /// XAD.1 - Street Address.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public SAD StreetAddress
        {
            get
            {
                SAD ret = null;

                try
                {
                    ret = this[1] as SAD;
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
        /// XAD.2 - Other Designation.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST OtherDesignation
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
        /// XAD.3 - City.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST City
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
        /// XAD.4 - State Or Province.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST StateOrProvince
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
        /// XAD.5 - Zip Or Postal Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST ZipOrPostalCode
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
        /// XAD.6 - Country.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID Country
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this[6] as ID;
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
        /// XAD.7 - Address Type.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID AddressType
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
        /// XAD.8 - Other Geographic Designation.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST OtherGeographicDesignation
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this[8] as ST;
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
        /// XAD.9 - County/Parish Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public IS CountyParishCode
        {
            get
            {
                IS ret = null;

                try
                {
                    ret = this[9] as IS;
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
        /// XAD.10 - Census Tract.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public IS CensusTract
        {
            get
            {
                IS ret = null;

                try
                {
                    ret = this[10] as IS;
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
        /// XAD.11 - Address Representation Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID AddressRepresentationCode
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
        /// XAD.12 - Address Validity Range.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public DR AddressValidityRange
        {
            get
            {
                DR ret = null;

                try
                {
                    ret = this[12] as DR;
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
        /// XAD.13 - Effective Date.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public TS EffectiveDate
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
        /// XAD.14 - Expiration Date.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public TS ExpirationDate
        {
            get
            {
                TS ret = null;

                try
                {
                    ret = this[14] as TS;
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
