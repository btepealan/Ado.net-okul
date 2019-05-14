using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_ADONet_OKUL.Models
{
    public class Genel
    {
        public static string connStr = "Data Source=LAPTOP-8F1IOV3T\\MSSQL2017; Initial Catalog=OKUL; Integrated Security=true";
        public static void Temizle(TabPage tp)
        {
            foreach (Control item in tp.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }

        }
    }
}
