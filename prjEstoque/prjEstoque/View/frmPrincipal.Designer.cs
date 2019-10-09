namespace prjEstoque
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSlide = new System.Windows.Forms.Button();
            this.pnHome = new System.Windows.Forms.Panel();
            this.pnCadastro = new System.Windows.Forms.Panel();
            this.pnGroup_Op = new System.Windows.Forms.Panel();
            this.pnGb_Categoria = new System.Windows.Forms.Panel();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAlcool = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.btnLimpar_Ocorrencia = new System.Windows.Forms.Button();
            this.dgvOcorrencias = new System.Windows.Forms.DataGridView();
            this.menuCategoria = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opAtualizar_Campo = new System.Windows.Forms.ToolStripMenuItem();
            this.opDeletar_Campo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastrar_Ocorrencia = new System.Windows.Forms.Button();
            this.btnCategoria_Slider = new System.Windows.Forms.Button();
            this.pnGb_Usuario = new System.Windows.Forms.Panel();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuario_Slider = new System.Windows.Forms.Button();
            this.pnList_Equipamento = new System.Windows.Forms.Panel();
            this.dgvEquipamento = new System.Windows.Forms.DataGridView();
            this.menuUsuario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarCampoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCampoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnCadastro.SuspendLayout();
            this.pnGroup_Op.SuspendLayout();
            this.pnGb_Categoria.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.gbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).BeginInit();
            this.menuCategoria.SuspendLayout();
            this.pnGb_Usuario.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnList_Equipamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamento)).BeginInit();
            this.menuUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pnTop.Controls.Add(this.panel1);
            this.pnTop.Controls.Add(this.lblTitle);
            this.pnTop.Controls.Add(this.pictureBox1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1095, 38);
            this.pnTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1016, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 38);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::prjEstoque.Properties.Resources.icons8_excluir_42;
            this.btnClose.Location = new System.Drawing.Point(41, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::prjEstoque.Properties.Resources.icons8_minimizar_janela_38;
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 38);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(50, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Bafômetro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjEstoque.Properties.Resources.icons8_caixa_39;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnLeft.Controls.Add(this.panel2);
            this.pnLeft.Controls.Add(this.btnCreate);
            this.pnLeft.Controls.Add(this.btnSlide);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 38);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(251, 662);
            this.pnLeft.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 478);
            this.panel2.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = global::prjEstoque.Properties.Resources.icons8_movimento_de_estoque_50;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 119);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(251, 65);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Cadastro";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSlide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSlide.FlatAppearance.BorderSize = 0;
            this.btnSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlide.Image = global::prjEstoque.Properties.Resources.icons8_no_inventário_40;
            this.btnSlide.Location = new System.Drawing.Point(0, 0);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(251, 81);
            this.btnSlide.TabIndex = 0;
            this.btnSlide.UseVisualStyleBackColor = true;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHome.Location = new System.Drawing.Point(251, 38);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(844, 662);
            this.pnHome.TabIndex = 2;
            // 
            // pnCadastro
            // 
            this.pnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnCadastro.Controls.Add(this.pnGroup_Op);
            this.pnCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCadastro.Location = new System.Drawing.Point(251, 38);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Size = new System.Drawing.Size(844, 662);
            this.pnCadastro.TabIndex = 3;
            // 
            // pnGroup_Op
            // 
            this.pnGroup_Op.AutoScroll = true;
            this.pnGroup_Op.Controls.Add(this.pnGb_Categoria);
            this.pnGroup_Op.Controls.Add(this.pnGb_Usuario);
            this.pnGroup_Op.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnGroup_Op.Location = new System.Drawing.Point(0, 48);
            this.pnGroup_Op.Name = "pnGroup_Op";
            this.pnGroup_Op.Size = new System.Drawing.Size(844, 614);
            this.pnGroup_Op.TabIndex = 0;
            // 
            // pnGb_Categoria
            // 
            this.pnGb_Categoria.Controls.Add(this.gbCategoria);
            this.pnGb_Categoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGb_Categoria.Location = new System.Drawing.Point(0, 65);
            this.pnGb_Categoria.Name = "pnGb_Categoria";
            this.pnGb_Categoria.Size = new System.Drawing.Size(844, 65);
            this.pnGb_Categoria.TabIndex = 1;
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.gbPesquisa);
            this.gbCategoria.Controls.Add(this.label7);
            this.gbCategoria.Controls.Add(this.txtAlcool);
            this.gbCategoria.Controls.Add(this.txtValor);
            this.gbCategoria.Controls.Add(this.cbUsuario);
            this.gbCategoria.Controls.Add(this.btnLimpar_Ocorrencia);
            this.gbCategoria.Controls.Add(this.dgvOcorrencias);
            this.gbCategoria.Controls.Add(this.btnCadastrar_Ocorrencia);
            this.gbCategoria.Controls.Add(this.btnCategoria_Slider);
            this.gbCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.ForeColor = System.Drawing.Color.White;
            this.gbCategoria.Location = new System.Drawing.Point(0, 0);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(844, 28);
            this.gbCategoria.TabIndex = 0;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Nova ocorrência:";
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.btnPesquisar);
            this.gbPesquisa.Controls.Add(this.textBox1);
            this.gbPesquisa.ForeColor = System.Drawing.Color.White;
            this.gbPesquisa.Location = new System.Drawing.Point(35, 206);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(362, 68);
            this.gbPesquisa.TabIndex = 21;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisar por CPF:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Aqua;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.Location = new System.Drawing.Point(262, 35);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 27);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "VAI TEIA";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 26);
            this.textBox1.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Usuário:";
            // 
            // txtAlcool
            // 
            this.txtAlcool.Location = new System.Drawing.Point(168, 45);
            this.txtAlcool.Name = "txtAlcool";
            this.txtAlcool.Size = new System.Drawing.Size(229, 26);
            this.txtAlcool.TabIndex = 17;
            // 
            // txtValor
            // 
            this.txtValor.AutoSize = true;
            this.txtValor.Location = new System.Drawing.Point(31, 47);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(117, 20);
            this.txtValor.TabIndex = 16;
            this.txtValor.Text = "Valor de álcool:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(168, 87);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(229, 28);
            this.cbUsuario.TabIndex = 14;
            this.cbUsuario.DropDown += new System.EventHandler(this.cbUsuario_DropDown);
            // 
            // btnLimpar_Ocorrencia
            // 
            this.btnLimpar_Ocorrencia.BackColor = System.Drawing.Color.Red;
            this.btnLimpar_Ocorrencia.FlatAppearance.BorderSize = 0;
            this.btnLimpar_Ocorrencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar_Ocorrencia.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar_Ocorrencia.Location = new System.Drawing.Point(279, 137);
            this.btnLimpar_Ocorrencia.Name = "btnLimpar_Ocorrencia";
            this.btnLimpar_Ocorrencia.Size = new System.Drawing.Size(118, 27);
            this.btnLimpar_Ocorrencia.TabIndex = 13;
            this.btnLimpar_Ocorrencia.Text = "LIMPAR";
            this.btnLimpar_Ocorrencia.UseVisualStyleBackColor = false;
            // 
            // dgvOcorrencias
            // 
            this.dgvOcorrencias.AllowUserToAddRows = false;
            this.dgvOcorrencias.AllowUserToDeleteRows = false;
            this.dgvOcorrencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcorrencias.ContextMenuStrip = this.menuCategoria;
            this.dgvOcorrencias.Location = new System.Drawing.Point(442, 32);
            this.dgvOcorrencias.Name = "dgvOcorrencias";
            this.dgvOcorrencias.ReadOnly = true;
            this.dgvOcorrencias.RowHeadersWidth = 51;
            this.dgvOcorrencias.Size = new System.Drawing.Size(398, 247);
            this.dgvOcorrencias.TabIndex = 12;
            // 
            // menuCategoria
            // 
            this.menuCategoria.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuCategoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.opAtualizar_Campo,
            this.opDeletar_Campo});
            this.menuCategoria.Name = "menuCategoria";
            this.menuCategoria.Size = new System.Drawing.Size(161, 70);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // opAtualizar_Campo
            // 
            this.opAtualizar_Campo.Name = "opAtualizar_Campo";
            this.opAtualizar_Campo.Size = new System.Drawing.Size(160, 22);
            this.opAtualizar_Campo.Text = "Atualizar campo";
            // 
            // opDeletar_Campo
            // 
            this.opDeletar_Campo.Name = "opDeletar_Campo";
            this.opDeletar_Campo.Size = new System.Drawing.Size(160, 22);
            this.opDeletar_Campo.Text = "Excluir campo";
            // 
            // btnCadastrar_Ocorrencia
            // 
            this.btnCadastrar_Ocorrencia.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar_Ocorrencia.FlatAppearance.BorderSize = 0;
            this.btnCadastrar_Ocorrencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar_Ocorrencia.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar_Ocorrencia.Location = new System.Drawing.Point(35, 137);
            this.btnCadastrar_Ocorrencia.Name = "btnCadastrar_Ocorrencia";
            this.btnCadastrar_Ocorrencia.Size = new System.Drawing.Size(118, 27);
            this.btnCadastrar_Ocorrencia.TabIndex = 11;
            this.btnCadastrar_Ocorrencia.Text = "CADASTRAR";
            this.btnCadastrar_Ocorrencia.UseVisualStyleBackColor = false;
            // 
            // btnCategoria_Slider
            // 
            this.btnCategoria_Slider.FlatAppearance.BorderSize = 0;
            this.btnCategoria_Slider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria_Slider.Image = global::prjEstoque.Properties.Resources.icons8_chevron_esquerda_16;
            this.btnCategoria_Slider.Location = new System.Drawing.Point(805, 10);
            this.btnCategoria_Slider.Name = "btnCategoria_Slider";
            this.btnCategoria_Slider.Size = new System.Drawing.Size(30, 16);
            this.btnCategoria_Slider.TabIndex = 8;
            this.btnCategoria_Slider.UseVisualStyleBackColor = true;
            this.btnCategoria_Slider.Click += new System.EventHandler(this.btnCategoria_Slider_Click);
            // 
            // pnGb_Usuario
            // 
            this.pnGb_Usuario.Controls.Add(this.gbUsuario);
            this.pnGb_Usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGb_Usuario.Location = new System.Drawing.Point(0, 0);
            this.pnGb_Usuario.Name = "pnGb_Usuario";
            this.pnGb_Usuario.Size = new System.Drawing.Size(844, 65);
            this.pnGb_Usuario.TabIndex = 2;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.dgvUsuarios);
            this.gbUsuario.Controls.Add(this.txtCpf);
            this.gbUsuario.Controls.Add(this.label5);
            this.gbUsuario.Controls.Add(this.dtpNascimento);
            this.gbUsuario.Controls.Add(this.label4);
            this.gbUsuario.Controls.Add(this.txtCnh);
            this.gbUsuario.Controls.Add(this.label2);
            this.gbUsuario.Controls.Add(this.btnLimpar);
            this.gbUsuario.Controls.Add(this.btnCadastrar);
            this.gbUsuario.Controls.Add(this.txtNome);
            this.gbUsuario.Controls.Add(this.label1);
            this.gbUsuario.Controls.Add(this.btnUsuario_Slider);
            this.gbUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuario.ForeColor = System.Drawing.Color.White;
            this.gbUsuario.Location = new System.Drawing.Point(0, 0);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(844, 28);
            this.gbUsuario.TabIndex = 0;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Novo usuário:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.ContextMenuStrip = this.menuUsuario;
            this.dgvUsuarios.Location = new System.Drawing.Point(442, 32);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(398, 239);
            this.dgvUsuarios.TabIndex = 21;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(168, 137);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(229, 26);
            this.txtCpf.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(168, 181);
            this.dtpNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(229, 26);
            this.dtpNascimento.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "CPF:";
            // 
            // txtCnh
            // 
            this.txtCnh.Location = new System.Drawing.Point(168, 95);
            this.txtCnh.Name = "txtCnh";
            this.txtCnh.Size = new System.Drawing.Size(229, 26);
            this.txtCnh.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "CNH:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(269, 251);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 27);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(34, 251);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(118, 27);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(168, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 26);
            this.txtNome.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // btnUsuario_Slider
            // 
            this.btnUsuario_Slider.FlatAppearance.BorderSize = 0;
            this.btnUsuario_Slider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario_Slider.Image = global::prjEstoque.Properties.Resources.icons8_chevron_esquerda_16;
            this.btnUsuario_Slider.Location = new System.Drawing.Point(805, 10);
            this.btnUsuario_Slider.Name = "btnUsuario_Slider";
            this.btnUsuario_Slider.Size = new System.Drawing.Size(30, 16);
            this.btnUsuario_Slider.TabIndex = 8;
            this.btnUsuario_Slider.UseVisualStyleBackColor = true;
            this.btnUsuario_Slider.Click += new System.EventHandler(this.btnUsuario_Slider_Click);
            // 
            // pnList_Equipamento
            // 
            this.pnList_Equipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnList_Equipamento.Controls.Add(this.dgvEquipamento);
            this.pnList_Equipamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnList_Equipamento.Location = new System.Drawing.Point(251, 38);
            this.pnList_Equipamento.Name = "pnList_Equipamento";
            this.pnList_Equipamento.Size = new System.Drawing.Size(844, 662);
            this.pnList_Equipamento.TabIndex = 3;
            // 
            // dgvEquipamento
            // 
            this.dgvEquipamento.AllowUserToAddRows = false;
            this.dgvEquipamento.AllowUserToDeleteRows = false;
            this.dgvEquipamento.AllowUserToResizeRows = false;
            this.dgvEquipamento.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvEquipamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEquipamento.ColumnHeadersHeight = 35;
            this.dgvEquipamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEquipamento.Location = new System.Drawing.Point(0, 0);
            this.dgvEquipamento.Name = "dgvEquipamento";
            this.dgvEquipamento.ReadOnly = true;
            this.dgvEquipamento.RowHeadersWidth = 51;
            this.dgvEquipamento.Size = new System.Drawing.Size(844, 662);
            this.dgvEquipamento.TabIndex = 1;
            // 
            // menuUsuario
            // 
            this.menuUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem1,
            this.atualizarCampoToolStripMenuItem,
            this.excluirCampoToolStripMenuItem});
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(161, 70);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // atualizarCampoToolStripMenuItem
            // 
            this.atualizarCampoToolStripMenuItem.Name = "atualizarCampoToolStripMenuItem";
            this.atualizarCampoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atualizarCampoToolStripMenuItem.Text = "Atualizar campo";
            this.atualizarCampoToolStripMenuItem.Click += new System.EventHandler(this.atualizarCampoToolStripMenuItem_Click);
            // 
            // excluirCampoToolStripMenuItem
            // 
            this.excluirCampoToolStripMenuItem.Name = "excluirCampoToolStripMenuItem";
            this.excluirCampoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirCampoToolStripMenuItem.Text = "Excluir campo";
            this.excluirCampoToolStripMenuItem.Click += new System.EventHandler(this.excluirCampoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 700);
            this.Controls.Add(this.pnCadastro);
            this.Controls.Add(this.pnList_Equipamento);
            this.Controls.Add(this.pnHome);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnCadastro.ResumeLayout(false);
            this.pnGroup_Op.ResumeLayout(false);
            this.pnGb_Categoria.ResumeLayout(false);
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrencias)).EndInit();
            this.menuCategoria.ResumeLayout(false);
            this.pnGb_Usuario.ResumeLayout(false);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnList_Equipamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamento)).EndInit();
            this.menuUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSlide;
        private System.Windows.Forms.Panel pnCadastro;
        private System.Windows.Forms.Panel pnGroup_Op;
        private System.Windows.Forms.Panel pnGb_Categoria;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.Panel pnList_Equipamento;
        private System.Windows.Forms.DataGridView dgvEquipamento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCategoria_Slider;
        private System.Windows.Forms.DataGridView dgvOcorrencias;
        private System.Windows.Forms.ContextMenuStrip menuCategoria;
        private System.Windows.Forms.Button btnCadastrar_Ocorrencia;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opAtualizar_Campo;
        private System.Windows.Forms.ToolStripMenuItem opDeletar_Campo;
        private System.Windows.Forms.Button btnLimpar_Ocorrencia;
        private System.Windows.Forms.Panel pnGb_Usuario;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.TextBox txtCnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsuario_Slider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAlcool;
        private System.Windows.Forms.Label txtValor;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atualizarCampoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirCampoToolStripMenuItem;
    }
}

