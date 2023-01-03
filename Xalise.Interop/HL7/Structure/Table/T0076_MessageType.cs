using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0076 - Message type.
    /// </summary>
    [Serializable]
    public class T0076_MessageType : AbstractTable
    {
        public static T0076_MessageType ACK = new T0076_MessageType("ACK", "General acknowledgment message");
        public static T0076_MessageType ADR = new T0076_MessageType("ADR", "ADT response");
        public static T0076_MessageType ADT = new T0076_MessageType("ADT", "ADT message");
        public static T0076_MessageType BAR = new T0076_MessageType("BAR", "Add/change billing account");
        public static T0076_MessageType BPS = new T0076_MessageType("BPS", "Blood product dispense status message");
        public static T0076_MessageType BRP = new T0076_MessageType("BRP", "Blood product dispense status acknowledgement message");
        public static T0076_MessageType BRT = new T0076_MessageType("BRT", "Blood product transfusion/disposition acknowledgement message");
        public static T0076_MessageType BTS = new T0076_MessageType("BTS", "Blood product transfusion/disposition message");
        public static T0076_MessageType CRM = new T0076_MessageType("CRM", "Clinical study registration message");
        public static T0076_MessageType CSU = new T0076_MessageType("CSU", "Unsolicited study data message");
        public static T0076_MessageType DFT = new T0076_MessageType("DFT", "Detail financial transactions");
        public static T0076_MessageType DOC = new T0076_MessageType("DOC", "Document response");
        public static T0076_MessageType DSR = new T0076_MessageType("DSR", "Display response");
        public static T0076_MessageType EAC = new T0076_MessageType("EAC", "Automated equipment command message");
        public static T0076_MessageType EAN = new T0076_MessageType("EAN", "Automated equipment notification message");
        public static T0076_MessageType EAR = new T0076_MessageType("EAR", "Automated equipment response message");
        public static T0076_MessageType EDR = new T0076_MessageType("EDR", "Enhanced display response");
        public static T0076_MessageType EQQ = new T0076_MessageType("EQQ", "Embedded query language query");
        public static T0076_MessageType ERP = new T0076_MessageType("ERP", "Event replay response");
        public static T0076_MessageType ESR = new T0076_MessageType("ESR", "Automated equipment status update acknowledgment message");
        public static T0076_MessageType ESU = new T0076_MessageType("ESU", "Automated equipment status update message");
        public static T0076_MessageType INR = new T0076_MessageType("INR", "Automated equipment inventory request message");
        public static T0076_MessageType INU = new T0076_MessageType("INU", "Automated equipment inventory update message");
        public static T0076_MessageType LSR = new T0076_MessageType("LSR", "Automated equipment log/service request message");
        public static T0076_MessageType LSU = new T0076_MessageType("LSU", "Automated equipment log/service update message");
        public static T0076_MessageType MCF = new T0076_MessageType("MCF", "Delayed Acknowledgment (Retained for backward compatibility only)");
        public static T0076_MessageType MDM = new T0076_MessageType("MDM", "Medical document management");
        public static T0076_MessageType MFD = new T0076_MessageType("MFD", "Master files delayed application acknowledgment");
        public static T0076_MessageType MFK = new T0076_MessageType("MFK", "Master files application acknowledgment");
        public static T0076_MessageType MFN = new T0076_MessageType("MFN", "Master files notification");
        public static T0076_MessageType MFQ = new T0076_MessageType("MFQ", "Master files query");
        public static T0076_MessageType MFR = new T0076_MessageType("MFR", "Master files response");
        public static T0076_MessageType NMD = new T0076_MessageType("NMD", "Application management data message");
        public static T0076_MessageType NMQ = new T0076_MessageType("NMQ", "Application management query message");
        public static T0076_MessageType NMR = new T0076_MessageType("NMR", "Application management response message");
        public static T0076_MessageType OMB = new T0076_MessageType("OMB", "Blood product order message");
        public static T0076_MessageType OMD = new T0076_MessageType("OMD", "Dietary order");
        public static T0076_MessageType OMG = new T0076_MessageType("OMG", "General clinical order message");
        public static T0076_MessageType OMI = new T0076_MessageType("OMI", "Imaging order");
        public static T0076_MessageType OML = new T0076_MessageType("OML", "Laboratory order message");
        public static T0076_MessageType OMN = new T0076_MessageType("OMN", "Non-stock requisition order message");
        public static T0076_MessageType OMP = new T0076_MessageType("OMP", "Pharmacy/treatment order message");
        public static T0076_MessageType OMS = new T0076_MessageType("OMS", "Stock requisition order message");
        public static T0076_MessageType ORB = new T0076_MessageType("ORB", "Blood product order acknowledgement message");
        public static T0076_MessageType ORD = new T0076_MessageType("ORD", "Dietary order acknowledgment message");
        public static T0076_MessageType ORF = new T0076_MessageType("ORF", "Query for results of observation");
        public static T0076_MessageType ORG = new T0076_MessageType("ORG", "General clinical order acknowledgment message");
        public static T0076_MessageType ORI = new T0076_MessageType("ORI", "Imaging order acknowledgement message");
        public static T0076_MessageType ORL = new T0076_MessageType("ORL", "Laboratory acknowledgment message (unsolicited)");
        public static T0076_MessageType ORM = new T0076_MessageType("ORM", "Pharmacy/treatment order message");
        public static T0076_MessageType ORN = new T0076_MessageType("ORN", "Non-stock requisition - General order acknowledgment message");
        public static T0076_MessageType ORP = new T0076_MessageType("ORP", "Pharmacy/treatment order acknowledgment message");
        public static T0076_MessageType ORR = new T0076_MessageType("ORR", "General order response message response to any ORM");
        public static T0076_MessageType ORS = new T0076_MessageType("ORS", "Stock requisition - Order acknowledgment message");
        public static T0076_MessageType ORU = new T0076_MessageType("ORU", "Unsolicited transmission of an observation message");
        public static T0076_MessageType OSQ = new T0076_MessageType("OSQ", "Query response for order status");
        public static T0076_MessageType OSR = new T0076_MessageType("OSR", "Query response for order status");
        public static T0076_MessageType OUL = new T0076_MessageType("OUL", "Unsolicited laboratory observation message");
        public static T0076_MessageType PEX = new T0076_MessageType("PEX", "Product experience message");
        public static T0076_MessageType PGL = new T0076_MessageType("PGL", "Patient goal message");
        public static T0076_MessageType PIN = new T0076_MessageType("PIN", "Patient insurance information");
        public static T0076_MessageType PMU = new T0076_MessageType("PMU", "Add personnel record");
        public static T0076_MessageType PPG = new T0076_MessageType("PPG", "Patient pathway message (goal-oriented)");
        public static T0076_MessageType PPP = new T0076_MessageType("PPP", "Patient pathway message (problem-oriented)");
        public static T0076_MessageType PPR = new T0076_MessageType("PPR", "Patient problem message");
        public static T0076_MessageType PPT = new T0076_MessageType("PPT", "Patient pathway goal-oriented response");
        public static T0076_MessageType PPV = new T0076_MessageType("PPV", "Patient goal response");
        public static T0076_MessageType PRR = new T0076_MessageType("PRR", "Patient problem response");
        public static T0076_MessageType PTR = new T0076_MessageType("PTR", "Patient pathway problem-oriented response");
        public static T0076_MessageType QBP = new T0076_MessageType("QBP", "Query by parameter");
        public static T0076_MessageType QCK = new T0076_MessageType("QCK", "Deferred query");
        public static T0076_MessageType QCN = new T0076_MessageType("QCN", "Cancel query");
        public static T0076_MessageType QRY = new T0076_MessageType("QRY", "Query, original mode");
        public static T0076_MessageType QSB = new T0076_MessageType("QSB", "Create subscription");
        public static T0076_MessageType QSX = new T0076_MessageType("QSX", "Cancel subscription/acknowledge message");
        public static T0076_MessageType QVR = new T0076_MessageType("QVR", "Query for previous events");
        public static T0076_MessageType RAR = new T0076_MessageType("RAR", "Pharmacy/treatment administration information");
        public static T0076_MessageType RAS = new T0076_MessageType("RAS", "Pharmacy/treatment administration message");
        public static T0076_MessageType RCI = new T0076_MessageType("RCI", "Return clinical information");
        public static T0076_MessageType RCL = new T0076_MessageType("RCL", "Return clinical list");
        public static T0076_MessageType RDE = new T0076_MessageType("RDE", "Pharmacy/treatment encoded order message");
        public static T0076_MessageType RDR = new T0076_MessageType("RDR", "Pharmacy/treatment dispense information");
        public static T0076_MessageType RDS = new T0076_MessageType("RDS", "Pharmacy/treatment dispense message");
        public static T0076_MessageType RDY = new T0076_MessageType("RDY", "Display based response");
        public static T0076_MessageType REF = new T0076_MessageType("REF", "Patient referral");
        public static T0076_MessageType RER = new T0076_MessageType("RER", "Pharmacy/treatment encoded order information");
        public static T0076_MessageType RGR = new T0076_MessageType("RGR", "Pharmacy/treatment dose information");
        public static T0076_MessageType RGV = new T0076_MessageType("RGV", "Pharmacy/treatment give message");
        public static T0076_MessageType ROR = new T0076_MessageType("ROR", "Pharmacy/treatment order response");
        public static T0076_MessageType RPA = new T0076_MessageType("RPA", "Return patient authorization");
        public static T0076_MessageType RPI = new T0076_MessageType("RPI", "Return patient information");
        public static T0076_MessageType RPL = new T0076_MessageType("RPL", "Return patient display list");
        public static T0076_MessageType RPR = new T0076_MessageType("RPR", "Return patient list");
        public static T0076_MessageType RQA = new T0076_MessageType("RQA", "Request patient authorization");
        public static T0076_MessageType RQC = new T0076_MessageType("RQC", "Request clinical information");
        public static T0076_MessageType RQI = new T0076_MessageType("RQI", "Request patient information");
        public static T0076_MessageType RQP = new T0076_MessageType("RQP", "Request patient demographics");
        public static T0076_MessageType RQQ = new T0076_MessageType("RQQ", "Event replay query");
        public static T0076_MessageType RRA = new T0076_MessageType("RRA", "Pharmacy/treatment administration acknowledgment message");
        public static T0076_MessageType RRD = new T0076_MessageType("RRD", "Pharmacy/treatment dispense acknowledgment message");
        public static T0076_MessageType RRE = new T0076_MessageType("RRE", "Pharmacy/treatment encoded order acknowledgment message");
        public static T0076_MessageType RRG = new T0076_MessageType("RRG", "Pharmacy/treatment give acknowledgment message");
        public static T0076_MessageType RRI = new T0076_MessageType("RRI", "Return referral information");
        public static T0076_MessageType RSP = new T0076_MessageType("RSP", "Segment pattern response");
        public static T0076_MessageType RTB = new T0076_MessageType("RTB", "Tabular response");
        public static T0076_MessageType SIU = new T0076_MessageType("SIU", "Schedule information unsolicited");
        public static T0076_MessageType SPQ = new T0076_MessageType("SPQ", "Stored procedure request");
        public static T0076_MessageType SQM = new T0076_MessageType("SQM", "Schedule query message");
        public static T0076_MessageType SQR = new T0076_MessageType("SQR", "Schedule query response");
        public static T0076_MessageType SRM = new T0076_MessageType("SRM", "Schedule request message");
        public static T0076_MessageType SRR = new T0076_MessageType("SRR", "Scheduled request response");
        public static T0076_MessageType SSR = new T0076_MessageType("SSR", "Specimen status request message");
        public static T0076_MessageType SSU = new T0076_MessageType("SSU", "Specimen status update message");
        public static T0076_MessageType SUR = new T0076_MessageType("SUR", "Summary product experience report");
        public static T0076_MessageType TBR = new T0076_MessageType("TBR", "Tabular data response");
        public static T0076_MessageType TCR = new T0076_MessageType("TCR", "Automated equipment test code settings request message");
        public static T0076_MessageType TCU = new T0076_MessageType("TCU", "Automated equipment test code settings update message");
        public static T0076_MessageType UDM = new T0076_MessageType("UDM", "Unsolicited display update message");
        public static T0076_MessageType VQQ = new T0076_MessageType("VQQ", "Virtual table query");
        public static T0076_MessageType VXQ = new T0076_MessageType("VXQ", "Query for vaccination record");
        public static T0076_MessageType VXR = new T0076_MessageType("VXR", "Vaccination record response");
        public static T0076_MessageType VXU = new T0076_MessageType("VXU", "Unsolicited vaccination record update");
        public static T0076_MessageType VXX = new T0076_MessageType("VXX", "Response for vaccination query with multiple PID matches");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public T0076_MessageType(string value, string description) : base(value, description) { }

        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public override string TableNumber
        {
            get
            {
                return "0076";
            }
        }
    }
}
