using EXCEL_SAPHELP.Properties;
using Microsoft.Office.Tools.Ribbon;
using SAP.Middleware.Connector;
using System.ComponentModel;

namespace EXCEL_SAPHELP.EXCEL
{
    partial class SAPHelper : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SAPHelper()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_SAPHelper = this.Factory.CreateRibbonTab();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button5 = this.Factory.CreateRibbonButton();
            this.bnReSet = this.Factory.CreateRibbonButton();
            this.gp_RFC = this.Factory.CreateRibbonGroup();
            this.bt_Connect = this.Factory.CreateRibbonButton();
            this.bn_Login = this.Factory.CreateRibbonButton();
            this.bn_LogonGui = this.Factory.CreateRibbonButton();
            this.tgb_ConfigFlag = this.Factory.CreateRibbonToggleButton();
            this.tgb_LogonFlag = this.Factory.CreateRibbonToggleButton();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.tgb_flag = this.Factory.CreateRibbonToggleButton();
            this.button4 = this.Factory.CreateRibbonButton();
            this.box2 = this.Factory.CreateRibbonBox();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.box5 = this.Factory.CreateRibbonBox();
            this.bn_ReadTableS = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.bn_SignUp = this.Factory.CreateRibbonButton();
            this.bn_FL = this.Factory.CreateRibbonButton();
            this.tab_SAPHelper.SuspendLayout();
            this.group2.SuspendLayout();
            this.gp_RFC.SuspendLayout();
            this.group1.SuspendLayout();
            this.box1.SuspendLayout();
            this.box2.SuspendLayout();
            this.box5.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_SAPHelper
            // 
            this.tab_SAPHelper.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab_SAPHelper.Groups.Add(this.group2);
            this.tab_SAPHelper.Groups.Add(this.gp_RFC);
            this.tab_SAPHelper.Groups.Add(this.group1);
            this.tab_SAPHelper.Groups.Add(this.group3);
            this.tab_SAPHelper.Label = "SAP助手(by Tiger)";
            this.tab_SAPHelper.Name = "tab_SAPHelper";
            // 
            // group2
            // 
            this.group2.Items.Add(this.button2);
            this.group2.Items.Add(this.button5);
            this.group2.Items.Add(this.bnReSet);
            this.group2.Label = "关于";
            this.group2.Name = "group2";
            // 
            // button2
            // 
            this.button2.Image = global::EXCEL_SAPHELP.Properties.Resources.Logo;
            this.button2.Label = "联系作者";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Image = global::EXCEL_SAPHELP.Properties.Resources.gitee;
            this.button5.Label = "开源代码";
            this.button5.Name = "button5";
            this.button5.ShowImage = true;
            this.button5.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button5_Click);
            // 
            // bnReSet
            // 
            this.bnReSet.Image = global::EXCEL_SAPHELP.Properties.Resources.S_AGGREG;
            this.bnReSet.Label = "引用数据库";
            this.bnReSet.Name = "bnReSet";
            this.bnReSet.ShowImage = true;
            this.bnReSet.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bnReSet_Click);
            // 
            // gp_RFC
            // 
            this.gp_RFC.Items.Add(this.bt_Connect);
            this.gp_RFC.Items.Add(this.bn_Login);
            this.gp_RFC.Items.Add(this.bn_LogonGui);
            this.gp_RFC.Items.Add(this.tgb_ConfigFlag);
            this.gp_RFC.Items.Add(this.tgb_LogonFlag);
            this.gp_RFC.Label = "SAP登陆";
            this.gp_RFC.Name = "gp_RFC";
            // 
            // bt_Connect
            // 
            this.bt_Connect.Image = global::EXCEL_SAPHELP.Properties.Resources.S_BSCCON;
            this.bt_Connect.Label = "配置默认登陆信息";
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.ShowImage = true;
            this.bt_Connect.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bt_Connect_Click);
            // 
            // bn_Login
            // 
            this.bn_Login.Image = global::EXCEL_SAPHELP.Properties.Resources.S_CONNEC;
            this.bn_Login.Label = "后台登陆";
            this.bn_Login.Name = "bn_Login";
            this.bn_Login.ShowImage = true;
            this.bn_Login.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bn_Login_Click);
            // 
            // bn_LogonGui
            // 
            this.bn_LogonGui.Image = global::EXCEL_SAPHELP.Properties.Resources.S_F_MOSH;
            this.bn_LogonGui.Label = "登陆GUI客户端";
            this.bn_LogonGui.Name = "bn_LogonGui";
            this.bn_LogonGui.ShowImage = true;
            this.bn_LogonGui.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bn_LogonGui_Click);
            // 
            // tgb_ConfigFlag
            // 
            this.tgb_ConfigFlag.Image = global::EXCEL_SAPHELP.Properties.Resources.S_S_LEDR;
            this.tgb_ConfigFlag.Label = "未读取到默认配置";
            this.tgb_ConfigFlag.Name = "tgb_ConfigFlag";
            this.tgb_ConfigFlag.ShowImage = true;
            // 
            // tgb_LogonFlag
            // 
            this.tgb_LogonFlag.Image = global::EXCEL_SAPHELP.Properties.Resources.S_S_LEDR;
            this.tgb_LogonFlag.Label = "未链接";
            this.tgb_LogonFlag.Name = "tgb_LogonFlag";
            this.tgb_LogonFlag.ShowImage = true;
            // 
            // group1
            // 
            this.group1.Items.Add(this.box1);
            this.group1.Items.Add(this.box2);
            this.group1.Items.Add(this.box5);
            this.group1.Label = "读取表信息";
            this.group1.Name = "group1";
            // 
            // box1
            // 
            this.box1.Items.Add(this.tgb_flag);
            this.box1.Items.Add(this.button4);
            this.box1.Name = "box1";
            // 
            // tgb_flag
            // 
            this.tgb_flag.Image = global::EXCEL_SAPHELP.Properties.Resources.S_DISCON;
            this.tgb_flag.Label = "离线查询模式(点击切换为在线模式)";
            this.tgb_flag.Name = "tgb_flag";
            this.tgb_flag.ShowImage = true;
            this.tgb_flag.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tgb_flag_Click);
            // 
            // button4
            // 
            this.button4.Label = "初始化表字段数据";
            this.button4.Name = "button4";
            this.button4.Visible = false;
            this.button4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button4_Click);
            // 
            // box2
            // 
            this.box2.Items.Add(this.button1);
            this.box2.Items.Add(this.button3);
            this.box2.Name = "box2";
            // 
            // button1
            // 
            this.button1.Image = global::EXCEL_SAPHELP.Properties.Resources.S_MAPREL;
            this.button1.Label = "获取SAP常用表清单";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = global::EXCEL_SAPHELP.Properties.Resources.S_UNASSI;
            this.button3.Label = "根据A列更新本地表结构";
            this.button3.Name = "button3";
            this.button3.ShowImage = true;
            this.button3.Visible = false;
            this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button3_Click);
            // 
            // box5
            // 
            this.box5.Items.Add(this.bn_ReadTableS);
            this.box5.Name = "box5";
            // 
            // bn_ReadTableS
            // 
            this.bn_ReadTableS.Image = global::EXCEL_SAPHELP.Properties.Resources.S_B_BOYE;
            this.bn_ReadTableS.Label = "读取表结构";
            this.bn_ReadTableS.Name = "bn_ReadTableS";
            this.bn_ReadTableS.ShowImage = true;
            this.bn_ReadTableS.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bn_ReadTableS_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.bn_SignUp);
            this.group3.Items.Add(this.bn_FL);
            this.group3.Label = "剪切板文本处理";
            this.group3.Name = "group3";
            // 
            // bn_SignUp
            // 
            this.bn_SignUp.Image = global::EXCEL_SAPHELP.Properties.Resources.S_B_AREA;
            this.bn_SignUp.Label = "负号提前";
            this.bn_SignUp.Name = "bn_SignUp";
            this.bn_SignUp.ShowImage = true;
            this.bn_SignUp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bn_SignUp_Click);
            // 
            // bn_FL
            // 
            this.bn_FL.Image = global::EXCEL_SAPHELP.Properties.Resources.S_X__XLS;
            this.bn_FL.Label = "分列处理(ALV导出在剪切板中)";
            this.bn_FL.Name = "bn_FL";
            this.bn_FL.ShowImage = true;
            this.bn_FL.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bn_FL_Click);
            // 
            // SAPHelper
            // 
            this.Name = "SAPHelper";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab_SAPHelper);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab_SAPHelper.ResumeLayout(false);
            this.tab_SAPHelper.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.gp_RFC.ResumeLayout(false);
            this.gp_RFC.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.box5.ResumeLayout(false);
            this.box5.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


         

        internal RibbonTab tab_SAPHelper;

        internal RibbonGroup gp_RFC;

        internal RibbonButton bt_Connect;

        internal RibbonToggleButton tgb_LogonFlag;

        internal RibbonGroup group1;

        internal RibbonBox box2;

        internal RibbonButton bn_ReadTableS;

        internal RibbonButton bn_Login;

        internal RibbonButton bn_LogonGui;

        internal RibbonToggleButton tgb_ConfigFlag;

        internal RibbonButton button1;

        internal RibbonBox box5;

        internal RibbonButton button3;

        internal RibbonToggleButton tgb_flag;

        internal RibbonGroup group2;

        internal RibbonButton button2;
        internal RibbonBox box1;
        internal RibbonButton button4;
        internal RibbonButton button5;
        internal RibbonGroup group3;
        internal RibbonButton bn_SignUp;
        internal RibbonButton bn_FL;
        internal RibbonButton bnReSet;
    }

    //partial class ThisRibbonCollection
    //{
    //    internal SAPHelper Ribbon1
    //    {
    //        get { return this.GetRibbon<SAPHelper>(); }
    //    }
    //}
}
