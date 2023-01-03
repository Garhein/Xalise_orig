using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.DataType.Composite
{
    /// <summary>
    /// DLN - Driver License Number.
    /// </summary>
    [Serializable]
    public class DLN : AbstractTypeComposite
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>        
        public DLN(string description, int maxLength, bool required) : base(description, maxLength, required, 3)
        {
            this[1] = new ST("License Number", 20, true);
            this[2] = new IS("Issuing State, Province, Country", 20, false);
            this[3] = new DT("Expiration Date", 24, false);
        }

        /// <summary>
        /// DLN.1 - License Number.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ST LicenseNumber
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
        /// DLN.2 - Issuing State, Province, Country.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public IS IssuingStateProvinceCountry
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
        /// DLN.3 - Expiration Date.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public DT ExpirationDate
        {
            get
            {
                DT ret = null;

                try
                {
                    ret = this[3] as DT;
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
