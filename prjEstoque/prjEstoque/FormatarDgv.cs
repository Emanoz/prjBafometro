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
            dgv.Columns["Cpf"].Width = 140;
            dgv.Columns["Cnh"].Width = 140;
            dgv.Columns["DataNascimento"].Width = 140;
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        public static void FormatarOcorrencia(System.Windows.Forms.DataGridView dgv)
        {
            dgv.Columns["CodOcorrencia"].Visible = false;
            dgv.Columns["CodUsuario"].HeaderText = "Usuário";
            dgv.Columns["ValorAlcool"].HeaderText = "Valor";
            dgv.Columns["DataOcorrencia"].HeaderText = "Data ocorrência";
            dgv.Columns["DataOcorrencia"].Width = 140;
            dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }
    }
}
