using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCEL_SAPHELP.WinForm
{
    public partial class frWriteTableName : Form
    {
        public string TableName = "";
        public string flag = "";
        public bool ishaveinclude = false;
        public string showtype = "Sheet";
        public frWriteTableName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setvalue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tb_TableName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                setvalue(); 
            }
        }

        private void setvalue()
        {
            TableName = tb_TableName.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(TableName))
            {
                MessageBox.Show("请输入表名");
            }
            if (rb_Sheet.Checked)
            {
                flag = "SHEET";
            }
            if (rbWindows.Checked)
            {
                flag = "WINDOWS";
            }

            ishaveinclude = checkBox1.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void bn_FindTable_Click(object sender, EventArgs e)
        {
            FindTable ft = new FindTable();
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tb_TableName.Text = ft.chosetablename;
            }
            else
            {
                tb_TableName.Focus();
            }
        }

        private void frWriteTableName_Load(object sender, EventArgs e)
        {
            if (showtype == "Sheet")
            {
                rb_Sheet.Checked = true;
                rbWindows.Checked = false;
            }
            else
            {
                rb_Sheet.Checked = false;
                rbWindows.Checked = true;
            }
        }
    }
}
