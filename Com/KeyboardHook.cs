 
using EXCEL_SAPHELP.WinForm;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCEL_SAPHELP.Com
{
    class KeyboardHook
    {
        #region (invokestuff)
        [DllImport("kernel32.dll")]
        static extern uint GetCurrentThreadId();
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int code, HookProcKeyboard func, IntPtr hInstance, uint threadID);
        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        #endregion

        #region constans
        private const int WH_KEYBOARD = 2;
        private const int HC_ACTION = 0;
        #endregion

        delegate int HookProcKeyboard(int code, IntPtr wParam, IntPtr lParam);
        private HookProcKeyboard KeyboardProcDelegate = null;
        private IntPtr khook;
        bool doing = false;

        public void InitHook()
        {
            uint id = GetCurrentThreadId();
            //init the keyboard hook with the thread id of the Visual Studio IDE   
            this.KeyboardProcDelegate = new HookProcKeyboard(this.KeyboardProc);
            khook = SetWindowsHookEx(WH_KEYBOARD, this.KeyboardProcDelegate, IntPtr.Zero, id);
        }

        public void UnHook()
        {
            if (khook != IntPtr.Zero)
            {
                UnhookWindowsHookEx(khook);
            }
        }

        private int KeyboardProc(int code, IntPtr wParam, IntPtr lParam)
        {
            try
            {
                if (code != HC_ACTION)
                {
                    return CallNextHookEx(khook, code, wParam, lParam);
                }

                if ((int)wParam == (int)Keys.Q && ((int)lParam  == 1048577))
                {
                    if (!doing)
                    {
                        doing = true;
                        #region alt + 5
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
                                doing = false;
                                return 1;
                            }

                            if (SysConfigInfo.sConnectFlag == ConnectFlag.已连接.ToString())
                            {
                                int num = 0;
                                num = RunRFC_READ_TABLE.runfun(SysConfigInfo.SapRfcDestination, SysConfigInfo.SapRfcRepository, stablename);
                                num = RunDD_GET_NAMETAB_FOR_RFC.runfun(SysConfigInfo.SapRfcDestination, SysConfigInfo.SapRfcRepository, stablename);
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
                                worksheet2.Cells[num2, 3].Value = "元素";
                                worksheet2.Cells[num2, 4].Value = "类型";
                                worksheet2.Cells[num2, 5].Value = "数据类型";
                                worksheet2.Cells[num2, 6].Value = "结构中的位置";
                                worksheet2.Cells[num2, 7].Value = "长度";
                                worksheet2.Cells[num2, 8].Value = "字段描述";
                                SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
                                string sql = "select CAST(sys_t_x031l.position AS INTEGER) as position,sys_t_x031l.fieldname,sys_t_x031l.rollname,sys_t_x031l.dtyp,sys_t_x031l.exid,CAST(sys_t_dbfld.offset AS INTEGER) as offset,CAST(sys_t_dbfld.length AS INTEGER) as length,'" + stablename + "-' || sys_t_x031l.fieldname as field, sys_t_dbfld.fieldtext from sys_t_x031l inner join sys_t_dbfld on sys_t_dbfld.tabname = sys_t_x031l.tabname and sys_t_dbfld.fieldname = sys_t_x031l.fieldname where sys_t_x031l.tabname = '" + stablename + "'  order by CAST(sys_t_x031l.position AS INTEGER)";
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
                            if (flag == "WINDOWS")
                            {
                                FullTable ft = new FullTable(); 
                                SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
                                string sql = "select CAST(sys_t_x031l.position AS INTEGER) as position,sys_t_x031l.fieldname,sys_t_x031l.rollname,sys_t_x031l.dtyp,sys_t_x031l.exid,CAST(sys_t_dbfld.offset AS INTEGER) as offset,CAST(sys_t_dbfld.length AS INTEGER) as length,'" + stablename + "-' || sys_t_x031l.fieldname as field,sys_t_dbfld.fieldtext from sys_t_x031l inner join sys_t_dbfld on sys_t_dbfld.tabname = sys_t_x031l.tabname and sys_t_dbfld.fieldname = sys_t_x031l.fieldname where sys_t_x031l.tabname = '" + stablename + "'  order by CAST(sys_t_x031l.position AS INTEGER)";
                                System.Data.DataTable dataTable = sQLiteDBHelper.ExecuteDataTable(sql);
                                ft.dt = dataTable;
                                ft.stitle = stablename;
                                ft.Show();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message); 
                        } 
                        #endregion 
                        doing = false;
                        return 1;
                    }
                }
            }
            catch
            {
            } 
            return CallNextHookEx(khook, code, wParam, lParam);
        }
    }
}
