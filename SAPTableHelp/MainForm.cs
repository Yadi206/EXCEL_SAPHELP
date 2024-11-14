using SAP.Middleware.Connector; 
using SAPTableHelp.WinForm;
using System;
using System.Collections.Generic; 
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Windows.Forms;
using SAPTableHelp.RunFun;
using SAPTableHelp.Com.Model;
using EXCELDLL = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace SAPTableHelp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Saplogon sl = new Saplogon();
            if (sl.ShowDialog() == DialogResult.OK)
            {
                SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
                SysConfigInfo.saploginfo = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_logininfo", null);
                setmsg(": 链接设置成功", true);
                if (SysConfigInfo.saploginfo != null && SysConfigInfo.saploginfo.Rows.Count > 0)
                {
                    setmsg(": 服务器：" + SysConfigInfo.saploginfo.Rows[0]["AppServerHost"], true);
                    setmsg(": 客户端：" + SysConfigInfo.saploginfo.Rows[0]["Client"], true);
                    setmsg(": 用户：" + SysConfigInfo.saploginfo.Rows[0]["User"], true);
                }

            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
            SysConfigInfo.saploginfo = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_logininfo", null);
            if (SysConfigInfo.saploginfo == null || SysConfigInfo.saploginfo.Rows.Count == 0)
            {
                setmsg(": 未读取到默认配置", false);
            }
            else
            {
                setmsg(": 默认配置成功", true);

                if (SysConfigInfo.saploginfo != null && SysConfigInfo.saploginfo.Rows.Count > 0)
                {
                    setmsg(": 服务器：" + SysConfigInfo.saploginfo.Rows[0]["AppServerHost"], true);
                    setmsg(": 客户端：" + SysConfigInfo.saploginfo.Rows[0]["Client"], true);
                    setmsg(": 用户：" + SysConfigInfo.saploginfo.Rows[0]["User"], true);
                }
            }



        }

        private void setmsg(string msg, bool ss)
        {
            if (ss)
            {
                rtb_MSG.SelectionColor = Color.Green;
            }
            else
            {
                rtb_MSG.SelectionColor = Color.Red;
            }
            rtb_MSG.AppendText(Environment.NewLine + DateTime.Now.ToLongTimeString() + msg);
            rtb_MSG.SelectionStart = rtb_MSG.Text.Length;
            rtb_MSG.ScrollToCaret();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

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
                    SysConfigInfo.sConnectFlag = ConnectFlag.已连接.ToString();
                    setmsg(": 链接成功", true);
                }
                catch (Exception ex)
                {
                    setmsg(": 登陆失败" + ex.Message, false);
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stablename = "";
            string flag = "";
            bool ishaveinclude = false;

            if (SysConfigInfo.sConnectFlag == ConnectFlag.已连接.ToString())
            {
                frWriteTableName wtn = new frWriteTableName();
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

                int num = 0;
                string sti = "";
                string txtTableName = "";
                List<DD03L> dd03ls3 = new List<DD03L>();
                sti = SapTableInfo.SaveTableInfo(stablename, ref dd03ls3, ref txtTableName);

                if (sti != "成功")
                {
                    setmsg(sti, false);
                    return;
                }
                
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
            else
            {
                setmsg("：请先执行后台登录", false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetTables ft = new SetTables();
            if (ft.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            if (ft.dt.Rows.Count > 0)
            {
                int line = 1;
                string text = "";
                List<SAPTable> tTables = new List<SAPTable>();
                try
                {
                    foreach (DataRow item in ft.dt.Rows)
                    {
                        if (!string.IsNullOrEmpty(item["表名"].ToString()))
                        {
                            text = item["表名"].ToString();
                            text = text.Trim().ToUpper();
                        }

                        //A列表数据读取
                        string stxtTableName0 = "";
                        IRfcTable table1 = null;
                        RFCHelp.getTableInfo(text, ref table1, ref stxtTableName0);
                        if (SysConfigInfo.sFunExist != "函数:")
                        {
                            setmsg("读取表" + text + "失败，失败原因：" + SysConfigInfo.sFunExist, false);
                        }
                        setmsg("：" + text + "✓", true);

                        //文本表数据读取
                        if (!string.IsNullOrEmpty(stxtTableName0))
                        {
                            string stxtTableName1 = "";
                            IRfcTable table2 = null;
                            RFCHelp.getTableInfo(stxtTableName0, ref table2, ref stxtTableName1);

                            if (SysConfigInfo.sFunExist != "函数:")
                            {
                                setmsg("读取表" + stxtTableName0 + "失败，失败原因：" + SysConfigInfo.sFunExist, false);
                            }
                            setmsg("：" + stxtTableName0 + "✓", true);
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
                                        string stxtTableName2 = "";
                                        IRfcTable table2 = null;
                                        RFCHelp.getTableInfo(stablename, ref table2, ref stxtTableName2);

                                        if (SysConfigInfo.sFunExist != "函数:")
                                        {
                                            setmsg("读取表" + stablename + "失败，失败原因：" + SysConfigInfo.sFunExist, false);
                                        }
                                        setmsg("：" + stablename + "✓", true);
                                        //字段对应值域表对应文本表
                                        if (!string.IsNullOrEmpty(stxtTableName2))
                                        {
                                            string stxtTableName3 = "";
                                            IRfcTable table3 = null;
                                            RFCHelp.getTableInfo(stxtTableName2, ref table3, ref stxtTableName3);

                                            if (SysConfigInfo.sFunExist != "函数:")
                                            {
                                                setmsg("读取表" + stxtTableName2 + "失败，失败原因：" + SysConfigInfo.sFunExist, false);
                                            }
                                            setmsg("：" + stxtTableName2 + "✓", true);
                                        }
                                        line++;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    setmsg("：" + ex.Message, false);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (SysConfigInfo.sConnectFlag != ConnectFlag.已连接.ToString())
            {
                setmsg("：请先执行后台登录", false);
            }
            List<DD03L> dd03ls1 = new List<DD03L>();

            SetTables ft = new SetTables();
            if (ft.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            if (ft.dt.Rows.Count > 0)
            {
                int line = 1;
                string text = "";
                List<SAPTable> tTables = new List<SAPTable>();
                try
                {
                    foreach (DataRow item in ft.dt.Rows)
                    {
                        if (!string.IsNullOrEmpty(item["表名"].ToString()))
                        {
                            text = item["表名"].ToString();
                            text = text.Trim().ToUpper();
                        }

                        var a = tTables.FirstOrDefault(t => t.tablename == text);
                        if (a != null)
                        {
                            continue;
                        }

                        //A列表数据读取
                        string stxtTableName0 = "";
                        string sti = SapTableInfo.SaveTableInfo(text, ref dd03ls1, ref stxtTableName0);
                        if (sti != "成功")
                        {
                            setmsg("读取表" + text + "失败，失败原因：" + sti, false);
                        }
                        setmsg("：" + text + "✓", true);

                        //文本表数据读取
                        if (!string.IsNullOrEmpty(stxtTableName0))
                        {
                            a = tTables.FirstOrDefault(t => t.tablename == text);
                            if (a == null)
                            {
                                string stxtTableName1 = "";

                                List<DD03L> dd03ls2 = new List<DD03L>();
                                sti = SapTableInfo.SaveTableInfo(stxtTableName0, ref dd03ls2, ref stxtTableName1);

                                if (sti != "成功")
                                {
                                    setmsg("读取表" + stxtTableName0 + "失败，失败原因：" + sti, false);
                                }
                                setmsg("：" + stxtTableName0 + "✓", true);
                            }
                        }
                        //字段对应值域表读取
                        if (dd03ls1 != null)
                        {
                            foreach (DD03L item1 in dd03ls1)
                            {
                                string stablename = item1.CHECKTABLE.ToString().Replace("'", "").Replace(" ", "");
                                if (!string.IsNullOrEmpty(stablename))
                                {
                                    a = tTables.FirstOrDefault(t => t.tablename == stablename);
                                    if (a == null)
                                    {
                                        SAPTable tt = new SAPTable();
                                        tt.tablename = stablename;
                                        tTables.Add(tt);
                                        string stxtTableName2 = "";


                                        List<DD03L> dd03ls2 = new List<DD03L>();
                                        sti = SapTableInfo.SaveTableInfo(stablename, ref dd03ls2, ref stxtTableName2);

                                        if (sti != "成功")
                                        {
                                            setmsg("读取表" + stablename + "失败，失败原因：" + sti, false);
                                        }
                                        setmsg("：" + stablename + "✓", true);
                                        //字段对应值域表对应文本表
                                        if (!string.IsNullOrEmpty(stxtTableName2))
                                        {
                                            string stxtTableName3 = "";
                                            List<DD03L> dd03ls3 = new List<DD03L>();
                                            sti = SapTableInfo.SaveTableInfo(stxtTableName2, ref dd03ls3, ref stxtTableName3);

                                            if (sti != "成功")
                                            {
                                                setmsg("读取表" + stxtTableName2 + "失败，失败原因：" + sti, false);
                                            }
                                            setmsg("：" + stxtTableName2 + "✓", true);
                                        }
                                        line++;
                                    }
                                }





                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    setmsg("：" + ex.Message, false);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        { 
            //// 保存Excel文件
            //xlWorkBook.SaveAs("C:\\MyExcel.xlsx");

            //// 关闭Excel文件
            //xlWorkBook.Close();
            //xlApp.Quit();

            frWriteFunName wf = new frWriteFunName();
            if (wf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sfunanme = wf.FunName;
                    int icurrow = 0;
                    int icurcolumn = 0;
                    EXCELDLL.Application xlApp = new EXCELDLL.Application(); 
                    // 隐藏Excel窗口
                    xlApp.Visible = true;
                    // 禁用警告消息
                    xlApp.DisplayAlerts = false;
                    EXCELDLL.Workbook activeWorkbook = xlApp.Workbooks.Add();
                     
                    bool flag1 = false;
                    foreach (EXCELDLL.Worksheet sheet in activeWorkbook.Sheets)
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
                    EXCELDLL.Worksheet worksheet2 = activeWorkbook.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
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

        private void setBiaoTou(EXCELDLL.Worksheet ws, int currow, int curcolumn)
        {
            EXCELDLL.Range curcell;
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

        private void setHeBing(EXCELDLL.Worksheet ws, int srow, int scolumn, int erow, int ecolumn)
        {
            ws.Range[ws.Cells[srow, scolumn], ws.Cells[erow, ecolumn]].Merge();
            ws.Range[ws.Cells[srow, scolumn], ws.Cells[erow, ecolumn]].VerticalAlignment = EXCELDLL.XlVAlign.xlVAlignTop;
        }

        private void setBianKuang(EXCELDLL.Worksheet ws, int srow, int scolumn, int erow, int ecolumn)
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
    }
}
