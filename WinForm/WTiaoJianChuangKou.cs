using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class WTiaoJianChuangKou : Form
{
	public List<ShaiXuan> ShaiXuans = new List<ShaiXuan>();

	public List<BianLiang> BianLiangs = new List<BianLiang>();

	public string ZhiXingYuju = "";

	private IContainer components = null;

	private Button button1;

	private Button button2;

	public WTiaoJianChuangKou(DataGridView dg)
	{
		InitializeComponent();
		for (int i = 0; i < dg.Columns.Count; i++)
		{
			SuspendLayout();
			AddLabel(dg.Columns[i].HeaderText, dg.Columns[i].HeaderText.Length, i + 1);
			AddTextBox(dg.Columns[i].HeaderText, dg.Columns[i].HeaderText.Length, i + 1);
			ResumeLayout(performLayout: false);
		}
	}

	private void AddLabel(string Name, int ZiShu, int XuHao)
	{
		Label label = new Label();
		label.AutoSize = true;
		label.Location = new Point(15, XuHao * 24);
		label.Name = "lb" + Name;
		label.Size = new Size(12 * ZiShu, 12);
		label.TabIndex = 0;
		label.Text = Name;
		base.Controls.Add(label);
	}

	private void AddTextBox(string Name, int ZiShu, int XuHao)
	{
		TextBox textBox = new TextBox();
		textBox.Location = new Point(100, 21 + (XuHao - 1) * 24);
		textBox.Name = "tb" + Name;
		textBox.Size = new Size(200, 21);
		textBox.TabIndex = XuHao;
		base.Controls.Add(textBox);
		BianLiangs.Add(new BianLiang(textBox, "TextBox"));
	}

	private void button2_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		try
		{
			foreach (BianLiang bianLiang in BianLiangs)
			{
				if (bianLiang.LeiXing == "TextBox")
				{
					ShaiXuans.Add(new ShaiXuan((bianLiang.DuiXiang as TextBox).Name.Substring(2, (bianLiang.DuiXiang as TextBox).Name.Length - 2), (bianLiang.DuiXiang as TextBox).Text));
				}
			}
			base.DialogResult = DialogResult.OK;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WTiaoJianChuangKou));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(21, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(85, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WTiaoJianChuangKou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(366, 369);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WTiaoJianChuangKou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WTiaoJianChuangKou";
            this.ResumeLayout(false);

	}
}
