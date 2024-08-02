using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

public class FullTable : Form
{
	public DataTable dt;

	public DataSet ds;

	public int lines = 0;

	private IContainer components = null;

	private CDataGridView cDataGridView1;

	public FullTable()
	{
		InitializeComponent();
	}

	private void FullTable_Load(object sender, EventArgs e)
	{
		cDataGridView1.DataSource = dt;
	}

	private void cDataGridView1_ButtonSelectClick(CDataGridView cdgv, int rowindex, int columnindex)
	{
		string text = "";
		string text2 = "";
		text = ((!(((DataTable)cdgv.DataSource).TableName.ToString() == "IM")) ? (((DataTable)cdgv.DataSource).Namespace.ToString() + "." + ((DataTable)cdgv.DataSource).Columns[columnindex].ColumnName.ToString()) : (((DataTable)cdgv.DataSource).Namespace.ToString() + "T." + ((DataTable)cdgv.DataSource).Rows[rowindex]["Code"].ToString()));
		text2 = text + "[R" + (rowindex + 1) + ",C" + (columnindex + 1) + "]";
		if (!ds.Tables.Contains(text2))
		{
			DataTable dataTable = new DataTable();
			dataTable = ds.Tables[text].Clone();
			dataTable.Namespace = text;
			dataTable.TableName = text2;
			ds.Tables.Add(dataTable);
		}
		FullTable fullTable = new FullTable();
		fullTable.Text = text2;
		fullTable.ds = ds;
		fullTable.dt = ds.Tables[text2];
		fullTable.ShowDialog();
		cdgv.Rows[rowindex].Cells[columnindex].Value = "点击赋值:" + fullTable.lines + "行";
	}

	private void FullTable_FormClosed(object sender, FormClosedEventArgs e)
	{
		lines = ((DataTable)cDataGridView1.DataSource).Rows.Count;
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
		this.cDataGridView1 = new CDataGridView();
		((System.ComponentModel.ISupportInitialize)this.cDataGridView1).BeginInit();
		base.SuspendLayout();
		this.cDataGridView1.AllowUserToAddRows = false;
		this.cDataGridView1.AllowUserToDeleteRows = false;
		this.cDataGridView1.AllowUserToOrderColumns = true;
		this.cDataGridView1.BackgroundColor = System.Drawing.Color.White;
		this.cDataGridView1.ColumnHeaderColor1 = System.Drawing.Color.White;
		this.cDataGridView1.ColumnHeaderColor2 = System.Drawing.Color.FromArgb(212, 208, 200);
		this.cDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.cDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.cDataGridView1.Location = new System.Drawing.Point(0, 0);
		this.cDataGridView1.Name = "cDataGridView1";
		this.cDataGridView1.PrimaryRowcolor1 = System.Drawing.Color.White;
		this.cDataGridView1.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(255, 249, 232);
		this.cDataGridView1.RowTemplate.Height = 23;
		this.cDataGridView1.SecondaryLength = 2;
		this.cDataGridView1.SecondaryRowColor1 = System.Drawing.Color.White;
		this.cDataGridView1.SecondaryRowColor2 = System.Drawing.Color.White;
		this.cDataGridView1.SelectedRowColor1 = System.Drawing.Color.White;
		this.cDataGridView1.SelectedRowColor2 = System.Drawing.Color.FromArgb(171, 217, 254);
		this.cDataGridView1.Size = new System.Drawing.Size(818, 357);
		this.cDataGridView1.TabIndex = 0;
		this.cDataGridView1.ButtonSelectClick += new CDataGridView.ButtonClick(cDataGridView1_ButtonSelectClick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(818, 357);
		base.Controls.Add(this.cDataGridView1);
		base.Name = "FullTable";
		this.Text = "FullTable";
		base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FullTable_FormClosed);
		base.Load += new System.EventHandler(FullTable_Load);
		((System.ComponentModel.ISupportInitialize)this.cDataGridView1).EndInit();
		base.ResumeLayout(false);
	}
}
