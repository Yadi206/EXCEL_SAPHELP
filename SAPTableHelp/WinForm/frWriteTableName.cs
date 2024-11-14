using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPTableHelp.WinForm
{
    public partial class frWriteTableName : Form
    {
        public string TableName = "";
        public string flag = "";
        public bool ishaveinclude = false;
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
            flag = "WINDOWS";
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
    }
}
