﻿using System;
using Xalise.Interop.HL7.Core;
using Xalise.Interop.HL7.Exceptions;
using Xalise.Interop.HL7.Structure.DataType.Composite;
using Xalise.Interop.HL7.Structure.DataType.Primitive;

namespace Xalise.Interop.HL7.Structure.Segment
{
    /// <summary>
    /// SFT - Software Segment.
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
        /// SFT-1 - Software Vendor Organization.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public XON SoftwareVendorOrganization()
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

        /// <summary>
        /// SFT-2 - Software Certified Version or Release Number.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ST SoftwareCertifiedVersionOrReleaseNumber()
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
        /// SFT-3 - Software Product Name.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ST SoftwareProductName()
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

        /// <summary>
        /// SFT-4 - Software Binary ID.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public ST SoftwareBinaryID()
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

        /// <summary>
        /// SFT-5 - Software Product Information.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public TX SoftwareProductInformation()
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

        /// <summary>
        /// SFT-6 - Software Install Date.
        /// </summary>
        /// <exception cref="SegmentException">Si erreur à l'accès au champ.</exception>
        public TS SoftwareInstallDate()
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
