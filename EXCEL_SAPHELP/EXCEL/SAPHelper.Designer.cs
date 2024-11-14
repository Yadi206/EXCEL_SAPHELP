using EXCEL_SAPHELP.Properties;
using Microsoft.Office.Tools.Ribbon; 
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
            this.label1 = this.Factory.CreateRibbonLabel();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button5 = this.Factory.CreateRibbonButton();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.box2 = this.Factory.CreateRibbonBox();
            this.button1 = this.Factory.CreateRibbonButton();
            this.bn_ReadTableS = this.Factory.CreateRibbonButton();
            this.box1 = this.Factory.CreateRibbonBox();
            this.bn_Open = this.Factory.CreateRibbonButton();
            this.bnReSet = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.bn_SignUp = this.Factory.CreateRibbonButton();
            this.bn_FL = this.Factory.CreateRibbonButton();
            this.buttonGroup2 = this.Factory.CreateRibbonButtonGroup();
            this.bnSapRiQi = this.Factory.CreateRibbonButton();
            this.bnSAPShuZhi = this.Factory.CreateRibbonButton();
            this.bnJinE = this.Factory.CreateRibbonButton();
            this.tab_SAPHelper.SuspendLayout();
            this.group2.SuspendLayout();
            this.group1.SuspendLayout();
            this.box2.SuspendLayout();
            this.box1.SuspendLayout();
            this.group3.SuspendLayout();
            this.buttonGroup1.SuspendLayout();
            this.buttonGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_SAPHelper
            // 
            this.tab_SAPHelper.Groups.Add(this.group2);
            this.tab_SAPHelper.Groups.Add(this.group1);
            this.tab_SAPHelper.Groups.Add(this.group3);
            this.tab_SAPHelper.Label = "SAP工具箱";
            this.tab_SAPHelper.Name = "tab_SAPHelper";
            // 
            // group2
            // 
            this.group2.Items.Add(this.label1);
            this.group2.Items.Add(this.button2);
            this.group2.Items.Add(this.button5);
            this.group2.Label = "关于";
            this.group2.Name = "group2";
            // 
            // label1
            // 
            this.label1.Label = "版本号:V3.0.0";
            this.label1.Name = "label1";
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
            // group1
            // 
            this.group1.Items.Add(this.box2);
            this.group1.Items.Add(this.box1);
            this.group1.Label = "读取表信息";
            this.group1.Name = "group1";
            // 
            // box2
            // 
            this.box2.Items.Add(this.button1);
            this.box2.Items.Add(this.bn_ReadTableS);
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
            // bn_ReadTableS
            // 
            this.bn_ReadTableS.Image = global::EXCEL_SAPHELP.Properties.Resources.S_B_BOYE;
            this.bn_ReadTableS.Label = "读取表结构";
            this.bn_ReadTableS.Name = "bn_ReadTableS";
            this.bn_ReadTableS.ShowImage = true;
            this.bn_ReadTableS.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bn_ReadTableS_Click);
            // 
            // box1
            // 
            this.box1.Items.Add(this.bn_Open);
            this.box1.Items.Add(this.bnReSet);
            this.box1.Name = "box1";
            // 
            // bn_Open
            // 
            this.bn_Open.Image = global::EXCEL_SAPHELP.Properties.Resources.Logo;
            this.bn_Open.Label = "打开在线工具";
            this.bn_Open.Name = "bn_Open";
            this.bn_Open.ShowImage = true;
            this.bn_Open.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bn_Open_Click);
            // 
            // bnReSet
            // 
            this.bnReSet.Image = global::EXCEL_SAPHELP.Properties.Resources.S_AGGREG;
            this.bnReSet.Label = "引用数据库";
            this.bnReSet.Name = "bnReSet";
            this.bnReSet.ShowImage = true;
            this.bnReSet.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bnReSet_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.buttonGroup1);
            this.group3.Items.Add(this.buttonGroup2);
            this.group3.Label = "剪切板文本处理";
            this.group3.Name = "group3";
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Items.Add(this.bn_SignUp);
            this.buttonGroup1.Items.Add(this.bn_FL);
            this.buttonGroup1.Name = "buttonGroup1";
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
            // buttonGroup2
            // 
            this.buttonGroup2.Items.Add(this.bnSapRiQi);
            this.buttonGroup2.Items.Add(this.bnSAPShuZhi);
            this.buttonGroup2.Items.Add(this.bnJinE);
            this.buttonGroup2.Name = "buttonGroup2";
            // 
            // bnSapRiQi
            // 
            this.bnSapRiQi.Label = "->SAP日期格式";
            this.bnSapRiQi.Name = "bnSapRiQi";
            this.bnSapRiQi.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bnSapRiQi_Click);
            // 
            // bnSAPShuZhi
            // 
            this.bnSAPShuZhi.Label = "->SAP数值";
            this.bnSAPShuZhi.Name = "bnSAPShuZhi";
            this.bnSAPShuZhi.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bnSAPShuZhi_Click);
            // 
            // bnJinE
            // 
            this.bnJinE.Label = "->SAP金额";
            this.bnJinE.Name = "bnJinE";
            this.bnJinE.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bnJinE_Click);
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
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.buttonGroup1.ResumeLayout(false);
            this.buttonGroup1.PerformLayout();
            this.buttonGroup2.ResumeLayout(false);
            this.buttonGroup2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


         

        internal RibbonTab tab_SAPHelper;

        internal RibbonGroup group1;

        internal RibbonBox box2;

        internal RibbonButton bn_ReadTableS;

        internal RibbonButton button1;

        internal RibbonGroup group2;

        internal RibbonButton button2;
        internal RibbonButton button5;
        internal RibbonGroup group3;
        internal RibbonButton bn_SignUp;
        internal RibbonButton bn_FL;
        internal RibbonButton bnReSet;
        internal RibbonButton bnSapRiQi;
        internal RibbonButton bnSAPShuZhi;
        internal RibbonButton bnJinE;
        internal RibbonLabel label1;
        internal RibbonButtonGroup buttonGroup1;
        internal RibbonButtonGroup buttonGroup2;
        internal RibbonBox box1;
        internal RibbonButton bn_Open;
    }

    //partial class ThisRibbonCollection
    //{
    //    internal SAPHelper Ribbon1
    //    {
    //        get { return this.GetRibbon<SAPHelper>(); }
    //    }
    //}
}
