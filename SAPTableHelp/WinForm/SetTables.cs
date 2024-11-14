using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public class SetTables : Form
{
    public DataTable dt = new DataTable();
    private RichTextBox richTextBox1;
    private System.Windows.Forms.Button bn_ok;
    private System.Windows.Forms.Button bn_c;

    public SetTables()
    {
        InitializeComponent();
    } 
    private void InitializeComponent()
    { 
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bn_ok = new System.Windows.Forms.Button();
            this.bn_c = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(600, 219);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // bn_ok
            // 
            this.bn_ok.Location = new System.Drawing.Point(462, 226);
            this.bn_ok.Name = "bn_ok";
            this.bn_ok.Size = new System.Drawing.Size(58, 23);
            this.bn_ok.TabIndex = 1;
            this.bn_ok.Text = "确认";
            this.bn_ok.UseVisualStyleBackColor = true;
            this.bn_ok.Click += new System.EventHandler(this.bn_ok_Click);
            // 
            // bn_c
            // 
            this.bn_c.Location = new System.Drawing.Point(526, 226);
            this.bn_c.Name = "bn_c";
            this.bn_c.Size = new System.Drawing.Size(62, 23);
            this.bn_c.TabIndex = 2;
            this.bn_c.Text = "取消";
            this.bn_c.UseVisualStyleBackColor = true;
            this.bn_c.Click += new System.EventHandler(this.bn_c_Click);
            // 
            // SetTables
            // 
            this.ClientSize = new System.Drawing.Size(600, 261);
            this.Controls.Add(this.bn_c);
            this.Controls.Add(this.bn_ok);
            this.Controls.Add(this.richTextBox1);
            this.Name = "SetTables";
            this.Text = "设置要同步的表清单";
            this.Load += new System.EventHandler(this.SetTables_Load);
            this.ResumeLayout(false);

    }
    private void SetTables_Load(object sender, EventArgs e)
    {
        this.TopMost = true;
        dt = new DataTable();
        dt.Columns.Add("表名");
    }

    private void bn_c_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;

    }

    private void bn_ok_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(richTextBox1.Text))
        { 
            string[] allRow = richTextBox1.Text.Trim().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in allRow)
            {
                DataRow dr = dt.NewRow();
                dr["表名"] = item;
                dt.Rows.Add(dr);
            }
        } 
        this.DialogResult = DialogResult.OK;

    }


}
