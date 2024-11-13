using EXCEL_SAPHELP.Com.Model;
using EXCEL_SAPHELP.Properties;
using EXCEL_SAPHELP.WinForm;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using Newtonsoft.Json;
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
using System.Diagnostics;
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

            //SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
            //DataTable dataTable = sQLiteDBHelper.ExecuteDataTable("select  id,log_path,ShowType from sys_t_config");
            //if (dataTable != null && dataTable.Rows.Count > 0)
            //{
            //    DataRow dataRow2 = dataTable.Rows[0];
            //    tb_RZML.Text = dataRow2["log_path"].ToString();
            //    cbShowType.Text = dataRow2["ShowType"].ToString();
            //}


            System.Data.DataTable dataTable = sQLiteDBHelper.ExecuteDataTable("select id,log_path,ShowType from sys_t_config");
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
                if (dataRow["ShowType"] != null && !string.IsNullOrEmpty(dataRow["ShowType"].ToString()))
                {
                    SysConfigInfo.showtype = dataRow["ShowType"].ToString(); 
                } 
            }

            System.Data.DataTable dt2 = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_dbfld");
            if (dt2 == null || (dt2 != null && dt2.Rows.Count == 0))
            {
                bnSapRiQi.Visible = true;
            }

        }

        private void bn_ReadTableS_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                string stablename = "";
                string flag = "";
                bool ishaveinclude = false;
                frWriteTableName wtn = new frWriteTableName();
                wtn.showtype = SysConfigInfo.showtype;
                if (wtn.ShowDialog() == DialogResult.OK)
                {
                    stablename = wtn.TableName;
                    flag = wtn.flag;
                    ishaveinclude = wtn.ishaveinclude;
                }
                else
                {
                    return;
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
                    worksheet2.Cells[num2, 8].Value = "长度";
                    worksheet2.Cells[num2, 9].Value = "小数位";
                    worksheet2.Cells[num2, 10].Value = "表字段";
                    worksheet2.Cells[num2, 11].Value = "字段描述";
                    System.Data.DataTable dataTable = SapTableInfo.getSapTable(stablename, ishaveinclude);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        num2++;
                        (worksheet2.Cells[num2, 1]).Value = row["位置"];
                        (worksheet2.Cells[num2, 2]).Value = row["字段"];
                        (worksheet2.Cells[num2, 3]).Value = row["主键"];
                        (worksheet2.Cells[num2, 4]).Value = row["元素"];
                        (worksheet2.Cells[num2, 5]).Value = row["类型"];
                        (worksheet2.Cells[num2, 6]).Value = row["数据类型"];
                        (worksheet2.Cells[num2, 7]).Value = row["值域表"];
                        (worksheet2.Cells[num2, 8]).Value = row["长度"];
                        (worksheet2.Cells[num2, 9]).Value = row["小数位数"];
                        (worksheet2.Cells[num2, 10]).Value = row["拼接"];
                        (worksheet2.Cells[num2, 11]).Value = row["描述"];
                    }
                    worksheet2.Columns.AutoFit();
                    Borders borders = worksheet2.Range[worksheet2.Cells[1, 1], worksheet2.Cells[num2, 11]].Borders;
                    borders.LineStyle = XlLineStyle.xlContinuous;
                    borders.Weight = XlBorderWeight.xlThin;
                }

                if (flag == "WINDOWS")
                {
                    FullTable ft = new FullTable();
                    ft.ishaveinclude = ishaveinclude;
                    ft.dt = SapTableInfo.getSapTable(stablename, ishaveinclude);
                    SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
                    string sql = "";
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

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            Process.Start("https://www.yuque.com/tiger-fb9jj/ww5ogm/vvvcznwx5hc57oyt?singleDoc# 《让分享成为习惯！》");
        }


        private void button5_Click(object sender, RibbonControlEventArgs e)
        {
            Process.Start("https://gitee.com/Tiger_Hu_gitee/EXCEL_SAPHELP");
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

        private void bn_Open_Click(object sender, RibbonControlEventArgs e)
        {
            //调用程序：
            string args = "";

            Process KHMsg = new Process();
            KHMsg.StartInfo.FileName = SysConfigInfo.current_path_32 + "SAPTableHelp.exe";
            KHMsg.StartInfo.Arguments = args;
            KHMsg.Start();

            //while (!KHMsg.HasExited) { } //如果exe还没关闭，则等待
            //if (KHMsg.ExitCode == 2)
            //{
            //    //...
            //} 
        }


    }
}