using System;
using System.Linq;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Composite;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.Segment
{
    /// <summary>
    /// Message Header.
    /// Le segment MSH définit l'intention, la source, la destination et certaines spécificités de la syntaxe d'un message.
    /// </summary>
    [Serializable]
    public class MSH : AbstractSegment
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        public MSH()
        {
            this.InitField(typeof(ST), "Field Separator", 1, 1, true);
            this.InitField(typeof(ST), "Encoding Characters", 4, 1, true);
            this.InitField(typeof(HD), "Sending Application", 227, 1, false);
            this.InitField(typeof(HD), "Sending Facility", 227, 1, false);
            this.InitField(typeof(HD), "Receiving Application", 227, 1, false);
            this.InitField(typeof(HD), "Receiving Facility", 227, 1, false);
            this.InitField(typeof(TS), "Date/Time Of Message", 26, 1, true);
            this.InitField(typeof(ST), "Security", 40, 1, false);
            this.InitField(typeof(MSG), "Message Type", 15, 1, true);
            this.InitField(typeof(ST), "Message Control ID", 20, 1, true);
            this.InitField(typeof(PT), "Processing ID", 3, 1, true);
            this.InitField(typeof(VID), "Version ID", 60, 1, true);
            this.InitField(typeof(NM), "Sequence Number", 15, 1, false);
            this.InitField(typeof(ST), "Continuation Pointer", 180, 1, false);
            this.InitField(typeof(ID), "Accept Acknowledgment Type", 2, 1, false);
            this.InitField(typeof(ID), "Application Acknowledgment Type", 2, 1, false);
            this.InitField(typeof(ID), "Country Code", 3, 1, false);
            this.InitField(typeof(ID), "Character Set", 16, 0, false);
            this.InitField(typeof(CE), "Principal Language Of Message", 250, 1, false);
            this.InitField(typeof(ID), "Alternate Character Set Handling Scheme", 20, 1, false);
            this.InitField(typeof(EI), "Message Profile Identifier", 427, 0, false);
        }

        /// <summary>
        /// MSH-1
        /// Field Separator. 
        /// </summary>
        public ST FieldSeparator
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this.GetField(1, 1) as ST;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-2
        /// Encoding Characters.
        /// </summary>
        public ST EncodingCharacters
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this.GetField(2, 1) as ST;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-3
        /// Sending Application.
        /// </summary>
        public HD SendingApplication
        {
            get
            {
                HD ret = null;

                try
                {
                    ret = this.GetField(3, 1) as HD;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-4
        /// Sending Facility.
        /// </summary>
        public HD SendingFacility
        {
            get
            {
                HD ret = null;

                try
                {
                    ret = this.GetField(4, 1) as HD;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-5
        /// Receiving Application.
        /// </summary>
        public HD ReceivingApplication
        {
            get
            {
                HD ret = null;

                try
                {
                    ret = this.GetField(5, 1) as HD;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-6
        /// Receiving Facility.
        /// </summary>
        public HD ReceivingFacility
        {
            get
            {
                HD ret = null;

                try
                {
                    ret = this.GetField(6, 1) as HD;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-7
        /// Date/Time Of Message.
        /// </summary>
        public TS DateTimeOfMessage
        {
            get
            {
                TS ret = null;

                try
                {
                    ret = this.GetField(7, 1) as TS;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-8
        /// Security.
        /// </summary>
        public ST Security
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this.GetField(8, 1) as ST;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-9
        /// Message Type.
        /// </summary>
        public MSG MessageType
        {
            get
            {
                MSG ret = null;

                try
                {
                    ret = this.GetField(9, 1) as MSG;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-10
        /// Message Control ID.
        /// </summary>
        public ST MessageControlID
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this.GetField(10, 1) as ST;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-11
        /// Processing ID.
        /// </summary>
        public PT ProcessingID
        {
            get
            {
                PT ret = null;

                try
                {
                    ret = this.GetField(11, 1) as PT;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-12
        /// Version ID.
        /// </summary>
        public VID VersionID
        {
            get
            {
                VID ret = null;

                try
                {
                    ret = this.GetField(12, 1) as VID;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-13
        /// Sequence Number.
        /// </summary>
        public NM SequenceNumber
        {
            get
            {
                NM ret = null;

                try
                {
                    ret = this.GetField(13, 1) as NM;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-14
        /// Continuation Pointer.
        /// </summary>
        public ST ContinuationPointer
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this.GetField(14, 1) as ST;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-15
        /// Accept Acknowledgment Type.
        /// </summary>
        public ID AcceptAcknowledgmentType
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this.GetField(15, 1) as ID;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-16
        /// Application Acknowledgment Type.
        /// </summary>
        public ID ApplicationAcknowledgmentType
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this.GetField(16, 1) as ID;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-17
        /// Country Code.
        /// </summary>
        public ID CountryCode
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this.GetField(17, 1) as ID;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-18
        /// Character Set.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public ID GetCharacterSet(int numRepetition)
        {
            ID ret = null;

            try
            {
                ret = this.GetField(18, numRepetition) as ID;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// MSH-18
        /// Récupère la première répétition du champ.
        /// </summary>
        public ID CharacterSet
        {
            get
            {
                return this.GetCharacterSet(1);
            }
        }

        /// <summary>
        /// MSH-18
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public ID[] GetAllCharacterSet
        {
            get
            {
                ID[] ret = null;

                try
                {
                    ret = this.GetField(18).Cast<ID>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-19
        /// Principal Language Of Message.
        /// </summary>
        public CE PrincipalLanguageOfMessage
        {
            get
            {
                CE ret = null;

                try
                {
                    ret = this.GetField(19, 1) as CE;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-20
        /// Alternate Character Set Handling Scheme.
        /// </summary>
        public ID AlternateCharacterSetHandlingScheme
        {
            get
            {
                ID ret = null;

                try
                {
                    ret = this.GetField(20, 1) as ID;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// MSH-21
        /// Message Profile Identifier.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public EI GetMessageProfileIdentifier(int numRepetition)
        {
            EI ret = null;

            try
            {
                ret = this.GetField(21, numRepetition) as EI;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// MSH-21
        /// Récupère la première répétition du champ.
        /// </summary>
        public EI MessageProfileIdentifier
        {
            get
            {
                return this.GetMessageProfileIdentifier(1);
            }
        }

        /// <summary>
        /// MSH-21
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public EI[] GetAllMessageProfileIdentifier
        {
            get
            {
                EI[] ret = null;

                try
                {
                    ret = this.GetField(21).Cast<EI>().ToArray();
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
