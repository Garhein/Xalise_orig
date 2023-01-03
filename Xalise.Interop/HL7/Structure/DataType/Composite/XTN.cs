using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.DataType.Composite
{
    /// <summary>
    /// XTN - Extended Telecommunication Number.
    /// </summary>
    [Serializable]
    public class XTN : AbstractTypeComposite
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>        
        public XTN(string description, int maxLength, bool required) : base(description, maxLength, required, 12)
        {
            this[1]   = new ST("Telephone Number", 199, false);
            this[2]   = new ID("Telecommunication Use Code", 3, false);
            this[3]   = new ID("Telecommunication Equipment Type", 8, false);
            this[4]   = new ST("Email Address", 199, false);
            this[5]   = new NM("Country Code", 3, false);
            this[6]   = new NM("Area/City Code", 5, false);
            this[7]   = new NM("Local Number", 9, false);
            this[8]   = new NM("Extension", 5, false);
            this[9]   = new ST("Any Text", 199, false);
            this[10]  = new ST("Extension Prefix", 4, false);
            this[11]  = new ST("Speed Dial Code", 6, false);
            this[12]  = new ST("Unformatted Telephone Number", 199, false);
        }

        /// <summary>
        /// XTN.1 - Telephone Number.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST TelephoneNumber
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
        /// XTN.2 - Telecommunication Use Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID TelecommunicationUseCode
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this[2] as ID;
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
        /// XTN.3 - Telecommunication Equipment Type.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID TelecommunicationEquipmentType
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

        /// <summary>
        /// XTN.4 - Email Address.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST EmailAddress
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
        /// XTN.5 - Country Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public NM CountryCode
        {
            get
            {
                NM ret = null;

                try
                {
                    ret = this[5] as NM;
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
        /// XTN.6 - Area/City Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public NM AreaCityCode
        {
            get
            {
                NM ret = null;

                try
                {
                    ret = this[6] as NM;
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
        /// XTN.7 - Local Number.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public NM LocalNumber
        {
            get
            {
                NM ret = null;

                try
                {
                    ret = this[7] as NM;
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
        /// XTN.8 - Extension.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public NM Extension
        {
            get
            {
                NM ret = null;

                try
                {
                    ret = this[8] as NM;
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
        /// XTN.9 - Any Text.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST AnyText
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this[9] as ST;
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
        /// XTN.10 - Extension Prefix.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST ExtensionPrefix
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

        /// <summary>
        /// XTN.11 - Speed Dial Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST SpeedDialCode
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this[11] as ST;
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
        /// XTN.12 - Unformatted Telephone Number.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST UnformattedTelephoneNumber
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this[12] as ST;
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
    }
}
