using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEL_SAPHELP.Com.Model
{
    public class SapComTable
    {
        public sys_t_object modul { get; set; }
        public List<sys_t_tablelist> tablelist { get; set; }

    }
}
