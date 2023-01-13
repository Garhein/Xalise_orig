using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Composite;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.Segment
{
    /// <summary>
    /// Software Segment.
    /// Ce segment fournit des informations supplémentaires sur le(s) produit(s) logiciel(s) utilisé(s) comme application d'envoi.
    /// L'objectif principal de ce segment est à des fins de diagnostic.
    /// Il peut y avoir des utilisations supplémentaires selon les accords spécifiques au site.
    /// </summary>
    [Serializable]
    public class SFT : AbstractSegment
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        public SFT()
        {
            this.InitField(typeof(XON), "Software Vendor Organization", 567, 1, true);
            this.InitField(typeof(ST), "Software Certified Version or Release Number", 15, 1, true);
            this.InitField(typeof(ST), "Software Product Name", 20, 1, true);
            this.InitField(typeof(ST), "Software Binary ID", 20, 1, true);
            this.InitField(typeof(TX), "Software Product Information", 1024, 1, false);
            this.InitField(typeof(TS), "Software Install Date", 26, 1, false);
        }

        /// <summary>
        /// SFT-1
        /// Software Vendor Organization.
        /// </summary>
        public XON SoftwareVendorOrganization
        {
            get
            {
                XON ret = null;

                try
                {
                    ret = this.GetField(1, 1) as XON;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// SFT-2
        /// Software Certified Version or Release Number.
        /// </summary>
        public ST SoftwareCertifiedVersionOrReleaseNumber
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
        /// SFT-3
        /// Software Product Name.
        /// </summary>
        public ST SoftwareProductName
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this.GetField(3, 1) as ST;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// SFT-4
        /// Software Binary ID.
        /// </summary>
        public ST SoftwareBinaryID
        {
            get
            {
                ST ret = null;

                try
                {
                    ret = this.GetField(4, 1) as ST;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// SFT-5
        /// Software Product Information.
        /// </summary>
        public TX SoftwareProductInformation
        {
            get
            {
                TX ret = null;

                try
                {
                    ret = this.GetField(5, 1) as TX;
                }
                catch (SegmentException)
                {
                    throw;
                }

                return ret;
            }
        }

        /// <summary>
        /// SFT-6
        /// Software Install Date.
        /// </summary>
        public TS SoftwareInstallDate
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
    }
}
