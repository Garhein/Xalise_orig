using System;
using System.Linq;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Composite;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.Segment
{
    /// <summary>
    /// Role.
    /// Le segment de rôle contient les données nécessaires pour ajouter, mettre à jour, corriger et supprimer de l'enregistrement les personnes impliquées, ainsi que leur implication fonctionnelle dans l'activité transmise.
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
        /// ROL-1
        /// Role Instance ID.
        /// </summary>
        public EI RoleInstanceID
        {
            get
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
        }

        /// <summary>
        /// ROL-2
        /// Action Code.
        /// </summary>
        public ID ActionCode
        {
            get
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
        }

        /// <summary>
        /// ROL-3
        /// Role-ROL.
        /// </summary>
        public CE RoleROL
        {
            get
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
        }

        /// <summary>
        /// ROL-4
        /// Role Person.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public XCN GetRolePerson(int numRepetition)
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
        /// ROL-4
        /// Récupère la première répétition du champ.
        /// </summary>
        public XCN RolePerson
        {
            get
            {
                return this.GetRolePerson(1);
            }
        }

        /// <summary>
        /// ROL-4
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public XCN[] GetAllRolePerson
        {
            get
            {
                XCN[] ret = null;

                try
                {
                    ret = this.GetField(4).Cast<XCN>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// ROL-5
        /// Role Begin Date/Time.
        /// </summary>
        public TS RoleBeginDateTime
        {
            get
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
        }

        /// <summary>
        /// ROL-6
        /// Role End Date/Time.
        /// </summary>
        public TS RoleEndDateTime
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
        /// ROL-7
        /// Role Duration.
        /// </summary>
        public CE RoleDuration
        {
            get
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
        }

        /// <summary>
        /// ROL-8
        /// Role Action Reason.
        /// </summary>
        public CE RoleActionReason
        {
            get
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
        }

        /// <summary>
        /// ROL-9
        /// Provider Type.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public CE GetProviderType(int numRepetition)
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
        /// ROL-9
        /// Récupère la première répétition du champ.
        /// </summary>
        public CE ProviderType
        {
            get
            {
                return this.GetProviderType(1);
            }
        }

        /// <summary>
        /// ROL-9
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public CE[] GetAllProviderType
        {
            get
            {
                CE[] ret = null;

                try
                {
                    ret = this.GetField(9).Cast<CE>().ToArray();
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// ROL-10
        /// Organization Unit Type.
        /// </summary>
        public CE OrganizationUnitType
        {
            get
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
        }

        /// <summary>
        /// ROL-11
        /// Office/Home Address/Birthplace.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public XAD GetOfficeHomeAddressBirthplace(int numRepetition)
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
        /// ROL-11
        /// Récupère la première répétition du champ.
        /// </summary>
        public XAD OfficeHomeAddressBirthplace
        {
            get
            {
                return this.GetOfficeHomeAddressBirthplace(1);
            }
        }

        /// <summary>
        /// ROL-11
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public XAD[] GetAllOfficeHomeAddressBirthplace
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
        /// SFT-12
        /// Phone.
        /// </summary>
        /// <param name="numRepetition">Index de la répétition à récupérer.</param>
        /// <returns></returns>
        public XTN GetPhone(int numRepetition)
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
        /// SFT-12
        /// Récupère la première répétition du champ.
        /// </summary>
        public XTN Phone
        {
            get
            {
                return this.GetPhone(1);
            }
        }

        /// <summary>
        /// SFT-12
        /// Récupère l'ensemble des répétitions.
        /// </summary>
        /// <returns></returns>
        public XTN[] GetAllPhone
        {
            get
            {
                XTN[] ret = null;

                try
                {
                    ret = this.GetField(12).Cast<XTN>().ToArray();
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
