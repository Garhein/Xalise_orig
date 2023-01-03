using System;
using Xalise.Interop.HL7.Core;

namespace Xalise.Interop.HL7.Structure.Table
{
    /// <summary>
    /// 0354 - Message structure.
    /// </summary>
    [Serializable]
    public class T0354_MessageStructure : AbstractTable
    {
        public static T0354_MessageStructure ACK      = new T0354_MessageStructure("ACK", "Varies");
        public static T0354_MessageStructure ADR_A19  = new T0354_MessageStructure("ADR_A19", "A19");
        public static T0354_MessageStructure ADT_A01  = new T0354_MessageStructure("ADT_A01", "A01, A04, A08, A13");
        public static T0354_MessageStructure ADT_A02  = new T0354_MessageStructure("ADT_A02", "A02");
        public static T0354_MessageStructure ADT_A03  = new T0354_MessageStructure("ADT_A03", "A03");
        public static T0354_MessageStructure ADT_A05  = new T0354_MessageStructure("ADT_A05", "A05, A14, A28, A31");
        public static T0354_MessageStructure ADT_A06  = new T0354_MessageStructure("ADT_A06", "A06, A07");
        public static T0354_MessageStructure ADT_A09  = new T0354_MessageStructure("ADT_A09", "A09, A10, A11, A12");
        public static T0354_MessageStructure ADT_A15  = new T0354_MessageStructure("ADT_A15", "A15");
        public static T0354_MessageStructure ADT_A16  = new T0354_MessageStructure("ADT_A16", "A16");
        public static T0354_MessageStructure ADT_A17  = new T0354_MessageStructure("ADT_A17", "A17");
        public static T0354_MessageStructure ADT_A18  = new T0354_MessageStructure("ADT_A18", "A18");
        public static T0354_MessageStructure ADT_A20  = new T0354_MessageStructure("ADT_A20", "A20");
        public static T0354_MessageStructure ADT_A21  = new T0354_MessageStructure("ADT_A21", "A21, A22, A23, A25, A26, A27, A29, A32, A33");
        public static T0354_MessageStructure ADT_A24  = new T0354_MessageStructure("ADT_A24", "A24");
        public static T0354_MessageStructure ADT_A30  = new T0354_MessageStructure("ADT_A30", "A30, A34, A35, A36, A46, A47, A48, A49");
        public static T0354_MessageStructure ADT_A37  = new T0354_MessageStructure("ADT_A37", "A37");
        public static T0354_MessageStructure ADT_A38  = new T0354_MessageStructure("ADT_A38", "A38");
        public static T0354_MessageStructure ADT_A39  = new T0354_MessageStructure("ADT_A39", "A39, A40, A41, A42");
        public static T0354_MessageStructure ADT_A43  = new T0354_MessageStructure("ADT_A43", "A43, A44");
        public static T0354_MessageStructure ADT_A45  = new T0354_MessageStructure("ADT_A45", "A45");
        public static T0354_MessageStructure ADT_A50  = new T0354_MessageStructure("ADT_A50", "A50, A51");
        public static T0354_MessageStructure ADT_A52  = new T0354_MessageStructure("ADT_A52", "A52, A53, A55");
        public static T0354_MessageStructure ADT_A54  = new T0354_MessageStructure("ADT_A54", "A54");
        public static T0354_MessageStructure ADT_A60  = new T0354_MessageStructure("ADT_A60", "A60");
        public static T0354_MessageStructure ADT_A61  = new T0354_MessageStructure("ADT_A61", "A61, A62");
        public static T0354_MessageStructure BAR_P01  = new T0354_MessageStructure("BAR_P01", "P01");
        public static T0354_MessageStructure BAR_P02  = new T0354_MessageStructure("BAR_P02", "P02");
        public static T0354_MessageStructure BAR_P05  = new T0354_MessageStructure("BAR_P05", "P05");
        public static T0354_MessageStructure BAR_P06  = new T0354_MessageStructure("BAR_P06", "P06");
        public static T0354_MessageStructure BAR_P10  = new T0354_MessageStructure("BAR_P10", "P10");
        public static T0354_MessageStructure BAR_P12  = new T0354_MessageStructure("BAR_P12", "P12");
        public static T0354_MessageStructure BPS_O29  = new T0354_MessageStructure("BPS_O29", "O29");
        public static T0354_MessageStructure BRP_030  = new T0354_MessageStructure("BRP_030", "O30");
        public static T0354_MessageStructure BRT_O32  = new T0354_MessageStructure("BRT_O32", "O32");
        public static T0354_MessageStructure BTS_O31  = new T0354_MessageStructure("BTS_O31", "O31");
        public static T0354_MessageStructure CRM_C01  = new T0354_MessageStructure("CRM_C01", "C01, C02, C03, C04, C05, C06, C07, C08");
        public static T0354_MessageStructure CSU_C09  = new T0354_MessageStructure("CSU_C09", "C09, C10, C11, C12");
        public static T0354_MessageStructure DFT_P03  = new T0354_MessageStructure("DFT_P03", "P03");
        public static T0354_MessageStructure DFT_P11  = new T0354_MessageStructure("DFT_P11", "P11");
        public static T0354_MessageStructure DOC_T12  = new T0354_MessageStructure("DOC_T12", "T12");
        public static T0354_MessageStructure DSR_P04  = new T0354_MessageStructure("DSR_P04", "P04");
        public static T0354_MessageStructure DSR_Q01  = new T0354_MessageStructure("DSR_Q01", "Q01");
        public static T0354_MessageStructure DSR_Q03  = new T0354_MessageStructure("DSR_Q03", "Q03");
        public static T0354_MessageStructure EAC_U07  = new T0354_MessageStructure("EAC_U07", "U07");
        public static T0354_MessageStructure EAN_U09  = new T0354_MessageStructure("EAN_U09", "U09");
        public static T0354_MessageStructure EAR_U08  = new T0354_MessageStructure("EAR_U08", "U08");
        public static T0354_MessageStructure EDR_R07  = new T0354_MessageStructure("EDR_R07", "R07");
        public static T0354_MessageStructure EQQ_Q04  = new T0354_MessageStructure("EQQ_Q04", "Q04");
        public static T0354_MessageStructure ERP_R09  = new T0354_MessageStructure("ERP_R09", "R09");
        public static T0354_MessageStructure ESR_U02  = new T0354_MessageStructure("ESR_U02", "U02");
        public static T0354_MessageStructure ESU_U01  = new T0354_MessageStructure("ESU_U01", "U01");
        public static T0354_MessageStructure INR_U06  = new T0354_MessageStructure("INR_U06", "U06");
        public static T0354_MessageStructure INU_U05  = new T0354_MessageStructure("INU_U05", "U05");
        public static T0354_MessageStructure LSU_U12  = new T0354_MessageStructure("LSU_U12", "U12, U13	");
        public static T0354_MessageStructure MDM_T01  = new T0354_MessageStructure("MDM_T01", "T01, T03, T05, T07, T09, T11");
        public static T0354_MessageStructure MDM_T02  = new T0354_MessageStructure("MDM_T02", "T02, T04, T06, T08, T10");
        public static T0354_MessageStructure MFD_MFA  = new T0354_MessageStructure("MFD_MFA", "MFA");
        public static T0354_MessageStructure MFK_M01  = new T0354_MessageStructure("MFK_M01", "M01, M02, M03, M04, M05, M06, M07, M08, M09, M10, M11");
        public static T0354_MessageStructure MFN_M01  = new T0354_MessageStructure("MFN_M01", "M01");
        public static T0354_MessageStructure MFN_M02  = new T0354_MessageStructure("MFN_M02", "M02");
        public static T0354_MessageStructure MFN_M03  = new T0354_MessageStructure("MFN_M03", "M03");
        public static T0354_MessageStructure MFN_M04  = new T0354_MessageStructure("MFN_M04", "M04");
        public static T0354_MessageStructure MFN_M05  = new T0354_MessageStructure("MFN_M05", "M05");
        public static T0354_MessageStructure MFN_M06  = new T0354_MessageStructure("MFN_M06", "M06");
        public static T0354_MessageStructure MFN_M07  = new T0354_MessageStructure("MFN_M07", "M07");
        public static T0354_MessageStructure MFN_M08  = new T0354_MessageStructure("MFN_M08", "M08");
        public static T0354_MessageStructure MFN_M09  = new T0354_MessageStructure("MFN_M09", "M09");
        public static T0354_MessageStructure MFN_M10  = new T0354_MessageStructure("MFN_M10", "M10");
        public static T0354_MessageStructure MFN_M11  = new T0354_MessageStructure("MFN_M11", "M11");
        public static T0354_MessageStructure MFN_M12  = new T0354_MessageStructure("MFN_M12", "M12");
        public static T0354_MessageStructure MFN_M13  = new T0354_MessageStructure("MFN_M13", "M13");
        public static T0354_MessageStructure MFN_M15  = new T0354_MessageStructure("MFN_M15", "M15");
        public static T0354_MessageStructure MFQ_M01  = new T0354_MessageStructure("MFQ_M01", "M01, M02, M03, M04, M05, M06");
        public static T0354_MessageStructure MFR_M01  = new T0354_MessageStructure("MFR_M01", "M01, M02, M03, M04, M05, M06");
        public static T0354_MessageStructure NMD_N02  = new T0354_MessageStructure("NMD_N02", "N02");
        public static T0354_MessageStructure NMQ_N01  = new T0354_MessageStructure("NMQ_N01", "N01");
        public static T0354_MessageStructure NMR_N01  = new T0354_MessageStructure("NMR_N01", "N01");
        public static T0354_MessageStructure OMB_O27  = new T0354_MessageStructure("OMB_O27", "O27");
        public static T0354_MessageStructure OMD_O03  = new T0354_MessageStructure("OMD_O03", "O03");
        public static T0354_MessageStructure OMG_O19  = new T0354_MessageStructure("OMG_O19", "O19");
        public static T0354_MessageStructure OMI_O23  = new T0354_MessageStructure("OMI_O23", "O23");
        public static T0354_MessageStructure OML_O21  = new T0354_MessageStructure("OML_O21", "O21");
        public static T0354_MessageStructure OML_O33  = new T0354_MessageStructure("OML_O33", "O33");
        public static T0354_MessageStructure OML_O35  = new T0354_MessageStructure("OML_O35", "O35");
        public static T0354_MessageStructure OMN_O07  = new T0354_MessageStructure("OMN_O07", "O07");
        public static T0354_MessageStructure OMP_O09  = new T0354_MessageStructure("OMP_O09", "O09");
        public static T0354_MessageStructure OMS_O05  = new T0354_MessageStructure("OMS_O05", "O05");
        public static T0354_MessageStructure ORB_O28  = new T0354_MessageStructure("ORB_O28", "O28");
        public static T0354_MessageStructure ORD_O04  = new T0354_MessageStructure("ORD_O04", "O04");
        public static T0354_MessageStructure ORF_R04  = new T0354_MessageStructure("ORF_R04", "R04");
        public static T0354_MessageStructure ORG_O20  = new T0354_MessageStructure("ORG_O20", "O20");
        public static T0354_MessageStructure ORI_O24  = new T0354_MessageStructure("ORI_O24", "O24");
        public static T0354_MessageStructure ORL_O22  = new T0354_MessageStructure("ORL_O22", "O22");
        public static T0354_MessageStructure ORL_O34  = new T0354_MessageStructure("ORL_O34", "O34");
        public static T0354_MessageStructure ORL_O36  = new T0354_MessageStructure("ORL_O36", "O36");
        public static T0354_MessageStructure ORM_O01  = new T0354_MessageStructure("ORM_O01", "O01");
        public static T0354_MessageStructure ORN_O08  = new T0354_MessageStructure("ORN_O08", "O08");
        public static T0354_MessageStructure ORP_O10  = new T0354_MessageStructure("ORP_O10", "O10");
        public static T0354_MessageStructure ORR_R02  = new T0354_MessageStructure("ORR_R02", "O02");
        public static T0354_MessageStructure ORS_O06  = new T0354_MessageStructure("ORS_O06", "O06");
        public static T0354_MessageStructure ORU_R01  = new T0354_MessageStructure("ORU_R01", "R01");
        public static T0354_MessageStructure ORU_R30  = new T0354_MessageStructure("ORU_R30", "R30");
        public static T0354_MessageStructure ORU_R31  = new T0354_MessageStructure("ORU_R31", "R31");
        public static T0354_MessageStructure ORU_R32  = new T0354_MessageStructure("ORU_R32", "R32");
        public static T0354_MessageStructure ORU_W01  = new T0354_MessageStructure("ORU_W01", "W01");
        public static T0354_MessageStructure OSQ_Q06  = new T0354_MessageStructure("OSQ_Q06", "Q06");
        public static T0354_MessageStructure OSR_Q06  = new T0354_MessageStructure("OSR_Q06", "Q06");
        public static T0354_MessageStructure OUL_R21  = new T0354_MessageStructure("OUL_R21", "R21");
        public static T0354_MessageStructure OUL_R22  = new T0354_MessageStructure("OUL_R22", "R22");
        public static T0354_MessageStructure OUL_R23  = new T0354_MessageStructure("OUL_R23", "R23");
        public static T0354_MessageStructure OUL_R24  = new T0354_MessageStructure("OUL_R24", "R24");
        public static T0354_MessageStructure PEX_P07  = new T0354_MessageStructure("PEX_P07", "P07, P08");
        public static T0354_MessageStructure PGL_PC6  = new T0354_MessageStructure("PGL_PC6", "PC6, PC7, PC8");
        public static T0354_MessageStructure PMU_B01  = new T0354_MessageStructure("PMU_B01", "B01, B02");
        public static T0354_MessageStructure PMU_B03  = new T0354_MessageStructure("PMU_B03", "B03");
        public static T0354_MessageStructure PMU_B04  = new T0354_MessageStructure("PMU_B04", "B04, B05, B06");
        public static T0354_MessageStructure PMU_B07  = new T0354_MessageStructure("PMU_B07", "B07");
        public static T0354_MessageStructure PMU_B08  = new T0354_MessageStructure("PMU_B08", "B08");
        public static T0354_MessageStructure PPG_PCG  = new T0354_MessageStructure("PPG_PCG", "PCC, PCG, PCH, PCJ");
        public static T0354_MessageStructure PPP_PCB  = new T0354_MessageStructure("PPP_PCB", "PCB, PCD");
        public static T0354_MessageStructure PPR_PC1  = new T0354_MessageStructure("PPR_PC1", "PC1, PC2, PC3");
        public static T0354_MessageStructure PPT_PCL  = new T0354_MessageStructure("PPT_PCL", "PCL");
        public static T0354_MessageStructure PPV_PCA  = new T0354_MessageStructure("PPV_PCA", "PCA");
        public static T0354_MessageStructure PRR_PC5  = new T0354_MessageStructure("PRR_PC5", "PC5");
        public static T0354_MessageStructure PTR_PCF  = new T0354_MessageStructure("PTR_PCF", "PCF");
        public static T0354_MessageStructure QBP_Q11  = new T0354_MessageStructure("QBP_Q11", "Q11");
        public static T0354_MessageStructure QBP_Q13  = new T0354_MessageStructure("QBP_Q13", "Q13");
        public static T0354_MessageStructure QBP_Q15  = new T0354_MessageStructure("QBP_Q15", "Q15");
        public static T0354_MessageStructure QBP_Q21  = new T0354_MessageStructure("QBP_Q21", "Q21, Q22, Q23,Q24, Q25");
        public static T0354_MessageStructure QCK_Q02  = new T0354_MessageStructure("QCK_Q02", "Q02");
        public static T0354_MessageStructure QCN_J01  = new T0354_MessageStructure("QCN_J01", "J01, J02");
        public static T0354_MessageStructure QRF_W02  = new T0354_MessageStructure("QRF_W02", "W02");
        public static T0354_MessageStructure QRY_A19  = new T0354_MessageStructure("QRY_A19", "A19");
        public static T0354_MessageStructure QRY_P04  = new T0354_MessageStructure("QRY_P04", "P04");
        public static T0354_MessageStructure QRY_PC4  = new T0354_MessageStructure("QRY_PC4", "PC4, PC9, PCE, PCK");
        public static T0354_MessageStructure QRY_Q01  = new T0354_MessageStructure("QRY_Q01", "Q01, Q26, Q27, Q28, Q29, Q30");
        public static T0354_MessageStructure QRY_Q02  = new T0354_MessageStructure("QRY_Q02", "Q02");
        public static T0354_MessageStructure QRY_R02  = new T0354_MessageStructure("QRY_R02", "R02");
        public static T0354_MessageStructure QRY_T12  = new T0354_MessageStructure("QRY_T12", "T12");
        public static T0354_MessageStructure QSB_Q16  = new T0354_MessageStructure("QSB_Q16", "Q16");
        public static T0354_MessageStructure QVR_Q17  = new T0354_MessageStructure("QVR_Q17", "Q17");
        public static T0354_MessageStructure RAR_RAR  = new T0354_MessageStructure("RAR_RAR", "RAR");
        public static T0354_MessageStructure RAS_O17  = new T0354_MessageStructure("RAS_O17", "O17");
        public static T0354_MessageStructure RCI_I05  = new T0354_MessageStructure("RCI_I05", "I05");
        public static T0354_MessageStructure RCL_I06  = new T0354_MessageStructure("RCL_I06", "I06");
        public static T0354_MessageStructure RDE_O01  = new T0354_MessageStructure("RDE_O01", "O01");
        public static T0354_MessageStructure RDE_O11  = new T0354_MessageStructure("RDE_O11", "O11, O25");
        public static T0354_MessageStructure RDR_RDR  = new T0354_MessageStructure("RDR_RDR", "RDR");
        public static T0354_MessageStructure RDS_O13  = new T0354_MessageStructure("RDS_O13", "O13");
        public static T0354_MessageStructure RDY_K15  = new T0354_MessageStructure("RDY_K15", "K15");
        public static T0354_MessageStructure REF_I12  = new T0354_MessageStructure("REF_I12", "I12, I13, I14, I15");
        public static T0354_MessageStructure RER_RER  = new T0354_MessageStructure("RER_RER", "RER");
        public static T0354_MessageStructure RGR_RGR  = new T0354_MessageStructure("RGR_RGR", "RGR");
        public static T0354_MessageStructure RGV_O15  = new T0354_MessageStructure("RGV_O15", "O15");
        public static T0354_MessageStructure ROR_ROR  = new T0354_MessageStructure("ROR_ROR", "ROR");
        public static T0354_MessageStructure RPA_I08  = new T0354_MessageStructure("RPA_I08", "I08, I09. I10, I11");
        public static T0354_MessageStructure RPI_I01  = new T0354_MessageStructure("RPI_I01", "I01, I04");
        public static T0354_MessageStructure RPL_I02  = new T0354_MessageStructure("RPL_I02", "I02");
        public static T0354_MessageStructure RPR_I03  = new T0354_MessageStructure("RPR_I03", "I03");
        public static T0354_MessageStructure RQA_I08  = new T0354_MessageStructure("RQA_I08", "I08, I09, I10, I11");
        public static T0354_MessageStructure RQC_I05  = new T0354_MessageStructure("RQC_I05", "I05, I06");
        public static T0354_MessageStructure RQI_I01  = new T0354_MessageStructure("RQI_I01", "I01, I02, I03, I07");
        public static T0354_MessageStructure RQP_I04  = new T0354_MessageStructure("RQP_I04", "I04");
        public static T0354_MessageStructure RQQ_Q09  = new T0354_MessageStructure("RQQ_Q09", "Q09");
        public static T0354_MessageStructure RRA_O02  = new T0354_MessageStructure("RRA_O02", "O02");
        public static T0354_MessageStructure RRA_O18  = new T0354_MessageStructure("RRA_O18", "O18");
        public static T0354_MessageStructure RRD_O14  = new T0354_MessageStructure("RRD_O14", "O14");
        public static T0354_MessageStructure RRE_O12  = new T0354_MessageStructure("RRE_O12", "O12, O26");
        public static T0354_MessageStructure RRG_O16  = new T0354_MessageStructure("RRG_O16", "O16");
        public static T0354_MessageStructure RRI_I12  = new T0354_MessageStructure("RRI_I12", "I12, I13, I14, I15");
        public static T0354_MessageStructure RSP_K11  = new T0354_MessageStructure("RSP_K11", "K11");
        public static T0354_MessageStructure RSP_K21  = new T0354_MessageStructure("RSP_K21", "K21");
        public static T0354_MessageStructure RSP_K22  = new T0354_MessageStructure("RSP_K22", "K22");
        public static T0354_MessageStructure RSP_K23  = new T0354_MessageStructure("RSP_K23", "K23, K24	");
        public static T0354_MessageStructure RTB_K13  = new T0354_MessageStructure("RTB_K13", "K13");
        public static T0354_MessageStructure SIU_S12  = new T0354_MessageStructure("SIU_S12", "S12, S13, S14, S15, S16, S17, S18, S19, S20, S21, S22, S23, S24, S26");
        public static T0354_MessageStructure SPQ_Q08  = new T0354_MessageStructure("SPQ_Q08", "Q08");
        public static T0354_MessageStructure SQM_S25  = new T0354_MessageStructure("SQM_S25", "S25");
        public static T0354_MessageStructure SQR_S25  = new T0354_MessageStructure("SQR_S25", "S25");
        public static T0354_MessageStructure SRM_S01  = new T0354_MessageStructure("SRM_S01", "S01, S02, S03, S04, S05, S06, S07, S08, S09, S10, S11");
        public static T0354_MessageStructure SRR_S01  = new T0354_MessageStructure("SRR_S01", "S01, S02, S03, S04, S05, S06, S07, S08, S09, S10, S11");
        public static T0354_MessageStructure SSR_U04  = new T0354_MessageStructure("SSR_U04", "U04");
        public static T0354_MessageStructure SSU_U03  = new T0354_MessageStructure("SSU_U03", "U03");
        public static T0354_MessageStructure SUR_P09  = new T0354_MessageStructure("SUR_P09", "P09");
        public static T0354_MessageStructure TBR_R08  = new T0354_MessageStructure("TBR_R08", "R08");
        public static T0354_MessageStructure TBR_R09  = new T0354_MessageStructure("TBR_R09", "R09");
        public static T0354_MessageStructure TCU_U10  = new T0354_MessageStructure("TCU_U10", "U10, U11");
        public static T0354_MessageStructure UDM_Q05  = new T0354_MessageStructure("UDM_Q05", "Q05");
        public static T0354_MessageStructure VQQ_Q07  = new T0354_MessageStructure("VQQ_Q07", "Q07");
        public static T0354_MessageStructure VXQ_V01  = new T0354_MessageStructure("VXQ_V01", "V01");
        public static T0354_MessageStructure VXR_V03  = new T0354_MessageStructure("VXR_V03", "V03");
        public static T0354_MessageStructure VXU_V04  = new T0354_MessageStructure("VXU_V04", "V04");
        public static T0354_MessageStructure VXX_V02  = new T0354_MessageStructure("VXX_V02", "V02");

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="value">Valeur de la table.</param>
        /// <param name="description">Description de la donnée.</param>
        public T0354_MessageStructure(string value, string description) : base(value, description) { }

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
