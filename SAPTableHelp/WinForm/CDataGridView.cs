using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CDataGridView : DataGridView
{
	public delegate void ButtonClick(CDataGridView cdgv, int rowindex, int columnindex);

	private Array _ShowButtonColumns;

	private Color _ColumnHeaderColor1 = Color.White;

	private Color _ColumnHeaderColor2 = Color.FromArgb(212, 208, 200);

	private Color _PrimaryRowColor1 = Color.White;

	private Color _PrimaryRowColor2 = Color.FromArgb(255, 249, 232);

	private Color _SelectedRowColor1 = Color.White;

	private Color _SelectedRowColor2 = Color.FromArgb(171, 217, 254);

	private Color _SecondaryRowColor1 = Color.White;

	private Color _SecondaryRowColor2 = Color.White;

	private int _SecondaryLength = 2;

	private IContainer components = null;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem CToolStripMenuItem1;

	private ToolStripMenuItem CToolStripMenuItem2;

	private ToolStripMenuItem CToolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem4;

	public Button button1;

	public Color ColumnHeaderColor1
	{
		get
		{
			return _ColumnHeaderColor1;
		}
		set
		{
			_ColumnHeaderColor1 = value;
			Invalidate();
		}
	}

	public Color ColumnHeaderColor2
	{
		get
		{
			return _ColumnHeaderColor2;
		}
		set
		{
			_ColumnHeaderColor2 = value;
			Invalidate();
		}
	}

	public Color PrimaryRowcolor1
	{
		get
		{
			return _PrimaryRowColor1;
		}
		set
		{
			if (value.IsEmpty || value == Color.Transparent)
			{
				_PrimaryRowColor1 = Color.White;
			}
			else
			{
				_PrimaryRowColor1 = value;
			}
		}
	}

	public Color PrimaryRowcolor2
	{
		get
		{
			return _PrimaryRowColor2;
		}
		set
		{
			if (value.IsEmpty || value == Color.Transparent)
			{
				_PrimaryRowColor2 = Color.White;
			}
			else
			{
				_PrimaryRowColor2 = value;
			}
		}
	}

	public Color SecondaryRowColor1
	{
		get
		{
			return _SecondaryRowColor1;
		}
		set
		{
			if (value.IsEmpty || value == Color.Transparent)
			{
				_SecondaryRowColor1 = Color.White;
			}
			else
			{
				_SecondaryRowColor1 = value;
			}
		}
	}

	public Color SecondaryRowColor2
	{
		get
		{
			return _SecondaryRowColor2;
		}
		set
		{
			if (value.IsEmpty || value == Color.Transparent)
			{
				_SecondaryRowColor2 = Color.White;
			}
			else
			{
				_SecondaryRowColor2 = value;
			}
		}
	}

	public Color SelectedRowColor1
	{
		get
		{
			return _SelectedRowColor1;
		}
		set
		{
			_SelectedRowColor1 = value;
		}
	}

	public Color SelectedRowColor2
	{
		get
		{
			return _SelectedRowColor2;
		}
		set
		{
			_SelectedRowColor2 = value;
		}
	}

	public int SecondaryLength
	{
		get
		{
			return _SecondaryLength;
		}
		set
		{
			_SecondaryLength = value;
		}
	}

	public event ButtonClick ButtonSelectClick;

	public void SetParam(Array ShowButtonColumns)
	{
		_ShowButtonColumns = ShowButtonColumns;
	}

	public CDataGridView()
	{
		InitializeComponent();
		base.Controls.Add(button1);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		try
		{
			this.ButtonSelectClick.DynamicInvoke(this, base.CurrentCell.RowIndex, base.CurrentCell.ColumnIndex);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	public void _KeyDown(object sender, KeyEventArgs e)
	{
		try
		{
			if (e.KeyCode == Keys.D && e.Modifiers == Keys.Control)
			{
				base.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
				Clipboard.SetText(GetClipboardContent().GetData(DataFormats.Text).ToString());
			}
			if (e.KeyCode == Keys.E && e.Modifiers == Keys.Control)
			{
				base.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
				Clipboard.SetText(GetClipboardContent().GetData(DataFormats.Text).ToString());
			}
			if (e.KeyCode == Keys.F && e.Modifiers != Keys.Control)
			{
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void CToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			base.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
			Clipboard.SetText(GetClipboardContent().GetData(DataFormats.Text).ToString());
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void CToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		try
		{
			base.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			Clipboard.SetText(GetClipboardContent().GetData(DataFormats.Text).ToString());
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void CToolStripMenuItem3_Click(object sender, EventArgs e)
	{
		try
		{
			WTiaoJianChuangKou wTiaoJianChuangKou = new WTiaoJianChuangKou(this);
            wTiaoJianChuangKou.TopMost = true;
            if (wTiaoJianChuangKou.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			DataView dataView = new DataView();
			dataView = (base.DataSource as DataTable).DefaultView;
			string text = "1=1 ";
			foreach (ShaiXuan shaiXuan in wTiaoJianChuangKou.ShaiXuans)
			{
				if (!string.IsNullOrEmpty(shaiXuan.Zhi))
				{
					text = text + " AND " + shaiXuan.ZiDuan + " Like '%" + shaiXuan.Zhi + "%' ";
				}
			}
			dataView.RowFilter = text;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void toolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			DataTable dataTable = new DataTable();
			dataTable = base.DataSource as DataTable;
			DataRow dataRow = dataTable.NewRow();
			foreach (DataColumn column in dataTable.Columns)
			{
				if (column.Namespace != "STRING" && !string.IsNullOrEmpty(column.Namespace))
				{
					dataRow[column.ColumnName] = "点击赋值";
				}
			}
			dataTable.Rows.Add(dataRow);
			base.DataSource = dataTable;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void toolStripMenuItem2_Click(object sender, EventArgs e)
	{
		try
		{
			int count = base.SelectedRows.Count;
			if (count == 0)
			{
				MessageBox.Show("请选择要删除的行！");
				return;
			}
			for (int i = 0; i < count; i++)
			{
				base.Rows.Remove(base.SelectedRows[0]);
				EndEdit();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void toolStripMenuItem3_Click(object sender, EventArgs e)
	{
		try
		{
			DataTable dataTable = new DataTable();
			dataTable = GetCopyString();
			int num = 0;
			_ = base.CurrentCell.RowIndex;
			if (false)
			{
				return;
			}
			int rowIndex = base.CurrentCell.RowIndex;
			num = base.CurrentCell.ColumnIndex;
			int num2 = 0;
			for (int i = rowIndex; i < base.Rows.Count; i++)
			{
				int num3 = 0;
				for (int j = num; j < base.Columns.Count; j++)
				{
					base.Rows[i].Cells[j].Value = dataTable.Rows[num2][num3];
					num3++;
					if (num3 == dataTable.Columns.Count)
					{
						break;
					}
				}
				num2++;
				if (num2 == dataTable.Rows.Count)
				{
					break;
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void toolStripMenuItem4_Click(object sender, EventArgs e)
	{
		try
		{
			FullTable fullTable = new FullTable();
			fullTable.dt = base.DataSource as DataTable;
			fullTable.Show();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	public void _CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			if (e.Button == MouseButtons.Right)
			{
				Point p = PointToClient(Control.MousePosition);
				contextMenuStrip1.Show(PointToScreen(p));
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void DataGridEx_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
	{
		try
		{
			Rectangle bounds = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, base.RowHeadersWidth - 4, e.RowBounds.Height);
			TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), base.RowHeadersDefaultCellStyle.Font, bounds, base.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void GridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
	{
		try
		{
			Rectangle rec = new Rectangle(0, e.RowBounds.Top, base.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) - base.HorizontalScrollingOffset + 1, e.RowBounds.Height);
			e.PaintParts &= ~DataGridViewPaintParts.Focus;
			if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
			{
				if (base.RowTemplate.DefaultCellStyle.SelectionBackColor == Color.Transparent)
				{
					DrawLinearGradient(rec, e.Graphics, _SelectedRowColor1, _SelectedRowColor2);
				}
			}
			else if (base.RowTemplate.DefaultCellStyle.BackColor == Color.Transparent)
			{
				if (e.RowIndex % _SecondaryLength == 1)
				{
					DrawLinearGradient(rec, e.Graphics, _PrimaryRowColor1, _PrimaryRowColor2);
				}
				else
				{
					DrawLinearGradient(rec, e.Graphics, _SecondaryRowColor1, _SecondaryRowColor2);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void GridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
	{
		try
		{
			if (e.RowIndex == -1)
			{
				DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();
				if (!(_ColumnHeaderColor1 == Color.Transparent) && !(_ColumnHeaderColor2 == Color.Transparent) && !_ColumnHeaderColor1.IsEmpty && !_ColumnHeaderColor2.IsEmpty)
				{
					DrawLinearGradient(e.CellBounds, e.Graphics, _ColumnHeaderColor1, _ColumnHeaderColor2);
					e.Paint(e.ClipBounds, DataGridViewPaintParts.Border | DataGridViewPaintParts.ContentBackground | DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.ErrorIcon | DataGridViewPaintParts.Focus | DataGridViewPaintParts.SelectionBackground);
					e.Handled = true;
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private static void DrawLinearGradient(Rectangle Rec, Graphics Grp, Color Color1, Color Color2)
	{
		try
		{
			if (Color1 == Color2)
			{
				Brush brush = new SolidBrush(Color1);
				Grp.FillRectangle(brush, Rec);
				return;
			}
			  Brush brush2 = new LinearGradientBrush(Rec, Color1, Color2, LinearGradientMode.Vertical);
			Grp.FillRectangle(brush2, Rec);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	public DataTable GetCopyString()
	{
		DataTable dataTable = new DataTable();
		string text = Clipboard.GetText().Replace("\n", "");
		text = text.TrimEnd('\r');
		text = text.TrimEnd('\t');
		string[] array = text.Split('\r');
		string[] array2 = array[0].Split('\t');
		for (int i = 0; i <= array2.GetUpperBound(0); i++)
		{
			dataTable.Columns.Add(i.ToString());
		}
		string[] array3 = array;
		foreach (string text2 in array3)
		{
			string[] array4 = text2.Split('\t');
			DataRow dataRow = dataTable.NewRow();
			for (int k = 0; k <= array4.GetUpperBound(0); k++)
			{
				dataRow[k.ToString()] = array4[k];
			}
			dataTable.Rows.Add(dataRow);
		}
		return dataTable;
	}

	private bool IsShowButtonColumn(string columnName, Array ShowButtonColumns)
	{
		if (string.IsNullOrEmpty(columnName) || ShowButtonColumns == null || ShowButtonColumns.Length < 1)
		{
			return false;
		}
		foreach (string ShowButtonColumn in ShowButtonColumns)
		{
			if (ShowButtonColumn == columnName)
			{
				return true;
			}
		}
		return false;
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		base.OnPaint(pe);
	}

	private void DataGridViewButton_CellEnter(object sender, DataGridViewCellEventArgs e)
	{
		if (base.FirstDisplayedCell == null)
		{
			return;
		}
		string text = "";
		if (base.CurrentCell.Value.ToString().Length >= 4)
		{
			text = base.CurrentCell.Value.ToString().Substring(0, 4);
		}
		if (IsShowButtonColumn(base.Columns[base.CurrentCell.ColumnIndex].Name, _ShowButtonColumns) || text == "点击赋值")
		{
			Point location = default(Point);
			if (button1.Height != base.Rows[base.CurrentCell.RowIndex].Height)
			{
				button1.Height = base.Rows[base.CurrentCell.RowIndex].Height;
			}
			if (base.RowHeadersVisible)
			{
				location.X += base.RowHeadersWidth;
			}
			for (int i = base.FirstDisplayedCell.ColumnIndex; i <= base.CurrentCell.ColumnIndex; i++)
			{
				if (base.Columns[i].Visible)
				{
					location.X += base.Columns[i].Width + base.Columns[i].DividerWidth;
				}
			}
			location.X -= base.FirstDisplayedScrollingColumnHiddenWidth;
			location.X -= button1.Width;
			if (base.ColumnHeadersVisible)
			{
				location.Y += base.ColumnHeadersHeight;
			}
			for (int j = base.FirstDisplayedScrollingRowIndex; j < base.CurrentCell.RowIndex; j++)
			{
				if (base.Rows[j].Visible)
				{
					location.Y += base.Rows[j].Height + base.Rows[j].DividerHeight;
				}
			}
			button1.Location = location;
			button1.Visible = true;
		}
		else
		{
			button1.Visible = false;
		}
	}

	private void DataGridViewButton_Scroll(object sender, ScrollEventArgs e)
	{
		button1.Visible = false;
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
		this.components = new System.ComponentModel.Container();
		this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
		this.CToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.CToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.CToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.button1 = new System.Windows.Forms.Button();
		this.contextMenuStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this).BeginInit();
		base.SuspendLayout();
		this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.CToolStripMenuItem1, this.CToolStripMenuItem2, this.CToolStripMenuItem3, this.toolStripMenuItem1, this.toolStripMenuItem2, this.toolStripMenuItem3, this.toolStripMenuItem4 });
		this.contextMenuStrip1.Name = "contextMenuStrip3";
		this.contextMenuStrip1.Size = new System.Drawing.Size(167, 158);
		this.CToolStripMenuItem1.Name = "CToolStripMenuItem1";
		this.CToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
		this.CToolStripMenuItem1.Text = "复制【&D】 ";
		this.CToolStripMenuItem1.Click += new System.EventHandler(CToolStripMenuItem1_Click);
		this.CToolStripMenuItem2.Name = "CToolStripMenuItem2";
		this.CToolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
		this.CToolStripMenuItem2.Text = "带标题复制【&E】 ";
		this.CToolStripMenuItem2.Click += new System.EventHandler(CToolStripMenuItem2_Click);
		this.CToolStripMenuItem3.Name = "CToolStripMenuItem3";
		this.CToolStripMenuItem3.Size = new System.Drawing.Size(166, 22);
		this.CToolStripMenuItem3.Text = "筛选【&F】 ";
		this.CToolStripMenuItem3.Click += new System.EventHandler(CToolStripMenuItem3_Click);
		this.toolStripMenuItem1.Name = "toolStripMenuItem1";
		this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
		this.toolStripMenuItem1.Text = "添加行【&A】 ";
		this.toolStripMenuItem1.Click += new System.EventHandler(toolStripMenuItem1_Click);
		this.toolStripMenuItem2.Name = "toolStripMenuItem2";
		this.toolStripMenuItem2.Size = new System.Drawing.Size(166, 22);
		this.toolStripMenuItem2.Text = "删除行【&R】 ";
		this.toolStripMenuItem2.Click += new System.EventHandler(toolStripMenuItem2_Click);
		this.toolStripMenuItem3.Name = "toolStripMenuItem3";
		this.toolStripMenuItem3.Size = new System.Drawing.Size(166, 22);
		this.toolStripMenuItem3.Text = "从excel粘贴";
		this.toolStripMenuItem3.Click += new System.EventHandler(toolStripMenuItem3_Click);
		this.toolStripMenuItem4.Name = "toolStripMenuItem4";
		this.toolStripMenuItem4.Size = new System.Drawing.Size(166, 22);
		this.toolStripMenuItem4.Text = "全屏编辑";
		this.toolStripMenuItem4.Click += new System.EventHandler(toolStripMenuItem4_Click);
		this.button1.Location = new System.Drawing.Point(0, 0);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(75, 23);
		this.button1.TabIndex = 0;
		this.button1.Text = "表赋值";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Visible = false;
		this.button1.Click += new System.EventHandler(button1_Click);
		base.RowTemplate.Height = 23;
		base.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(DataGridViewButton_CellEnter);
		base.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(_CellMouseClick);
		base.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(GridView_CellPainting);
		base.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(DataGridEx_RowPostPaint);
		base.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(GridView_RowPrePaint);
		base.Scroll += new System.Windows.Forms.ScrollEventHandler(DataGridViewButton_Scroll);
		base.KeyDown += new System.Windows.Forms.KeyEventHandler(_KeyDown);
		this.contextMenuStrip1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this).EndInit();
		base.ResumeLayout(false);
	}
}
