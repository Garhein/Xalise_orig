using System;
using System.Linq;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Composite;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.Segment
{
    /// <summary>
    /// Patient Identification.
    /// Le segment PID est utilisé par toutes les applications comme principal moyen de communication des informations d'identification du patient.
    /// Ce segment contient des informations permanentes d'identification du patient et démographiques qui, pour la plupart, ne sont pas susceptibles de changer fréquemment.
    /// </summary>
    [Serializable]
    public class PID : AbstractSegment
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        public PID()
        {
            this.InitField(typeof(SI), "Set ID", 4, 1, false);
            this.InitField(typeof(CX), "Patient ID", 20, 1, false);
            this.InitField(typeof(CX), "Patient Identifier List", 250, 0, true);
            this.InitField(typeof(CX), "Alternate Patient ID", 20, 0, false);
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
            this.InitField(typeof(ST), "SSN Number", 16, 1, false);
            this.InitField(typeof(DLN), "Driver's License Number", 25, 1, false);
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
        /// PID-1
        /// Set ID.
        /// </summary>
        public SI SetID
        {
            get
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
        }

        /// <summary>
        /// PID-2
        /// Patient ID.
        /// </summary>
        public CX PatientID
        {
            get
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
        }

        /// <summary>
        /// PID-3
        /// Patient Identifier List.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public CX GetPatientIdentifierList(int numRepetition)
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
        /// PID-3
        /// Récupère la première répétition du champ.
        /// </summary>
        public CX PatientIdentifierList
        {
            get
            {
                return this.GetPatientIdentifierList(1);
            }
        }

        /// <summary>
        /// PID-3
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CX[] GetAllPatientIdentifierList
        {
            get
            {
                CX[] ret = null;

                try
                {
                    ret = this.GetField(3).Cast<CX>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-4
        /// Alternate Patient ID.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public CX GetAlternatePatientID(int numRepetition)
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
        /// PID-4
        /// Récupère la première répétition du champ.
        /// </summary>
        public CX AlternatePatientID
        {
            get
            {
                return this.GetAlternatePatientID(1);
            }
        }

        /// <summary>
        /// PID-4
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public CX[] GetAllAlternatePatientID
        {
            get
            {
                CX[] ret = null;

                try
                {
                    ret = this.GetField(4).Cast<CX>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-5
        /// Patient Name.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public XPN GetPatientName(int numRepetition)
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
        /// PID-5
        /// Récupère la première répétition du champ.
        /// </summary>
        public XPN PatientName
        {
            get
            {
                return this.GetPatientName(1);
            }
        }

        /// <summary>
        /// PID-5
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public XPN[] GetAllPatientName
        {
            get
            {
                XPN[] ret = null;

                try
                {
                    ret = this.GetField(5).Cast<XPN>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-6
        /// Mother's Maiden Name.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public XPN GetMothersMaidenName(int numRepetition)
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
        /// PID-6
        /// Récupère la première répétition du champ.
        /// </summary>
        public XPN MothersMaidenName
        {
            get
            {
                return this.GetMothersMaidenName(1);
            }
        }

        /// <summary>
        /// PID-6
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public XPN[] GetAllMothersMaidenName
        {
            get
            {
                XPN[] ret = null;

                try
                {
                    ret = this.GetField(6).Cast<XPN>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-7
        /// Date/Time of Birth.
        /// </summary>
        public TS DateTimeBirth
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
        /// PID-8
        /// Administrative Sex.
        /// </summary>
        public IS AdministrativeSex
        {
            get
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
        }

        /// <summary>
        /// PID-9
        /// Patient Alias.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public XPN GetPatientAlias(int numRepetition)
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
        /// PID-9
        /// Récupère la première répétition du champ.
        /// </summary>
        public XPN PatientAlias
        {
            get
            {
                return this.GetPatientAlias(1);
            }
        }

        /// <summary>
        /// PID-9
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public XPN[] GetAllPatientAlias
        {
            get
            {
                XPN[] ret = null;

                try
                {
                    ret = this.GetField(9).Cast<XPN>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-10
        /// Race.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public CE GetRace(int numRepetition)
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
        /// PID-10
        /// Récupère la première répétition du champ.
        /// </summary>
        public CE Race
        {
            get
            {
                return this.GetRace(1);
            }
        }

        /// <summary>
        /// PID-10
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public CE[] GetAllRace
        {
            get
            {
                CE[] ret = null;

                try
                {
                    ret = this.GetField(10).Cast<CE>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-11
        /// Patient Address.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public XAD GetPatientAddress(int numRepetition)
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
        /// PID-11
        /// Récupère la première répétition du champ.
        /// </summary>
        public XAD PatientAddress
        {
            get
            {
                return this.GetPatientAddress(1);
            }
        }

        /// <summary>
        /// PID-11
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XAD[] GetAllPatientAddress
        {
            get
            {
                XAD[] ret = null;

                try
                {
                    ret = this.GetField(11).Cast<XAD>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-12
        /// County Code.
        /// </summary>
        public IS CountyCode
        {
            get
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
        }

        /// <summary>
        /// PID-13
        /// Phone Number - Home.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public XTN GetPhoneNumberHome(int numRepetition)
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
        /// PID-13
        /// Récupère la première répétition du champ.
        /// </summary>
        public XTN PhoneNumberHome
        {
            get
            {
                return this.GetPhoneNumberHome(1);
            }
        }

        /// <summary>
        /// PID-13
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public XTN[] GetAllPhoneNumberHome
        {
            get
            {
                XTN[] ret = null;

                try
                {
                    ret = this.GetField(13).Cast<XTN>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-14
        /// Phone Number - Business.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public XTN GetPhoneNumberBusiness(int numRepetition)
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
        /// PID-14
        /// Récupère la première répétition du champ.
        /// </summary>
        public XTN PhoneNumberBusiness
        {
            get
            {
                return this.GetPhoneNumberBusiness(1);
            }
        }

        /// <summary>
        /// PID-14
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public XTN[] GetAllPhoneNumberBusiness
        {
            get
            {
                XTN[] ret = null;

                try
                {
                    ret = this.GetField(14).Cast<XTN>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-15
        /// Primary Language.
        /// </summary>
        public CE PrimaryLanguage
        {
            get
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
        }

        /// <summary>
        /// PID-16
        /// Marital Status.
        /// </summary>
        public CE MaritalStatus
        {
            get
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
        }

        /// <summary>
        /// PID-17
        /// Religion.
        /// </summary>
        public CE Religion
        {
            get
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
        }

        /// <summary>
        /// PID-18
        /// Patient Account Number.
        /// </summary>
        public CX PatientAccountNumber
        {
            get
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
        }

        /// <summary>
        /// PID-19
        /// SSN Number.
        /// </summary>
        public ST SSNNumber
        {
            get
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
        }

        /// <summary>
        /// PID-20
        /// Driver's License Number.
        /// </summary>
        public DLN DriversLicenseNumber
        {
            get
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
        }

        /// <summary>
        /// PID-21
        /// Mother's Identifier.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public CX GetMothersIdentifier(int numRepetition)
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
        /// PID-21
        /// Récupère la première répétition du champ.
        /// </summary>
        public CX MothersIdentifier
        {
            get
            {
                return this.GetMothersIdentifier(1);
            }
        }

        /// <summary>
        /// PID-21
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public CX[] GetAllMothersIdentifier
        {
            get
            {
                CX[] ret = null;

                try
                {
                    ret = this.GetField(21).Cast<CX>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-22
        /// Ethnic Group.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public CE GetEthnicGroup(int numRepetition)
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
        /// PID-22
        /// Récupère la première répétition du champ.
        /// </summary>
        public CE EthnicGroup
        {
            get
            {
                return this.GetEthnicGroup(1);
            }
        }

        /// <summary>
        /// PID-22
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public CE[] GetAllEthnicGroup
        {
            get
            {
                CE[] ret = null;

                try
                {
                    ret = this.GetField(22).Cast<CE>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-23
        /// Birth Place.
        /// </summary>
        public ST BirthPlace
        {
            get
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
        }

        /// <summary>
        /// PID-24
        /// Multiple Birth Indicator.
        /// </summary>
        public ID MultipleBirthIndicator
        {
            get
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
        }

        /// <summary>
        /// PID-25
        /// Birth Order.
        /// </summary>
        public NM BirthOrder
        {
            get
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
        }

        /// <summary>
        /// PID-26
        /// Citizenship.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public CE GetCitizenship(int numRepetition)
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
        /// PID-26
        /// Récupère la première répétition du champ.
        /// </summary>
        public CE Citizenship
        {
            get
            {
                return this.GetCitizenship(1);
            }
        }

        /// <summary>
        /// PID-26
        /// Citizenship.
        /// </summary>
        /// <returns></returns>
        public CE[] GetAllCitizenship
        {
            get
            {
                CE[] ret = null;

                try
                {
                    ret = this.GetField(26).Cast<CE>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-27
        /// Veterans Military Status.
        /// </summary>
        public CE VeteransMilitaryStatus
        {
            get
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
        }

        /// <summary>
        /// PID-28
        /// Nationality.
        /// </summary>
        public CE Nationality
        {
            get
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
        }

        /// <summary>
        /// PID-29
        /// Patient Death Date and Time.
        /// </summary>
        public TS PatientDeathDateTime
        {
            get
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
        }

        /// <summary>
        /// PID-30
        /// Patient Death Indicator.
        /// </summary>
        public ID PatientDeathIndicator
        {
            get
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
        }

        /// <summary>
        /// PID-31
        /// Identity Unknown Indicator.
        /// </summary>
        public ID IdentityUnknownIndicator
        {
            get
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
        }

        /// <summary>
        /// PID-32
        /// Identity Reliability Code.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public IS GetIdentityReliabilityCode(int numRepetition)
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
        /// PID-32
        /// Récupère la première répétition du champ.
        /// </summary>
        public IS IdentityReliabilityCode
        {
            get
            {
                return this.GetIdentityReliabilityCode(1);
            }
        }

        /// <summary>
        /// PID-32
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public IS[] GetAllIdentityReliabilityCode
        {
            get
            {
                IS[] ret = null;

                try
                {
                    ret = this.GetField(32).Cast<IS>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-33
        /// Last Update Date/Time.
        /// </summary>
        public TS LastUpdateDateTime
        {
            get
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
        }

        /// <summary>
        /// PID-34
        /// Last Update Facility.
        /// </summary>
        public HD LastUpdateFacility
        {
            get
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
        }

        /// <summary>
        /// PID-35
        /// Species Code.
        /// </summary>
        public CE SpeciesCode
        {
            get
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
        }

        /// <summary>
        /// PID-36
        /// Breed Code.
        /// </summary>
        public CE BreedCode
        {
            get
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
        }

        /// <summary>
        /// PID-37
        /// Strain.
        /// </summary>
        public ST Strain
        {
            get
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
        }

        /// <summary>
        /// PID-38
        /// Production Class Code.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public CE GetProductionClassCode(int numRepetition)
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
        /// PID-38
        /// Récupère la première répétition du champ.
        /// </summary>
        public CE ProductionClassCode
        {
            get
            {
                return this.GetProductionClassCode(1);
            }
        }

        /// <summary>
        /// PID-38
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public CE[] GetAllProductionClassCode
        {
            get
            {
                CE[] ret = null;

                try
                {
                    ret = this.GetField(38).Cast<CE>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// PID-39
        /// Tribal Citizenship.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public CWE GetTribalCitizenship(int numRepetition)
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
        /// PID-39
        /// Récupère la première répétition du champ.
        /// </summary>
        public CWE TribalCitizenship
        {
            get
            {
                return this.GetTribalCitizenship(1);
            }
        }

        /// <summary>
        /// PID-39
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public CWE[] GetAllTribalCitizenship
        {
            get
            {
                CWE[] ret = null;

                try
                {
                    ret = this.GetField(39).Cast<CWE>().ToArray();
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
