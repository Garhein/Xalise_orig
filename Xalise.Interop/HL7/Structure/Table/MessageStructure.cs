using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0354 - Message structure.
    /// </summary>
    [Serializable]
    public class MessageStructure : AbstractTable
    {
        public static MessageStructure ACK      = new MessageStructure("ACK", "Varies");
        public static MessageStructure ADR_A19  = new MessageStructure("ADR_A19", "A19");
        public static MessageStructure ADT_A01  = new MessageStructure("ADT_A01", "A01, A04, A08, A13");
        public static MessageStructure ADT_A02  = new MessageStructure("ADT_A02", "A02");
        public static MessageStructure ADT_A03  = new MessageStructure("ADT_A03", "A03");
        public static MessageStructure ADT_A05  = new MessageStructure("ADT_A05", "A05, A14, A28, A31");
        public static MessageStructure ADT_A06  = new MessageStructure("ADT_A06", "A06, A07");
        public static MessageStructure ADT_A09  = new MessageStructure("ADT_A09", "A09, A10, A11, A12");
        public static MessageStructure ADT_A15  = new MessageStructure("ADT_A15", "A15");
        public static MessageStructure ADT_A16  = new MessageStructure("ADT_A16", "A16");
        public static MessageStructure ADT_A17  = new MessageStructure("ADT_A17", "A17");
        public static MessageStructure ADT_A18  = new MessageStructure("ADT_A18", "A18");
        public static MessageStructure ADT_A20  = new MessageStructure("ADT_A20", "A20");
        public static MessageStructure ADT_A21  = new MessageStructure("ADT_A21", "A21, A22, A23, A25, A26, A27, A29, A32, A33");
        public static MessageStructure ADT_A24  = new MessageStructure("ADT_A24", "A24");
        public static MessageStructure ADT_A30  = new MessageStructure("ADT_A30", "A30, A34, A35, A36, A46, A47, A48, A49");
        public static MessageStructure ADT_A37  = new MessageStructure("ADT_A37", "A37");
        public static MessageStructure ADT_A38  = new MessageStructure("ADT_A38", "A38");
        public static MessageStructure ADT_A39  = new MessageStructure("ADT_A39", "A39, A40, A41, A42");
        public static MessageStructure ADT_A43  = new MessageStructure("ADT_A43", "A43, A44");
        public static MessageStructure ADT_A45  = new MessageStructure("ADT_A45", "A45");
        public static MessageStructure ADT_A50  = new MessageStructure("ADT_A50", "A50, A51");
        public static MessageStructure ADT_A52  = new MessageStructure("ADT_A52", "A52, A53, A55");
        public static MessageStructure ADT_A54  = new MessageStructure("ADT_A54", "A54");
        public static MessageStructure ADT_A60  = new MessageStructure("ADT_A60", "A60");
        public static MessageStructure ADT_A61  = new MessageStructure("ADT_A61", "A61, A62");
        public static MessageStructure BAR_P01  = new MessageStructure("BAR_P01", "P01");
        public static MessageStructure BAR_P02  = new MessageStructure("BAR_P02", "P02");
        public static MessageStructure BAR_P05  = new MessageStructure("BAR_P05", "P05");
        public static MessageStructure BAR_P06  = new MessageStructure("BAR_P06", "P06");
        public static MessageStructure BAR_P10  = new MessageStructure("BAR_P10", "P10");
        public static MessageStructure BAR_P12  = new MessageStructure("BAR_P12", "P12");
        public static MessageStructure BPS_O29  = new MessageStructure("BPS_O29", "O29");
        public static MessageStructure BRP_030  = new MessageStructure("BRP_030", "O30");
        public static MessageStructure BRT_O32  = new MessageStructure("BRT_O32", "O32");
        public static MessageStructure BTS_O31  = new MessageStructure("BTS_O31", "O31");
        public static MessageStructure CRM_C01  = new MessageStructure("CRM_C01", "C01, C02, C03, C04, C05, C06, C07, C08");
        public static MessageStructure CSU_C09  = new MessageStructure("CSU_C09", "C09, C10, C11, C12");
        public static MessageStructure DFT_P03  = new MessageStructure("DFT_P03", "P03");
        public static MessageStructure DFT_P11  = new MessageStructure("DFT_P11", "P11");
        public static MessageStructure DOC_T12  = new MessageStructure("DOC_T12", "T12");
        public static MessageStructure DSR_P04  = new MessageStructure("DSR_P04", "P04");
        public static MessageStructure DSR_Q01  = new MessageStructure("DSR_Q01", "Q01");
        public static MessageStructure DSR_Q03  = new MessageStructure("DSR_Q03", "Q03");
        public static MessageStructure EAC_U07  = new MessageStructure("EAC_U07", "U07");
        public static MessageStructure EAN_U09  = new MessageStructure("EAN_U09", "U09");
        public static MessageStructure EAR_U08  = new MessageStructure("EAR_U08", "U08");
        public static MessageStructure EDR_R07  = new MessageStructure("EDR_R07", "R07");
        public static MessageStructure EQQ_Q04  = new MessageStructure("EQQ_Q04", "Q04");
        public static MessageStructure ERP_R09  = new MessageStructure("ERP_R09", "R09");
        public static MessageStructure ESR_U02  = new MessageStructure("ESR_U02", "U02");
        public static MessageStructure ESU_U01  = new MessageStructure("ESU_U01", "U01");
        public static MessageStructure INR_U06  = new MessageStructure("INR_U06", "U06");
        public static MessageStructure INU_U05  = new MessageStructure("INU_U05", "U05");
        public static MessageStructure LSU_U12  = new MessageStructure("LSU_U12", "U12, U13	");
        public static MessageStructure MDM_T01  = new MessageStructure("MDM_T01", "T01, T03, T05, T07, T09, T11");
        public static MessageStructure MDM_T02  = new MessageStructure("MDM_T02", "T02, T04, T06, T08, T10");
        public static MessageStructure MFD_MFA  = new MessageStructure("MFD_MFA", "MFA");
        public static MessageStructure MFK_M01  = new MessageStructure("MFK_M01", "M01, M02, M03, M04, M05, M06, M07, M08, M09, M10, M11");
        public static MessageStructure MFN_M01  = new MessageStructure("MFN_M01", "M01");
        public static MessageStructure MFN_M02  = new MessageStructure("MFN_M02", "M02");
        public static MessageStructure MFN_M03  = new MessageStructure("MFN_M03", "M03");
        public static MessageStructure MFN_M04  = new MessageStructure("MFN_M04", "M04");
        public static MessageStructure MFN_M05  = new MessageStructure("MFN_M05", "M05");
        public static MessageStructure MFN_M06  = new MessageStructure("MFN_M06", "M06");
        public static MessageStructure MFN_M07  = new MessageStructure("MFN_M07", "M07");
        public static MessageStructure MFN_M08  = new MessageStructure("MFN_M08", "M08");
        public static MessageStructure MFN_M09  = new MessageStructure("MFN_M09", "M09");
        public static MessageStructure MFN_M10  = new MessageStructure("MFN_M10", "M10");
        public static MessageStructure MFN_M11  = new MessageStructure("MFN_M11", "M11");
        public static MessageStructure MFN_M12  = new MessageStructure("MFN_M12", "M12");
        public static MessageStructure MFN_M13  = new MessageStructure("MFN_M13", "M13");
        public static MessageStructure MFN_M15  = new MessageStructure("MFN_M15", "M15");
        public static MessageStructure MFQ_M01  = new MessageStructure("MFQ_M01", "M01, M02, M03, M04, M05, M06");
        public static MessageStructure MFR_M01  = new MessageStructure("MFR_M01", "M01, M02, M03, M04, M05, M06");
        public static MessageStructure NMD_N02  = new MessageStructure("NMD_N02", "N02");
        public static MessageStructure NMQ_N01  = new MessageStructure("NMQ_N01", "N01");
        public static MessageStructure NMR_N01  = new MessageStructure("NMR_N01", "N01");
        public static MessageStructure OMB_O27  = new MessageStructure("OMB_O27", "O27");
        public static MessageStructure OMD_O03  = new MessageStructure("OMD_O03", "O03");
        public static MessageStructure OMG_O19  = new MessageStructure("OMG_O19", "O19");
        public static MessageStructure OMI_O23  = new MessageStructure("OMI_O23", "O23");
        public static MessageStructure OML_O21  = new MessageStructure("OML_O21", "O21");
        public static MessageStructure OML_O33  = new MessageStructure("OML_O33", "O33");
        public static MessageStructure OML_O35  = new MessageStructure("OML_O35", "O35");
        public static MessageStructure OMN_O07  = new MessageStructure("OMN_O07", "O07");
        public static MessageStructure OMP_O09  = new MessageStructure("OMP_O09", "O09");
        public static MessageStructure OMS_O05  = new MessageStructure("OMS_O05", "O05");
        public static MessageStructure ORB_O28  = new MessageStructure("ORB_O28", "O28");
        public static MessageStructure ORD_O04  = new MessageStructure("ORD_O04", "O04");
        public static MessageStructure ORF_R04  = new MessageStructure("ORF_R04", "R04");
        public static MessageStructure ORG_O20  = new MessageStructure("ORG_O20", "O20");
        public static MessageStructure ORI_O24  = new MessageStructure("ORI_O24", "O24");
        public static MessageStructure ORL_O22  = new MessageStructure("ORL_O22", "O22");
        public static MessageStructure ORL_O34  = new MessageStructure("ORL_O34", "O34");
        public static MessageStructure ORL_O36  = new MessageStructure("ORL_O36", "O36");
        public static MessageStructure ORM_O01  = new MessageStructure("ORM_O01", "O01");
        public static MessageStructure ORN_O08  = new MessageStructure("ORN_O08", "O08");
        public static MessageStructure ORP_O10  = new MessageStructure("ORP_O10", "O10");
        public static MessageStructure ORR_R02  = new MessageStructure("ORR_R02", "O02");
        public static MessageStructure ORS_O06  = new MessageStructure("ORS_O06", "O06");
        public static MessageStructure ORU_R01  = new MessageStructure("ORU_R01", "R01");
        public static MessageStructure ORU_R30  = new MessageStructure("ORU_R30", "R30");
        public static MessageStructure ORU_R31  = new MessageStructure("ORU_R31", "R31");
        public static MessageStructure ORU_R32  = new MessageStructure("ORU_R32", "R32");
        public static MessageStructure ORU_W01  = new MessageStructure("ORU_W01", "W01");
        public static MessageStructure OSQ_Q06  = new MessageStructure("OSQ_Q06", "Q06");
        public static MessageStructure OSR_Q06  = new MessageStructure("OSR_Q06", "Q06");
        public static MessageStructure OUL_R21  = new MessageStructure("OUL_R21", "R21");
        public static MessageStructure OUL_R22  = new MessageStructure("OUL_R22", "R22");
        public static MessageStructure OUL_R23  = new MessageStructure("OUL_R23", "R23");
        public static MessageStructure OUL_R24  = new MessageStructure("OUL_R24", "R24");
        public static MessageStructure PEX_P07  = new MessageStructure("PEX_P07", "P07, P08");
        public static MessageStructure PGL_PC6  = new MessageStructure("PGL_PC6", "PC6, PC7, PC8");
        public static MessageStructure PMU_B01  = new MessageStructure("PMU_B01", "B01, B02");
        public static MessageStructure PMU_B03  = new MessageStructure("PMU_B03", "B03");
        public static MessageStructure PMU_B04  = new MessageStructure("PMU_B04", "B04, B05, B06");
        public static MessageStructure PMU_B07  = new MessageStructure("PMU_B07", "B07");
        public static MessageStructure PMU_B08  = new MessageStructure("PMU_B08", "B08");
        public static MessageStructure PPG_PCG  = new MessageStructure("PPG_PCG", "PCC, PCG, PCH, PCJ");
        public static MessageStructure PPP_PCB  = new MessageStructure("PPP_PCB", "PCB, PCD");
        public static MessageStructure PPR_PC1  = new MessageStructure("PPR_PC1", "PC1, PC2, PC3");
        public static MessageStructure PPT_PCL  = new MessageStructure("PPT_PCL", "PCL");
        public static MessageStructure PPV_PCA  = new MessageStructure("PPV_PCA", "PCA");
        public static MessageStructure PRR_PC5  = new MessageStructure("PRR_PC5", "PC5");
        public static MessageStructure PTR_PCF  = new MessageStructure("PTR_PCF", "PCF");
        public static MessageStructure QBP_Q11  = new MessageStructure("QBP_Q11", "Q11");
        public static MessageStructure QBP_Q13  = new MessageStructure("QBP_Q13", "Q13");
        public static MessageStructure QBP_Q15  = new MessageStructure("QBP_Q15", "Q15");
        public static MessageStructure QBP_Q21  = new MessageStructure("QBP_Q21", "Q21, Q22, Q23,Q24, Q25");
        public static MessageStructure QCK_Q02  = new MessageStructure("QCK_Q02", "Q02");
        public static MessageStructure QCN_J01  = new MessageStructure("QCN_J01", "J01, J02");
        public static MessageStructure QRF_W02  = new MessageStructure("QRF_W02", "W02");
        public static MessageStructure QRY_A19  = new MessageStructure("QRY_A19", "A19");
        public static MessageStructure QRY_P04  = new MessageStructure("QRY_P04", "P04");
        public static MessageStructure QRY_PC4  = new MessageStructure("QRY_PC4", "PC4, PC9, PCE, PCK");
        public static MessageStructure QRY_Q01  = new MessageStructure("QRY_Q01", "Q01, Q26, Q27, Q28, Q29, Q30");
        public static MessageStructure QRY_Q02  = new MessageStructure("QRY_Q02", "Q02");
        public static MessageStructure QRY_R02  = new MessageStructure("QRY_R02", "R02");
        public static MessageStructure QRY_T12  = new MessageStructure("QRY_T12", "T12");
        public static MessageStructure QSB_Q16  = new MessageStructure("QSB_Q16", "Q16");
        public static MessageStructure QVR_Q17  = new MessageStructure("QVR_Q17", "Q17");
        public static MessageStructure RAR_RAR  = new MessageStructure("RAR_RAR", "RAR");
        public static MessageStructure RAS_O17  = new MessageStructure("RAS_O17", "O17");
        public static MessageStructure RCI_I05  = new MessageStructure("RCI_I05", "I05");
        public static MessageStructure RCL_I06  = new MessageStructure("RCL_I06", "I06");
        public static MessageStructure RDE_O01  = new MessageStructure("RDE_O01", "O01");
        public static MessageStructure RDE_O11  = new MessageStructure("RDE_O11", "O11, O25");
        public static MessageStructure RDR_RDR  = new MessageStructure("RDR_RDR", "RDR");
        public static MessageStructure RDS_O13  = new MessageStructure("RDS_O13", "O13");
        public static MessageStructure RDY_K15  = new MessageStructure("RDY_K15", "K15");
        public static MessageStructure REF_I12  = new MessageStructure("REF_I12", "I12, I13, I14, I15");
        public static MessageStructure RER_RER  = new MessageStructure("RER_RER", "RER");
        public static MessageStructure RGR_RGR  = new MessageStructure("RGR_RGR", "RGR");
        public static MessageStructure RGV_O15  = new MessageStructure("RGV_O15", "O15");
        public static MessageStructure ROR_ROR  = new MessageStructure("ROR_ROR", "ROR");
        public static MessageStructure RPA_I08  = new MessageStructure("RPA_I08", "I08, I09. I10, I11");
        public static MessageStructure RPI_I01  = new MessageStructure("RPI_I01", "I01, I04");
        public static MessageStructure RPL_I02  = new MessageStructure("RPL_I02", "I02");
        public static MessageStructure RPR_I03  = new MessageStructure("RPR_I03", "I03");
        public static MessageStructure RQA_I08  = new MessageStructure("RQA_I08", "I08, I09, I10, I11");
        public static MessageStructure RQC_I05  = new MessageStructure("RQC_I05", "I05, I06");
        public static MessageStructure RQI_I01  = new MessageStructure("RQI_I01", "I01, I02, I03, I07");
        public static MessageStructure RQP_I04  = new MessageStructure("RQP_I04", "I04");
        public static MessageStructure RQQ_Q09  = new MessageStructure("RQQ_Q09", "Q09");
        public static MessageStructure RRA_O02  = new MessageStructure("RRA_O02", "O02");
        public static MessageStructure RRA_O18  = new MessageStructure("RRA_O18", "O18");
        public static MessageStructure RRD_O14  = new MessageStructure("RRD_O14", "O14");
        public static MessageStructure RRE_O12  = new MessageStructure("RRE_O12", "O12, O26");
        public static MessageStructure RRG_O16  = new MessageStructure("RRG_O16", "O16");
        public static MessageStructure RRI_I12  = new MessageStructure("RRI_I12", "I12, I13, I14, I15");
        public static MessageStructure RSP_K11  = new MessageStructure("RSP_K11", "K11");
        public static MessageStructure RSP_K21  = new MessageStructure("RSP_K21", "K21");
        public static MessageStructure RSP_K22  = new MessageStructure("RSP_K22", "K22");
        public static MessageStructure RSP_K23  = new MessageStructure("RSP_K23", "K23, K24	");
        public static MessageStructure RTB_K13  = new MessageStructure("RTB_K13", "K13");
        public static MessageStructure SIU_S12  = new MessageStructure("SIU_S12", "S12, S13, S14, S15, S16, S17, S18, S19, S20, S21, S22, S23, S24, S26");
        public static MessageStructure SPQ_Q08  = new MessageStructure("SPQ_Q08", "Q08");
        public static MessageStructure SQM_S25  = new MessageStructure("SQM_S25", "S25");
        public static MessageStructure SQR_S25  = new MessageStructure("SQR_S25", "S25");
        public static MessageStructure SRM_S01  = new MessageStructure("SRM_S01", "S01, S02, S03, S04, S05, S06, S07, S08, S09, S10, S11");
        public static MessageStructure SRR_S01  = new MessageStructure("SRR_S01", "S01, S02, S03, S04, S05, S06, S07, S08, S09, S10, S11");
        public static MessageStructure SSR_U04  = new MessageStructure("SSR_U04", "U04");
        public static MessageStructure SSU_U03  = new MessageStructure("SSU_U03", "U03");
        public static MessageStructure SUR_P09  = new MessageStructure("SUR_P09", "P09");
        public static MessageStructure TBR_R08  = new MessageStructure("TBR_R08", "R08");
        public static MessageStructure TBR_R09  = new MessageStructure("TBR_R09", "R09");
        public static MessageStructure TCU_U10  = new MessageStructure("TCU_U10", "U10, U11");
        public static MessageStructure UDM_Q05  = new MessageStructure("UDM_Q05", "Q05");
        public static MessageStructure VQQ_Q07  = new MessageStructure("VQQ_Q07", "Q07");
        public static MessageStructure VXQ_V01  = new MessageStructure("VXQ_V01", "V01");
        public static MessageStructure VXR_V03  = new MessageStructure("VXR_V03", "V03");
        public static MessageStructure VXU_V04  = new MessageStructure("VXU_V04", "V04");
        public static MessageStructure VXX_V02  = new MessageStructure("VXX_V02", "V02");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public MessageStructure(string value, string description) : base(value, description) { }

        /// <summary>
        /// Numéro de la table de données HL7.
        /// </summary>
        public override string TableNumber
        {
            get
            {
                return "0354";
            }
        }
    }
}
