using prjEstoque.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEstoque
{
    public partial class frmPrincipal : Form
    {
        private Util util = null;

        public frmPrincipal()
        {
            InitializeComponent();
            util = new Util();
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

        private void BtnCreate_Click(object sender, EventArgs e) => pnCadastro.BringToFront();

        private void BtnList_Prod_Click(object sender, EventArgs e)
        {
            pnList_Equipamento.BringToFront();

        }

        private void btnMinimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void btnCategoria_Slider_Click(object sender, EventArgs e)
        {
            util.Slider(pnGb_Categoria, gbCategoria, btnCategoria_Slider, 297, 832);

            Model.MODEL_Ocorrencia mOcorrencia = new Model.MODEL_Ocorrencia();
            dgvOcorrencias.DataSource = mOcorrencia.GetAll();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if(pnLeft.Width == 251)
            {
                util.Slider(pnLeft, 662, 59);
                btnCategoria_Slider.Location = new Point(997, btnCategoria_Slider.Location.Y);
            }
            else
            {
                util.Slider(pnLeft, 662, 251);
                btnCategoria_Slider.Location = new Point(805, btnCategoria_Slider.Location.Y);
            }
        }
        private void btnLimpar_Cat_Click(object sender, EventArgs e)
        {
            util.LimparCampos(gbCategoria.Controls);
        }

        private void btnUsuario_Slider_Click(object sender, EventArgs e)
        {
            util.Slider(pnGb_Usuario, gbUsuario, btnUsuario_Slider, 297, 832);

            Model.MODEL_Usuario mUsuario = new Model.MODEL_Usuario();
            dgvUsuarios.DataSource = mUsuario.GetAll();
            FormatarDgv.FormatarUsuario(dgvUsuarios);
        }

        private void cbUsuario_DropDown(object sender, EventArgs e)
        {
            cbUsuario.Items.Clear();
            Model.MODEL_Usuario mUsuario = new Model.MODEL_Usuario();
            List<Entity.Usuario> list = mUsuario.GetAll();

            foreach(Entity.Usuario u in list)
            {
                cbUsuario.Items.Add(u.Nome);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Model.MODEL_Usuario mUsuario = new Model.MODEL_Usuario();
            Usuario u = new Usuario(txtNome.Text, txtCpf.Text, txtCnh.Text, dtpNascimento.Value);
            if (mUsuario.Insert(u) == 0)
                MessageBox.Show("Erro ao inserir o registro!");
            else
                refreshToolStripMenuItem1_Click(null, null);

        }

        private void excluirCampoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.MODEL_Usuario mUsuario = new Model.MODEL_Usuario();
            if (mUsuario.Delete(int.Parse(dgvUsuarios[0, dgvUsuarios.CurrentRow.Index].Value.ToString())) == 0)
                MessageBox.Show("Erro ao excluir o registro!");
            else
                refreshToolStripMenuItem1_Click(null, null);
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Model.MODEL_Usuario mUsuario = new Model.MODEL_Usuario();
            dgvUsuarios.DataSource = mUsuario.GetAll();
            FormatarDgv.FormatarUsuario(dgvUsuarios);
        }

        private void atualizarCampoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.MODEL_Usuario mUsuario = new Model.MODEL_Usuario();
            Usuario u = new Usuario(int.Parse(dgvUsuarios[0, dgvUsuarios.CurrentRow.Index].Value.ToString()), txtNome.Text, txtCpf.Text, txtCnh.Text, dtpNascimento.Value);
            if (mUsuario.Update(u) == 0)
                MessageBox.Show("Erro ao atualizar o registro!");
            else
                refreshToolStripMenuItem1_Click(null, null);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            util.LimparCampos(gbUsuario.Controls);
        }
    }
}
