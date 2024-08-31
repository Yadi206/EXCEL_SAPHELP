using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using EXCEL_SAPHELP.EXCEL;
using SAP.Middleware.Connector;
 

public class Saplogon : Form
{
	public RfcConfigParameters parmss = new RfcConfigParameters();

	private DataTable dtLJPZ = new DataTable();

	private DataTable dtKJFS = new DataTable();

	private RfcDestination SapRfcDestination;

	private RfcRepository SapRfcRepository;

	private IRfcFunction myfun;

	public RfcConfigParameters parms = new RfcConfigParameters();

	private IContainer components = null;

	private SplitContainer splitContainer1;

	private Label lb_LuYou;

	private TextBox tbLuYou;

	private Label label5;

	private Label label6;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label1;

	private TextBox tbMiMa;

	private TextBox tbXiTongHao;

	private TextBox tbDengLuZhangHao;

	private TextBox tbDengLuYuYan;

	private TextBox tbKeHuDuanHao;

	private TextBox tbIP;

	private Button button1;

	private GroupBox groupBox1;

	private GroupBox groupBox2;

	private CDataGridView dgKJFS;

	private Button bnIMLogOn;

	private CDataGridView dgLJPZ;

	private Label label7;

	private TextBox tb_LJMC;

	private Label label8;

	private TextBox tb_sid;

	private GroupBox groupBox3;

	private Button button2;

	private TextBox tb_RZML;

	private Label label9;

	private Button button3;

	public Saplogon()
	{
		InitializeComponent();
	}

	private void Saplogon_Load(object sender, EventArgs e)
	{
		dtLJPZ.Columns.Add("EntryKey");
		dtLJPZ.Columns.Add("Description");
		dtLJPZ.Columns.Add("Server");
		dtLJPZ.Columns.Add("Database");
		dtLJPZ.Columns.Add("MSSysName");
		dtLJPZ.Columns.Add("Router");
		dtLJPZ.Columns.Add("Address");
		dtLJPZ.Columns.Add("Router2");
		dtLJPZ.Columns.Add("RouterChoice");
		dtLJPZ.Columns.Add("System");
		dtLJPZ.Columns.Add("MSSrvName");
		dtLJPZ.Columns.Add("MSSrvPort");
		dtLJPZ.Columns.Add("SessManKey");
		dtLJPZ.Columns.Add("SncName");
		dtLJPZ.Columns.Add("SncChoice");
		dtLJPZ.Columns.Add("Codepage");
		dtLJPZ.Columns.Add("CodepageIndex");
		dtLJPZ.Columns.Add("Origin");
		dtLJPZ.Columns.Add("LowSpeedConnection");
		dtLJPZ.Columns.Add("Utf8Off");
		dtLJPZ.Columns.Add("EncodingID");
		dtLJPZ.Columns.Add("ShortcutType");
		dtLJPZ.Columns.Add("ShortcutString");
		dtLJPZ.Columns.Add("ShortcutTo");
		dtLJPZ.Columns.Add("ShortcutBy");
		dtLJPZ.Columns.Add("SncNoSSO");
		dtLJPZ.Columns.Add("MSLast");
		dgLJPZ.DataSource = dtLJPZ;
		dtKJFS.Columns.Add("Label");
		dtKJFS.Columns.Add("desc");
		dtKJFS.Columns.Add("sid");
		dtKJFS.Columns.Add("clt");
		dtKJFS.Columns.Add("u");
		dtKJFS.Columns.Add("l");
		dtKJFS.Columns.Add("t");
		dtKJFS.Columns.Add("tit");
		dtKJFS.Columns.Add("wsz");
		dtKJFS.Columns.Add("wd");
		dtKJFS.Columns.Add("pwenc");
		dtKJFS.Columns.Add("cmd");
		dtKJFS.Columns.Add("ok");
		dtKJFS.Columns.Add("reuse");
		dtKJFS.Columns.Add("(null)");
		dgKJFS.DataSource = dtKJFS;
		string config_file_path = SysConfigInfo.config_file_path;
		string fileName = config_file_path + "\\saplogon.ini";
		FileInfo fileInfo = new FileInfo(fileName);
		if (fileInfo.Exists)
		{
			filllogon(config_file_path + "\\saplogon.ini");
			fillsapshort(config_file_path + "\\sapshortcut.ini");
		}
		else
		{
			fileName = config_file_path + "\\SAPUILandscape.xml";
			fileInfo = new FileInfo(fileName);
			if (fileInfo.Exists)
			{
				fillsapuilandscape(config_file_path + "\\SAPUILandscape.xml");
			}
		}
		if (SysConfigInfo.saploginfo != null && SysConfigInfo.saploginfo.Rows.Count > 0)
		{
            foreach (DataRow row in SysConfigInfo.saploginfo.Rows)
            {
                tb_LJMC.Text = row["id"].ToString();
                tbIP.Text = row["AppServerHost"].ToString();
                tbXiTongHao.Text = row["SystemNumber"].ToString();
                tbDengLuZhangHao.Text = row["User"].ToString();
                tbMiMa.Text = row["Password"].ToString();
                tbKeHuDuanHao.Text = row["Client"].ToString();
                tbDengLuYuYan.Text = row["Language"].ToString();
                tbLuYou.Text = row["SAPRouter"].ToString();
                tb_sid.Text = row["sid"].ToString();
            }
        }

   
		SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
		DataTable dataTable = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_config");
		if (dataTable != null && dataTable.Rows.Count > 0)
		{
			DataRow dataRow2 = dataTable.Rows[0];
			tb_RZML.Text = dataRow2["log_path"].ToString();
		}
		if (string.IsNullOrEmpty(tb_RZML.Text))
		{
			tb_RZML.Text = SysConfigInfo.config_file_path;
		}
	}

	public void filllogon(string file)
	{
		Ini ini = new Ini(file);
		for (int i = 1; i < 1000; i++)
		{
			string value = ini.ReadValue("Server", "Item" + i);
			if (string.IsNullOrEmpty(value))
			{
				break;
			}
			DataRow dataRow = dtLJPZ.NewRow();
			dataRow["Server"] = value;
			value = ini.ReadValue("EntryKey", "Item" + i);
			dataRow["EntryKey"] = value;
			value = ini.ReadValue("Description", "Item" + i);
			dataRow["Description"] = value;
			value = ini.ReadValue("Database", "Item" + i);
			dataRow["Database"] = value;
			value = ini.ReadValue("MSSysName", "Item" + i);
			dataRow["MSSysName"] = value;
			value = ini.ReadValue("Router", "Item" + i);
			dataRow["Router"] = value;
			value = ini.ReadValue("Address", "Item" + i);
			dataRow["Address"] = value;
			value = ini.ReadValue("Router2", "Item" + i);
			dataRow["Router2"] = value;
			value = ini.ReadValue("RouterChoice", "Item" + i);
			dataRow["RouterChoice"] = value;
			value = ini.ReadValue("System", "Item" + i);
			dataRow["System"] = value;
			value = ini.ReadValue("MSSrvName", "Item" + i);
			dataRow["MSSrvName"] = value;
			value = ini.ReadValue("MSSrvPort", "Item" + i);
			dataRow["MSSrvPort"] = value;
			value = ini.ReadValue("SessManKey", "Item" + i);
			dataRow["SessManKey"] = value;
			value = ini.ReadValue("SncName", "Item" + i);
			dataRow["SncName"] = value;
			value = ini.ReadValue("SncChoice", "Item" + i);
			dataRow["SncChoice"] = value;
			value = ini.ReadValue("Codepage", "Item" + i);
			dataRow["Codepage"] = value;
			value = ini.ReadValue("CodepageIndex", "Item" + i);
			dataRow["CodepageIndex"] = value;
			value = ini.ReadValue("Origin", "Item" + i);
			dataRow["Origin"] = value;
			value = ini.ReadValue("LowSpeedConnection", "Item" + i);
			dataRow["LowSpeedConnection"] = value;
			value = ini.ReadValue("Utf8Off", "Item" + i);
			dataRow["Utf8Off"] = value;
			value = ini.ReadValue("EncodingID", "Item" + i);
			dataRow["EncodingID"] = value;
			value = ini.ReadValue("ShortcutType", "Item" + i);
			dataRow["ShortcutType"] = value;
			value = ini.ReadValue("ShortcutString", "Item" + i);
			dataRow["ShortcutString"] = value;
			value = ini.ReadValue("ShortcutTo", "Item" + i);
			dataRow["ShortcutTo"] = value;
			value = ini.ReadValue("ShortcutBy", "Item" + i);
			dataRow["ShortcutBy"] = value;
			value = ini.ReadValue("SncNoSSO", "Item" + i);
			dataRow["SncNoSSO"] = value;
			value = ini.ReadValue("MSLast", "Item" + i);
			dataRow["MSLast"] = value;
			dtLJPZ.Rows.Add(dataRow);
		}
		dgLJPZ.DataSource = dtLJPZ;
	}

	private void bnIMLogOn_Click(object sender, EventArgs e)
	{
		string text = "";
		string text2 = "";
		string config_file_path = SysConfigInfo.config_file_path;
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		folderBrowserDialog.Description = "请选择SAP配置文件所在文件夹";
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		folderBrowserDialog.SelectedPath = "C:\\Documents and Settings\\" + Environment.UserName.ToString() + "\\Application Data\\SAP\\Common";
		if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		if (string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
		{
			MessageBox.Show(this, "文件夹路径不能为空", "提示");
			return;
		}
		text = folderBrowserDialog.SelectedPath.ToString() + "\\saplogon.ini";
		FileInfo fileInfo = new FileInfo(text);
		if (fileInfo.Exists)
		{
			text = folderBrowserDialog.SelectedPath.ToString() + "\\saplogon.ini";
			filllogon(text);
			text2 = config_file_path + "\\saplogon.ini";
			FileInfo fileInfo2 = new FileInfo(text);
			if (fileInfo2.Exists)
			{
				fileInfo2.CopyTo(text2, overwrite: true);
			}
			text = folderBrowserDialog.SelectedPath.ToString() + "\\sapshortcut.ini";
			fillsapshort(text);
			text2 = config_file_path + "\\sapshortcut.ini";
			fileInfo2 = new FileInfo(text);
			if (fileInfo2.Exists)
			{
				fileInfo2.CopyTo(text2, overwrite: true);
			}
		}
		else
		{
			text = folderBrowserDialog.SelectedPath.ToString() + "\\SAPUILandscape.xml";
			text2 = config_file_path + "\\SAPUILandscape.xml";
			FileInfo fileInfo3 = new FileInfo(text);
			if (fileInfo3.Exists)
			{
				fileInfo3.CopyTo(text2, overwrite: true);
			}
			fillsapuilandscape(text2);
		}
	}

	public void fillsapuilandscape(string filecopy)
	{
		SAPUILandscape sAPUILandscape = new SAPUILandscape();
		SAPLononInfo sAPLononInfo = sAPUILandscape.readxml(filecopy);
		foreach (SAPLJXX sAPLJXX in sAPLononInfo.SAPLJXXes)
		{
			DataRow dataRow = dtLJPZ.NewRow();
			dataRow["EntryKey"] = sAPLJXX.uuid;
			dataRow["Description"] = sAPLJXX.name;
			string[] array = sAPLJXX.server.Split(':');
			if (array != null && array.Count() > 1)
			{
				dataRow["Server"] = array[0];
				if (array[1].Length >= 4)
				{
					dataRow["Database"] = array[1].Substring(2, 2);
				}
			}
			dataRow["MSSysName"] = sAPLJXX.systemid;
			dataRow["Router"] = sAPLJXX.routerrouter;
			dataRow["Address"] = sAPLJXX.mshost;
			dtLJPZ.Rows.Add(dataRow);
		}
		dgLJPZ.DataSource = dtLJPZ;
		foreach (SAPKJFS sAPKJFSe in sAPLononInfo.SAPKJFSes)
		{
			DataRow dataRow2 = dtKJFS.NewRow();
			dataRow2["Label"] = sAPKJFSe.uuid;
			dataRow2["tit"] = sAPKJFSe.name;
			dataRow2["desc"] = sAPKJFSe.ljxx.name;
			string[] array2 = sAPKJFSe.ljxx.server.Split(':');
			if (array2 != null && array2.Count() > 1 && array2[1].Length >= 4)
			{
				dataRow2["sid"] = array2[1].Substring(2, 2);
			}
			dataRow2["clt"] = sAPKJFSe.client;
			dataRow2["u"] = sAPKJFSe.user;
			dataRow2["l"] = sAPKJFSe.language;
			dataRow2["t"] = "";
			dataRow2["wsz"] = "";
			dataRow2["wd"] = "";
			dataRow2["pwenc"] = "";
			dataRow2["cmd"] = "";
			dataRow2["ok"] = "";
			dataRow2["reuse"] = "";
			dataRow2["(null)"] = "";
			dtKJFS.Rows.Add(dataRow2);
		}
		dgKJFS.DataSource = dtKJFS;
	}

	public void fillsapshort(string file)
	{
		Ini ini = new Ini(file);
		for (int i = 1; i < 1000; i++)
		{
			string value = ini.ReadValue("Label", "Key" + i);
			if (string.IsNullOrEmpty(value))
			{
				continue;
			}
			DataRow dataRow = dtKJFS.NewRow();
			dataRow["Label"] = value;
			value = ini.ReadValue("Command", "Key" + i);
			string[] array = value.Split('"');
			for (int j = 0; j < array.Count() - 1; j++)
			{
				if (array[j].Substring(0, 1) == " ")
				{
					array[j] = array[j].Substring(1, array[j].Count() - 1);
				}
				if (array[j].Substring(0, 1) == "-")
				{
					dataRow[array[j].Substring(1, array[j].Count() - 2)] = array[j + 1];
				}
			}
			dtKJFS.Rows.Add(dataRow);
		}
		dgKJFS.DataSource = dtKJFS;
	}

	private void bnIMSapshortcut_Click(object sender, EventArgs e)
	{
		string file = "";
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Multiselect = true;
		openFileDialog.Title = "请选择文件夹";
		openFileDialog.Filter = "所有文件(*.*)|*.*";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			file = openFileDialog.FileName;
		}
		fillsapshort(file);
	}

	private void dgLJPZ_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex != -1 && e.ColumnIndex != -1)
		{
			tbIP.Text = dgLJPZ.Rows[e.RowIndex].Cells["Server"].Value.ToString();
			tbDengLuYuYan.Text = "ZH";
			tbXiTongHao.Text = dgLJPZ.Rows[e.RowIndex].Cells["Database"].Value.ToString();
			tbLuYou.Text = dgLJPZ.Rows[e.RowIndex].Cells["Router"].Value.ToString();
			tbIP.Text = dgLJPZ.Rows[e.RowIndex].Cells["Server"].Value.ToString();
		}
	}

	private void dgKJFS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex == -1 || e.ColumnIndex == -1)
		{
			return;
		}
		foreach (DataGridViewRow item in (IEnumerable)dgLJPZ.Rows)
		{
			if (item.Cells["Description"].Value.ToString() == dgKJFS.Rows[e.RowIndex].Cells["desc"].Value.ToString())
			{
				tbIP.Text = item.Cells["Server"].Value.ToString();
				tbXiTongHao.Text = item.Cells["Database"].Value.ToString();
				tbLuYou.Text = item.Cells["Router"].Value.ToString();
				tbIP.Text = item.Cells["Server"].Value.ToString();
			}
		}
		tbDengLuYuYan.Text = dgKJFS.Rows[e.RowIndex].Cells["l"].Value.ToString();
		tbKeHuDuanHao.Text = dgKJFS.Rows[e.RowIndex].Cells["clt"].Value.ToString();
		tbDengLuZhangHao.Text = dgKJFS.Rows[e.RowIndex].Cells["u"].Value.ToString();
		SapPassword sapPassword = new SapPassword();
		tbMiMa.Text = sapPassword.getMingWen(dgKJFS.Rows[e.RowIndex].Cells["pwenc"].Value.ToString());
		tb_LJMC.Text = dgKJFS.Rows[e.RowIndex].Cells["desc"].Value.ToString();
		tb_sid.Text = dgKJFS.Rows[e.RowIndex].Cells["sid"].Value.ToString();
		tbMiMa.Focus();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		try
		{
			if (string.IsNullOrEmpty(tbMiMa.Text.ToString()))
			{
				MessageBox.Show("请输入密码");
				return;
			}
			string sql = "delete from sys_t_logininfo; insert into sys_t_logininfo (id, AppServerHost, SystemNumber, \"User\", Password, Client, \"Language\", Name, Trace,SAPRouter,sid) values (@id, @AppServerHost, @SystemNumber, @User, @Password, @Client, @Language, @Name, @Trace,@SAPRouter,@sid);";
			SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
			SQLiteParameter[] parameters = new SQLiteParameter[11]
			{
				new SQLiteParameter("@id", tb_LJMC.Text.ToString()),
				new SQLiteParameter("@AppServerHost", tbIP.Text.ToString()),
				new SQLiteParameter("@SystemNumber", tbXiTongHao.Text.ToString()),
				new SQLiteParameter("@User", tbDengLuZhangHao.Text.ToString()),
				new SQLiteParameter("@Password", tbMiMa.Text.ToString()),
				new SQLiteParameter("@Client", tbKeHuDuanHao.Text.ToString()),
				new SQLiteParameter("@Language", tbDengLuYuYan.Text.ToString()),
				new SQLiteParameter("@Name", "HYDRFC"),
				new SQLiteParameter("@Trace", "4"),
				new SQLiteParameter("@SAPRouter", tbLuYou.Text.ToString()),
				new SQLiteParameter("@sid", tb_sid.Text.ToString())
			};
			int num = sQLiteDBHelper.ExecuteNonQuery(sql, parameters);
			if (num > 0)
			{
				base.DialogResult = DialogResult.OK;
			}
			else
			{
				base.DialogResult = DialogResult.No;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void tbIP_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			button1_Click(null, null);
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		try
		{
			SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
			DataTable dataTable = sQLiteDBHelper.ExecuteDataTable("select * from sys_t_config");
			string text = "";
			SQLiteParameter[] parameters;
			if (dataTable != null && dataTable.Rows.Count > 0)
			{
				DataRow dataRow = dataTable.NewRow();
				dataRow = dataTable.Rows[0];
				text = "delete from sys_t_config; insert into sys_t_config (id,log_path) values (@id,@log_path);";
				parameters = new SQLiteParameter[2]
				{
					new SQLiteParameter("@id", dataRow["id"]),
					new SQLiteParameter("@log_path", tb_RZML.Text)
				};
			}
			else
			{
				text = "delete from sys_t_config; insert into sys_t_config (id,log_path) values (@id,@log_path);";
				parameters = new SQLiteParameter[2]
				{
					new SQLiteParameter("@id", "20240629"),
					new SQLiteParameter("@log_path", tb_RZML.Text)
				};
			}
			int num = sQLiteDBHelper.ExecuteNonQuery(text, parameters);
			if (num > 0)
			{
				MessageBox.Show("保存成功");
			}
			else
			{
				MessageBox.Show("保存失败");
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		string selectedPath = tb_RZML.Text;
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		folderBrowserDialog.Description = "请选择日志存放位置";
		folderBrowserDialog.SelectedPath = selectedPath;
		if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
		{
			if (string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
			{
				MessageBox.Show(this, "文件夹路径不能为空", "提示");
			}
			else
			{
				tb_RZML.Text = folderBrowserDialog.SelectedPath;
			}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saplogon));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgLJPZ = new CDataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgKJFS = new CDataGridView();
            this.lb_LuYou = new System.Windows.Forms.Label();
            this.tbLuYou = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMiMa = new System.Windows.Forms.TextBox();
            this.tbXiTongHao = new System.Windows.Forms.TextBox();
            this.tbDengLuZhangHao = new System.Windows.Forms.TextBox();
            this.tbDengLuYuYan = new System.Windows.Forms.TextBox();
            this.tbKeHuDuanHao = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bnIMLogOn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_LJMC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_sid = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_RZML = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLJPZ)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKJFS)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(536, 464);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgLJPZ);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "链接配置";
            // 
            // dgLJPZ
            // 
            this.dgLJPZ.AllowUserToAddRows = false;
            this.dgLJPZ.AllowUserToDeleteRows = false;
            this.dgLJPZ.AllowUserToOrderColumns = true;
            this.dgLJPZ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgLJPZ.BackgroundColor = System.Drawing.Color.White;
            this.dgLJPZ.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgLJPZ.ColumnHeaderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dgLJPZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLJPZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLJPZ.GridColor = System.Drawing.Color.White;
            this.dgLJPZ.Location = new System.Drawing.Point(3, 17);
            this.dgLJPZ.Name = "dgLJPZ";
            this.dgLJPZ.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgLJPZ.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgLJPZ.ReadOnly = true;
            this.dgLJPZ.RowTemplate.Height = 23;
            this.dgLJPZ.SecondaryLength = 2;
            this.dgLJPZ.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgLJPZ.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgLJPZ.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgLJPZ.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgLJPZ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLJPZ.Size = new System.Drawing.Size(530, 212);
            this.dgLJPZ.TabIndex = 0;
            this.dgLJPZ.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLJPZ_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgKJFS);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "快捷方式";
            // 
            // dgKJFS
            // 
            this.dgKJFS.AllowUserToAddRows = false;
            this.dgKJFS.AllowUserToDeleteRows = false;
            this.dgKJFS.AllowUserToOrderColumns = true;
            this.dgKJFS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgKJFS.BackgroundColor = System.Drawing.Color.White;
            this.dgKJFS.ColumnHeaderColor1 = System.Drawing.Color.White;
            this.dgKJFS.ColumnHeaderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.dgKJFS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKJFS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKJFS.GridColor = System.Drawing.Color.White;
            this.dgKJFS.Location = new System.Drawing.Point(3, 17);
            this.dgKJFS.Name = "dgKJFS";
            this.dgKJFS.PrimaryRowcolor1 = System.Drawing.Color.White;
            this.dgKJFS.PrimaryRowcolor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(232)))));
            this.dgKJFS.ReadOnly = true;
            this.dgKJFS.RowTemplate.Height = 23;
            this.dgKJFS.SecondaryLength = 2;
            this.dgKJFS.SecondaryRowColor1 = System.Drawing.Color.White;
            this.dgKJFS.SecondaryRowColor2 = System.Drawing.Color.White;
            this.dgKJFS.SelectedRowColor1 = System.Drawing.Color.White;
            this.dgKJFS.SelectedRowColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(254)))));
            this.dgKJFS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKJFS.Size = new System.Drawing.Size(530, 208);
            this.dgKJFS.TabIndex = 0;
            this.dgKJFS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKJFS_CellDoubleClick);
            // 
            // lb_LuYou
            // 
            this.lb_LuYou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_LuYou.AutoSize = true;
            this.lb_LuYou.Location = new System.Drawing.Point(546, 276);
            this.lb_LuYou.Name = "lb_LuYou";
            this.lb_LuYou.Size = new System.Drawing.Size(29, 12);
            this.lb_LuYou.TabIndex = 22;
            this.lb_LuYou.Text = "路由";
            // 
            // tbLuYou
            // 
            this.tbLuYou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLuYou.Location = new System.Drawing.Point(651, 272);
            this.tbLuYou.Name = "tbLuYou";
            this.tbLuYou.Size = new System.Drawing.Size(240, 21);
            this.tbLuYou.TabIndex = 23;
            this.tbLuYou.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIP_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "用户密码";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "SAP系统编号";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "用户帐号";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "登陆语言";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "SAP客户端号";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "IP地址";
            // 
            // tbMiMa
            // 
            this.tbMiMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMiMa.Location = new System.Drawing.Point(651, 245);
            this.tbMiMa.Name = "tbMiMa";
            this.tbMiMa.Size = new System.Drawing.Size(240, 21);
            this.tbMiMa.TabIndex = 21;
            this.tbMiMa.UseSystemPasswordChar = true;
            this.tbMiMa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIP_KeyPress);
            // 
            // tbXiTongHao
            // 
            this.tbXiTongHao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbXiTongHao.Location = new System.Drawing.Point(651, 189);
            this.tbXiTongHao.Name = "tbXiTongHao";
            this.tbXiTongHao.Size = new System.Drawing.Size(240, 21);
            this.tbXiTongHao.TabIndex = 15;
            this.tbXiTongHao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIP_KeyPress);
            // 
            // tbDengLuZhangHao
            // 
            this.tbDengLuZhangHao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDengLuZhangHao.Location = new System.Drawing.Point(651, 217);
            this.tbDengLuZhangHao.Name = "tbDengLuZhangHao";
            this.tbDengLuZhangHao.Size = new System.Drawing.Size(240, 21);
            this.tbDengLuZhangHao.TabIndex = 20;
            this.tbDengLuZhangHao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIP_KeyPress);
            // 
            // tbDengLuYuYan
            // 
            this.tbDengLuYuYan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDengLuYuYan.Location = new System.Drawing.Point(651, 161);
            this.tbDengLuYuYan.Name = "tbDengLuYuYan";
            this.tbDengLuYuYan.Size = new System.Drawing.Size(240, 21);
            this.tbDengLuYuYan.TabIndex = 12;
            this.tbDengLuYuYan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIP_KeyPress);
            // 
            // tbKeHuDuanHao
            // 
            this.tbKeHuDuanHao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeHuDuanHao.Location = new System.Drawing.Point(651, 133);
            this.tbKeHuDuanHao.Name = "tbKeHuDuanHao";
            this.tbKeHuDuanHao.Size = new System.Drawing.Size(240, 21);
            this.tbKeHuDuanHao.TabIndex = 11;
            this.tbKeHuDuanHao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIP_KeyPress);
            // 
            // tbIP
            // 
            this.tbIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIP.Location = new System.Drawing.Point(651, 105);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(240, 21);
            this.tbIP.TabIndex = 10;
            this.tbIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIP_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(816, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "保存默认登陆信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnIMLogOn
            // 
            this.bnIMLogOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnIMLogOn.Location = new System.Drawing.Point(553, 17);
            this.bnIMLogOn.Name = "bnIMLogOn";
            this.bnIMLogOn.Size = new System.Drawing.Size(165, 23);
            this.bnIMLogOn.TabIndex = 24;
            this.bnIMLogOn.Text = "读取SAP登录配置文件[.ini]";
            this.bnIMLogOn.UseVisualStyleBackColor = true;
            this.bnIMLogOn.Click += new System.EventHandler(this.bnIMLogOn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "链接名称";
            // 
            // tb_LJMC
            // 
            this.tb_LJMC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_LJMC.Location = new System.Drawing.Point(651, 51);
            this.tb_LJMC.Name = "tb_LJMC";
            this.tb_LJMC.Size = new System.Drawing.Size(240, 21);
            this.tb_LJMC.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "系统标识";
            // 
            // tb_sid
            // 
            this.tb_sid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sid.Location = new System.Drawing.Point(651, 78);
            this.tb_sid.Name = "tb_sid";
            this.tb_sid.Size = new System.Drawing.Size(240, 21);
            this.tb_sid.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.tb_RZML);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(548, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 122);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "配置";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 96);
            this.button3.TabIndex = 2;
            this.button3.Text = "选择目录";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "保存配置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_RZML
            // 
            this.tb_RZML.Location = new System.Drawing.Point(78, 20);
            this.tb_RZML.Multiline = true;
            this.tb_RZML.Name = "tb_RZML";
            this.tb_RZML.Size = new System.Drawing.Size(222, 96);
            this.tb_RZML.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "日志目录：";
            // 
            // Saplogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_sid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_LJMC);
            this.Controls.Add(this.bnIMLogOn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_LuYou);
            this.Controls.Add(this.tbLuYou);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMiMa);
            this.Controls.Add(this.tbXiTongHao);
            this.Controls.Add(this.tbDengLuZhangHao);
            this.Controls.Add(this.tbDengLuYuYan);
            this.Controls.Add(this.tbKeHuDuanHao);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Saplogon";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Saplogon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLJPZ)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKJFS)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

	}
}
