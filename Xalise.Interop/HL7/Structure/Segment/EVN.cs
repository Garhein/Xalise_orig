using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Composite;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.Segment
{
    /// <summary>
    /// EVN - Event Type.
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
        /// EVN-1 - Event Type Code.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ID EventTypeCode()
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

        /// <summary>
        /// EVN-2 - Recorded Date/Time.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public TS RecordedDateTime()
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

        /// <summary>
        /// EVN-3 - Date/Time Planned Event.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public TS DateTimePlannedEvent()
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

        /// <summary>
        /// EVN-4 - Event Reason Code.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public IS EventReasonCode()
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

        /// <summary>
        /// EVN-5 - Operator ID.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XCN OperatorID(int numRepetition)
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
        /// EVN-5 - Operator ID.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XCN[] OperatorID()
        {
            XCN[] ret = null;

            try
            {
                IType[] reps = this.GetField(5);
                ret          = new XCN[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as XCN;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// EVN-6 - Event Occurred.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public TS EventOccurred()
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

        /// <summary>
        /// EVN-7 - Event Facility.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public HD EventFacility()
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
