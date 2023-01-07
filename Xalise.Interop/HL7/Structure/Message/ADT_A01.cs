using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Structure.Segment;
using Xalise.Interop.HL7.Structure.Table;

namespace Xalise.Interop.HL7.Structure.Message
{
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public MSH MSH()
        {
            MSH ret = null;

            try
            {
                ret = this.GetSegment("MSH", 1)as MSH;
            }
            catch (Exception)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numRepetition"></param>
        /// <returns></returns>
        public SFT SFT(int numRepetition)
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
        /// 
        /// </summary>
        /// <returns></returns>
        public SFT[] SFT()
        {
            SFT[] ret = null;

            try
            {
                MessageItem item = this.GetStructure("SFT");
                ret              = new SFT[item.Repetitions.Count];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = item[i] as SFT;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public EVN EVN()
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public PID PID()
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numRepetition"></param>
        /// <returns></returns>
        public ROL ROL(int numRepetition)
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
        /// 
        /// </summary>
        /// <returns></returns>
        public ROL[] ROL()
        {
            ROL[] ret = null;

            try
            {
                MessageItem item = this.GetStructure("ROL");
                ret              = new ROL[item.Repetitions.Count];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = item[i] as ROL;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void InitDefaultValues()
        {
            this.MSH().MessageType().MessageCode.Value      = T0076_MessageType.ADT.Value;
            this.MSH().MessageType().TriggerEvent.Value     = T003_EventType.A01.Value;
            this.MSH().MessageType().MessageStructure.Value = T0354_MessageStructure.ADT_A01.Value;
        }
    }
}
