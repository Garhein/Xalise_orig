using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Primitive;
using Xalise.Interop.HL7.Structure.Table;

namespace Xalise.Interop.HL7.Structure.DataType.Composite
{
    /// <summary>
    /// MSG - Message Type.
    /// </summary>
    [Serializable]
    public class MSG : AbstractTypeComposite
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="description">Description de la donnée.</param>
        /// <param name="maxLength">Longueur maximale autorisée.</param>
        /// <param name="required">Indique si la donnée est obligatoire.</param>        
        public MSG(string description, int maxLength, bool required) : base(description, maxLength, required, 3)
        {
            this[1] = new ID("Message Code", 3, true, typeof(MessageType));
            this[2] = new ID("Trigger Event", 3, true, typeof(EventType));
            this[3] = new ID("Message Structure", 7, true, typeof(MessageStructure));
        }

        /// <summary>
        /// MSG.1 - Message Code.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID MessageCode
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this[1] as ID;
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
        /// MSG.2 - Trigger Event.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID TriggerEvent
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
        /// MSG.3 - Message Structure.
        /// </summary>
        /// <exception cref="DataTypeException">Si erreur à l'accès au composant.</exception>
        public ID MessageStructure
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
