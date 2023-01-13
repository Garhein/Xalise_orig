using System;
using System.Linq;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Structure.Segment;
using Xalise.Interop.HL7.Structure.Table;

namespace Xalise.Interop.HL7.Structure.Message
{
    /// <summary>
    /// Admit/Visit Notification.
    /// </summary>
    public class ADT_A01 : AbstractMessage
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="encodingChars">Séparateur de champ et caractères d'encodage utilisés pour le message.</param>
        public ADT_A01(EncodingCharacters encodingChars) : base(encodingChars)
        {
            this.InitMessageItem(typeof(MSH), "Message Header", 1, true);
            this.InitMessageItem(typeof(SFT), "Software Segment", 0, false);
            this.InitMessageItem(typeof(EVN), "Event Type", 1, true);
            this.InitMessageItem(typeof(PID), "Patient Identification", 1, true);
            this.InitMessageItem(typeof(ROL), "Role", 0, false);
            this.InitDefaultValues();
        }

        /// <summary>
        /// Initialisation des valeurs par défaut du message.
        /// </summary>
        public override void InitDefaultValues()
        {
            this.MSH.MessageType.MessageCode.Value      = T0076_MessageType.ADT.Value;
            this.MSH.MessageType.TriggerEvent.Value     = T003_EventType.A01.Value;
            this.MSH.MessageType.MessageStructure.Value = T0354_MessageStructure.ADT_A01.Value;
        }

        /// <summary>
        /// Segment <see cref="Segment.MSH"/>.
        /// </summary>
        /// <returns></returns>
        public MSH MSH
        {
            get
            {
                MSH ret = null;

                try
                {
                    ret = this.GetSegment("MSH", 1) as MSH;
                }
                catch (Exception)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// Récupère la première occurence du segment <see cref="Segment.SFT"/>.
        /// </summary>
        public SFT SFT
        {
            get
            {
                return this.GetSFT(1);
            }
        }

        /// <summary>
        /// Récupère une occurence précise du segment <see cref="Segment.SFT"/>.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public SFT GetSFT(int numRepetition)
        {
            SFT ret = null;

            try
            {
                ret = this.GetSegment("SFT", numRepetition) as SFT;
            }
            catch (Exception)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// Récupère l'ensemble des segments <see cref="Segment.SFT"/>.
        /// </summary>
        /// <returns></returns>
        public SFT[] GetAllSFT
        {
            get
            {
                SFT[] ret = null;

                try
                {
                    ret = this.GetStructure("SFT").ConvertRepetitionsToISegmentArray.Cast<SFT>().ToArray();
                }
                catch (Exception)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// Récupère le segment <see cref="Segment.EVN"/>.
        /// </summary>
        /// <returns></returns>
        public EVN EVN
        {
            get
            {
                EVN ret = null;

                try
                {
                    ret = this.GetSegment("EVN", 1) as EVN;
                }
                catch (Exception)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// Récupère le segment <see cref="Segment.PID"/>.
        /// </summary>
        /// <returns></returns>
        public PID PID
        {
            get
            {
                PID ret = null;

                try
                {
                    ret = this.GetSegment("PID", 1) as PID;
                }
                catch (Exception)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// Récupère la première occurence du segment <see cref="Segment.ROL"/>.
        /// </summary>
        public ROL ROL
        {
            get
            {
                return this.GetROL(1);
            }
        }

        /// <summary>
        /// Récupère une occurence précise du segment <see cref="Segment.ROL"/>.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public ROL GetROL(int numRepetition)
        {
            ROL ret = null;

            try
            {
                ret = this.GetSegment("ROL", numRepetition) as ROL;
            }
            catch (Exception)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// Récupère l'ensemble des segments <see cref="Segment.ROL"/>.
        /// </summary>
        /// <returns></returns>
        public ROL[] GetAllROL
        {
            get
            {
                ROL[] ret = null;

                try
                {
                    ret = this.GetStructure("ROL").ConvertRepetitionsToISegmentArray.Cast<ROL>().ToArray();
                }
                catch (Exception)
                {
                    throw;
                }

                return ret;
            }
        }
    }
}
