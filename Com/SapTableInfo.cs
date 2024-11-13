
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


public static class SapTableInfo
{
    public static DataTable getSapTable(string tabname,bool ishaveinclude)
    {
        DataTable dt = new DataTable();
        SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
        string sql = "";
        if (ishaveinclude)
        {
            sql += "select CAST(sys_t_x031l.position AS INTEGER) as 位置, ";
            sql += "       sys_t_x031l.fieldname as 字段, ";
            sql += "       ifnull(sys_t_et_dfies.keyflag, '') as 主键, ";
            sql += "       sys_t_x031l.rollname as 元素,";
            sql += "       sys_t_x031l.dtyp as 类型, ";
            sql += "       sys_t_x031l.exid as 数据类型, ";
            sql += "       ifnull(sys_t_et_dfies.checktable, '') as 值域表, ";
            sql += "       CAST(sys_t_dbfld.length AS INTEGER) as 长度, ";
            sql += "       sys_t_x031l.decimals as 小数位数, ";
            sql += "       '" + tabname + "-' || sys_t_x031l.fieldname as 拼接, ";
            sql += "       sys_t_dbfld.fieldtext as 描述 ";
            sql += "from sys_t_x031l LEFT join sys_t_dbfld on sys_t_dbfld.tabname = sys_t_x031l.tabname and sys_t_dbfld.fieldname = sys_t_x031l.fieldname ";
            sql += "                 LEFT join sys_t_et_dfies on sys_t_et_dfies.tabname = sys_t_x031l.tabname and sys_t_et_dfies.fieldname = sys_t_x031l.fieldname and sys_t_et_dfies.position = sys_t_x031l.position ";
            sql += "where sys_t_x031l.tabname = '" + tabname + "' ";
            sql += "order by CAST(sys_t_x031l.position AS INTEGER) ";
        }
        else
        {
            sql += "select CAST(sys_t_x031l.position AS INTEGER) as 位置, ";
            sql += "       sys_t_x031l.fieldname as 字段, ";
            sql += "       ifnull(sys_t_et_dfies.keyflag, '') as 主键, ";
            sql += "       sys_t_x031l.rollname as 元素,";
            sql += "       sys_t_x031l.dtyp as 类型, ";
            sql += "       sys_t_x031l.exid as 数据类型, ";
            sql += "       ifnull(sys_t_et_dfies.checktable, '') as 值域表, ";
            sql += "       CAST(sys_t_dbfld.length AS INTEGER) as 长度, ";
            sql += "       sys_t_x031l.decimals as 小数位数, ";
            sql += "       '" + tabname + "-' || sys_t_x031l.fieldname as 拼接, ";
            sql += "       sys_t_dbfld.fieldtext as 描述 ";
            sql += "from sys_t_x031l LEFT join sys_t_dbfld on sys_t_dbfld.tabname = sys_t_x031l.tabname and sys_t_dbfld.fieldname = sys_t_x031l.fieldname ";
            sql += "                 LEFT join sys_t_et_dfies on sys_t_et_dfies.tabname = sys_t_x031l.tabname and sys_t_et_dfies.fieldname = sys_t_x031l.fieldname and sys_t_et_dfies.position = sys_t_x031l.position ";
            sql += "where sys_t_x031l.tabname = '" + tabname + "' and CAST(sys_t_dbfld.length AS INTEGER) <> 0 ";
            sql += "order by CAST(sys_t_x031l.position AS INTEGER) ";
        }
       
        dt = sQLiteDBHelper.ExecuteDataTable(sql);
        return dt;
    }
}

