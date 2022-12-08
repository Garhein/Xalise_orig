using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;

namespace Xalise.Interop.HL7.Structure.DataType.Composite
{
    /// <summary>
    /// DR - Date/Time Range.
    /// </summary>
    [Serializable]
    public class DR: AbstractTypeComposite
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>        
        public DR(string description, int maxLength, bool required) : base(description, maxLength, required, 2)
        {
            this[1] = new TS("Range Start Date/Time", 26, false);
            this[2] = new TS("Range End Date/Time", 26, false);
        }

        /// <summary>
        /// DR.1 - Range Start Date/Time.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public TS RangeStartDateTime
        {
            get
            {
                TS ret = null;

                try
                {
                    ret = this[1] as TS;
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
        /// DR.2 - Range End Date/Time.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public TS RangeEndDateTime
        {
            get
            {
                TS ret = null;

                try
                {
                    ret = this[2] as TS;
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
    }
}
