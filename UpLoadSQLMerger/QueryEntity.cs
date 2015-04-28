using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.IO;

namespace UpLoadSQLMerger
{
    class QueryEntity
    {
        public static List<string> TransDefQuerys;
        public static List<string> FunctionInfoQuery;
        public static List<string> FunctionInfoAddRecord;

        public static List<string> FieldMessageQuery;
        public static List<string> FieldMessageAddRecord;

        public static List<string> TransSplitQuery;
        public static List<string> TransSplitAddRecord;

        public static List<string> TblExchangeQuery;
        public static List<string> TblExchangeAddRecord;

        public static List<string> TransAutoQuery;
        public static List<string> TransAutoAddRecord;

        public static List<string> VoidConfigQuery;
        public static List<string> VoidConfigAddRecord;

        public static List<string> TBLPrintModuleQuery;
        public static List<string> TBLPrintModuleAddRecord;

        public static List<string> PrintModuleGroupQuery;
        public static List<string> PrintModuleGroupAddRecord;

        public static List<string> PrintModuleGroupMemberQuery;
        public static List<string> PrintModuleGroupMemberAddRecord;

        public static List<string> DynamicDetailQuery;
        public static List<string> DynamicDetailAddRecord;

        public static List<string> DynamicItemQuery;
        public static List<string> DynamicItemAddRecord;

        public static List<string> TransCommandsQuery;

        public static List<string> OperationInfoQuery;
        public static List<string> OperationInfoAddRecord;

        public static List<string> DynamicValidQuery;
        public static List<string> DynamicValidAddRecord;

        public static List<string> TblDispContentQuery;
        public static List<string> TblDispContentAddRecord;

        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        public static bool WriteToFile()
        {
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string Logpath = path + "\\log.txt";
            string SQLpath = path + "\\sql.txt";

            //写日志文件
            try
            {
                if (File.Exists(Logpath))
                {
                    File.Delete(Logpath);
                }
            }
            catch 
            {
                return false;
            }

            using (FileStream fs = File.Create(Logpath))
            {
                AddText(fs, "Function_Info表操作:\r\n");
                foreach (string s in FunctionInfoAddRecord)
                {
                    AddText(fs, s+"\r\n");
                }

                AddText(fs, "\r\nField_message表操作:\r\n");
                foreach (string s in FieldMessageAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }

                AddText(fs, "\r\nTrans_split表操作:\r\n");
                foreach (string s in TransSplitAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }

                AddText(fs, "\r\nTbl_exchange表操作：\r\n");
                foreach (string s in TblExchangeAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nTrans_Auto表操作：\r\n");
                foreach (string s in TransAutoAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nVoid_Config表操作：\r\n");
                foreach (string s in VoidConfigAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs,"\r\nTbl_Print_Module表操作：\r\n");
                foreach(string s in TBLPrintModuleAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs,"\r\nPrint_Module_group表操作：\r\n");
                foreach(string s in PrintModuleGroupAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs,"\r\nPrint_Module_group_member表操作：\r\n");
                foreach(string s in PrintModuleGroupMemberAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs,"\r\nDynamic_Detail表操作：\r\n");
                foreach(string s in DynamicDetailAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs,"\r\nDynamic_Item表操作：\r\n");
                foreach(string s in DynamicItemAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs,"\r\nOperation_info表操作：\r\n");
                foreach(string s in OperationInfoAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs,"\r\nDynamic_Valid表操作：\r\n");
                foreach(string s in DynamicValidAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs,"\r\nTbl_Disp_Content表操作：\r\n");
                foreach (string s in TblDispContentAddRecord)
                {
                    AddText(fs, s + "\r\n");
                }

                UnicodeEncoding uniencoding = new System.Text.UnicodeEncoding();
                
                
                fs.Close();
                
                
            }

            
            

            //写sql语句
            try
            {
                if (File.Exists(SQLpath))
                {
                    File.Delete(SQLpath);
                }
            }
            catch
            {
                return false;
            }

            using (FileStream fs = File.Create(SQLpath))
            {
                AddText(fs, "Function_Info表操作:\r\n");
                foreach (string s in FunctionInfoQuery)
                {
                    AddText(fs, s + "\r\n");
                }

                AddText(fs, "\r\nField_message表操作:\r\n");
                foreach (string s in FieldMessageQuery)
                {
                    AddText(fs, s + "\r\n");
                }

                AddText(fs, "\r\nTrans_split表操作:\r\n");
                foreach (string s in TransSplitQuery)
                {
                    AddText(fs, s + "\r\n");
                }

                AddText(fs, "\r\nTbl_exchange表操作：\r\n");
                foreach (string s in TblExchangeQuery)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nTrans_Auto表操作：\r\n");
                foreach (string s in TransAutoQuery)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nVoid_Config表操作：\r\n");
                foreach (string s in VoidConfigQuery)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nTbl_Print_Module表操作：\r\n");
                foreach (string s in TBLPrintModuleQuery)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nPrint_Module_group表操作：\r\n");
                foreach (string s in PrintModuleGroupQuery)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nPrint_Module_group_member表操作：\r\n");
                foreach (string s in PrintModuleGroupMemberQuery)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nDynamic_Detail表操作：\r\n");
                foreach (string s in DynamicDetailQuery)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nDynamic_Item表操作：\r\n");
                foreach (string s in DynamicItemQuery)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nOperation_info表操作：\r\n");
                foreach (string s in OperationInfoQuery)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nDynamic_Valid表操作：\r\n");
                foreach (string s in DynamicValidQuery)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nTbl_Disp_Content表操作：\r\n");
                foreach (string s in TblDispContentQuery)
                {
                    AddText(fs, s + "\r\n");
                }

                AddText(fs, "\r\nTrans_def表操作：\r\n");
                foreach (string s in TransDefQuerys)
                {
                    AddText(fs, s + "\r\n");
                }
                AddText(fs, "\r\nTrans_commands表操作：\r\n");
                foreach (string s in TransCommandsQuery)
                {
                    AddText(fs, s + "\r\n");
                }

            }
            return true;
        }

        

        public static void CleanQuerys()
        {

            TransDefQuerys.Clear();
            FunctionInfoAddRecord.Clear();
            FunctionInfoQuery.Clear();

            FieldMessageQuery.Clear();
            FieldMessageAddRecord.Clear();

            TransSplitQuery.Clear();
            TransSplitAddRecord.Clear();

            TblExchangeQuery.Clear();
            TblExchangeAddRecord.Clear();

            TransAutoQuery.Clear();
            TransAutoAddRecord.Clear();

            VoidConfigQuery.Clear();
            VoidConfigAddRecord.Clear();

            TBLPrintModuleQuery.Clear();
            TBLPrintModuleAddRecord.Clear();

            PrintModuleGroupQuery.Clear();
            PrintModuleGroupAddRecord.Clear();

            PrintModuleGroupMemberQuery.Clear();
            PrintModuleGroupMemberAddRecord.Clear();

            DynamicDetailQuery.Clear();
            DynamicDetailAddRecord.Clear();

            DynamicItemAddRecord.Clear();
            DynamicItemQuery.Clear();

            TransCommandsQuery.Clear();

            OperationInfoQuery.Clear();
            OperationInfoAddRecord.Clear();

            DynamicValidQuery.Clear();
            DynamicValidAddRecord.Clear();

            TblDispContentQuery.Clear();
            TblDispContentAddRecord.Clear();

        }

        public QueryEntity()
        {
            TransDefQuerys = new List<string>();

            FunctionInfoAddRecord = new List<string>();
            FunctionInfoQuery = new List<string>();

            FieldMessageQuery = new List<string>();
            FieldMessageAddRecord = new List<string>();

            TransSplitQuery = new List<string>();
            TransSplitAddRecord = new List<string>();

            TblExchangeQuery = new List<string>();
            TblExchangeAddRecord = new List<string>();

            TransAutoQuery = new List<string>();
            TransAutoAddRecord = new List<string>();

            VoidConfigQuery = new List<string>();
            VoidConfigAddRecord = new List<string>();

            TBLPrintModuleQuery = new List<string>();
            TBLPrintModuleAddRecord = new List<string>();

            PrintModuleGroupQuery = new List<string>();
            PrintModuleGroupAddRecord = new List<string>();

            PrintModuleGroupMemberQuery = new List<string>();
            PrintModuleGroupMemberAddRecord = new List<string>();

            DynamicDetailQuery = new List<string>();
            DynamicDetailAddRecord = new List<string>();

            DynamicItemQuery = new List<string>();
            DynamicItemAddRecord = new List<string>();

            TransCommandsQuery = new List<string>();

            OperationInfoQuery = new List<string>();
            OperationInfoAddRecord = new List<string>();

            DynamicValidQuery = new List<string>();
            DynamicValidAddRecord = new List<string>();

            TblDispContentQuery = new List<string>();
            TblDispContentAddRecord = new List<string>();
        }
    }

    class TransQuery
    {
        public static string TransDefQuery(string sTRANSTYPE, string sTRANSCODE, string sNEXTTRANSCODE, string sAUTOVOID, string sPINBLOCK
            , string sFUNCTIONINDEX, string sTRANSNAME, string sTELEPHONENO, string sDISPTYPE, string sSERVERCODE, string sDEPTNO
            , string sREMARK, string sCASHIERBILLADRECNO,string sNII)
        {
            if (sTRANSCODE != "null") sTRANSCODE = "'" + sTRANSCODE + "'";
            if (sNEXTTRANSCODE != "null") sNEXTTRANSCODE = "'" + sNEXTTRANSCODE + "'";
            if (sAUTOVOID != "null") sAUTOVOID = "'" + sAUTOVOID + "'";
            if (sPINBLOCK != "null") sPINBLOCK = "'" + sPINBLOCK + "'";
            if (sTRANSNAME != "null") sTRANSNAME = "'" + sTRANSNAME + "'";
            if (sDISPTYPE != "null") sDISPTYPE = "'" + sDISPTYPE + "'";
            if (sSERVERCODE != "null") sSERVERCODE = "'" + sSERVERCODE + "'";
            if (sDEPTNO != "null") sDEPTNO = "'" + sDEPTNO + "'";
            if (sREMARK != "null") sREMARK = "'" + sREMARK + "'";
            if (sNII != "null") sNII = "'" + sNII + "'";

            string query =
                "insert into trans_def  (TRANS_TYPE, TRANS_CODE, NEXT_TRANS_CODE, AUTOVOID, PIN_BLOCK, FUNCTION_INDEX, TRANS_NAME, TELEPHONE_NO, DISP_TYPE, NII, SERVER_CODE, VERIFIED, SYNC_STATUS, DEPTNO, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER, REMARK, CASHIERBILLAD_RECNO)" +
"values (" + sTRANSTYPE + ", " + sTRANSCODE + ", " + sNEXTTRANSCODE + ", " + sAUTOVOID + ", " + sPINBLOCK + ", " + sFUNCTIONINDEX + ", " + sTRANSNAME + ", " + sTELEPHONENO + ", " + sDISPTYPE + "," + sNII + ", " + sSERVERCODE + ", 'T', 0, " + sDEPTNO + ", '0', to_date('16-11-2012 16:31:03', 'dd-mm-yyyy hh24:mi:ss'), '联迪设计员[000002]', to_date('05-01-2015 11:08:26', 'dd-mm-yyyy hh24:mi:ss'), '系统管理员[000002]', " + sREMARK + ", " + sCASHIERBILLADRECNO + ");";

            return query;

        }

        public static string TransCommandsQuery(string sTRANSTYPE, string iSTEP, string sFLAG, string sCOMMAND, string iFUNCINDEX, string sALOG, string sCOMMANDNAME, string sORGCOMMAND, string iDATAINDEX)
        {
            if (sFLAG != "null") sFLAG = "'" + sFLAG + "'";
            if (sCOMMAND != "null") sCOMMAND = "'" + sCOMMAND + "'";
            if (sALOG != "null") sALOG = "'" + sALOG + "'";
            if (sCOMMANDNAME != "null") sCOMMANDNAME = "'" + sCOMMANDNAME + "'";
            if (sORGCOMMAND != "null") sORGCOMMAND = "'" + sORGCOMMAND + "'";

            string query =
                "insert into trans_commands  (TRANS_TYPE, STEP, FLAG, COMMAND, FUNC_INDEX, ALOG, COMMAND_NAME, ORGCOMMAND, DATA_INDEX, VERIFIED, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER)" +
"values (" + sTRANSTYPE + ", " + iSTEP + ", " + sFLAG + ", " + sCOMMAND + ", " + iFUNCINDEX + ", " + sALOG + ", " + sCOMMANDNAME + ", " + sORGCOMMAND + ", " + iDATAINDEX + ",  'T', 0, '0', to_date('05-01-2015 11:08:19', 'dd-mm-yyyy hh24:mi:ss'), '系统管理员[000002]', to_date('05-01-2015 11:08:26', 'dd-mm-yyyy hh24:mi:ss'), '系统管理员[000002]');";

            return query;
        }

        public static string FieldMessageQuery(string iTPOSCODE, string sFBSKD, string sFIELD1, string sFIELD3, string sFIELD22, string sFIELD25, string sFIELD54, string sFIELD48REQ, string sFIELD48RESP, string iFLAG, string sTRNTYPE, string sTRNNAME, string iMSGTYPE, string sMSG48TYPE, string iAPPID, string sRESV3, string sSUBFIELD, string sFIELD4, string sFIELD60, string sDISPINFO, string sZFINFO, string sFILLFBSKD, string iMSGSPECVER, string sFIELD48REQPREFIX, string sFIELD48REQSUFFIX, string sFIELD48RESPPREFIX, string sFIELD48RESPSUFFIX, string sFIELD63REQ, string sFIELD63RESP, string sFIELD57REQ, string sFIELD57RESP, string sFIELD62REQ, string sFIELD62RESP, string sFIELD2, string sREQMINBITMAP, string sREQMAXBITMAP, string sRESMINBITMAP, string sRESMAXBITMAP, string sPRONAME, string sPRODETAIL, string sBACK, string sNEEDDIGITALSIGN, string sTIDCNVFLAG, string iCNVNO)
        {
            if (sFBSKD != "null") sFBSKD = "'" + sFBSKD + "'";
            if (sFIELD1 != "null") sFIELD1 = "'" + sFIELD1 + "'";
            if (sFIELD3 != "null") sFIELD3 = "'" + sFIELD3 + "'";
            if (sFIELD22 != "null") sFIELD22 = "'" + sFIELD22 + "'";
            if (sFIELD25 != "null") sFIELD25 = "'" + sFIELD25 + "'";
            if (sFIELD54 != "null") sFIELD54 = "'" + sFIELD54 + "'";
            if (sFIELD48REQ != "null") sFIELD48REQ = "'" + sFIELD48REQ + "'";
            if (sFIELD48RESP != "null") sFIELD48RESP = "'" + sFIELD48RESP + "'";
            if (sTRNTYPE != "null") sTRNTYPE = "'" + sTRNTYPE + "'";
            if (sTRNNAME != "null") sTRNNAME = "'" + sTRNNAME + "'";
            if (sMSG48TYPE != "null") sMSG48TYPE = "'" + sMSG48TYPE + "'";
            if (sRESV3 != "null") sRESV3 = "'" + sRESV3 + "'";
            if (sSUBFIELD != "null") sSUBFIELD = "'" + sSUBFIELD + "'";
            if (sFIELD4 != "null") sFIELD4 = "'" + sFIELD4 + "'";
            if (sFIELD60 != "null") sFIELD60 = "'" + sFIELD60 + "'";
            if (sDISPINFO != "null") sDISPINFO = "'" + sDISPINFO + "'";
            if (sZFINFO != "null") sZFINFO = "'" + sZFINFO + "'";
            if (sFILLFBSKD != "null") sFILLFBSKD = "'" + sFILLFBSKD + "'";
            if (sFIELD48REQPREFIX != "null") sFIELD48REQPREFIX = "'" + sFIELD48REQPREFIX + "'";
            if (sFIELD48REQSUFFIX != "null") sFIELD48REQSUFFIX = "'" + sFIELD48REQSUFFIX + "'";
            if (sFIELD48RESPPREFIX != "null") sFIELD48RESPPREFIX = "'" + sFIELD48RESPPREFIX + "'";
            if (sFIELD48RESPSUFFIX != "null") sFIELD48RESPSUFFIX = "'" + sFIELD48RESPSUFFIX + "'";
            if (sFIELD63REQ != "null") sFIELD63REQ = "'" + sFIELD63REQ + "'";
            if (sFIELD63RESP != "null") sFIELD63RESP = "'" + sFIELD63RESP + "'";
            if (sFIELD57REQ != "null") sFIELD57REQ = "'" + sFIELD57REQ + "'";
            if (sFIELD57RESP != "null") sFIELD57RESP = "'" + sFIELD57RESP + "'";
            if (sFIELD62REQ != "null") sFIELD62REQ = "'" + sFIELD62REQ + "'";
            if (sFIELD62RESP != "null") sFIELD62RESP = "'" + sFIELD62RESP + "'";
            if (sFIELD2 != "null") sFIELD2 = "'" + sFIELD2 + "'";
            if (sREQMINBITMAP != "null") sREQMINBITMAP = "'" + sREQMINBITMAP + "'";
            if (sREQMAXBITMAP != "null") sREQMAXBITMAP = "'" + sREQMAXBITMAP + "'";
            if (sRESMINBITMAP != "null") sRESMINBITMAP = "'" + sRESMINBITMAP + "'";
            if (sRESMAXBITMAP != "null") sRESMAXBITMAP = "'" + sRESMAXBITMAP + "'";
            if (sPRONAME != "null") sPRONAME = "'" + sPRONAME + "'";
            if (sPRODETAIL != "null") sPRODETAIL = "'" + sPRODETAIL + "'";
            if (sBACK != "null") sBACK = "'" + sBACK + "'";
            if (sNEEDDIGITALSIGN != "null") sNEEDDIGITALSIGN = "'" + sNEEDDIGITALSIGN + "'";
            if (sTIDCNVFLAG != "null") sTIDCNVFLAG = "'" + sTIDCNVFLAG + "'";


            string query =
                "insert into field_message  (TPOS_CODE, FBSKD, FIELD1, FIELD3, FIELD22, FIELD25, FIELD54, FIELD48_REQ, FIELD48_RESP, FLAG, TRN_TYPE, TRN_NAME, MSG_TYPE, MSG48_TYPE, APP_ID, RESV3, SUBFIELD, FIELD4, FIELD60, VERIFIED, SYNC_STATUS, DISPINFO, ZFINFO, DELETE_FLAG, FILL_FBSKD, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER, MSG_SPEC_VER, FIELD48_REQ_PREFIX, FIELD48_REQ_SUFFIX, FIELD48_RESP_PREFIX, FIELD48_RESP_SUFFIX, FIELD63_REQ, FIELD63_RESP, FIELD57_REQ, FIELD57_RESP, FIELD62_REQ, FIELD62_RESP, FIELD2, REQ_MIN_BITMAP, REQ_MAX_BITMAP, RES_MIN_BITMAP, RES_MAX_BITMAP, PRONAME, PRODETAIL, BACK, NEED_DIGITAL_SIGN, TIDCNV_FLAG, CNV_NO) values (" + iTPOSCODE + ", " + sFBSKD + ", " + sFIELD1 + ", " + sFIELD3 + ", " + sFIELD22 + ", " + sFIELD25 + ", " + sFIELD54 + ", " + sFIELD48REQ + ", " + sFIELD48RESP + ", " + iFLAG + ", " + sTRNTYPE + ", " + sTRNNAME + ", " + iMSGTYPE + ", " + sMSG48TYPE + ", " + iAPPID + ", " + sRESV3 + ", " + sSUBFIELD + ", " + sFIELD4 + ",  " + sFIELD60 + ",  'T', 0, " + sDISPINFO + ", " + sZFINFO + " , '0', " + sFILLFBSKD + ", to_date('16-11-2012 17:28:02', 'dd-mm-yyyy hh24:mi:ss'), '联迪设计员[000002]', to_date('05-01-2015 11:14:22', 'dd-mm-yyyy hh24:mi:ss'), '系统管理员[000002]', " + iMSGSPECVER + ", " + sFIELD48REQPREFIX + "," + sFIELD48REQSUFFIX + ", " + sFIELD48RESPPREFIX + ", " + sFIELD48RESPSUFFIX + ", " + sFIELD63REQ + ", " + sFIELD63RESP + ", " + sFIELD57REQ + ", " + sFIELD57RESP + ", " + sFIELD62REQ + ", " + sFIELD62RESP + ", " + sFIELD2 + ", " + sREQMINBITMAP + ", " + sREQMAXBITMAP + ", " + sRESMINBITMAP + "," + sRESMAXBITMAP + ", " + sPRONAME + ", " + sPRODETAIL + ", " + sBACK + ", " + sNEEDDIGITALSIGN + ", " + sTIDCNVFLAG + ", " + iCNVNO + ");";

            return query;
        }

        public static string TransSplitQuery(string iTRANSTYPE, string sCONDNEXTTRANSTYPES, string sFLAG, string sTRANSNAME)
        {
            if (sCONDNEXTTRANSTYPES != "null") sCONDNEXTTRANSTYPES = "'" + sCONDNEXTTRANSTYPES + "'";
            if (sFLAG != "null") sFLAG = "'" + sFLAG + "'";
            if (sTRANSNAME != "null") sTRANSNAME = "'" + sTRANSNAME + "'";

            string query =
            "insert into trans_split (TRANS_TYPE, COND_NEXT_TRANS_TYPES, VERIFIED, DELETE_FLAG, SYNC_STATUS, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER, FLAG) values (" + iTRANSTYPE + "," + sCONDNEXTTRANSTYPES + ",'T', '0', 0, to_date('02-11-2012 16:17:58', 'dd-mm-yyyy hh24:mi:ss'), null, to_date('02-11-2012 16:17:58', 'dd-mm-yyyy hh24:mi:ss'), null," + sFLAG + ");";

            return query;
        }

        public static string TblExchangeQuery(string iTRANSTYPE, string sBEFORE, string sAFTER)
        {
            if (sBEFORE != "null") sBEFORE = "'" + sBEFORE + "'";
            if (sAFTER != "null") sAFTER = "'" + sAFTER + "'";

            string query =
                "insert into tbl_exchange (TRANS_TYPE, BEFORE, AFTER, VERIFIED, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER) values (" + iTRANSTYPE + ", " + sBEFORE + ", " + sAFTER + ", 'T', 0, '0', to_date('25-02-2014 09:50:57', 'dd-mm-yyyy hh24:mi:ss'), '1', to_date('25-02-2014 09:50:57', 'dd-mm-yyyy hh24:mi:ss'), '1');";

            return query;
        }

        public static string TransAutoQuery(string iTRANSTYPE, string iNEXTTRANSTYPE)
        {
            string query =
                "insert into trans_auto (TRANS_TYPE, NEXT_TRANS_TYPE, VERIFIED, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER) values (" + iTRANSTYPE + ", " + iNEXTTRANSTYPE + ", 'F', 0, '0', to_date('16-10-2013 14:15:54', 'dd-mm-yyyy hh24:mi:ss'), '系统管理员[000002]', to_date('16-10-2013 14:15:54', 'dd-mm-yyyy hh24:mi:ss'), '系统管理员[000002]');";

            return query;
        }

        public static string VoidConfigQuery(string iTRANSTYPE)
        {
            string query =
                "insert into void_config (TRANS_TYPE, VERIFIED, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER) values (" + iTRANSTYPE + ", 'T', 0, '0', to_date('12-10-2013 12:30:53', 'dd-mm-yyyy hh24:mi:ss'), '系统管理员[000002]', to_date('25-10-2013 10:55:12', 'dd-mm-yyyy hh24:mi:ss'), '系统管理员[000002]');";

            return query;
        }

        public static string PrintModuleGroupQuery(string iGROUPID, string sGROUPNAME, string sDEPTNO)
        {
            if (sGROUPNAME != "null") sGROUPNAME = "'" + sGROUPNAME + "'";
            if (sDEPTNO != "null") sDEPTNO = "'" + sDEPTNO + "'";

            string query =
                "insert into print_module_group (GROUP_ID, GROUP_NAME, VERIFIED, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER, DEPT_NO) values (" + iGROUPID + ", " + sGROUPNAME + ", 'T', 0, '0', to_date('02-11-2012 13:22:19', 'dd-mm-yyyy hh24:mi:ss'), null, to_date('02-11-2012 13:22:19', 'dd-mm-yyyy hh24:mi:ss'), null, " + sDEPTNO + ");";

            return query;
        }

        public static string PrintModuleGroupMemberQuery(string iGROUPID, string iMODULE, string sRETURNCODE, string sSTYLUSPRINTERFLAG, string sID, string sDEPTNO, string sTMISPRINTERFLAG)
        {
            if (sRETURNCODE != "null") sRETURNCODE = "'" + sRETURNCODE + "'";
            if (sSTYLUSPRINTERFLAG != "null") sSTYLUSPRINTERFLAG = "'" + sSTYLUSPRINTERFLAG + "'";
            if (sID != "null") sID = "'" + sID + "'";
            if (sDEPTNO != "null") sDEPTNO = "'" + sDEPTNO + "'";
            if (sTMISPRINTERFLAG != "null") sTMISPRINTERFLAG = "'" + sTMISPRINTERFLAG + "'";
            string query =
                "insert into print_module_group_member (GROUP_ID, MODULE, RETURN_CODE, VERIFIED, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER, STYLUS_PRINTER_FLAG, ID, DEPT_NO, TMIS_PRINTER_FLAG) values (" + iGROUPID + ", " + iMODULE + ", " + sRETURNCODE + ", 'T', 0, '0', to_date('02-11-2012 13:22:20', 'dd-mm-yyyy hh24:mi:ss'), null, to_date('02-11-2012 13:22:20', 'dd-mm-yyyy hh24:mi:ss'), null, " + sSTYLUSPRINTERFLAG + ", " + sID + ", " + sDEPTNO + ", " + sTMISPRINTERFLAG + ");";

            return query;
        }

        public static string TblPrintModuleQuery(string iMODULE, string sDESCRIBE, string iPRINT_NUM, string iTITLE1, string iTITLE2, string iTITLE3, string iSIGN1, string iSIGN2, string iSIGN3, string iREC_NUM, string sREC_NO, string sLOGOFLAG, string sDEPTNO)
        {
            if (sDESCRIBE != "null") sDESCRIBE = "'" + sDESCRIBE + "'";
            if (sREC_NO != "null") sREC_NO = "'" + sREC_NO + "'";
            if (sLOGOFLAG != "null") sLOGOFLAG = "'" + sLOGOFLAG + "'";
            if (sDEPTNO != "null") sDEPTNO = "'" + sDEPTNO + "'";

            string query =
                "insert into Tbl_print_module (MODULE, DESCRIBE, PRINT_NUM, TITLE1, TITLE2, TITLE3, SIGN1, SIGN2, SIGN3, REC_NUM, REC_NO, VERIFIED, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER, LOGO_FLAG, DEPT_NO) values (" + iMODULE + "," + sDESCRIBE + "," + iPRINT_NUM + "," + iTITLE1 + "," + iTITLE2 + "," + iTITLE3 + "," + iSIGN1 + "," + iSIGN2 + "," + iSIGN3 + "," + iREC_NUM + "," + sREC_NO + ",'T', 0, '0', to_date('09-10-2012 16:53:13', 'dd-mm-yyyy hh24:mi:ss'), null, to_date('18-11-2013 10:12:09', 'dd-mm-yyyy hh24:mi:ss'), '系统管理员[000002]'," + sLOGOFLAG + "," + sDEPTNO + ");";

            return query;
        }

        public static string FunctionInfoQuery(string iFUNCINDEX, string sOPFLAG, string iMODULENUM, string sINFO1FORMAT, string sINFO1, string sINFO2FORMAT, string sINFO2, string sINFO3_FORMAT, string sINFO3)
        {
            if (sOPFLAG != "null") sOPFLAG = "'" + sOPFLAG + "'";
            if (sINFO1FORMAT != "null") sINFO1FORMAT = "'" + sINFO1FORMAT + "'";
            if (sINFO1 != "null") sINFO1 = "'" + sINFO1 + "'";
            if (sINFO2FORMAT != "null") sINFO2FORMAT = "'" + sINFO2FORMAT + "'";
            if (sINFO2 != "null") sINFO2 = "'" + sINFO2 + "'";
            if (sINFO3_FORMAT != "null") sINFO3_FORMAT = "'" + sINFO3_FORMAT + "'";
            if (sINFO3 != "null") sINFO3 = "'" + sINFO3 + "'";

            string query =
                "insert into function_info (FUNC_INDEX, OP_FLAG, MODULE_NUM, INFO1_FORMAT, INFO1, INFO2_FORMAT, INFO2, INFO3_FORMAT, INFO3, UPDATE_DATE, VERIFIED, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER) values (" + iFUNCINDEX + "," + sOPFLAG + "," + iMODULENUM + "," + sINFO1FORMAT + "," + sINFO1 + "," + sINFO2FORMAT + "," + sINFO2 + "," + sINFO3_FORMAT + "," + sINFO3 + ",'20120523', 'T', 0, '0', to_date('09-10-2012 16:53:12', 'dd-mm-yyyy hh24:mi:ss'), null, to_date('09-10-2012 16:53:12', 'dd-mm-yyyy hh24:mi:ss'), null);";

            return query;

        }

        public static string DynamicItemQuery(string iRECNO, string sTITLE, string sDESCRIBE, string iITEMNUM, string sDATARULE, string sMARKS, string iDATASCRTYPE, string sVARIABLE)
        {
            if (sTITLE != "null") sTITLE = "'" + sTITLE + "'";
            if (sDESCRIBE != "null") sDESCRIBE = "'" + sDESCRIBE + "'";
            if (sDATARULE != "null") sDATARULE = "'" + sDATARULE + "'";
            if (sMARKS != "null") sMARKS = "'" + sMARKS + "'";
            if (sVARIABLE != "null") sVARIABLE = "'" + sVARIABLE + "'";

            string query =
                "insert into dynamic_item (RECNO, TITLE, DESCRIBE, ITEM_NUM, DATA_RULE, VERIFIED, MARKS, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER, DATA_SCR_TYPE, VARIABLE) values (" + iRECNO + "," + sTITLE + "," + sDESCRIBE + "," + iITEMNUM + "," + sDATARULE + ", 'T'+," + sMARKS + ",0, '0', to_date('02-11-2012 13:22:23', 'dd-mm-yyyy hh24:mi:ss'), null, to_date('02-11-2012 13:22:23', 'dd-mm-yyyy hh24:mi:ss'), null," + iDATASCRTYPE + "," + sVARIABLE + ");";

            return query;
        }

        public static string DynamicDetailQuery(string iRECNO, string iSTEP, string sITEMNAME, string sITEMVALUE, string sSTATUS, string sTRANSCODE, string sRSV, string sNEEDINPUT)
        {
            if (sSTATUS != "null") sSTATUS = "'" + sSTATUS + "'";
            if (sTRANSCODE != "null") sTRANSCODE = "'" + sTRANSCODE + "'";
            if (sITEMNAME != "null") sITEMNAME = "'" + sITEMNAME + "'";
            if (sITEMVALUE != "null") sITEMVALUE = "'" + sITEMVALUE + "'";
            if (sRSV != "null") sRSV = "'" + sRSV + "'";
            if (sNEEDINPUT != "null") sNEEDINPUT = "'" + sNEEDINPUT + "'";

            string query =
            "insert into dynamic_detail (REC_NO, STEP, ITEM_NAME, ITEM_VALUE, STATUS, TRANS_CODE, RSV, VERIFIED, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER, NEED_INPUT) values (" + iRECNO + "," + iSTEP + "," + sITEMNAME + "," + sITEMVALUE + "," + sSTATUS + "," + sTRANSCODE + "," + sRSV + ", 'T', 0, '0', to_date('02-11-2012 13:22:23', 'dd-mm-yyyy hh24:mi:ss'), null, to_date('02-11-2012 13:22:23', 'dd-mm-yyyy hh24:mi:ss'), null," + sNEEDINPUT + ");";

            return query;
        }

        public static string DynamicValidQuery(string iRECNO, string iMINLEN, string iMAXLEN, string iMINVAL, string iMAXVAL, string sINPUTFLAG, string sINPUTTYPE, string sRSV, string iOPTNUM1, string iOPTNUM2, string sOPTCODE, string sINPUT_NAME)
        {
            if (sINPUTFLAG != "null") sINPUTFLAG = "'" + sINPUTFLAG + "'";
            if (sINPUTTYPE != "null") sINPUTTYPE = "'" + sINPUTTYPE + "'";
            if (sRSV != "null") sRSV = "'" + sRSV + "'";
            if (sOPTCODE != "null") sOPTCODE = "'" + sOPTCODE + "'";
            if (sINPUT_NAME != "null") sINPUT_NAME = "'" + sINPUT_NAME + "'";

            string query =
                "insert into Dynamic_valid (REC_NO, MINLEN, MAXLEN, MINVAL, MAXVAL, INPUT_FLAG, INPUT_TYPE, RSV, VERIFIED, ADD_DATE, OPTNUM1, OPTNUM2, OPTCODE, INPUT_NAME, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER) values (" + iRECNO + "," + iMINLEN + "," + iMAXLEN + "," + iMINVAL + "," + iMAXVAL + "," + sINPUTFLAG + "," + sINPUTTYPE + "," + sRSV + ",'T', '20110819'," + iOPTNUM1 + "," + iOPTNUM2 + "," + sOPTCODE + "," + sINPUT_NAME + ", 0, '0', to_date('02-11-2012 13:22:23', 'dd-mm-yyyy hh24:mi:ss'), null, to_date('26-08-2013 15:54:39', 'dd-mm-yyyy hh24:mi:ss'), '系统管理员[000002]');";

            return query;

        }

        public static string TblDispContentQuery(string iDATAINDEX, string sLINES, string iTIMEOUT, string iCTRLBITMAP, string sREFRESHMODE)
        {
            if (sLINES != "null") sLINES = "'" + sLINES + "'";
            if (sREFRESHMODE != "null") sREFRESHMODE = "'" + sREFRESHMODE + "'";

            string query =
                "insert into tbl_disp_content (DATA_INDEX, LINES, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER, VERIFIED, TIMEOUT, CTRL_BITMAP, REFRESH_MODE) values (" + iDATAINDEX + "," + sLINES + ", 0, '0', to_date('17-04-2013 13:43:15', 'dd-mm-yyyy hh24:mi:ss'), '系统管理员[000002]', to_date('23-08-2013 12:46:47', 'dd-mm-yyyy hh24:mi:ss'), '系统管理员[000002]', 'T'," + iTIMEOUT + "," + iCTRLBITMAP + "," + sREFRESHMODE + ");";

            return query;

        }

        public static string OperationInfoQuery(string iOPERINDEX, string sOPFLAG, string iMODULENUM, string sINFO1FORMAT, string sINFO1, string sINFO2FORMAT, string sINFO2, string sINFO3FORMAT, string sINFO3)
        {
            if (sOPFLAG != "null") sOPFLAG = "'" + sOPFLAG + "'";
            if (sINFO1FORMAT != "null") sINFO1FORMAT = "'" + sINFO1FORMAT + "'";
            if (sINFO1 != "null") sINFO1 = "'" + sINFO1 + "'";
            if (sINFO2FORMAT != "null") sINFO2FORMAT = "'" + sINFO2FORMAT + "'";
            if (sINFO2 != "null") sINFO2 = "'" + sINFO2 + "'";
            if (sINFO3FORMAT != "null") sINFO3FORMAT = "'" + sINFO3FORMAT + "'";
            if (sINFO3 != "null") sINFO3 = "'" + sINFO3 + "'";

            string query =
                "insert into Operation_info (OPER_INDEX, OP_FLAG, MODULE_NUM, INFO1_FORMAT, INFO1, INFO2_FORMAT, INFO2, INFO3_FORMAT, INFO3, UPDATE_DATE, VERIFIED, SYNC_STATUS, DELETE_FLAG, CREATEDATE, CREATER, LASTMODIFIED, LASTMODIFIER) values (" + iOPERINDEX + "," + sOPFLAG + "," + iMODULENUM + "," + sINFO1FORMAT + "," + sINFO1 + "," + sINFO2FORMAT + "," + sINFO2 + "," + sINFO3FORMAT + "," + sINFO3 + ", '20110916', 'T', 0, '0', to_date('09-10-2012 16:53:12', 'dd-mm-yyyy hh24:mi:ss'), null, to_date('09-10-2012 16:53:12', 'dd-mm-yyyy hh24:mi:ss'), null);";

            return query;
        }
    }
}
