using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpLoadSQLMerger
{
    class session
    {
        private session() { }
        private static readonly session instance = new session();
        public static session Instance
        {
            get
            {
                return instance;
            }
        }

        private static readonly OnlineDBTableAdapters.TableAdapterManager _ONLINEDB = new OnlineDBTableAdapters.TableAdapterManager();
        private static readonly PRDTPOSDBTableAdapters.TableAdapterManager _TPOSDB = new PRDTPOSDBTableAdapters.TableAdapterManager();

        public OnlineDBTableAdapters.TableAdapterManager ONLINEDB
        {
            get
            {
                if (_ONLINEDB.DYNAMIC_DETAILTableAdapter == null) _ONLINEDB.DYNAMIC_DETAILTableAdapter = new OnlineDBTableAdapters.DYNAMIC_DETAILTableAdapter();
                if (_ONLINEDB.DYNAMIC_ITEMTableAdapter == null) _ONLINEDB.DYNAMIC_ITEMTableAdapter = new OnlineDBTableAdapters.DYNAMIC_ITEMTableAdapter();
                if (_ONLINEDB.DYNAMIC_VALIDTableAdapter == null) _ONLINEDB.DYNAMIC_VALIDTableAdapter = new OnlineDBTableAdapters.DYNAMIC_VALIDTableAdapter();
                if (_ONLINEDB.FIELD_MESSAGETableAdapter == null) _ONLINEDB.FIELD_MESSAGETableAdapter = new OnlineDBTableAdapters.FIELD_MESSAGETableAdapter();
                if (_ONLINEDB.PRINT_MODULE_GROUP_MEMBERTableAdapter == null) _ONLINEDB.PRINT_MODULE_GROUP_MEMBERTableAdapter = new OnlineDBTableAdapters.PRINT_MODULE_GROUP_MEMBERTableAdapter();
                if (_ONLINEDB.PRINT_MODULE_GROUPTableAdapter == null) _ONLINEDB.PRINT_MODULE_GROUPTableAdapter = new OnlineDBTableAdapters.PRINT_MODULE_GROUPTableAdapter();
                if (_ONLINEDB.TRANS_AUTOTableAdapter == null) _ONLINEDB.TRANS_AUTOTableAdapter = new OnlineDBTableAdapters.TRANS_AUTOTableAdapter();
                if (_ONLINEDB.TRANS_COMMANDSTableAdapter == null) _ONLINEDB.TRANS_COMMANDSTableAdapter = new OnlineDBTableAdapters.TRANS_COMMANDSTableAdapter();
                if (_ONLINEDB.TRANS_DEFTableAdapter == null) _ONLINEDB.TRANS_DEFTableAdapter = new OnlineDBTableAdapters.TRANS_DEFTableAdapter();
                if (_ONLINEDB.TRANS_SPLITTableAdapter == null) _ONLINEDB.TRANS_SPLITTableAdapter = new OnlineDBTableAdapters.TRANS_SPLITTableAdapter();
                if (_ONLINEDB.TBL_PRINT_MODULETableAdapter == null) _ONLINEDB.TBL_PRINT_MODULETableAdapter = new OnlineDBTableAdapters.TBL_PRINT_MODULETableAdapter();
                if (_ONLINEDB.TBL_EXCHANGETableAdapter == null) _ONLINEDB.TBL_EXCHANGETableAdapter = new OnlineDBTableAdapters.TBL_EXCHANGETableAdapter();
                if (_ONLINEDB.TBL_DISP_CONTENTTableAdapter == null) _ONLINEDB.TBL_DISP_CONTENTTableAdapter = new OnlineDBTableAdapters.TBL_DISP_CONTENTTableAdapter();
                if (_ONLINEDB.VOID_CONFIGTableAdapter == null) _ONLINEDB.VOID_CONFIGTableAdapter = new OnlineDBTableAdapters.VOID_CONFIGTableAdapter();
                if (_ONLINEDB.OPERATION_INFOTableAdapter == null) _ONLINEDB.OPERATION_INFOTableAdapter = new OnlineDBTableAdapters.OPERATION_INFOTableAdapter();
                if (_ONLINEDB.FUNCTION_INFOTableAdapter == null) _ONLINEDB.FUNCTION_INFOTableAdapter = new OnlineDBTableAdapters.FUNCTION_INFOTableAdapter();
                return _ONLINEDB;
            }
        }
        public PRDTPOSDBTableAdapters.TableAdapterManager TPOSDB
        {
            get
            {
                if (_TPOSDB.DYNAMIC_DETAILTableAdapter == null) _TPOSDB.DYNAMIC_DETAILTableAdapter = new PRDTPOSDBTableAdapters.DYNAMIC_DETAILTableAdapter();
                if (_TPOSDB.DYNAMIC_ITEMTableAdapter == null) _TPOSDB.DYNAMIC_ITEMTableAdapter = new PRDTPOSDBTableAdapters.DYNAMIC_ITEMTableAdapter();
                if (_TPOSDB.DYNAMIC_VALIDTableAdapter == null) _TPOSDB.DYNAMIC_VALIDTableAdapter = new PRDTPOSDBTableAdapters.DYNAMIC_VALIDTableAdapter();
                if (_TPOSDB.FIELD_MESSAGETableAdapter == null) _TPOSDB.FIELD_MESSAGETableAdapter = new PRDTPOSDBTableAdapters.FIELD_MESSAGETableAdapter();
                if (_TPOSDB.PRINT_MODULE_GROUP_MEMBERTableAdapter == null) _TPOSDB.PRINT_MODULE_GROUP_MEMBERTableAdapter = new PRDTPOSDBTableAdapters.PRINT_MODULE_GROUP_MEMBERTableAdapter();
                if (_TPOSDB.PRINT_MODULE_GROUPTableAdapter == null) _TPOSDB.PRINT_MODULE_GROUPTableAdapter = new PRDTPOSDBTableAdapters.PRINT_MODULE_GROUPTableAdapter();
                if (_TPOSDB.TRANS_AUTOTableAdapter == null) _TPOSDB.TRANS_AUTOTableAdapter = new PRDTPOSDBTableAdapters.TRANS_AUTOTableAdapter();
                if (_TPOSDB.TRANS_COMMANDSTableAdapter == null) _TPOSDB.TRANS_COMMANDSTableAdapter = new PRDTPOSDBTableAdapters.TRANS_COMMANDSTableAdapter();
                if (_TPOSDB.TRANS_DEFTableAdapter == null) _TPOSDB.TRANS_DEFTableAdapter = new PRDTPOSDBTableAdapters.TRANS_DEFTableAdapter();
                if (_TPOSDB.TRANS_SPLITTableAdapter == null) _TPOSDB.TRANS_SPLITTableAdapter = new PRDTPOSDBTableAdapters.TRANS_SPLITTableAdapter();
                if (_TPOSDB.TBL_PRINT_MODULETableAdapter == null) _TPOSDB.TBL_PRINT_MODULETableAdapter = new PRDTPOSDBTableAdapters.TBL_PRINT_MODULETableAdapter();
                if (_TPOSDB.TBL_EXCHANGETableAdapter == null) _TPOSDB.TBL_EXCHANGETableAdapter = new PRDTPOSDBTableAdapters.TBL_EXCHANGETableAdapter();
                if (_TPOSDB.TBL_DISP_CONTENTTableAdapter == null) _TPOSDB.TBL_DISP_CONTENTTableAdapter = new PRDTPOSDBTableAdapters.TBL_DISP_CONTENTTableAdapter();
                if (_TPOSDB.VOID_CONFIGTableAdapter == null) _TPOSDB.VOID_CONFIGTableAdapter = new PRDTPOSDBTableAdapters.VOID_CONFIGTableAdapter();
                if (_TPOSDB.OPERATION_INFOTableAdapter == null) _TPOSDB.OPERATION_INFOTableAdapter = new PRDTPOSDBTableAdapters.OPERATION_INFOTableAdapter();
                if (_TPOSDB.FUNCTION_INFOTableAdapter == null) _TPOSDB.FUNCTION_INFOTableAdapter = new PRDTPOSDBTableAdapters.FUNCTION_INFOTableAdapter();
                return _TPOSDB;
            }
        }
    }
}
