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

namespace EXCEL_SAPHELP
{
    public partial class ThisAddIn
    {
        KeyboardHook keyboardHook = new KeyboardHook();
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //keyboardHook.InitHook();  //绑定钩子 

            //hook = new KeyboardHook();
            //hook.InitHook();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            //keyboardHook.UnHook();  //拆卸钩子 
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
