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
    public partial class frWriteFunName : Form
    {
        public string FunName = ""; 
        public frWriteFunName()
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
            FunName = tb_TableName.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(FunName))
            {
                MessageBox.Show("请输入函数名");
            }
            
            this.DialogResult = DialogResult.OK;
        }
          
    }
}
