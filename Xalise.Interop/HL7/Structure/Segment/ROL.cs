using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Composite;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.Segment
{
    /// <summary>
    /// ROL - Role
    /// </summary>
    [Serializable]
    public class ROL : AbstractSegment
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        public ROL()
        {
            this.InitField(typeof(EI), "Role Instance ID", 60, 1, false);
            this.InitField(typeof(ID), "Action Code", 2, 1, true);
            this.InitField(typeof(CE), "Role-ROL", 250, 1, true);
            this.InitField(typeof(XCN), "Role Person", 250, 0, true);
            this.InitField(typeof(TS), "Role Begin Date/Time", 26, 1, false);
            this.InitField(typeof(TS), "Role End Date/Time", 26, 1, false);
            this.InitField(typeof(CE), "Role Duration", 250, 1, false);
            this.InitField(typeof(CE), "Role Action Reason", 250, 1, false);
            this.InitField(typeof(CE), "Provider Type", 250, 0, false);
            this.InitField(typeof(CE), "Organization Unit Type", 250, 1, false);
            this.InitField(typeof(XAD), "Office/Home Address/Birthplace", 250, 0, false);
            this.InitField(typeof(XTN), "Phone", 250, 0, false);
        }

        /// <summary>
        /// ROL-1 - Role Instance ID.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public EI RoleInstanceID()
        {
            EI ret = null;

            try
            {
                ret = this.GetField(1, 1) as EI;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// ROL-2 - Action Code.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ID ActionCode()
        {
            ID ret = null;

            try
            {
                ret = this.GetField(2, 1) as ID;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// ROL-3 - Role-ROL.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CE RoleROL()
        {
            CE ret = null;

            try
            {
                ret = this.GetField(3, 1) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// ROL-4 - Role Person.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XCN RolePerson(int numRepetition)
        {
            XCN ret = null;

            try
            {
                ret = this.GetField(4, numRepetition) as XCN;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// ROL-4 - Role Person.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XCN[] RolePerson()
        {
            XCN[] ret = null;

            try
            {
                IType[] reps = this.GetField(4);
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
        /// ROL-5 - Role Begin Date/Time.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public TS RoleBeginDateTime()
        {
            TS ret = null;

            try
            {
                ret = this.GetField(5, 1) as TS;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// ROL-6 - Role End Date/Time.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public TS RoleEndDateTime()
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
        /// ROL-7 - Role Duration.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CE RoleDuration()
        {
            CE ret = null;

            try
            {
                ret = this.GetField(7, 1) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// ROL-8 - Role Action Reason.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CE RoleActionReason()
        {
            CE ret = null;

            try
            {
                ret = this.GetField(8, 1) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// ROL-9 - Provider Type.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CE ProviderType(int numRepetition)
        {
            CE ret = null;

            try
            {
                ret = this.GetField(9, numRepetition) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// ROL-9 - Provider Type.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public CE[] ProviderType()
        {
            CE[] ret = null;

            try
            {
                IType[] reps = this.GetField(9);
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
        /// ROL-10 - Organization Unit Type.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public CE OrganizationUnitType()
        {
            CE ret = null;

            try
            {
                ret = this.GetField(10, 1) as CE;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// ROL-11 - Office/Home Address/Birthplace.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XAD OfficeHomeAddressBirthplace(int numRepetition)
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
        /// ROL-11 - Office/Home Address/Birthplace.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XAD[] OfficeHomeAddressBirthplace()
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
        /// SFT-12 - Phone.
        /// </summary>
        /// <param name="numRepetition">Numéro de la répétition.</param>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XTN Phone(int numRepetition)
        {
            XTN ret = null;

            try
            {
                ret = this.GetField(12, numRepetition) as XTN;
            }
            catch (SegmentException)
            {
                throw;
            }

            return ret;
        }

        /// <summary>
        /// SFT-12 - Phone.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        /// <returns></returns>
        public XTN[] Phone()
        {
            XTN[] ret = null;

            try
            {
                IType[] reps = this.GetField(12);
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
    }
}
