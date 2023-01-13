using System;
using System.Linq;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Composite;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.Segment
{
    /// <summary>
    /// Event Type.
    /// Le segment EVN est utilisé pour communiquer les informations d'événement de déclenchement nécessaires aux applications de réception.
    /// </summary>
    [Serializable]
    public class EVN : AbstractSegment
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        public EVN()
        {
            this.InitField(typeof(ID), "Event Type Code", 3, 1, false);
            this.InitField(typeof(TS), "Recorded Date/Time", 26, 1, true);
            this.InitField(typeof(TS), "Date/Time Planned Event", 26, 1, false);
            this.InitField(typeof(IS), "Event Reason Code", 3, 1, false);
            this.InitField(typeof(XCN), "Operator ID", 250, 0, false);
            this.InitField(typeof(TS), "Event Occurred", 26, 1, false);
            this.InitField(typeof(HD), "Event Facility", 241, 1, false);
        }

        /// <summary>
        /// EVN-1
        /// Event Type Code.
        /// </summary>
        public ID EventTypeCode
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this.GetField(1, 1) as ID;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// EVN-2
        /// Recorded Date/Time.
        /// </summary>
        public TS RecordedDateTime
        {
            get
            {
                TS ret = null;

                try
                {
                    ret = this.GetField(2, 1) as TS;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// EVN-3
        /// Date/Time Planned Event.
        /// </summary>
        public TS DateTimePlannedEvent
        {
            get
            {
                TS ret = null;

                try
                {
                    ret = this.GetField(3, 1) as TS;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// EVN-4
        /// Event Reason Code.
        /// </summary>
        public IS EventReasonCode
        {
            get
            {
                IS ret = null;

                try
                {
                    ret = this.GetField(4, 1) as IS;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// EVN-5
        /// Operator ID.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public XCN GetOperatorID(int numRepetition)
        {
            XCN ret = null;

            try
            {
                ret = this.GetField(5, numRepetition) as XCN;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// EVN-5
        /// Récupère la première répétition du champ.
        /// </summary>
        public XCN OperatorID
        {
            get
            {
                return this.GetOperatorID(1);
            }
        }

        /// <summary>
        /// EVN-5
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public XCN[] GetAllOperatorID
        {
            get
            {
                XCN[] ret = null;

                try
                {
                    ret = this.GetField(5).Cast<XCN>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// EVN-6
        /// Event Occurred.
        /// </summary>
        public TS EventOccurred
        {
            get
            {
                TS ret = null;

                try
                {
                    ret = this.GetField(6, 1) as TS;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// EVN-7
        /// Event Facility.
        /// </summary>
        public HD EventFacility
        {
            get
            {
                HD ret = null;

                try
                {
                    ret = this.GetField(7, 1) as HD;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }
    }
}
