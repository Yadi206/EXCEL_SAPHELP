using EXCEL_SAPHELP.Com.Model;
using EXCEL_SAPHELP.Properties;
using EXCEL_SAPHELP.RunFun;
using EXCEL_SAPHELP.WinForm;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using Newtonsoft.Json;
using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace EXCEL_SAPHELP.EXCEL
{

    public partial class SAPHelper
    {

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //MessageBox.Show(SysConfigInfo.current_path);
            SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
            FileInfo fileInfo = new FileInfo(SysConfigInfo.sqlite_path);
            if (!fileInfo.Exists)
            {
                sQLiteDBHelper.CreateDB(SysConfigInfo.sqlite_path);
                string strSqlite = "CREATE TABLE sys_t_config (id TEXT  NOT NULL PRIMARY KEY,log_path TEXT NULL);";
                sQLiteDBHelper.CreateTable(SysConfigInfo.sqlite_path, strSqlite);
                string strSqlite2 = "CREATE TABLE sys_t_logininfo (id TEXT  NOT NULL PRIMARY KEY,AppServerHost TEXT  NULL,SystemNumber TEXT  NULL,User TEXT  NULL,Password TEXT  NULL,  Client TEXT  NULL,Language TEXT  NULL,Name TEXT  NULL,Trace TEXT  NULL,SAPRouter TEXT NULL,sid TEXT NULL,log_path TEXT NULL)";
                sQLiteDBHelper.CreateTable(SysConfigInfo.sqlite_path, strSqlite2);
                string strSqlite3 = "CREATE TABLE sys_t_object ( objectid TEXT  NOT NULL PRIMARY KEY,url TEXT NULL,model TEXT )";
                sQLiteDBHelper.CreateTable(SysConfigInfo.sqlite_path, strSqlite3);
                string strSqlite4 = "CREATE TABLE sys_t_tablelist ( objectid TEXT  NOT NULL,tableid TEXT  NOT NULL,tablename TEXT NULL ,primary key(objectid, tableid))";
                sQLiteDBHelper.CreateTable(SysConfigInfo.sqlite_path, strSqlite4);
                string strSqlite5 = "CREATE TABLE sys_t_x031l ( tabname TEXT  NOT NULL,position  TEXT  NOT NULL,flag1 TEXT NULL ,flag2 TEXT NULL ,flag3 TEXT NULL ,flag4 TEXT NULL ,dbtabpos TEXT NULL ,fieldtype TEXT NULL ,offset TEXT NULL ,dblength TEXT NULL ,dblength2 TEXT NULL ,exlength TEXT NULL ,decimals TEXT NULL ,depth TEXT NULL ,fldalign TEXT NULL ,fieldname TEXT NULL ,rollname TEXT NULL ,abtype TEXT NULL ,dtyp TEXT NULL ,exid TEXT NULL ,reftable TEXT NULL ,reffield TEXT NULL ,precfield TEXT NULL ,convexit TEXT NULL ,memoryid TEXT NULL ,checktable TEXT NULL ,digits TEXT NULL ,primary key(tabname, position))";
                sQLiteDBHelper.CreateTable(SysConfigInfo.sqlite_path, strSqlite5);
                string strSqlite6 = "create TABLE sys_t_dbfld( tabname TEXT  NOT NULL,fieldname TEXT  NOT NULL,offset TEXT NULL,length TEXT NULL,type TEXT NULL,fieldtext TEXT NULL,primary key(tabname, fieldname))";
                sQLiteDBHelper.CreateTable(SysConfigInfo.sqlite_path, strSqlite6);
                string strSqlite7 = "create table sys_t_et_dfies( tabname text not null,fieldname text not null,langu text null,position text null,offset text null,domname text null,rollname text null,checktable text null,leng text null,intlen text null,outputlen text null,decimals text null,datatype text null,inttype text null,reftable text null,reffield text null,precfield text null,authorid text null,memoryid text null,logflag text null,mask text null,masklen text null,convexit text null,headlen text null,scrlen1 text null,scrlen2 text null,scrlen3 text null,fieldtext text null,reptext text null,scrtext_s text null,scrtext_m text null,scrtext_l text null,keyflag text null,lowercase text null,mac text null,genkey text null,noforkey text null,valexi text null,noauthch text null,sign text null,dynpfld text null,f4availabl text null,comptype text null,lfieldname text null,ltrflddis text null,bidictrlc text null,outputstyle text null,nohistory text null,ampmformat text null,primary key(tabname, fieldname)) ";
                sQLiteDBHelper.CreateTable(SysConfigInfo.sqlite_path, strSqlite7);
                string strSqlite8 = "create table sys_t_tables( tabname text not null,tabdescribe text null,tabtxtname text null,primary key(tabname))";
                sQLiteDBHelper.CreateTable(SysConfigInfo.sqlite_path, strSqlite8);
            }

            SysConfigInfo.saploginfo = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_logininfo", null);
            if (SysConfigInfo.saploginfo == null || SysConfigInfo.saploginfo.Rows.Count == 0)
            {
                tgb_ConfigFlag.Label = "未读取到默认配置";
                tgb_ConfigFlag.Image = Resources.S_S_LEDR;
                tgb_ConfigFlag.Checked = true;
            }
            else
            {
                tgb_ConfigFlag.Label = "默认配置成功";
                tgb_ConfigFlag.Image = Resources.S_S_LEDG;
                tgb_ConfigFlag.Checked = true;
            }
            System.Data.DataTable dataTable = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_config");
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                if (dataRow["log_path"] != null && !string.IsNullOrEmpty(dataRow["log_path"].ToString()))
                {
                    SysConfigInfo.config_file_path = dataRow["log_path"].ToString();
                    if (!Directory.Exists(SysConfigInfo.config_file_path))
                    {
                        SysConfigInfo.config_file_path = Path.GetTempPath();
                    }
                }
            }

            System.Data.DataTable dt2 = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_dbfld");
            if (dt2 == null || (dt2 != null && dt2.Rows.Count == 0))
            {
                bnSapRiQi.Visible = true;
            }


            //
        }

        private void bt_Connect_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                Saplogon saplogon = new Saplogon();
                if (saplogon.ShowDialog() == DialogResult.OK)
                {
                    SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
                    SysConfigInfo.saploginfo = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_logininfo", null);
                    tgb_ConfigFlag.Label = "默认配置成功";
                    tgb_ConfigFlag.Image = Resources.S_S_LEDG;
                    tgb_ConfigFlag.Checked = true;
                    MessageBox.Show("默认登陆配置成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bn_CKZT_Click(object sender, RibbonControlEventArgs e)
        {
            string text = "";
            text = text + "  IP: " + SysConfigInfo.parms["USER"].ToString();
            text = text + "  客户端号: " + SysConfigInfo.parms["CLIENT"].ToString();
            text = text + "  登陆语言: " + SysConfigInfo.parms["LANG"].ToString();
            text = text + "  登陆用户: " + SysConfigInfo.parms["USER"].ToString();
            text = text + "  系统编号: " + SysConfigInfo.parms["SYSNR"].ToString();
            MessageBox.Show(text);
        }

        private void bn_GetFunName_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet activeSheet = ExcelApp.GetInstance().ActiveSheet;
            SysConfigInfo.myfun = SysConfigInfo.SapRfcRepository.CreateFunction((activeSheet.Cells[1, 1]).Value);
            for (int i = 0; i < SysConfigInfo.myfun.Metadata.ParameterCount; i++)
            {
                (activeSheet.Cells[i + 2, 1]).Value = SysConfigInfo.myfun.Metadata[i].ToString();
                (activeSheet.Cells[i + 2, 2]).Value = SysConfigInfo.myfun.Metadata[i].Documentation;
            }
        }

        private void bn_ReadTableS_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                string stablename = "";
                string flag = "";
                frWriteTableName wtn = new frWriteTableName();
                if (wtn.ShowDialog() == DialogResult.OK)
                {
                    stablename = wtn.TableName;
                    flag = wtn.flag;
                }
                else
                {
                    return;
                }

                if (tgb_flag.Checked)
                {
                    int num = 0;
                    IRfcTable table = null;
                    string txtTableName = "";
                    num = RFCHelp.getTableInfo(stablename, ref table, ref txtTableName);
                }
                if (flag == "SHEET")
                {
                    Workbook activeWorkbook = Globals.ThisAddIn.Application.ActiveWorkbook;
                    bool flag1 = false;
                    foreach (Worksheet sheet in activeWorkbook.Sheets)
                    {
                        if (sheet != null && sheet.Name == stablename)
                        {
                            flag1 = true;
                            break;
                        }
                    }
                    if (flag1)
                    {
                        (activeWorkbook.Sheets[stablename]).Delete();
                    }
                    Worksheet worksheet2 = activeWorkbook.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    worksheet2.Name = stablename;
                    int num2 = 1;
                    worksheet2.Cells[num2, 1].Value = "位置";
                    worksheet2.Cells[num2, 2].Value = "字段名";
                    worksheet2.Cells[num2, 3].Value = "主键";//1
                    worksheet2.Cells[num2, 4].Value = "元素";
                    worksheet2.Cells[num2, 5].Value = "类型";
                    worksheet2.Cells[num2, 6].Value = "数据类型";
                    worksheet2.Cells[num2, 7].Value = "值域表";//2
                    worksheet2.Cells[num2, 8].Value = "结构中的位置";
                    worksheet2.Cells[num2, 9].Value = "长度";
                    worksheet2.Cells[num2, 10].Value = "小数位";
                    worksheet2.Cells[num2, 11].Value = "表字段";
                    worksheet2.Cells[num2, 12].Value = "字段描述";
                    SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
                    string sql = "";
                    sql += "select CAST(sys_t_x031l.position AS INTEGER) as position, ";
                    sql += "       sys_t_x031l.fieldname, ";
                    sql += "       ifnull(sys_t_et_dfies.keyflag, '') as keyflag, ";
                    sql += "       sys_t_x031l.rollname,";
                    sql += "       sys_t_x031l.dtyp, ";
                    sql += "       sys_t_x031l.exid, ";
                    sql += "       ifnull(sys_t_et_dfies.checktable, '') as checktable, ";
                    sql += "       CAST(sys_t_dbfld.offset AS INTEGER) as offset, ";
                    sql += "       CAST(sys_t_dbfld.length AS INTEGER) as length, ";
                    sql += "       sys_t_x031l.decimals, ";
                    sql += "       '" + stablename + "-' || sys_t_x031l.fieldname as field, ";
                    sql += "       sys_t_dbfld.fieldtext ";
                    sql += "from sys_t_x031l inner join sys_t_dbfld on sys_t_dbfld.tabname = sys_t_x031l.tabname and sys_t_dbfld.fieldname = sys_t_x031l.fieldname ";
                    sql += "                 LEFT join sys_t_et_dfies on sys_t_et_dfies.tabname = sys_t_x031l.tabname and sys_t_et_dfies.fieldname = sys_t_x031l.fieldname ";
                    sql += "where sys_t_x031l.tabname = '" + stablename + "' ";
                    sql += "order by CAST(sys_t_dbfld.offset AS INTEGER) ";
                    System.Data.DataTable dataTable = sQLiteDBHelper.ExecuteDataTable(sql);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        num2++;
                        (worksheet2.Cells[num2, 1]).Value = row["position"];
                        (worksheet2.Cells[num2, 2]).Value = row["fieldname"];
                        (worksheet2.Cells[num2, 3]).Value = row["keyflag"];
                        (worksheet2.Cells[num2, 4]).Value = row["rollname"];
                        (worksheet2.Cells[num2, 5]).Value = row["dtyp"];
                        (worksheet2.Cells[num2, 6]).Value = row["exid"];
                        (worksheet2.Cells[num2, 7]).Value = row["checktable"];
                        (worksheet2.Cells[num2, 8]).Value = row["offset"];
                        (worksheet2.Cells[num2, 9]).Value = row["length"];
                        (worksheet2.Cells[num2, 10]).Value = row["decimals"];
                        (worksheet2.Cells[num2, 11]).Value = row["field"];
                        (worksheet2.Cells[num2, 12]).Value = row["fieldtext"];
                    }
                    worksheet2.Columns.AutoFit();
                    Borders borders = worksheet2.Range[worksheet2.Cells[1, 1], worksheet2.Cells[num2, 12]].Borders;
                    borders.LineStyle = XlLineStyle.xlContinuous;
                    borders.Weight = XlBorderWeight.xlThin;
                }

                if (flag == "WINDOWS")
                {
                    FullTable ft = new FullTable();
                    SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
                    string sql = "";
                    sql += "select CAST(sys_t_x031l.position AS INTEGER) as 位置, ";
                    sql += "       sys_t_x031l.fieldname as 字段, ";
                    sql += "       '" + stablename + "-' || sys_t_x031l.fieldname as 拼接, ";
                    sql += "       sys_t_dbfld.fieldtext as 描述,";
                    sql += "       ifnull(sys_t_et_dfies.keyflag, '') as 主键, ";
                    sql += "       sys_t_x031l.rollname as 元素,";
                    sql += "       sys_t_x031l.dtyp as 类型, ";
                    sql += "       sys_t_x031l.exid as 类型2, ";
                    sql += "       ifnull(sys_t_et_dfies.checktable, '') as 值域表, ";
                    sql += "       CAST(sys_t_dbfld.offset AS INTEGER) as OFFSET, ";
                    sql += "       CAST(sys_t_dbfld.length AS INTEGER) as LENGTH, ";
                    sql += "       sys_t_x031l.decimals as 小数 ";
                    sql += "from sys_t_x031l inner join sys_t_dbfld on sys_t_dbfld.tabname = sys_t_x031l.tabname and sys_t_dbfld.fieldname = sys_t_x031l.fieldname ";
                    sql += "                 LEFT join sys_t_et_dfies on sys_t_et_dfies.tabname = sys_t_x031l.tabname and sys_t_et_dfies.fieldname = sys_t_x031l.fieldname ";
                    sql += "where sys_t_x031l.tabname = '" + stablename + "' ";
                    sql += "order by CAST(sys_t_dbfld.offset AS INTEGER) ";
                    System.Data.DataTable dataTable = sQLiteDBHelper.ExecuteDataTable(sql);
                    ft.dt = dataTable;
                    sql = "select * from  sys_t_tables where tabname = '" + stablename + "';";
                    System.Data.DataTable dt_tab = sQLiteDBHelper.ExecuteDataTable(sql);
                    if (dt_tab != null && dt_tab.Rows.Count > 0)
                    {
                        ft.stitle = dt_tab.Rows[0]["tabname"].ToString() + ":" + dt_tab.Rows[0]["tabdescribe"].ToString();
                        ft.sTxtTableName = dt_tab.Rows[0]["tabtxtname"].ToString();
                    }
                    else
                    {
                        ft.stitle = stablename;
                    }
                    ft.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);
        }

        private void bn_Login_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                if (!tgb_ConfigFlag.Checked)
                {
                    MessageBox.Show("请先配置登陆信息");
                    return;
                }
                SysConfigInfo.parms = new RfcConfigParameters();
                foreach (DataRow row in SysConfigInfo.saploginfo.Rows)
                {
                    SysConfigInfo.parms.Add("ASHOST", row["AppServerHost"].ToString());
                    SysConfigInfo.parms.Add("SYSNR", row["SystemNumber"].ToString());
                    SysConfigInfo.parms.Add("USER", row["User"].ToString());
                    SysConfigInfo.parms.Add("PASSWD", row["Password"].ToString());
                    SysConfigInfo.parms.Add("CLIENT", row["Client"].ToString());
                    SysConfigInfo.parms.Add("LANG", row["Language"].ToString());
                    SysConfigInfo.parms.Add("NAME", "HYDRFC");
                    if (!string.IsNullOrEmpty(row["SAPRouter"].ToString()))
                    {
                        SysConfigInfo.parms.Add("SAPROUTER", row["SAPRouter"].ToString());
                    }
                    SysConfigInfo.parms.Add("TRACE", "0");
                    RfcTrace.TraceDirectory = "C:\\rfclog";
                }
                try
                {
                    SysConfigInfo.SapRfcDestination = RfcDestinationManager.GetDestination(SysConfigInfo.parms);
                    SysConfigInfo.SapRfcRepository = SysConfigInfo.SapRfcDestination.Repository;
                    tgb_LogonFlag.Label = "链接成功";
                    tgb_LogonFlag.Image = Resources.S_S_LEDG;
                    tgb_LogonFlag.Checked = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("登陆失败");
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void bn_LogonGui_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                if (!tgb_ConfigFlag.Checked)
                {
                    MessageBox.Show("请先配置登陆信息");
                    return;
                }
                string arguments = "";
                foreach (DataRow row in SysConfigInfo.saploginfo.Rows)
                {
                    arguments = "-user=" + row["User"].ToString() + " -pw=" + row["Password"].ToString() + " -language=" + row["Language"].ToString() + " -SYSTEM=" + row["sid"].ToString() + " -CLIENT=" + row["Client"].ToString() + " -sysname=" + row["id"].ToString() + " -maxgui";
                }
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo("sapshcut.exe", arguments);
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {

                List<SapComTable> scts = new List<SapComTable>();
                SapComTable sct = new SapComTable();
                sys_t_object sto = new sys_t_object();
                List<sys_t_tablelist> stts = new List<sys_t_tablelist>();
                sys_t_tablelist stt = new sys_t_tablelist();

                Workbook activeWorkbook = Globals.ThisAddIn.Application.ActiveWorkbook;
                bool flag = false;
                foreach (Worksheet sheet in activeWorkbook.Sheets)
                {
                    if (sheet != null && sheet.Name == "常用表清单")
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    (activeWorkbook.Sheets["常用表清单"]).Delete();
                }
                Worksheet worksheet2 = activeWorkbook.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                worksheet2.Name = "常用表清单";

                int num = 0;
                int num2 = 0;
                SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
                System.Data.DataTable dataTable = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_object", null);
                if (dataTable == null || dataTable.Rows.Count <= 0)
                {
                    string url = "https://ncstatic.clewm.net/rsrc/2024/0714/22/c5e4b6f0c6932e62de7fe65fbea31b3e.txt";
                    string filePath = SysConfigInfo.config_file_path + "\\sapcomtable.txt";
                    FileInfo fileInfo = new FileInfo(filePath);
                    if (!fileInfo.Exists)
                    {
                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(url, filePath);
                        }
                    }

                    StreamReader sr = new StreamReader(filePath, Encoding.UTF8);
                    string content = sr.ReadToEnd();
                    if (!string.IsNullOrEmpty(content))
                    {
                        scts = JsonConvert.DeserializeObject<List<SapComTable>>(content);
                    }
                    if (scts != null && scts.Count > 0)
                    {
                        string instersys_t_object = "";
                        string instersys_t_tablelist = "";
                        foreach (SapComTable table in scts)
                        {
                            instersys_t_object += "insert into sys_t_object(objectid, url, model) values ('" + table.modul.objectid + "','" + table.modul.url + "','" + table.modul.model + "');" + Environment.NewLine;
                            foreach (sys_t_tablelist item in table.tablelist)
                            {
                                instersys_t_tablelist += "insert into sys_t_tablelist (objectid, tableid, tablename) values ('" + item.objectid + "','" + item.tableid + "','" + item.tablename + "');" + Environment.NewLine;
                            }

                        }
                        if (!string.IsNullOrEmpty(instersys_t_object))
                        {
                            sQLiteDBHelper.ExecuteNonQuery(instersys_t_object, null);
                            sQLiteDBHelper.ExecuteNonQuery(instersys_t_tablelist, null);
                        }
                    }
                    dataTable = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_object", null);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    num++;
                    (worksheet2.Cells[num, 1]).Value = "业务对象【" + row["objectid"].ToString() + "】";
                    (worksheet2.Cells[num, 3]).Value = "跳转到表关系";
                    worksheet2.Hyperlinks.Add(worksheet2.Cells[num, 3], row["url"].ToString());
                    ((_Worksheet)worksheet2).get_Range((object)("A" + num + ":B" + num), Type.Missing).Merge(Type.Missing);
                    Interior interior = ((_Worksheet)worksheet2).get_Range((object)("A" + num + ":B" + num), Type.Missing).Interior;
                    interior.ThemeColor = 5;
                    interior.TintAndShade = 0.6;
                    System.Data.DataTable dataTable2 = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_tablelist where objectid = '" + row["objectid"].ToString() + "'", null);
                    stts = new List<sys_t_tablelist>();
                    foreach (DataRow row2 in dataTable2.Rows)
                    {
                        num++;
                        (worksheet2.Cells[num, 1]).Value = row2["tableid"].ToString();
                        (worksheet2.Cells[num, 2]).Value = row2["tablename"].ToString();
                    }
                }
                string stringscts = JsonConvert.SerializeObject(scts);
                worksheet2.Columns.AutoFit();
                Borders borders = worksheet2.Range[worksheet2.Cells[1, 1], worksheet2.Cells[num, 3]].Borders;
                borders.LineStyle = XlLineStyle.xlContinuous;
                borders.Weight = XlBorderWeight.xlThin;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            List<SAPTable> tTables = new List<SAPTable>();
            int line = 1;
            string text = "";
            try
            {
                Worksheet worksheet = Globals.ThisAddIn.Application.ActiveSheet;
                int num = 0;
                int num2 = 0;
                while (num < 2)
                {
                    num2++;
                    text = "";
                    if ((!string.IsNullOrEmpty((worksheet.Cells[num2, 1]).value)))
                    {
                        text = (worksheet.Cells[num2, 1]).value.ToString();
                        text = text.Trim().ToUpper();
                    }
                    if (string.IsNullOrEmpty(text) || text.Substring(0, 1) == "业")
                    {
                        num++;
                        continue;
                    }
                    num = 0;
                    try
                    {
                        //A列表数据读取
                        string stxtTableName0 = "";
                        IRfcTable table1 = null;
                        RFCHelp.getTableInfo((worksheet.Cells[num2, 1]).value.ToString(), ref table1, ref stxtTableName0);
                        (worksheet.Cells[num2, 4]).Activate();
                        (worksheet.Cells[num2, 4]).value = "✓";
                        //A列对应文本表数据读取
                        if (!string.IsNullOrEmpty(stxtTableName0))
                        {
                            (worksheet.Cells[num2, 5]).value = stxtTableName0;
                            string stxtTableName1 = "";
                            IRfcTable table2 = null;
                            RFCHelp.getTableInfo(stxtTableName0, ref table2, ref stxtTableName1);
                            (worksheet.Cells[num2, 6]).Activate();
                            (worksheet.Cells[num2, 6]).value = "✓";
                        }
                        //字段对应值域表读取
                        if (table1 != null)
                        {
                            for (int i = 0; i < table1.RowCount; i++)
                            {
                                table1.CurrentIndex = i;
                                IRfcStructure currentRow = table1.CurrentRow;
                                string stablename = currentRow.GetValue("CHECKTABLE").ToString().Replace("'", "");
                                if (!string.IsNullOrEmpty(stablename))
                                {
                                    var a = tTables.FirstOrDefault(t => t.tablename == stablename);
                                    if (a == null)
                                    {
                                        SAPTable tt = new SAPTable();
                                        tt.tablename = stablename;
                                        tTables.Add(tt);
                                        (worksheet.Cells[line, 7]).value = stablename;
                                        string stxtTableName2 = "";
                                        IRfcTable table2 = null;
                                        RFCHelp.getTableInfo(stablename, ref table2, ref stxtTableName2);
                                        (worksheet.Cells[line, 8]).Activate();
                                        (worksheet.Cells[line, 8]).value = "✓";
                                        //字段对应值域表对应文本表
                                        if (!string.IsNullOrEmpty(stxtTableName2))
                                        {
                                            (worksheet.Cells[line, 9]).value = stxtTableName2;
                                            string stxtTableName3 = "";
                                            IRfcTable table3 = null;
                                            RFCHelp.getTableInfo(stxtTableName2, ref table3, ref stxtTableName3);
                                            (worksheet.Cells[line, 10]).Activate();
                                            (worksheet.Cells[line, 10]).value = "✓";
                                        }
                                        line++;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        (worksheet.Cells[num2, 4]).value = ex.Message;
                    }
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void tgb_flag_Click(object sender, RibbonControlEventArgs e)
        {
            if (tgb_flag.Checked)
            {
                bn_Login_Click(null, null);
                if (tgb_LogonFlag.Checked)
                {
                    tgb_flag.Label = "在线查询模式(点击切换为离线查询模式)";
                    tgb_flag.Image = Resources.S_CONNEC;
                    SysConfigInfo.sConnectFlag = ConnectFlag.已连接.ToString();
                    button3.Visible = true;
                }
            }
            else
            {
                button3.Visible = false;
                tgb_flag.Label = "离线查询模式(点击切换为在线查询模式)";
                SysConfigInfo.sConnectFlag = ConnectFlag.未连接.ToString();
                tgb_flag.Image = Resources.S_DISCON;
            }
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            Process.Start("https://www.yuque.com/tiger-fb9jj/ww5ogm/vvvcznwx5hc57oyt?singleDoc# 《让分享成为习惯！》");
        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {
            CWaitForm b = new CWaitForm();
            b._wtVoid = 执行;
            b.ShowDialog();
        }
        public void 执行()
        {
            SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
            //执行函数 
            //初始化表和字段
            string url = "https://ncstatic.clewm.net/rsrc/2024/0715/11/8a5419c674c4b518b212c5eec69e3c65.txt";
            string filePath = SysConfigInfo.config_file_path + "\\sys_t_dbfld.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            if (!fileInfo.Exists)
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, filePath);
                }
            }
            StreamReader sr = new StreamReader(filePath, Encoding.UTF8);
            string content = sr.ReadToEnd();
            sQLiteDBHelper.ExecuteNonQuery(content, null);

            url = "https://ncstatic.clewm.net/rsrc/2024/0715/11/0da4f724faf4af538ea2f2773fcdec81.txt";
            filePath = SysConfigInfo.config_file_path + "\\sys_t_x031l.txt";
            fileInfo = new FileInfo(filePath);
            fileInfo = new FileInfo(filePath);
            if (!fileInfo.Exists)
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, filePath);
                }
            }
            sr = new StreamReader(filePath, Encoding.UTF8);
            content = sr.ReadToEnd();
            sQLiteDBHelper.ExecuteNonQuery(content, null);
        }

        private void button5_Click(object sender, RibbonControlEventArgs e)
        {
            Process.Start("https://gitee.com/Tiger_Hu_gitee/EXCEL_SAPHELP");
        }
        private void setBiaoTou(Worksheet ws, int currow, int curcolumn)
        {
            Range curcell;
            curcell = ws.Cells[currow, curcolumn];
            curcell.Interior.Color = Color.Yellow;
            curcell.Borders.LineStyle = 1;
            curcell.Value = "字段";


            curcell = ws.Cells[currow, curcolumn + 1];
            curcell.Interior.Color = Color.Yellow;
            curcell.Borders.LineStyle = 1;
            curcell.Value = "字段描述";

            curcell = ws.Cells[currow, curcolumn + 2];
            curcell.Interior.Color = Color.Yellow;
            curcell.Borders.LineStyle = 1;
            curcell.Value = "字段类型";

            curcell = ws.Cells[currow, curcolumn + 3];
            curcell.Interior.Color = Color.Yellow;
            curcell.Borders.LineStyle = 1;
            curcell.Value = "字段长度";

            curcell = ws.Cells[currow, curcolumn + 4];
            curcell.Interior.Color = Color.Yellow;
            curcell.Borders.LineStyle = 1;
            curcell.Value = "小数";

            curcell = ws.Cells[currow, curcolumn + 5];
            curcell.Interior.Color = Color.Yellow;
            curcell.Borders.LineStyle = 1;
            curcell.Value = "是否必输";

            curcell = ws.Cells[currow, curcolumn + 6];
            curcell.Interior.Color = Color.Yellow;
            curcell.Borders.LineStyle = 1;
            curcell.Value = "备注";

        }

        private void setHeBing(Worksheet ws, int srow, int scolumn, int erow, int ecolumn)
        {
            ws.Range[ws.Cells[srow, scolumn], ws.Cells[erow, ecolumn]].Merge();
            ws.Range[ws.Cells[srow, scolumn], ws.Cells[erow, ecolumn]].VerticalAlignment = XlVAlign.xlVAlignTop;
        }

        private void setBianKuang(Worksheet ws, int srow, int scolumn, int erow, int ecolumn)
        {
            ws.Range[ws.Cells[srow, scolumn], ws.Cells[erow, ecolumn]].Borders.LineStyle = 1;
        }


        private void setfunpara(Worksheet ws, ref int currow, ref int curcolumn, IRfcFunction rfun, RfcParameterMetadata rfcPM)
        {
            int icurcolumn = 0;
            currow++;
            int istartrow = currow;
            Range curcell;
            if (rfcPM.DataType == RfcDataType.STRUCTURE)
            {
                IRfcStructure s1 = rfun.GetStructure(rfcPM.Name);
                ws.Cells[currow, curcolumn].Value = rfcPM.Name;
                ws.Cells[currow, curcolumn + 1].Value = rfcPM.Documentation;
                ws.Cells[currow, curcolumn + 2].Value = Enum.Format(typeof(RfcDataType), rfcPM.DataType, "g");
                setBiaoTou(ws, currow, curcolumn + 3);
                for (global::System.Int32 j = 0; j < s1.Count; j++)
                {
                    RfcFieldMetadata rsm = s1.Metadata[j];
                    icurcolumn = curcolumn + 3;
                    setstrupara(ws, ref currow, ref icurcolumn, s1, rsm);
                }
                setHeBing(ws, istartrow, curcolumn, currow, curcolumn);
                setHeBing(ws, istartrow, curcolumn + 1, currow, curcolumn + 1);
                setHeBing(ws, istartrow, curcolumn + 2, currow, curcolumn + 2);
                setBianKuang(ws, istartrow, curcolumn, currow, curcolumn + 9);

            }
            else if (rfcPM.DataType == RfcDataType.TABLE)
            {
                IRfcTable t1 = rfun.GetTable(rfcPM.Name);
                RfcTableMetadata tm1 = t1.Metadata;
                RfcStructureMetadata sm1 = tm1.LineType;
                IRfcStructure s1 = sm1.CreateStructure();
                ws.Cells[currow, curcolumn].Value = rfcPM.Name;
                ws.Cells[currow, curcolumn + 1].Value = rfcPM.Documentation;
                ws.Cells[currow, curcolumn + 2].Value = Enum.Format(typeof(RfcDataType), rfcPM.DataType, "g");
                setBiaoTou(ws, currow, curcolumn + 3);
                for (global::System.Int32 j = 0; j < s1.Count; j++)
                {
                    RfcFieldMetadata rsm = s1.Metadata[j];
                    icurcolumn = curcolumn + 3;
                    setstrupara(ws, ref currow, ref icurcolumn, s1, rsm);
                }
                setHeBing(ws, istartrow, curcolumn, currow, curcolumn);
                setHeBing(ws, istartrow, curcolumn + 1, currow, curcolumn + 1);
                setHeBing(ws, istartrow, curcolumn + 2, currow, curcolumn + 2);
                setBianKuang(ws, istartrow, curcolumn, currow, curcolumn + 9);
            }
            else
            {
                ws.Cells[currow, curcolumn].Value = rfcPM.Name;
                ws.Cells[currow, curcolumn + 1].Value = rfcPM.Documentation;
                ws.Cells[currow, curcolumn + 2].Value = Enum.Format(typeof(RfcDataType), rfcPM.DataType, "g");
                ws.Cells[currow, curcolumn + 3].Value = rfcPM.NucLength;
                ws.Cells[currow, curcolumn + 4].Value = rfcPM.Decimals;
                if (!rfcPM.Optional)
                {
                    ws.Cells[currow, curcolumn + 5].Value = "必输";
                }
                ws.Cells[currow, curcolumn + 6].Value = rfcPM.DefaultValue;
                setBianKuang(ws, istartrow, curcolumn, currow, curcolumn + 6);
            }
        }

        private void setstrupara(Worksheet ws, ref int currow, ref int curcolumn, IRfcStructure rs, RfcFieldMetadata rfcFM)
        {
            int icurcolumn = 0;
            currow++;
            int istartrow = currow;
            if (rfcFM.DataType == RfcDataType.STRUCTURE)
            {

                IRfcStructure s1 = rs.GetStructure(rfcFM.Name);
                ws.Cells[currow, curcolumn].Value = rfcFM.Name;
                ws.Cells[currow, curcolumn + 1].Value = rfcFM.Documentation;
                ws.Cells[currow, curcolumn + 2].Value = Enum.Format(typeof(RfcDataType), rfcFM.DataType, "g");
                setBiaoTou(ws, currow, curcolumn + 3);
                for (global::System.Int32 j = 0; j < s1.Count; j++)
                {
                    RfcFieldMetadata rsm = s1.Metadata[j];
                    icurcolumn = curcolumn + 3;
                    setstrupara(ws, ref currow, ref icurcolumn, s1, rsm);
                }
                setHeBing(ws, istartrow, curcolumn, currow, curcolumn);
                setHeBing(ws, istartrow, curcolumn + 1, currow, curcolumn + 1);
                setHeBing(ws, istartrow, curcolumn + 2, currow, curcolumn + 2);
                setBianKuang(ws, istartrow, curcolumn, currow, curcolumn + 9);
            }
            else if (rfcFM.DataType == RfcDataType.TABLE)
            {
                IRfcTable t1 = rs.GetTable(rfcFM.Name);

                RfcTableMetadata tm1 = t1.Metadata;
                RfcStructureMetadata sm1 = tm1.LineType;
                IRfcStructure s1 = sm1.CreateStructure();
                ws.Cells[currow, curcolumn].Value = rfcFM.Name;
                ws.Cells[currow, curcolumn + 2].Value = Enum.Format(typeof(RfcDataType), rfcFM.DataType, "g");
                setBiaoTou(ws, currow, curcolumn + 3);
                for (global::System.Int32 j = 0; j < s1.Count; j++)
                {
                    RfcFieldMetadata rsm = s1.Metadata[j];
                    icurcolumn = curcolumn + 3;
                    setstrupara(ws, ref currow, ref icurcolumn, s1, rsm);
                }
                setHeBing(ws, istartrow, curcolumn, currow, curcolumn);
                setHeBing(ws, istartrow, curcolumn + 1, currow, curcolumn + 1);
                setHeBing(ws, istartrow, curcolumn + 2, currow, curcolumn + 2);
                setBianKuang(ws, istartrow, curcolumn, currow, curcolumn + 9);
            }
            else
            {
                ws.Cells[currow, curcolumn].Value = rfcFM.Name;
                ws.Cells[currow, curcolumn + 1].Value = rfcFM.Documentation;
                ws.Cells[currow, curcolumn + 2].Value = Enum.Format(typeof(RfcDataType), rfcFM.DataType, "g");
                ws.Cells[currow, curcolumn + 3].Value = rfcFM.NucLength;
                ws.Cells[currow, curcolumn + 4].Value = rfcFM.Decimals;
                ws.Cells[currow, curcolumn + 5].Value = "";
                ws.Cells[currow, curcolumn + 6].Value = "";
                setBianKuang(ws, istartrow, curcolumn, currow, curcolumn + 6);
            }
        }



        private void bn_SignUp_Click(object sender, RibbonControlEventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            string idstrc = (string)iData.GetData(DataFormats.Text);//检索与指定格式相关联的数据
            SendKeys.Send("{ESC}");
            string idstrv = "";
            if (!string.IsNullOrEmpty(idstrc))
            {
                string[] allRow = idstrc.Trim().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < allRow.Length; i++)
                {
                    //把每行的数据按单元格截取，放到一个string数组里，第二个参数是不返回空字符
                    string[] content = allRow[i].Trim().Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < content.Length; j++)
                    {
                        string ssign = content[j].Substring(content[j].Length - 1, 1);
                        if (!string.IsNullOrEmpty(ssign) && ssign == "-")
                        {
                            content[j] = "-" + content[j].Substring(0, content[j].Length - 1);
                        }
                        if (j < content.Length - 1)
                        {
                            idstrv += content[j] + "\t";
                        }
                        else
                        {
                            idstrv += content[j];
                        }
                    }

                    if (i < allRow.Length - 1)
                    {
                        idstrv += "\r\n";
                    }
                }
                Clipboard.SetDataObject(idstrv);
                MessageBox.Show("处理成功,请指定单元格黏贴");
            }
        }

        private void bn_FL_Click(object sender, RibbonControlEventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            string idstrc = (string)iData.GetData(DataFormats.Text);//检索与指定格式相关联的数据 
            SendKeys.Send("{ESC}");
            string idstrv = "";
            if (!string.IsNullOrEmpty(idstrc))
            {
                string[] allRow = idstrc.Trim().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 3; i < allRow.Length - 1; i++)
                {
                    if (i == 4)
                    {
                        continue;
                    }
                    allRow[i] = allRow[i].Substring(1, allRow[i].Length - 1);
                    allRow[i] = allRow[i].Replace("|", "\t");
                    if (i < allRow.Length - 1)
                    {
                        idstrv += allRow[i] + "\r\n";
                    }
                    else
                    {
                        idstrv += allRow[i];
                    }
                }
                Clipboard.SetDataObject(idstrv);
                MessageBox.Show("处理成功,请指定单元格黏贴");
            }
        }
 


        private void bnReSet_Click(object sender, RibbonControlEventArgs e)
        {
            string sfilename = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;      //该值确定是否可以选择多个文件
            dialog.Title = "选择Excel_SapHelp.db文件位置";     //弹窗的标题
            dialog.InitialDirectory = "D:\\";       //默认打开的文件夹的位置
            dialog.Filter = "Sqlite 数据库文件(*.db)|*.db";       //筛选文件
            dialog.ShowHelp = false;     //是否显示“帮助”按钮

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sfilename = dialog.FileName;
                FileInfo fileInfo = new FileInfo(sfilename);
                fileInfo.CopyTo(SysConfigInfo.current_path + @"Excel_SapHelp.db", true);
                Ribbon1_Load(null, null);
                MessageBox.Show("加载成功");

            }
        }

        private void bnSapRiQi_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet activeSheet = Globals.ThisAddIn.Application.ActiveSheet;
            Range selectedRange = Globals.ThisAddIn.Application.Selection;

            foreach (Range cell in selectedRange.Cells)
            {
                try
                {
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        string svalue = cell.Value.ToString().Replace(".", "-");
                        DateTime dte = DateTime.Parse(svalue);
                        cell.Value = dte.Year.ToString() + dte.Month.ToString("00") + dte.Day.ToString("00");
                        cell.NumberFormatLocal = "@";
                    }
                }
                catch (Exception ex)
                {
                    cell.Interior.Color = Color.Red;
                }
            }
        }

        private void bnSAPShuZhi_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet activeSheet = Globals.ThisAddIn.Application.ActiveSheet;
            Range selectedRange = Globals.ThisAddIn.Application.Selection;
            foreach (Range cell in selectedRange.Cells)
            {
                try
                {
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        string svalue = cell.Value.ToString().Replace(",", "");
                        svalue = svalue.Replace("，", "");
                        svalue = svalue.Replace("，", "");
                        svalue = svalue.Replace(" ", "");
                        decimal d = decimal.Parse(svalue);
                        d = Math.Round(d, 3);

                        cell.Value = d;
                        cell.NumberFormatLocal = "0.000";
                    }
                }
                catch (Exception ex)
                {
                    cell.Interior.Color = Color.Red;
                }
            }
        }

        private void bnJinE_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet activeSheet = Globals.ThisAddIn.Application.ActiveSheet;
            Range selectedRange = Globals.ThisAddIn.Application.Selection;
            foreach (Range cell in selectedRange.Cells)
            {
                try
                {
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        string svalue = cell.Value.ToString().Replace(",", "");
                        svalue = svalue.Replace("，", "");
                        svalue = svalue.Replace("，", "");
                        svalue = svalue.Replace(" ", "");
                        decimal d = decimal.Parse(svalue);
                        d = Math.Round(d, 2);
                        cell.Value = d;
                        cell.NumberFormatLocal = "0.00";
                    }
                }
                catch (Exception ex)
                {
                    cell.Interior.Color = Color.Red;
                }
            }
        }

        private void bnReadRFC_Click(object sender, RibbonControlEventArgs e)
        {
            frWriteFunName wf = new frWriteFunName();
            if (wf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sfunanme = wf.FunName;
                    int icurrow = 0;
                    int icurcolumn = 0;
                    Workbook activeWorkbook = Globals.ThisAddIn.Application.ActiveWorkbook;
                    bool flag1 = false;
                    foreach (Worksheet sheet in activeWorkbook.Sheets)
                    {
                        if (sheet != null && sheet.Name == sfunanme)
                        {
                            flag1 = true;
                            break;
                        }
                    }
                    if (flag1)
                    {
                        (activeWorkbook.Sheets[sfunanme]).Delete();
                    }
                    Worksheet worksheet2 = activeWorkbook.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    worksheet2.Name = sfunanme;
                    worksheet2.Cells[1, 1].Value = sfunanme;
                    IRfcFunction rfcFunction = SysConfigInfo.SapRfcRepository.CreateFunction(sfunanme);
                    //IMPORT
                    icurrow = 2;
                    icurcolumn = 1;
                    worksheet2.Cells[icurrow, 1].value = "输入参数:";
                    worksheet2.Range[worksheet2.Cells[icurrow, icurcolumn], worksheet2.Cells[icurrow, icurcolumn + 7]].Merge();
                    worksheet2.Range[worksheet2.Cells[icurrow, icurcolumn], worksheet2.Cells[icurrow, icurcolumn + 7]].HorizontalAlignment = XlHAlign.xlHAlignLeft;
                    worksheet2.Range[worksheet2.Cells[icurrow, icurcolumn], worksheet2.Cells[icurrow, icurcolumn + 7]].Interior.Color = Color.Orange;
                    icurrow++;
                    setBiaoTou(worksheet2, icurrow, 1);
                    for (global::System.Int32 i = 0; i < rfcFunction.Metadata.ParameterCount; i++)
                    {
                        RfcParameterMetadata rpm = rfcFunction.Metadata[i];
                        if (rpm.Direction == RfcDirection.IMPORT)
                        {
                            setfunpara(worksheet2, ref icurrow, ref icurcolumn, rfcFunction, rpm);
                        }
                    }
                    //EXPORT 
                    icurrow++;
                    icurcolumn = 1;
                    worksheet2.Cells[icurrow, 1].value = "输出参数:";
                    worksheet2.Range[worksheet2.Cells[icurrow, icurcolumn], worksheet2.Cells[icurrow, icurcolumn + 7]].Merge();
                    worksheet2.Range[worksheet2.Cells[icurrow, icurcolumn], worksheet2.Cells[icurrow, icurcolumn + 7]].HorizontalAlignment = XlHAlign.xlHAlignLeft;
                    worksheet2.Range[worksheet2.Cells[icurrow, icurcolumn], worksheet2.Cells[icurrow, icurcolumn + 7]].Interior.Color = Color.Orange;
                    icurrow++;
                    setBiaoTou(worksheet2, icurrow, 1);
                    for (global::System.Int32 i = 0; i < rfcFunction.Metadata.ParameterCount; i++)
                    {
                        RfcParameterMetadata rpm = rfcFunction.Metadata[i];
                        if (rpm.Direction == RfcDirection.EXPORT)
                        {
                            setfunpara(worksheet2, ref icurrow, ref icurcolumn, rfcFunction, rpm);
                        }
                    }
                    //CHANGING
                    icurrow++;
                    icurcolumn = 1;
                    worksheet2.Cells[icurrow, 1].value = "更改参数:";
                    worksheet2.Range[worksheet2.Cells[icurrow, icurcolumn], worksheet2.Cells[icurrow, icurcolumn + 7]].Merge();
                    worksheet2.Range[worksheet2.Cells[icurrow, icurcolumn], worksheet2.Cells[icurrow, icurcolumn + 7]].HorizontalAlignment = XlHAlign.xlHAlignLeft;
                    worksheet2.Range[worksheet2.Cells[icurrow, icurcolumn], worksheet2.Cells[icurrow, icurcolumn + 7]].Interior.Color = Color.Orange;
                    icurrow++;
                    setBiaoTou(worksheet2, icurrow, 1);
                    for (global::System.Int32 i = 0; i < rfcFunction.Metadata.ParameterCount; i++)
                    {
                        RfcParameterMetadata rpm = rfcFunction.Metadata[i];
                        if (rpm.Direction == RfcDirection.CHANGING)
                        {
                            setfunpara(worksheet2, ref icurrow, ref icurcolumn, rfcFunction, rpm);
                        }
                    }
                    //TABLES  
                    icurrow++;
                    icurcolumn = 1;
                    worksheet2.Cells[icurrow, 1].value = "表参数:";
                    worksheet2.Range[worksheet2.Cells[icurrow, icurcolumn], worksheet2.Cells[icurrow, icurcolumn + 7]].Merge();
                    worksheet2.Range[worksheet2.Cells[icurrow, icurcolumn], worksheet2.Cells[icurrow, icurcolumn + 7]].HorizontalAlignment = XlHAlign.xlHAlignLeft;
                    worksheet2.Range[worksheet2.Cells[icurrow, icurcolumn], worksheet2.Cells[icurrow, icurcolumn + 7]].Interior.Color = Color.Orange;
                    icurrow++;
                    setBiaoTou(worksheet2, icurrow, 1);
                    for (global::System.Int32 i = 0; i < rfcFunction.Metadata.ParameterCount; i++)
                    {
                        RfcParameterMetadata rpm = rfcFunction.Metadata[i];
                        if (rpm.Direction == RfcDirection.TABLES)
                        {
                            setfunpara(worksheet2, ref icurrow, ref icurcolumn, rfcFunction, rpm);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

       
    }
}