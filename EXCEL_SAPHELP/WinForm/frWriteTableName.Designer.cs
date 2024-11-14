namespace EXCEL_SAPHELP.WinForm
{
    partial class frWriteTableName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TableName = new System.Windows.Forms.TextBox();
            this.rb_Sheet = new System.Windows.Forms.RadioButton();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bn_FindTable = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "表名:";
            // 
            // tb_TableName
            // 
            this.tb_TableName.Location = new System.Drawing.Point(55, 23);
            this.tb_TableName.Name = "tb_TableName";
            this.tb_TableName.Size = new System.Drawing.Size(152, 21);
            this.tb_TableName.TabIndex = 0;
            this.tb_TableName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TableName_KeyPress);
            // 
            // rb_Sheet
            // 
            this.rb_Sheet.AutoSize = true;
            this.rb_Sheet.Location = new System.Drawing.Point(15, 89);
            this.rb_Sheet.Name = "rb_Sheet";
            this.rb_Sheet.Size = new System.Drawing.Size(101, 16);
            this.rb_Sheet.TabIndex = 1;
            this.rb_Sheet.Text = "新建Sheet显示";
            this.rb_Sheet.UseVisualStyleBackColor = true;
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Checked = true;
            this.rbWindows.Location = new System.Drawing.Point(15, 111);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(95, 16);
            this.rbWindows.TabIndex = 5;
            this.rbWindows.TabStop = true;
            this.rbWindows.Text = "独立窗口展示";
            this.rbWindows.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(94, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(183, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bn_FindTable
            // 
            this.bn_FindTable.Location = new System.Drawing.Point(213, 22);
            this.bn_FindTable.Name = "bn_FindTable";
            this.bn_FindTable.Size = new System.Drawing.Size(52, 23);
            this.bn_FindTable.TabIndex = 2;
            this.bn_FindTable.Text = "查找";
            this.bn_FindTable.UseVisualStyleBackColor = true;
            this.bn_FindTable.Click += new System.EventHandler(this.bn_FindTable_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "显示.INCLUDE 等引用结构";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frWriteTableName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 179);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bn_FindTable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbWindows);
            this.Controls.Add(this.rb_Sheet);
            this.Controls.Add(this.tb_TableName);
            this.Controls.Add(this.label1);
            this.Name = "frWriteTableName";
            this.ShowIcon = false;
            this.Text = "输入要查询结构的表名";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frWriteTableName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TableName;
        private System.Windows.Forms.RadioButton rb_Sheet;
        private System.Windows.Forms.RadioButton rbWindows;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bn_FindTable;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}