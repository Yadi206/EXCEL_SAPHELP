using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;


public static class SapTableInfo
{
    public static string SaveTableInfo(string tableName, ref List<DD03L> gl_dd03ls, ref string TxtTable)
    {
        string rmsg = "";
        int result = 0;
        string text1 = "";
        string text2 = "";
        string text3 = "";
        string text4 = "";
        try
        {
            //处理sys_t_tables
            text1 = "delete from sys_t_tables where tabname = '" + tableName + "';";
            text2 += "delete from sys_t_dbfld where tabname = '" + tableName + "';";
            text3 += "delete from sys_t_x031l where tabname = '" + tableName + "';";
            text4 += "delete from sys_t_et_dfies where tabname = '" + tableName + "';";
            string langu = "1";
            if (SysConfigInfo.parms["LANG"].ToString() == "SR") langu = "0";
            if (SysConfigInfo.parms["LANG"].ToString() == "ZH") langu = "1";
            if (SysConfigInfo.parms["LANG"].ToString() == "TH") langu = "2";
            if (SysConfigInfo.parms["LANG"].ToString() == "KO") langu = "3";
            if (SysConfigInfo.parms["LANG"].ToString() == "RO") langu = "4";
            if (SysConfigInfo.parms["LANG"].ToString() == "SL") langu = "5";
            if (SysConfigInfo.parms["LANG"].ToString() == "HR") langu = "6";
            if (SysConfigInfo.parms["LANG"].ToString() == "MS") langu = "7";
            if (SysConfigInfo.parms["LANG"].ToString() == "UK") langu = "8";
            if (SysConfigInfo.parms["LANG"].ToString() == "ET") langu = "9";
            if (SysConfigInfo.parms["LANG"].ToString() == "AR") langu = "A";
            if (SysConfigInfo.parms["LANG"].ToString() == "HE") langu = "B";
            if (SysConfigInfo.parms["LANG"].ToString() == "CS") langu = "C";
            if (SysConfigInfo.parms["LANG"].ToString() == "DE") langu = "D";
            if (SysConfigInfo.parms["LANG"].ToString() == "EN") langu = "E";
            if (SysConfigInfo.parms["LANG"].ToString() == "FR") langu = "F";
            if (SysConfigInfo.parms["LANG"].ToString() == "EL") langu = "G";
            if (SysConfigInfo.parms["LANG"].ToString() == "HU") langu = "H";
            if (SysConfigInfo.parms["LANG"].ToString() == "IT") langu = "I";
            if (SysConfigInfo.parms["LANG"].ToString() == "JA") langu = "J";
            if (SysConfigInfo.parms["LANG"].ToString() == "DA") langu = "K";
            if (SysConfigInfo.parms["LANG"].ToString() == "PL") langu = "L";
            if (SysConfigInfo.parms["LANG"].ToString() == "ZF") langu = "M";
            if (SysConfigInfo.parms["LANG"].ToString() == "NL") langu = "N";
            if (SysConfigInfo.parms["LANG"].ToString() == "NO") langu = "O";
            if (SysConfigInfo.parms["LANG"].ToString() == "PT") langu = "P";
            if (SysConfigInfo.parms["LANG"].ToString() == "SK") langu = "Q";
            if (SysConfigInfo.parms["LANG"].ToString() == "RU") langu = "R";
            if (SysConfigInfo.parms["LANG"].ToString() == "ES") langu = "S";
            if (SysConfigInfo.parms["LANG"].ToString() == "TR") langu = "T";
            if (SysConfigInfo.parms["LANG"].ToString() == "FI") langu = "U";
            if (SysConfigInfo.parms["LANG"].ToString() == "SV") langu = "V";
            if (SysConfigInfo.parms["LANG"].ToString() == "BG") langu = "W";
            if (SysConfigInfo.parms["LANG"].ToString() == "LT") langu = "X";
            if (SysConfigInfo.parms["LANG"].ToString() == "LV") langu = "Y";
            if (SysConfigInfo.parms["LANG"].ToString() == "Z1") langu = "Z";
            if (SysConfigInfo.parms["LANG"].ToString() == "AF") langu = "a";
            if (SysConfigInfo.parms["LANG"].ToString() == "IS") langu = "b";
            if (SysConfigInfo.parms["LANG"].ToString() == "CA") langu = "c";
            if (SysConfigInfo.parms["LANG"].ToString() == "SH") langu = "d";
            if (SysConfigInfo.parms["LANG"].ToString() == "ID") langu = "i";
            if (SysConfigInfo.parms["LANG"].ToString() == "HI") langu = "묩";
            if (SysConfigInfo.parms["LANG"].ToString() == "KK") langu = "뱋";
            if (SysConfigInfo.parms["LANG"].ToString() == "VI") langu = "쁩";

            DD02T dd02t = new DD02T(tableName, langu);
            if (string.IsNullOrEmpty(dd02t.DDTEXT))
            {
                dd02t = new DD02T(tableName, "E");
            }


            DD08L dd08l = new DD08L(tableName);
            if (dd08l != null && !string.IsNullOrEmpty(dd08l.TABNAME))
            {
                TxtTable = dd08l.TABNAME.Replace("'", "").Replace(" ", "");
            }
            else
            {
                TxtTable = "";
            }

            text1 += "insert into sys_t_tables (tabname, tabdescribe, tabtxtname) values ('" + dd02t.TABNAME.Replace("'", "").Replace(" ", "") + "','" + dd02t.DDTEXT.Replace("'", "").Replace(" ", "") + "','" + TxtTable + "');";

            DD03L dd03l = new DD03L(tableName);
            gl_dd03ls = dd03l.getDD03Ls(tableName);
            DD03T dd03t = new DD03T(tableName);
            List<DD03T> dd03ts = dd03t.getDD03Ts(tableName);
            DD03VT dd03vt = new DD03VT(tableName);
            List<DD03VT> dd03vts = dd03vt.getDD03VTs(tableName);

            //DD03L_Columns.Add("TABNAME");//表名 
            //DD03L_Columns.Add("POSITION");//表格中区域的位置 
            //DD03L_Columns.Add("FIELDNAME");//字段名 
            //DD03L_Columns.Add("KEYFLAG");//标识表格的关键字段 
            //DD03L_Columns.Add("MANDATORY");//标记:要求输入字段(不为空) 
            //DD03L_Columns.Add("ROLLNAME");//数据元素(语义域) 
            //DD03L_Columns.Add("CHECKTABLE");//异型键表名检查 
            //DD03L_Columns.Add("INTTYPE");//ABAP数据类型(C,D,N,...) 
            //DD03L_Columns.Add("INTLEN");//内部长度（字节） 
            //DD03L_Columns.Add("REFTABLE");//字段的参考表 
            //DD03L_Columns.Add("DATATYPE");//ABAP字典中的数据类型 
            //DD03L_Columns.Add("LENG");//长度（字符数） 
            //DD03L_Columns.Add("DECIMALS");//小数位数 
            //DD03L_Columns.Add("DOMNAME");//定义域名 

            //DD03VT_Columns.Add("TABNAME");//表名 
            //DD03VT_Columns.Add("FIELDNAME");//字段名   
            //DD03VT_Columns.Add("DDLANGUAGE");//语言代码 
            //DD03VT_Columns.Add("DDTEXT");//简短描述  
            //DD03VT_Columns.Add("REPTEXT");//标题 
            //DD03VT_Columns.Add("SCRTEXT_S");//短字段标签  

            //DD03T_Columns.Add("TABNAME");//表名 
            //DD03T_Columns.Add("DDLANGUAGE");//语言代码 
            //DD03T_Columns.Add("AS4LOCAL");//资源库对象的激活状态  
            //DD03T_Columns.Add("FIELDNAME");//字段名   
            //DD03T_Columns.Add("DDTEXT");//资源库对象的简短描述 
            if (gl_dd03ls == null || gl_dd03ls.Count == 0)
            {
                rmsg = tableName + "表不存在";
                return rmsg;
            }
            foreach (DD03L item in gl_dd03ls)
            {
                dd03t = new DD03T();
                dd03t = dd03ts.FirstOrDefault(t => t.FIELDNAME == item.FIELDNAME);
                dd03vt = new DD03VT();
                dd03vt = dd03vts.FirstOrDefault(t => t.FIELDNAME == item.FIELDNAME);

                if (dd03t != null)
                {
                    text2 += "insert into sys_t_dbfld (tabname, fieldname, offset, length, type, fieldtext)values ('" + tableName + "','" +
                                                                                                            item.FIELDNAME.ToString().Replace("'", "").Replace(" ", "") + "','','" +
                                                                                                            item.INTLEN.ToString().Replace("'", "").Replace(" ", "") + "','" +
                                                                                                            item.INTTYPE.ToString().Replace("'", "").Replace(" ", "") + "','" +
                                                                                                            dd03t.DDTEXT.ToString().Replace("'", "").Replace(" ", "") + "');";
                }
                if (dd03vt != null)
                {
                    text2 += "insert into sys_t_dbfld (tabname, fieldname, offset, length, type, fieldtext)values ('" + tableName + "','" +
                                                                                                            item.FIELDNAME.ToString().Replace("'", "").Replace(" ", "") + "','','" +
                                                                                                            item.INTLEN.ToString().Replace("'", "").Replace(" ", "") + "','" +
                                                                                                            item.INTTYPE.ToString().Replace("'", "").Replace(" ", "") + "','" +
                                                                                                            dd03vt.DDTEXT.ToString().Replace("'", "").Replace(" ", "") + "');";


                }
                text3 += "insert into sys_t_x031l (tabname, \"position\", flag1, flag2, flag3, flag4, dbtabpos, fieldtype, offset, dblength,dblength2, exlength, decimals, depth, fldalign, fieldname, rollname, abtype, dtyp, exid,reftable, reffield, precfield, convexit, memoryid, checktable, digits)values ('" +
                        tableName.ToString() + "','" +
                         item.POSITION.ToString().Replace("'", "").Replace(" ", "") +
                        "','','','','','00','','','','','" + item.INTLEN.ToString().Replace("'", "").Replace(" ", "") + "','" +
                         item.DECIMALS.ToString().Replace("'", "").Replace(" ", "") + "','','','" +
                         item.FIELDNAME.ToString().Replace("'", "").Replace(" ", "") + "','" +
                         item.ROLLNAME.ToString().Replace("'", "").Replace(" ", "") + "','','" +
                        item.DATATYPE.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        item.INTTYPE.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        item.REFTABLE.ToString().Replace("'", "").Replace(" ", "") + "','','','','','" + item.CHECKTABLE.ToString().Replace("'", "").Replace(" ", "") +
                        "','');";
                text4 += "insert into sys_t_et_dfies (" +
                        "tabname, fieldname, langu, \"position\", offset, domname, rollname, checktable, leng, intlen," +
                        "outputlen, decimals, datatype, inttype, reftable, reffield, precfield, authorid, memoryid," +
                        "logflag, mask, masklen, convexit, headlen, scrlen1, scrlen2, scrlen3, fieldtext, reptext," +
                        "scrtext_s, scrtext_m, scrtext_l, keyflag, lowercase, mac, genkey, noforkey, valexi," +
                        "noauthch, sign, dynpfld, f4availabl, comptype, lfieldname, ltrflddis, bidictrlc," +
                        "outputstyle, nohistory, ampmformat)" +
                        "values ('" +
                        tableName.ToString() + "','" +
                        item.FIELDNAME.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        "" + "','" +//DDLANGUAGE
                        item.POSITION.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        "" + "','" +  //OFFSET
                        item.DOMNAME.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        item.ROLLNAME.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        item.CHECKTABLE.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        item.LENG.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        item.INTLEN.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        "" + "','" +//OUTPUTLEN
                        item.DECIMALS.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        item.DATATYPE.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        item.INTTYPE.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        item.REFTABLE.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        "" + "','" +//REFFIELD
                        "" + "','" +//PRECFIELD
                        "" + "','" +//AUTHORID
                        "" + "','" +//MEMORYID
                        "" + "','" +//LOGFLAG
                        "" + "','" +//MASK
                        "" + "','" +//MASKLEN
                        "" + "','" +//CONVEXIT
                        "" + "','" +//HEADLEN
                        "" + "','" +//SCRLEN1
                        "" + "','" +//SCRLEN2
                        "" + "','" +//SCRLEN3
                        "" + "','" +//FIELDTEXT
                        "" + "','" +//REPTEXT
                        "" + "','" +//SCRTEXT_S
                        "" + "','" +//SCRTEXT_M
                        "" + "','" +//SCRTEXT_L
                        item.KEYFLAG.ToString().Replace("'", "").Replace(" ", "") + "','" +
                        "" + "','" +//LOWERCASE
                        "" + "','" +//MAC
                        "" + "','" +//GENKEY
                        "" + "','" +//NOFORKEY
                        "" + "','" +//VALEXI
                        "" + "','" +//NOAUTHCH
                        "" + "','" +//SIGN
                        "" + "','" +//DYNPFLD
                        "" + "','" +//F4AVAILABL
                        "" + "','" +//COMPTYPE
                        "" + "','" +//LFIELDNAME
                        "" + "','" +//LTRFLDDIS
                        "" + "','" +//BIDICTRLC
                        "" + "','" +//OUTPUTSTYLE
                        "" + "','" +//NOHISTORY
                        "" + "'" +//AMPMFORMAT
                        ");";
            }
            SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
            result = sQLiteDBHelper.ExecuteNonQuery(text1, null);
            result = sQLiteDBHelper.ExecuteNonQuery(text2, null);
            result = sQLiteDBHelper.ExecuteNonQuery(text3, null);
            result = sQLiteDBHelper.ExecuteNonQuery(text4, null);
            if (result == 0)
            {
                rmsg = "无记录被保存";
            }
            else
            {
                rmsg = "成功";
            }
        }
        catch (Exception ex)
        {
            rmsg += ex.Message;
        }
        return rmsg;
    }

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
            sql += "where sys_t_x031l.tabname = '" + tabname + "'   ";
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
            sql += "where sys_t_x031l.tabname = '" + tabname + "' AND CAST(sys_t_dbfld.length AS INTEGER) <> 0 ";
            sql += "order by CAST(sys_t_x031l.position AS INTEGER) ";
        }
       
        dt = sQLiteDBHelper.ExecuteDataTable(sql); 
        return dt; 
    }



}

