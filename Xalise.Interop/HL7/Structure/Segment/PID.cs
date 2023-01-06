using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Composite;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.Segment
{
    /// <summary>
    /// PID - Patient Identification
    /// </summary>
    [Serializable]
    public class PID : AbstractSegment
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        public PID()
        {
            this.InitField(typeof(SI), "Set ID - PID", 4, 1, false);
            this.InitField(typeof(CX), "Patient ID", 20, 1, false);
            this.InitField(typeof(CX), "Patient Identifier List", 250, 0, true);
            this.InitField(typeof(CX), "Alternate Patient ID - PID", 20, 0, false);
            this.InitField(typeof(XPN), "Patient Name", 250, 0, true);
            this.InitField(typeof(XPN), "Mother's Maiden Name", 250, 0, false);
            this.InitField(typeof(TS), "Date/Time of Birth", 26, 1, false);
            this.InitField(typeof(IS), "Administrative Sex", 1, 1, false);
            this.InitField(typeof(XPN), "Patient Alias", 250, 0, false);
            this.InitField(typeof(CE), "Race", 250, 0, false);
            this.InitField(typeof(XAD), "Patient Address", 250, 0, false);
            this.InitField(typeof(IS), "County Code", 4, 1, false);
            this.InitField(typeof(XTN), "Phone Number - Home", 250, 0, false);
            this.InitField(typeof(XTN), "Phone Number - Business", 250, 0, false);
            this.InitField(typeof(CE), "Primary Language", 250, 1, false);
            this.InitField(typeof(CE), "Marital Status", 250, 1, false);
            this.InitField(typeof(CE), "Religion", 250, 1, false);
            this.InitField(typeof(CX), "Patient Account Number", 250, 1, false);
            this.InitField(typeof(ST), "SSN Number - Patient", 16, 1, false);
            this.InitField(typeof(DLN), "Driver's License Number - Patient", 25, 1, false);
            this.InitField(typeof(CX), "Mother's Identifier", 250, 0, false);
            this.InitField(typeof(CE), "Ethnic Group", 250, 0, false);
            this.InitField(typeof(ST), "Birth Place", 250, 1, false);
            this.InitField(typeof(ID), "Multiple Birth Indicator", 1, 1, false);
            this.InitField(typeof(NM), "Birth Order", 2, 1, false);
            this.InitField(typeof(CE), "Citizenship", 250, 0, false);
            this.InitField(typeof(CE), "Veterans Military Status", 250, 1, false);
            this.InitField(typeof(CE), "Nationality", 250, 1, false);
            this.InitField(typeof(TS), "Patient Death Date and Time", 26, 1, false);
            this.InitField(typeof(ID), "Patient Death Indicator", 1, 1, false);
            this.InitField(typeof(ID), "Identity Unknown Indicator", 1, 1, false);
            this.InitField(typeof(IS), "Identity Reliability Code", 20, 0, false);
            this.InitField(typeof(TS), "Last Update Date/Time", 26, 1, false);
            this.InitField(typeof(HD), "Last Update Facility", 241, 1, false);
            this.InitField(typeof(CE), "Species Code", 250, 1, false);
            this.InitField(typeof(CE), "Breed Code", 250, 1, false);
            this.InitField(typeof(ST), "Strain", 80, 1, false);
            this.InitField(typeof(CE), "Production Class Code", 250, 2, false);
            this.InitField(typeof(CWE), "Tribal Citizenship", 250, 0, false);
        }

        /// <summary>
        /// PID-1 - Set ID - PID.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public SI SetIDPID()
        {
            SI ret = null;

            try
            {
                ret = this.GetField(1, 1) as SI;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-2 - Patient ID.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CX PatientID()
        {
            CX ret = null;

            try
            {
                ret = this.GetField(2, 1) as CX;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-3 - Patient Identifier List.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CX PatientIdentifierList(int numRepetition)
        {
            CX ret = null;

            try
            {
                ret = this.GetField(3, numRepetition) as CX;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-3 - Patient Identifier List.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CX[] PatientIdentifierList()
        {
            CX[] ret = null;

            try
            {
                IType[] reps = this.GetField(3);
                ret          = new CX[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as CX;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-4 - Alternate Patient ID - PID.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CX AlternatePatientIDPID(int numRepetition)
        {
            CX ret = null;

            try
            {
                ret = this.GetField(4, numRepetition) as CX;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-4 - Alternate Patient ID - PID.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CX[] AlternatePatientIDPID()
        {
            CX[] ret = null;

            try
            {
                IType[] reps = this.GetField(4);
                ret          = new CX[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as CX;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-5 - Patient Name.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XPN PatientName(int numRepetition)
        {
            XPN ret = null;

            try
            {
                ret = this.GetField(5, numRepetition) as XPN;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-5 - Patient Name.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XPN[] PatientName()
        {
            XPN[] ret = null;

            try
            {
                IType[] reps = this.GetField(5);
                ret          = new XPN[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as XPN;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-6 - Mother's Maiden Name.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XPN MothersMaidenName(int numRepetition)
        {
            XPN ret = null;

            try
            {
                ret = this.GetField(6, numRepetition) as XPN;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-6 - Mother's Maiden Name.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XPN[] MothersMaidenName()
        {
            XPN[] ret = null;

            try
            {
                IType[] reps = this.GetField(6);
                ret          = new XPN[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as XPN;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-7 - Date/Time of Birth.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public TS DateTimeBirth()
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
        /// PID-8 - Administrative Sex.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public IS AdministrativeSex()
        {
            IS ret = null;

            try
            {
                ret = this.GetField(8, 1) as IS;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-9 - Patient Alias.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XPN PatientAlias(int numRepetition)
        {
            XPN ret = null;

            try
            {
                ret = this.GetField(9, numRepetition) as XPN;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-9 - Patient Alias.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XPN[] PatientAlias()
        {
            XPN[] ret = null;

            try
            {
                IType[] reps = this.GetField(9);
                ret          = new XPN[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as XPN;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-10 - Race.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CE Race(int numRepetition)
        {
            CE ret = null;

            try
            {
                ret = this.GetField(10, numRepetition) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-10 - Race.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CE[] Race()
        {
            CE[] ret = null;

            try
            {
                IType[] reps = this.GetField(10);
                ret          = new CE[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as CE;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-11 - Patient Address.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XAD PatientAddress(int numRepetition)
        {
            XAD ret = null;

            try
            {
                ret = this.GetField(11, numRepetition) as XAD;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-11 - Patient Address.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XAD[] PatientAddress()
        {
            XAD[] ret = null;

            try
            {
                IType[] reps = this.GetField(11);
                ret          = new XAD[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as XAD;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-12 - County Code.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public IS CountyCode()
        {
            IS ret = null;

            try
            {
                ret = this.GetField(12, 1) as IS;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-13 - Phone Number - Home.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XTN PhoneNumberHome(int numRepetition)
        {
            XTN ret = null;

            try
            {
                ret = this.GetField(13, numRepetition) as XTN;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-13 - Phone Number - Home.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XTN[] PhoneNumberHome()
        {
            XTN[] ret = null;

            try
            {
                IType[] reps = this.GetField(13);
                ret          = new XTN[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as XTN;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-14 - Phone Number - Business.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XTN PhoneNumberBusiness(int numRepetition)
        {
            XTN ret = null;

            try
            {
                ret = this.GetField(14, numRepetition) as XTN;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-14 - Phone Number - Business.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XTN[] PhoneNumberBusiness()
        {
            XTN[] ret = null;

            try
            {
                IType[] reps = this.GetField(14);
                ret          = new XTN[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as XTN;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-15 - Primary Language.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CE PrimaryLanguage()
        {
            CE ret = null;

            try
            {
                ret = this.GetField(15, 1) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-16 - Marital Status.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CE MaritalStatus()
        {
            CE ret = null;

            try
            {
                ret = this.GetField(16, 1) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-17 - Religion.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CE Religion()
        {
            CE ret = null;

            try
            {
                ret = this.GetField(17, 1) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-18 - Patient Account Number.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CX PatientAccountNumber()
        {
            CX ret = null;

            try
            {
                ret = this.GetField(18, 1) as CX;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-19 - SSN Number - Patient.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ST SSNNumberPatient()
        {
            ST ret = null;

            try
            {
                ret = this.GetField(19, 1) as ST;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-20 - Driver's License Number - Patient.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public DLN DriversLicenseNumberPatient()
        {
            DLN ret = null;

            try
            {
                ret = this.GetField(20, 1) as DLN;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-21 - Mother's Identifier.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CX MothersIdentifier(int numRepetition)
        {
            CX ret = null;

            try
            {
                ret = this.GetField(21, numRepetition) as CX;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-21 - Mother's Identifier.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CX[] MothersIdentifier()
        {
            CX[] ret = null;

            try
            {
                IType[] reps = this.GetField(21);
                ret          = new CX[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as CX;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-22 - Ethnic Group.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CE EthnicGroup(int numRepetition)
        {
            CE ret = null;

            try
            {
                ret = this.GetField(22, numRepetition) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-22 - Ethnic Group.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CE[] EthnicGroup()
        {
            CE[] ret = null;

            try
            {
                IType[] reps = this.GetField(22);
                ret          = new CE[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as CE;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-23 - Birth Place.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ST BirthPlace()
        {
            ST ret = null;

            try
            {
                ret = this.GetField(23, 1) as ST;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-24 - Multiple Birth Indicator.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ID MultipleBirthIndicator()
        {
            ID ret = null;

            try
            {
                ret = this.GetField(24, 1) as ID;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-25 - Birth Order.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public NM BirthOrder()
        {
            NM ret = null;

            try
            {
                ret = this.GetField(25, 1) as NM;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-26 - Citizenship.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CE Citizenship(int numRepetition)
        {
            CE ret = null;

            try
            {
                ret = this.GetField(26, numRepetition) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-26 - Citizenship.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CE[] Citizenship()
        {
            CE[] ret = null;

            try
            {
                IType[] reps = this.GetField(26);
                ret          = new CE[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as CE;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-27 - Veterans Military Status.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CE VeteransMilitaryStatus()
        {
            CE ret = null;

            try
            {
                ret = this.GetField(27, 1) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-28 - Nationality.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CE Nationality()
        {
            CE ret = null;

            try
            {
                ret = this.GetField(28, 1) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-29 - Patient Death Date and Time.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public TS PatientDeathDateTime()
        {
            TS ret = null;

            try
            {
                ret = this.GetField(29, 1) as TS;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-30 - Patient Death Indicator.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ID PatientDeathIndicator()
        {
            ID ret = null;

            try
            {
                ret = this.GetField(30, 1) as ID;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-31 - Identity Unknown Indicator.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ID IdentityUnknownIndicator()
        {
            ID ret = null;

            try
            {
                ret = this.GetField(31, 1) as ID;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-32 - Identity Reliability Code.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public IS IdentityReliabilityCode(int numRepetition)
        {
            IS ret = null;

            try
            {
                ret = this.GetField(32, numRepetition) as IS;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-32 - Identity Reliability Code.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public IS[] IdentityReliabilityCode()
        {
            IS[] ret = null;

            try
            {
                IType[] reps = this.GetField(32);
                ret          = new IS[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as IS;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-33 - Last Update Date/Time.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public TS LastUpdateDateTime()
        {
            TS ret = null;

            try
            {
                ret = this.GetField(33, 1) as TS;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-34 - Last Update Facility.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public HD LastUpdateFacility()
        {
            HD ret = null;

            try
            {
                ret = this.GetField(34, 1) as HD;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-35 - Species Code.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CE SpeciesCode()
        {
            CE ret = null;

            try
            {
                ret = this.GetField(35, 1) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-36 - Breed Code.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CE BreedCode()
        {
            CE ret = null;

            try
            {
                ret = this.GetField(36, 1) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-37 - Strain.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ST Strain()
        {
            ST ret = null;

            try
            {
                ret = this.GetField(37, 1) as ST;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-38 - Production Class Code.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CE ProductionClassCode(int numRepetition)
        {
            CE ret = null;

            try
            {
                ret = this.GetField(38, numRepetition) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-38 - Production Class Code.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CE[] ProductionClassCode()
        {
            CE[] ret = null;

            try
            {
                IType[] reps = this.GetField(38);
                ret          = new CE[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as CE;
                }
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-39 - Tribal Citizenship.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CWE TribalCitizenship(int numRepetition)
        {
            CWE ret = null;

            try
            {
                ret = this.GetField(39, numRepetition) as CWE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// PID-39 - Tribal Citizenship.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CWE[] TribalCitizenship()
        {
            CWE[] ret = null;

            try
            {
                IType[] reps = this.GetField(39);
                ret          = new CWE[reps.Length];

                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = reps[i] as CWE;
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
