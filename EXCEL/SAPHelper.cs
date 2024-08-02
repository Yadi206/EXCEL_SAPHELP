using EXCEL_SAPHELP.Com.Model;
using EXCEL_SAPHELP.Properties;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using Newtonsoft.Json;
using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
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
                SysConfigInfo.config_file_path = dataRow["log_path"].ToString();
            }

            System.Data.DataTable dt2 = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_dbfld");
            if (dt2 == null || (dt2 != null && dt2.Rows.Count == 0))
            {
                button4.Visible = true;
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
            text = text + "  IP: " + parms["USER"].ToString();
            text = text + "  客户端号: " + parms["CLIENT"].ToString();
            text = text + "  登陆语言: " + parms["LANG"].ToString();
            text = text + "  登陆用户: " + parms["USER"].ToString();
            text = text + "  系统编号: " + parms["SYSNR"].ToString();
            MessageBox.Show(text);
        }

        private void bn_GetFunName_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet activeSheet = ExcelApp.GetInstance().ActiveSheet;
            myfun = SapRfcRepository.CreateFunction((activeSheet.Cells[1, 1]).Value);
            for (int i = 0; i < myfun.Metadata.ParameterCount; i++)
            {
                (activeSheet.Cells[i + 2, 1]).Value = myfun.Metadata[i].ToString();
                (activeSheet.Cells[i + 2, 2]).Value = myfun.Metadata[i].Documentation;
            }
        }

        private void bn_ReadTableS_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                eb_TableName.Text = eb_TableName.Text.ToUpper();
                if (tgb_flag.Checked)
                {
                    int num = 0;
                    num = RunRFC_READ_TABLE.runfun(SapRfcDestination, SapRfcRepository, eb_TableName.Text.ToString());
                    num = RunDD_GET_NAMETAB_FOR_RFC.runfun(SapRfcDestination, SapRfcRepository, eb_TableName.Text.ToString());
                }
                Workbook activeWorkbook = Globals.ThisAddIn.Application.ActiveWorkbook;
                bool flag = false;
                foreach (Worksheet sheet in activeWorkbook.Sheets)
                {
                    if (sheet != null && sheet.Name == eb_TableName.Text.ToString())
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    (activeWorkbook.Sheets[eb_TableName.Text.ToString()]).Delete();
                }
                Worksheet worksheet2 = activeWorkbook.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                worksheet2.Name = eb_TableName.Text.ToString();
                int num2 = 1;
                worksheet2.Cells[num2, 1].Value = "位置";
                worksheet2.Cells[num2, 2].Value = "字段名";
                worksheet2.Cells[num2, 3].Value = "元素";
                worksheet2.Cells[num2, 4].Value = "类型";
                worksheet2.Cells[num2, 5].Value = "数据类型";
                worksheet2.Cells[num2, 6].Value = "结构中的位置";
                worksheet2.Cells[num2, 7].Value = "长度";
                worksheet2.Cells[num2, 8].Value = "字段描述";
                SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
                string sql = "select CAST(sys_t_x031l.position AS INTEGER) as position,sys_t_x031l.fieldname,sys_t_x031l.rollname,sys_t_x031l.dtyp,sys_t_x031l.exid,CAST(sys_t_dbfld.offset AS INTEGER) as offset,CAST(sys_t_dbfld.length AS INTEGER) as length,sys_t_dbfld.fieldtext from sys_t_x031l inner join sys_t_dbfld on sys_t_dbfld.tabname = sys_t_x031l.tabname and sys_t_dbfld.fieldname = sys_t_x031l.fieldname where sys_t_x031l.tabname = '" + eb_TableName.Text.ToString() + "'  order by CAST(sys_t_x031l.position AS INTEGER)";
                System.Data.DataTable dataTable = sQLiteDBHelper.ExecuteDataTable(sql);
                foreach (DataRow row in dataTable.Rows)
                {
                    num2++;
                    (worksheet2.Cells[num2, 1]).Value = row["position"];
                    (worksheet2.Cells[num2, 2]).Value = row["fieldname"];
                    (worksheet2.Cells[num2, 3]).Value = row["rollname"];
                    (worksheet2.Cells[num2, 4]).Value = row["dtyp"];
                    (worksheet2.Cells[num2, 5]).Value = row["exid"];
                    (worksheet2.Cells[num2, 6]).Value = row["offset"];
                    (worksheet2.Cells[num2, 7]).Value = row["length"];
                    (worksheet2.Cells[num2, 8]).Value = row["fieldtext"];
                }
                worksheet2.Columns.AutoFit();
                Borders borders = worksheet2.Range[worksheet2.Cells[1, 1], worksheet2.Cells[num2, 8]].Borders;
                borders.LineStyle = XlLineStyle.xlContinuous;
                borders.Weight = XlBorderWeight.xlThin;
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
                parms = new RfcConfigParameters();
                foreach (DataRow row in SysConfigInfo.saploginfo.Rows)
                {
                    parms.Add("ASHOST", row["AppServerHost"].ToString());
                    parms.Add("SYSNR", row["SystemNumber"].ToString());
                    parms.Add("USER", row["User"].ToString());
                    parms.Add("PASSWD", row["Password"].ToString());
                    parms.Add("CLIENT", row["Client"].ToString());
                    parms.Add("LANG", row["Language"].ToString());
                    parms.Add("NAME", "HYDRFC");
                    if (!string.IsNullOrEmpty(row["SAPRouter"].ToString()))
                    {
                        parms.Add("SAPROUTER", row["SAPRouter"].ToString());
                    }
                    parms.Add("TRACE", "0");
                    RfcTrace.TraceDirectory = "C:\\rfclog";
                }
                try
                {
                    SapRfcDestination = RfcDestinationManager.GetDestination(parms);
                    SapRfcRepository = SapRfcDestination.Repository;
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
            string text = "";
            try
            {
                Worksheet worksheet = Globals.ThisAddIn.Application.ActiveSheet;
                int num = 0;
                int num2 = 0;
                int num3 = 0;
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
                        num3 = RunRFC_READ_TABLE.runfun(SapRfcDestination, SapRfcRepository, (worksheet.Cells[num2, 1]).value.ToString());
                        num3 = RunDD_GET_NAMETAB_FOR_RFC.runfun(SapRfcDestination, SapRfcRepository, (worksheet.Cells[num2, 1]).value.ToString());
                        (worksheet.Cells[num2, 4]).Activate();
                        (worksheet.Cells[num2, 4]).value = "✓";
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
                    tgb_flag.Label = "在线查询模式";
                    tgb_flag.Image = Resources.S_CONNEC;
                    button3.Visible = true;
                }
            }
            else
            {
                button3.Visible = false;
                tgb_flag.Label = "离线查询模式";
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

    }
}