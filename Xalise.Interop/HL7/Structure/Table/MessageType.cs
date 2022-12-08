using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0076 - Message type.
    /// </summary>
    [Serializable]
    public class MessageType : AbstractTable
    {
        public static MessageType ACK = new MessageType("ACK", "General acknowledgment message");
        public static MessageType ADR = new MessageType("ADR", "ADT response");
        public static MessageType ADT = new MessageType("ADT", "ADT message");
        public static MessageType BAR = new MessageType("BAR", "Add/change billing account");
        public static MessageType BPS = new MessageType("BPS", "Blood product dispense status message");
        public static MessageType BRP = new MessageType("BRP", "Blood product dispense status acknowledgement message");
        public static MessageType BRT = new MessageType("BRT", "Blood product transfusion/disposition acknowledgement message");
        public static MessageType BTS = new MessageType("BTS", "Blood product transfusion/disposition message");
        public static MessageType CRM = new MessageType("CRM", "Clinical study registration message");
        public static MessageType CSU = new MessageType("CSU", "Unsolicited study data message");
        public static MessageType DFT = new MessageType("DFT", "Detail financial transactions");
        public static MessageType DOC = new MessageType("DOC", "Document response");
        public static MessageType DSR = new MessageType("DSR", "Display response");
        public static MessageType EAC = new MessageType("EAC", "Automated equipment command message");
        public static MessageType EAN = new MessageType("EAN", "Automated equipment notification message");
        public static MessageType EAR = new MessageType("EAR", "Automated equipment response message");
        public static MessageType EDR = new MessageType("EDR", "Enhanced display response");
        public static MessageType EQQ = new MessageType("EQQ", "Embedded query language query");
        public static MessageType ERP = new MessageType("ERP", "Event replay response");
        public static MessageType ESR = new MessageType("ESR", "Automated equipment status update acknowledgment message");
        public static MessageType ESU = new MessageType("ESU", "Automated equipment status update message");
        public static MessageType INR = new MessageType("INR", "Automated equipment inventory request message");
        public static MessageType INU = new MessageType("INU", "Automated equipment inventory update message");
        public static MessageType LSR = new MessageType("LSR", "Automated equipment log/service request message");
        public static MessageType LSU = new MessageType("LSU", "Automated equipment log/service update message");
        public static MessageType MCF = new MessageType("MCF", "Delayed Acknowledgment (Retained for backward compatibility only)");
        public static MessageType MDM = new MessageType("MDM", "Medical document management");
        public static MessageType MFD = new MessageType("MFD", "Master files delayed application acknowledgment");
        public static MessageType MFK = new MessageType("MFK", "Master files application acknowledgment");
        public static MessageType MFN = new MessageType("MFN", "Master files notification");
        public static MessageType MFQ = new MessageType("MFQ", "Master files query");
        public static MessageType MFR = new MessageType("MFR", "Master files response");
        public static MessageType NMD = new MessageType("NMD", "Application management data message");
        public static MessageType NMQ = new MessageType("NMQ", "Application management query message");
        public static MessageType NMR = new MessageType("NMR", "Application management response message");
        public static MessageType OMB = new MessageType("OMB", "Blood product order message");
        public static MessageType OMD = new MessageType("OMD", "Dietary order");
        public static MessageType OMG = new MessageType("OMG", "General clinical order message");
        public static MessageType OMI = new MessageType("OMI", "Imaging order");
        public static MessageType OML = new MessageType("OML", "Laboratory order message");
        public static MessageType OMN = new MessageType("OMN", "Non-stock requisition order message");
        public static MessageType OMP = new MessageType("OMP", "Pharmacy/treatment order message");
        public static MessageType OMS = new MessageType("OMS", "Stock requisition order message");
        public static MessageType ORB = new MessageType("ORB", "Blood product order acknowledgement message");
        public static MessageType ORD = new MessageType("ORD", "Dietary order acknowledgment message");
        public static MessageType ORF = new MessageType("ORF", "Query for results of observation");
        public static MessageType ORG = new MessageType("ORG", "General clinical order acknowledgment message");
        public static MessageType ORI = new MessageType("ORI", "Imaging order acknowledgement message");
        public static MessageType ORL = new MessageType("ORL", "Laboratory acknowledgment message (unsolicited)");
        public static MessageType ORM = new MessageType("ORM", "Pharmacy/treatment order message");
        public static MessageType ORN = new MessageType("ORN", "Non-stock requisition - General order acknowledgment message");
        public static MessageType ORP = new MessageType("ORP", "Pharmacy/treatment order acknowledgment message");
        public static MessageType ORR = new MessageType("ORR", "General order response message response to any ORM");
        public static MessageType ORS = new MessageType("ORS", "Stock requisition - Order acknowledgment message");
        public static MessageType ORU = new MessageType("ORU", "Unsolicited transmission of an observation message");
        public static MessageType OSQ = new MessageType("OSQ", "Query response for order status");
        public static MessageType OSR = new MessageType("OSR", "Query response for order status");
        public static MessageType OUL = new MessageType("OUL", "Unsolicited laboratory observation message");
        public static MessageType PEX = new MessageType("PEX", "Product experience message");
        public static MessageType PGL = new MessageType("PGL", "Patient goal message");
        public static MessageType PIN = new MessageType("PIN", "Patient insurance information");
        public static MessageType PMU = new MessageType("PMU", "Add personnel record");
        public static MessageType PPG = new MessageType("PPG", "Patient pathway message (goal-oriented)");
        public static MessageType PPP = new MessageType("PPP", "Patient pathway message (problem-oriented)");
        public static MessageType PPR = new MessageType("PPR", "Patient problem message");
        public static MessageType PPT = new MessageType("PPT", "Patient pathway goal-oriented response");
        public static MessageType PPV = new MessageType("PPV", "Patient goal response");
        public static MessageType PRR = new MessageType("PRR", "Patient problem response");
        public static MessageType PTR = new MessageType("PTR", "Patient pathway problem-oriented response");
        public static MessageType QBP = new MessageType("QBP", "Query by parameter");
        public static MessageType QCK = new MessageType("QCK", "Deferred query");
        public static MessageType QCN = new MessageType("QCN", "Cancel query");
        public static MessageType QRY = new MessageType("QRY", "Query, original mode");
        public static MessageType QSB = new MessageType("QSB", "Create subscription");
        public static MessageType QSX = new MessageType("QSX", "Cancel subscription/acknowledge message");
        public static MessageType QVR = new MessageType("QVR", "Query for previous events");
        public static MessageType RAR = new MessageType("RAR", "Pharmacy/treatment administration information");
        public static MessageType RAS = new MessageType("RAS", "Pharmacy/treatment administration message");
        public static MessageType RCI = new MessageType("RCI", "Return clinical information");
        public static MessageType RCL = new MessageType("RCL", "Return clinical list");
        public static MessageType RDE = new MessageType("RDE", "Pharmacy/treatment encoded order message");
        public static MessageType RDR = new MessageType("RDR", "Pharmacy/treatment dispense information");
        public static MessageType RDS = new MessageType("RDS", "Pharmacy/treatment dispense message");
        public static MessageType RDY = new MessageType("RDY", "Display based response");
        public static MessageType REF = new MessageType("REF", "Patient referral");
        public static MessageType RER = new MessageType("RER", "Pharmacy/treatment encoded order information");
        public static MessageType RGR = new MessageType("RGR", "Pharmacy/treatment dose information");
        public static MessageType RGV = new MessageType("RGV", "Pharmacy/treatment give message");
        public static MessageType ROR = new MessageType("ROR", "Pharmacy/treatment order response");
        public static MessageType RPA = new MessageType("RPA", "Return patient authorization");
        public static MessageType RPI = new MessageType("RPI", "Return patient information");
        public static MessageType RPL = new MessageType("RPL", "Return patient display list");
        public static MessageType RPR = new MessageType("RPR", "Return patient list");
        public static MessageType RQA = new MessageType("RQA", "Request patient authorization");
        public static MessageType RQC = new MessageType("RQC", "Request clinical information");
        public static MessageType RQI = new MessageType("RQI", "Request patient information");
        public static MessageType RQP = new MessageType("RQP", "Request patient demographics");
        public static MessageType RQQ = new MessageType("RQQ", "Event replay query");
        public static MessageType RRA = new MessageType("RRA", "Pharmacy/treatment administration acknowledgment message");
        public static MessageType RRD = new MessageType("RRD", "Pharmacy/treatment dispense acknowledgment message");
        public static MessageType RRE = new MessageType("RRE", "Pharmacy/treatment encoded order acknowledgment message");
        public static MessageType RRG = new MessageType("RRG", "Pharmacy/treatment give acknowledgment message");
        public static MessageType RRI = new MessageType("RRI", "Return referral information");
        public static MessageType RSP = new MessageType("RSP", "Segment pattern response");
        public static MessageType RTB = new MessageType("RTB", "Tabular response");
        public static MessageType SIU = new MessageType("SIU", "Schedule information unsolicited");
        public static MessageType SPQ = new MessageType("SPQ", "Stored procedure request");
        public static MessageType SQM = new MessageType("SQM", "Schedule query message");
        public static MessageType SQR = new MessageType("SQR", "Schedule query response");
        public static MessageType SRM = new MessageType("SRM", "Schedule request message");
        public static MessageType SRR = new MessageType("SRR", "Scheduled request response");
        public static MessageType SSR = new MessageType("SSR", "Specimen status request message");
        public static MessageType SSU = new MessageType("SSU", "Specimen status update message");
        public static MessageType SUR = new MessageType("SUR", "Summary product experience report");
        public static MessageType TBR = new MessageType("TBR", "Tabular data response");
        public static MessageType TCR = new MessageType("TCR", "Automated equipment test code settings request message");
        public static MessageType TCU = new MessageType("TCU", "Automated equipment test code settings update message");
        public static MessageType UDM = new MessageType("UDM", "Unsolicited display update message");
        public static MessageType VQQ = new MessageType("VQQ", "Virtual table query");
        public static MessageType VXQ = new MessageType("VXQ", "Query for vaccination record");
        public static MessageType VXR = new MessageType("VXR", "Vaccination record response");
        public static MessageType VXU = new MessageType("VXU", "Unsolicited vaccination record update");
        public static MessageType VXX = new MessageType("VXX", "Response for vaccination query with multiple PID matches");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public MessageType(string value, string description) : base(value, description) { }

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
