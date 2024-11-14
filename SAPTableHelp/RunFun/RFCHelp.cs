using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPTableHelp.RunFun
{
    public static class RFCHelp
    {
        public static int getTableInfo(string sTableName,ref IRfcTable table ,ref string stxtTableName )
        {
            SysConfigInfo.sFunExist = "函数:";
            int num3 = 0;
            try
            { 
                //读取表描述
                num3 = RunLTR_MODEL_GET_TABLE_TEXTS.runfun(SysConfigInfo.SapRfcDestination, SysConfigInfo.SapRfcRepository, sTableName);
            }
            catch (Exception)
            { 
                SysConfigInfo.sFunExist += "LTR_MODEL_GET_TABLE_TEXTS 函数不存在,无法读取表描述;";
            }
            try
            { 
                //读取文本表
                num3 = RunTABLE_GET_TEXTTABLE.runfun(SysConfigInfo.SapRfcDestination, SysConfigInfo.SapRfcRepository, sTableName, ref stxtTableName);

            }
            catch (Exception)
            {
                SysConfigInfo.sFunExist += "TABLE_GET_TEXTTABLE 函数不存在,无法读取文本表;"; 
            }
            try
            {
                //读取字段描述
                num3 = RunRFC_READ_TABLE.runfun(SysConfigInfo.SapRfcDestination, SysConfigInfo.SapRfcRepository, sTableName);
            }
            catch (Exception)
            {
                SysConfigInfo.sFunExist += "RFC_READ_TABLE 函数不存在,无法读取表字段;";
            }
            try
            {
                //读取字段详细信息
                num3 = RunDD_GET_NAMETAB_FOR_RFC.runfun(SysConfigInfo.SapRfcDestination, SysConfigInfo.SapRfcRepository, sTableName);
            }
            catch (Exception)
            {
                SysConfigInfo.sFunExist += "DD_GET_NAMETAB_FOR_RFC 函数不存在,无法读取表字段详细信息;";
            } 
            try
            {
                //读取字段主键 值域表 
                num3 = RunMDG_TR_NAMETAB_GET_RFC.runfun(SysConfigInfo.SapRfcDestination, SysConfigInfo.SapRfcRepository, sTableName, ref table);
            }
            catch (Exception)
            {
                SysConfigInfo.sFunExist += "MDG_TR_NAMETAB_GET_RFC 函数不存在,无法读取表字段主键信息;";
            } 
            return num3;
        } 
    }
}
