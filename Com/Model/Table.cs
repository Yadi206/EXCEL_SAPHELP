using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEL_SAPHELP.Com.Model
{
    public class SAPTable
    {
        public SAPTable()
        {
            tablename = "";
        }
        /// <summary>
        /// 表名
        /// </summary>
        public string tablename { get; set; }
    }
}
