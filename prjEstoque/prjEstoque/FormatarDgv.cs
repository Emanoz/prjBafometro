using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque
{
    class FormatarDgv
    {
        public static void FormatarUsuario(System.Windows.Forms.DataGridView dgv)
        {
            dgv.Columns["CodUsuario"].Visible = false;
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }
    }
}
