using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public class FindTable : Form
{
    public string chosetablename = "";
    public string stitle = "";
    public DataTable dt;
    public DataSet ds;
    public int lines = 0;
    private IContainer components = null;
    private MenuStrip ms_menu;
    private ToolStripMenuItem tsb_Top;
    private ToolStripTextBox tstb_FindValue;
    private ToolStripMenuItem 查找ToolStripMenuItem;
    private CDataGridView cDataGridView1;
    int currentrow = 0;
    int currentcolumn = 0;
    private ToolStripMenuItem 标记全部ToolStripMenuItem1;
    private ToolStripMenuItem tlsp_YXXX;
    string currentfindvalue = "";


    public FindTable()
    {
        InitializeComponent();
    }


    private void FindTable_Load(object sender, EventArgs e)
    {
        this.TopMost = true;

        SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
        string sql = "select * from sys_t_tablelist";
        System.Data.DataTable dataTable = sQLiteDBHelper.ExecuteDataTable(sql);
        this.dt = dataTable;
        cDataGridView1.DataSource = dt;
        if (!string.IsNullOrEmpty(stitle))
        {
            this.Text = stitle;
        }
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
        FindTable FindTable = new FindTable();
        FindTable.Text = text2;
        FindTable.ds = ds;
        FindTable.dt = ds.Tables[text2];
        FindTable.ShowDialog();
        cdgv.Rows[rowindex].Cells[columnindex].Value = "点击赋值:" + FindTable.lines + "行";
    }

    private void FindTable_FormClosed(object sender, FormClosedEventArgs e)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindTable));
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.tsb_Top = new System.Windows.Forms.ToolStripMenuItem();
            this.tstb_FindValue = new System.Windows.Forms.ToolStripTextBox();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标记全部ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsp_YXXX = new System.Windows.Forms.ToolStripMenuItem();
            this.cDataGridView1 = new CDataGridView();
            this.ms_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Top,
            this.tstb_FindValue,
            this.查找ToolStripMenuItem,
            this.标记全部ToolStripMenuItem1,
            this.tlsp_YXXX});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(572, 27);
            this.ms_menu.TabIndex = 1;
            this.ms_menu.Text = "menuStrip1";
            // 
            // tsb_Top
            // 
            this.tsb_Top.Name = "tsb_Top";
            this.tsb_Top.Size = new System.Drawing.Size(77, 23);
            this.tsb_Top.Text = "✓总在最前";
            this.tsb_Top.Click += new System.EventHandler(this.tsb_Top_Click);
            // 
            // tstb_FindValue
            // 
            this.tstb_FindValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstb_FindValue.Name = "tstb_FindValue";
            this.tstb_FindValue.Size = new System.Drawing.Size(100, 23);
            this.tstb_FindValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstb_FindValue_KeyPress);
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(107, 23);
            this.查找ToolStripMenuItem.Text = "查找(CTRL + G)";
            this.查找ToolStripMenuItem.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // 标记全部ToolStripMenuItem1
            // 
            this.标记全部ToolStripMenuItem1.Name = "标记全部ToolStripMenuItem1";
            this.标记全部ToolStripMenuItem1.Size = new System.Drawing.Size(68, 23);
            this.标记全部ToolStripMenuItem1.Text = "标记全部";
            this.标记全部ToolStripMenuItem1.Click += new System.EventHandler(this.标记全部ToolStripMenuItem1_Click);
            // 
            // tlsp_YXXX
            // 
            this.tlsp_YXXX.Name = "tlsp_YXXX";
            this.tlsp_YXXX.Size = new System.Drawing.Size(184, 23);
            this.tlsp_YXXX.Text = "自动转大写(点击切换允许小写)";
            this.tlsp_YXXX.Click += new System.EventHandler(this.tlsp_YXXX_Click);
            // 
            // cDataGridView1
            // 
            this.cDataGridView1.AllowUserToAddRows = false;
            this.cDataGridView1.AllowUserToDeleteRows = false;
            this.cDataGridView1.AllowUserToOrderColumns = true;
            this.cDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.cDataGridView1.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.cDataGridView1.ColumnHeaderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.cDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDataGridView1.Location = new System.Drawing.Point(0, 27);
            this.cDataGridView1.Name = "cDataGridView1";
            this.cDataGridView1.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.cDataGridView1.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.cDataGridView1.ReadOnly = true;
            this.cDataGridView1.RowTemplate.Height = 23;
            this.cDataGridView1.SecondaryLength = 2;
            this.cDataGridView1.SecondaryRowColor1 = System.Drawing.Color.White;
            this.cDataGridView1.SecondaryRowColor2 = System.Drawing.Color.White;
            this.cDataGridView1.SelectedRowColor1 = System.Drawing.Color.White;
            this.cDataGridView1.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.cDataGridView1.Size = new System.Drawing.Size(572, 627);
            this.cDataGridView1.TabIndex = 0;
            this.cDataGridView1.ButtonSelectClick += new CDataGridView.ButtonClick(this.cDataGridView1_ButtonSelectClick);
            this.cDataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cDataGridView1_CellMouseDoubleClick);
            // 
            // FindTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 654);
            this.Controls.Add(this.cDataGridView1);
            this.Controls.Add(this.ms_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.ms_menu;
            this.Name = "FindTable";
            this.Text = "FindTable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindTable_FormClosed);
            this.Load += new System.EventHandler(this.FindTable_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindTable_KeyDown);
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void tsb_Top_Click(object sender, EventArgs e)
    {
        if (this.TopMost)
        {
            this.TopMost = false;
            tsb_Top.Text = "总在最前";
        }
        else
        {
            this.TopMost = true;
            tsb_Top.Text = "✓总在最前";
        }
    }



    private void FindTable_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Modifiers == Keys.Control && e.KeyCode == Keys.G)
        {
            查找ToolStripMenuItem_Click(null, null);
        }
        if (e.KeyCode == Keys.Escape)
        {
            this.Close();
        }
    }

    private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(tstb_FindValue.Text))
        {
            if (tstb_FindValue.Focused == false)
            {
                tstb_FindValue.Focus();
            }
            else
            {
                MessageBox.Show("输入要查找的值");
            }
            return;
        }
        DataTable rentTable = (DataTable)cDataGridView1.DataSource;//获取数据源

        if (tlsp_YXXX.Text == "自动转大写(点击切换允许小写)")
        {
            tstb_FindValue.Text = tstb_FindValue.Text.ToUpper();
        }
        string sfindvalue = tstb_FindValue.Text.Trim();
        if (currentfindvalue != sfindvalue)
        {
            currentrow = 0;
            currentcolumn = 0;
            currentfindvalue = sfindvalue;
            cDataGridView1.ClearSelection();
        }
        else
        {
            currentcolumn++;
            if (currentcolumn > rentTable.Columns.Count)
            {
                currentcolumn = 0;
                currentrow++;
            }
        }

        for (int i = currentrow; i < rentTable.Rows.Count; i++)
        {
            currentrow = i;
            for (int j = currentcolumn; j < rentTable.Columns.Count; j++)
            {
                currentcolumn = j;
                if (rentTable.Rows[i][j].ToString().Contains(currentfindvalue))
                {
                    cDataGridView1.Rows[i].Cells[j].Selected = true;
                    cDataGridView1.FirstDisplayedScrollingRowIndex = i;
                    cDataGridView1.FirstDisplayedScrollingColumnIndex = j;
                    return;
                }
            }
            currentcolumn = 0;
        }
        MessageBox.Show("未发现更多数据,已全部搜索完成");
    }

    private void 标记全部ToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(tstb_FindValue.Text))
        {
            MessageBox.Show("输入要查找的值");
            return;
        }
        DataTable rentTable = (DataTable)cDataGridView1.DataSource;//获取数据源
        string sfindvalue = tstb_FindValue.Text.Trim();
        for (int i = 0; i < rentTable.Rows.Count; i++)
        {
            for (int j = 0; j < rentTable.Columns.Count; j++)
            {
                if (rentTable.Rows[i][j].ToString().Contains(sfindvalue))
                {
                    cDataGridView1.Rows[i].Cells[j].Selected = true;
                    cDataGridView1.FirstDisplayedScrollingRowIndex = i;
                    cDataGridView1.FirstDisplayedScrollingColumnIndex = j;
                }
            }
        }

    }

    private void tstb_FindValue_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 13)
        {
            查找ToolStripMenuItem_Click(null, null);
        }
    }

    private void tlsp_YXXX_Click(object sender, EventArgs e)
    {
        if (tlsp_YXXX.Text == "允许小写(点击切换自动转大写)")
        {
            tlsp_YXXX.Text = "自动转大写(点击切换允许小写)";
        }
        if (tlsp_YXXX.Text == "自动转大写(点击切换允许小写)")
        {
            tlsp_YXXX.Text = "允许小写(点击切换自动转大写)";
        }
    }



    private void cDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (e.RowIndex > 0)
        {
            this.chosetablename = this.cDataGridView1.Rows[e.RowIndex].Cells["tableid"].Value.ToString();
            this.DialogResult = DialogResult.OK;
        } 
    }
}
