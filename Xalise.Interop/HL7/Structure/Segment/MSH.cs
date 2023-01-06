using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Composite;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.Segment
{
    /// <summary>
    /// MSH - Message Header.
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
        /// MSH-1 - Field Separator.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ST FieldSeparator()
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

        /// <summary>
        /// MSH-2 - Encoding Characters.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ST EncodingCharacters()
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

        /// <summary>
        /// MSH-3 - Sending Application.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public HD SendingApplication()
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

        /// <summary>
        /// MSH-4 - Sending Facility.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public HD SendingFacility()
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

        /// <summary>
        /// MSH-5 - Receiving Application.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public HD ReceivingApplication()
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

        /// <summary>
        /// MSH-6 - Receiving Facility.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public HD ReceivingFacility()
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

        /// <summary>
        /// MSH-7 - Date/Time Of Message.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public TS DateTimeOfMessage()
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

        /// <summary>
        /// MSH-8 - Security.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ST Security()
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

        /// <summary>
        /// MSH-9 - Message Type.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public MSG MessageType()
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

        /// <summary>
        /// MSH-10 - Message Control ID.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ST MessageControlID()
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

        /// <summary>
        /// MSH-11 - Processing ID.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public PT ProcessingID()
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

        /// <summary>
        /// MSH-12 - Version ID.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public VID VersionID()
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

        /// <summary>
        /// MSH-13 - Sequence Number.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public NM SequenceNumber()
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

        /// <summary>
        /// MSH-14 - Continuation Pointer.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ST ContinuationPointer()
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

        /// <summary>
        /// MSH-15 - Accept Acknowledgment Type.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ID AcceptAcknowledgmentType()
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

        /// <summary>
        /// MSH-16 - Application Acknowledgment Type.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ID ApplicationAcknowledgmentType()
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

        /// <summary>
        /// MSH-17 - Country Code.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ID CountryCode()
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

        /// <summary>
        /// MSH-18 - Character Set.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public ID CharacterSet(int numRepetition)
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
        /// MSH-18 - Character Set.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public ID[] CharacterSet()
        {
            ID[] ret = null;

            try
            {
                IType[] reps = this.GetField(18);
                ret = new ID[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as ID;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// MSH-19 - Principal Language Of Message.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CE PrincipalLanguageOfMessage()
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

        /// <summary>
        /// MSH-20 - Alternate Character Set Handling Scheme.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ID AlternateCharacterSetHandlingScheme()
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

        /// <summary>
        /// MSH-21 - Message Profile Identifier.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public EI MessageProfileIdentifier(int numRepetition)
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
        /// MSH-21 - Message Profile Identifier.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public EI[] MessageProfileIdentifier()
        {
            EI[] ret = null;

            try
            {
                IType[] reps = this.GetField(21);
                ret          = new EI[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as EI;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }
    }
}
