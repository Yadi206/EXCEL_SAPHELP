using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEL_SAPHELP.RunFun
{
    public static class RFCHelp
    {
        public static int getTableInfo(string sTableName,ref IRfcTable table ,ref string stxtTableName )
        {
            int num3 = 0; 
            //读取表描述
            num3 = LTR_MODEL_GET_TABLE_TEXTS.runfun(SysConfigInfo.SapRfcDestination, SysConfigInfo.SapRfcRepository, sTableName); 
            //读取文本表
            num3 = RunTABLE_GET_TEXTTABLE.runfun(SysConfigInfo.SapRfcDestination, SysConfigInfo.SapRfcRepository, sTableName, ref stxtTableName);
            //读取字段描述
            num3 = RunRFC_READ_TABLE.runfun(SysConfigInfo.SapRfcDestination, SysConfigInfo.SapRfcRepository, sTableName);
            //读取字段详细信息
            num3 = RunDD_GET_NAMETAB_FOR_RFC.runfun(SysConfigInfo.SapRfcDestination, SysConfigInfo.SapRfcRepository, sTableName);
            //读取字段主键 值域表 
            num3 = RunMDG_TR_NAMETAB_GET_RFC.runfun(SysConfigInfo.SapRfcDestination, SysConfigInfo.SapRfcRepository, sTableName,ref table); 
            return num3;
        }


    }
}
