using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using EXCEL_SAPHELP.Com;
using System.Windows.Forms;
using Microsoft.Office.Core;

namespace EXCEL_SAPHELP
{
    public partial class ThisAddIn
    {
        KeyboardHook keyboardHook = new KeyboardHook();
        Excel.Application app;
        List<string> customMenuTags = new List<string>();
        private static CommandBarButton btn;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

            app = Globals.ThisAddIn.Application;
            app.SheetSelectionChange += App_SheetSelectionChange;
            customMenuTags = new List<string>();
            customMenuTags.Add("ShowTable");
            //keyboardHook.InitHook();  //绑定钩子 

            //hook = new KeyboardHook();
            //hook.InitHook();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            //keyboardHook.UnHook();  //拆卸钩子 
        }


        private void App_SheetSelectionChange(object Sh, Excel.Range Target)
        {

            //右键重置避免按钮重复
            CommandBar currentMenuBar = app.CommandBars["cell"];
            currentMenuBar.Reset();
            //删除右键
            foreach (CommandBarControl temp_contrl in currentMenuBar.Controls)
            {
                string t = temp_contrl.Tag;
                if (customMenuTags.Contains(t))
                {
                    if (temp_contrl.Type == MsoControlType.msoControlPopup)
                    {
                        temp_contrl.Delete();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }
                    else
                    {
                        try
                        {
                            temp_contrl.Delete();
                        }
                        catch { }
                    }
                }
            }

            //解决事件连续触发
            btn = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();


            //定义右键菜单
            btn = (CommandBarButton)currentMenuBar.Controls.Add(MsoControlType.msoControlButton, missing, missing, missing);

            btn.Tag = "ShowTable";
            btn.Caption = "查看SAP表格";
            btn.Click += NewControl_Click;

            //显示
            foreach (CommandBarControl temp_contrl in currentMenuBar.Controls)
            {
                string t = temp_contrl.Tag;
                if (customMenuTags.Contains(t))
                {
                    if (temp_contrl.Type == MsoControlType.msoControlButtonPopup)
                    {
                        ((CommandBarPopup)temp_contrl).Visible = true;
                    }
                    else
                    {
                        try
                        {
                            ((CommandBarButton)temp_contrl).Visible = true;
                        }
                        catch { }
                    }
                }
            }

        }

        private void NewControl_Click(Office.CommandBarButton Ctrl, ref bool CancelDefault)
        {
            Excel.Range activeCell = Globals.ThisAddIn.Application.ActiveCell;
            string stabname = "";
            if (activeCell != null)
            {
                stabname = activeCell.Value.ToString();
                stabname = stabname.ToUpper();
                FullTable ft = new FullTable();
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
                sql += "       '" + stabname + "-' || sys_t_x031l.fieldname as field, ";
                sql += "       sys_t_dbfld.fieldtext ";
                sql += "from sys_t_x031l inner join sys_t_dbfld on sys_t_dbfld.tabname = sys_t_x031l.tabname and sys_t_dbfld.fieldname = sys_t_x031l.fieldname ";
                sql += "                 LEFT join sys_t_et_dfies on sys_t_et_dfies.tabname = sys_t_x031l.tabname and sys_t_et_dfies.fieldname = sys_t_x031l.fieldname ";
                sql += "where sys_t_x031l.tabname = '" + stabname + "' ";
                sql += "order by CAST(sys_t_dbfld.offset AS INTEGER) ";
                System.Data.DataTable dataTable = sQLiteDBHelper.ExecuteDataTable(sql);
                ft.dt = dataTable;
                sql = "select * from  sys_t_tables where tabname = '" + stabname + "';";
                System.Data.DataTable dt_tab = sQLiteDBHelper.ExecuteDataTable(sql);
                if (dt_tab != null && dt_tab.Rows.Count > 0)
                {
                    ft.stitle = dt_tab.Rows[0]["tabname"].ToString() + ":" + dt_tab.Rows[0]["tabdescribe"].ToString();
                    ft.sTxtTableName = dt_tab.Rows[0]["tabtxtname"].ToString();
                }
                else
                {
                    ft.stitle = stabname;
                }
                ft.Show();
            }
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
