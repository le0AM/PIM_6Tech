namespace PIM_6Tech
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.txtPagamentos = new System.Windows.Forms.TabPage();
            this.btnBuscarPag = new MaterialSkin.Controls.MaterialButton();
            this.txtSalarioLiqPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDataPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtVRPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtVTPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFGTSPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtINSSPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSalarioPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNomePag = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.matriculaPag = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnCalcular = new MaterialSkin.Controls.MaterialButton();
            this.txtColaborador = new System.Windows.Forms.TabPage();
            this.txtSalarioCad = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNascimento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAdmissao = new MaterialSkin.Controls.MaterialTextBox();
            this.txtConfSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCadastrar = new MaterialSkin.Controls.MaterialButton();
            this.txtTelefone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtTurno = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCargo = new MaterialSkin.Controls.MaterialComboBox();
            this.txtCadMatricula = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCadSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNome = new MaterialSkin.Controls.MaterialTextBox();
            this.editCad = new System.Windows.Forms.TabPage();
            this.btnDeletar = new MaterialSkin.Controls.MaterialButton();
            this.btnPesquisar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEditarNascimento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEditarAdmissao = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEditarConfirmar = new MaterialSkin.Controls.MaterialTextBox();
            this.btnModificar = new MaterialSkin.Controls.MaterialButton();
            this.txtEditarTelefone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtEditarTurno = new MaterialSkin.Controls.MaterialComboBox();
            this.txtEditarMatricula = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEditarSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEditarEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEditarNome = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFinalizar = new System.Windows.Forms.TabPage();
            this.btnSair = new MaterialSkin.Controls.MaterialButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.txtPagamentos.SuspendLayout();
            this.txtColaborador.SuspendLayout();
            this.editCad.SuspendLayout();
            this.txtFinalizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.txtPagamentos);
            this.materialTabControl1.Controls.Add(this.txtColaborador);
            this.materialTabControl1.Controls.Add(this.editCad);
            this.materialTabControl1.Controls.Add(this.txtFinalizar);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(744, 463);
            this.materialTabControl1.TabIndex = 1;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // txtPagamentos
            // 
            this.txtPagamentos.Controls.Add(this.btnBuscarPag);
            this.txtPagamentos.Controls.Add(this.txtSalarioLiqPag);
            this.txtPagamentos.Controls.Add(this.txtDataPag);
            this.txtPagamentos.Controls.Add(this.txtVRPag);
            this.txtPagamentos.Controls.Add(this.txtVTPag);
            this.txtPagamentos.Controls.Add(this.txtFGTSPag);
            this.txtPagamentos.Controls.Add(this.txtINSSPag);
            this.txtPagamentos.Controls.Add(this.txtSalarioPag);
            this.txtPagamentos.Controls.Add(this.txtNomePag);
            this.txtPagamentos.Controls.Add(this.label6);
            this.txtPagamentos.Controls.Add(this.matriculaPag);
            this.txtPagamentos.Controls.Add(this.btnCalcular);
            this.txtPagamentos.ImageKey = "Pagamentos.png";
            this.txtPagamentos.Location = new System.Drawing.Point(4, 39);
            this.txtPagamentos.Name = "txtPagamentos";
            this.txtPagamentos.Padding = new System.Windows.Forms.Padding(3);
            this.txtPagamentos.Size = new System.Drawing.Size(736, 420);
            this.txtPagamentos.TabIndex = 0;
            this.txtPagamentos.Text = "Pagamentos";
            this.txtPagamentos.UseVisualStyleBackColor = true;
            this.txtPagamentos.Click += new System.EventHandler(this.txtPagamentos_Click);
            // 
            // btnBuscarPag
            // 
            this.btnBuscarPag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarPag.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarPag.Depth = 0;
            this.btnBuscarPag.HighEmphasis = true;
            this.btnBuscarPag.Icon = null;
            this.btnBuscarPag.Location = new System.Drawing.Point(430, 64);
            this.btnBuscarPag.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarPag.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarPag.Name = "btnBuscarPag";
            this.btnBuscarPag.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarPag.Size = new System.Drawing.Size(77, 36);
            this.btnBuscarPag.TabIndex = 23;
            this.btnBuscarPag.Text = "Buscar";
            this.btnBuscarPag.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarPag.UseAccentColor = false;
            this.btnBuscarPag.UseVisualStyleBackColor = true;
            this.btnBuscarPag.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // txtSalarioLiqPag
            // 
            this.txtSalarioLiqPag.AnimateReadOnly = false;
            this.txtSalarioLiqPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalarioLiqPag.Depth = 0;
            this.txtSalarioLiqPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalarioLiqPag.Hint = "Salario líquido";
            this.txtSalarioLiqPag.LeadingIcon = null;
            this.txtSalarioLiqPag.Location = new System.Drawing.Point(261, 312);
            this.txtSalarioLiqPag.MaxLength = 50;
            this.txtSalarioLiqPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSalarioLiqPag.Multiline = false;
            this.txtSalarioLiqPag.Name = "txtSalarioLiqPag";
            this.txtSalarioLiqPag.Size = new System.Drawing.Size(164, 50);
            this.txtSalarioLiqPag.TabIndex = 22;
            this.txtSalarioLiqPag.Text = "";
            this.txtSalarioLiqPag.TrailingIcon = null;
            // 
            // txtDataPag
            // 
            this.txtDataPag.AnimateReadOnly = false;
            this.txtDataPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataPag.Depth = 0;
            this.txtDataPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataPag.Hint = "Data da folha ";
            this.txtDataPag.LeadingIcon = null;
            this.txtDataPag.Location = new System.Drawing.Point(7, 312);
            this.txtDataPag.MaxLength = 50;
            this.txtDataPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataPag.Multiline = false;
            this.txtDataPag.Name = "txtDataPag";
            this.txtDataPag.Size = new System.Drawing.Size(164, 50);
            this.txtDataPag.TabIndex = 20;
            this.txtDataPag.Text = "";
            this.txtDataPag.TrailingIcon = null;
            this.txtDataPag.TextChanged += new System.EventHandler(this.materialTextBox7_TextChanged);
            // 
            // txtVRPag
            // 
            this.txtVRPag.AnimateReadOnly = false;
            this.txtVRPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVRPag.Depth = 0;
            this.txtVRPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVRPag.Hint = "Vale - refeição";
            this.txtVRPag.LeadingIcon = null;
            this.txtVRPag.Location = new System.Drawing.Point(512, 215);
            this.txtVRPag.MaxLength = 50;
            this.txtVRPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVRPag.Multiline = false;
            this.txtVRPag.Name = "txtVRPag";
            this.txtVRPag.Size = new System.Drawing.Size(164, 50);
            this.txtVRPag.TabIndex = 19;
            this.txtVRPag.Text = "";
            this.txtVRPag.TrailingIcon = null;
            // 
            // txtVTPag
            // 
            this.txtVTPag.AnimateReadOnly = false;
            this.txtVTPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVTPag.Depth = 0;
            this.txtVTPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVTPag.Hint = "Vale - transporte";
            this.txtVTPag.LeadingIcon = null;
            this.txtVTPag.Location = new System.Drawing.Point(261, 215);
            this.txtVTPag.MaxLength = 50;
            this.txtVTPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVTPag.Multiline = false;
            this.txtVTPag.Name = "txtVTPag";
            this.txtVTPag.Size = new System.Drawing.Size(164, 50);
            this.txtVTPag.TabIndex = 18;
            this.txtVTPag.Text = "";
            this.txtVTPag.TrailingIcon = null;
            // 
            // txtFGTSPag
            // 
            this.txtFGTSPag.AnimateReadOnly = false;
            this.txtFGTSPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFGTSPag.Depth = 0;
            this.txtFGTSPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFGTSPag.Hint = "FGTS";
            this.txtFGTSPag.LeadingIcon = null;
            this.txtFGTSPag.Location = new System.Drawing.Point(7, 215);
            this.txtFGTSPag.MaxLength = 50;
            this.txtFGTSPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFGTSPag.Multiline = false;
            this.txtFGTSPag.Name = "txtFGTSPag";
            this.txtFGTSPag.Size = new System.Drawing.Size(164, 50);
            this.txtFGTSPag.TabIndex = 17;
            this.txtFGTSPag.Text = "";
            this.txtFGTSPag.TrailingIcon = null;
            this.txtFGTSPag.TextChanged += new System.EventHandler(this.materialTextBox4_TextChanged);
            // 
            // txtINSSPag
            // 
            this.txtINSSPag.AnimateReadOnly = false;
            this.txtINSSPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtINSSPag.Depth = 0;
            this.txtINSSPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtINSSPag.Hint = "INSS";
            this.txtINSSPag.LeadingIcon = null;
            this.txtINSSPag.Location = new System.Drawing.Point(512, 129);
            this.txtINSSPag.MaxLength = 50;
            this.txtINSSPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtINSSPag.Multiline = false;
            this.txtINSSPag.Name = "txtINSSPag";
            this.txtINSSPag.Size = new System.Drawing.Size(164, 50);
            this.txtINSSPag.TabIndex = 16;
            this.txtINSSPag.Text = "";
            this.txtINSSPag.TrailingIcon = null;
            // 
            // txtSalarioPag
            // 
            this.txtSalarioPag.AnimateReadOnly = false;
            this.txtSalarioPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalarioPag.Depth = 0;
            this.txtSalarioPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalarioPag.Hint = "Sálario bruto";
            this.txtSalarioPag.LeadingIcon = null;
            this.txtSalarioPag.Location = new System.Drawing.Point(261, 129);
            this.txtSalarioPag.MaxLength = 50;
            this.txtSalarioPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSalarioPag.Multiline = false;
            this.txtSalarioPag.Name = "txtSalarioPag";
            this.txtSalarioPag.Size = new System.Drawing.Size(164, 50);
            this.txtSalarioPag.TabIndex = 15;
            this.txtSalarioPag.Text = "";
            this.txtSalarioPag.TrailingIcon = null;
            // 
            // txtNomePag
            // 
            this.txtNomePag.AnimateReadOnly = false;
            this.txtNomePag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomePag.Depth = 0;
            this.txtNomePag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomePag.Hint = "Nome";
            this.txtNomePag.LeadingIcon = null;
            this.txtNomePag.Location = new System.Drawing.Point(7, 129);
            this.txtNomePag.MaxLength = 50;
            this.txtNomePag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomePag.Multiline = false;
            this.txtNomePag.Name = "txtNomePag";
            this.txtNomePag.Size = new System.Drawing.Size(164, 50);
            this.txtNomePag.TabIndex = 14;
            this.txtNomePag.Text = "";
            this.txtNomePag.TrailingIcon = null;
            this.txtNomePag.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "Calcule os descontos";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // matriculaPag
            // 
            this.matriculaPag.AnimateReadOnly = false;
            this.matriculaPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.matriculaPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.matriculaPag.Depth = 0;
            this.matriculaPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.matriculaPag.HideSelection = true;
            this.matriculaPag.Hint = "Insira a matrícula";
            this.matriculaPag.LeadingIcon = null;
            this.matriculaPag.Location = new System.Drawing.Point(267, 58);
            this.matriculaPag.MaxLength = 32767;
            this.matriculaPag.MouseState = MaterialSkin.MouseState.OUT;
            this.matriculaPag.Name = "matriculaPag";
            this.matriculaPag.PasswordChar = '\0';
            this.matriculaPag.PrefixSuffixText = null;
            this.matriculaPag.ReadOnly = false;
            this.matriculaPag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.matriculaPag.SelectedText = "";
            this.matriculaPag.SelectionLength = 0;
            this.matriculaPag.SelectionStart = 0;
            this.matriculaPag.ShortcutsEnabled = true;
            this.matriculaPag.Size = new System.Drawing.Size(153, 48);
            this.matriculaPag.TabIndex = 12;
            this.matriculaPag.TabStop = false;
            this.matriculaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.matriculaPag.TrailingIcon = null;
            this.matriculaPag.UseSystemPasswordChar = false;
            this.matriculaPag.Click += new System.EventHandler(this.matriculaPag_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalcular.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCalcular.Depth = 0;
            this.btnCalcular.HighEmphasis = true;
            this.btnCalcular.Icon = null;
            this.btnCalcular.Location = new System.Drawing.Point(502, 326);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCalcular.Size = new System.Drawing.Size(95, 36);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCalcular.UseAccentColor = false;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtColaborador
            // 
            this.txtColaborador.Controls.Add(this.txtSalarioCad);
            this.txtColaborador.Controls.Add(this.txtNascimento);
            this.txtColaborador.Controls.Add(this.txtAdmissao);
            this.txtColaborador.Controls.Add(this.txtConfSenha);
            this.txtColaborador.Controls.Add(this.materialLabel1);
            this.txtColaborador.Controls.Add(this.btnCadastrar);
            this.txtColaborador.Controls.Add(this.txtTelefone);
            this.txtColaborador.Controls.Add(this.txtTurno);
            this.txtColaborador.Controls.Add(this.txtCargo);
            this.txtColaborador.Controls.Add(this.txtCadMatricula);
            this.txtColaborador.Controls.Add(this.txtCadSenha);
            this.txtColaborador.Controls.Add(this.txtEmail);
            this.txtColaborador.Controls.Add(this.txtNome);
            this.txtColaborador.ImageKey = "Colaborador.png";
            this.txtColaborador.Location = new System.Drawing.Point(4, 39);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Size = new System.Drawing.Size(736, 420);
            this.txtColaborador.TabIndex = 3;
            this.txtColaborador.Text = "Colaborador";
            this.txtColaborador.UseVisualStyleBackColor = true;
            this.txtColaborador.Click += new System.EventHandler(this.txtColaborador_Click);
            // 
            // txtSalarioCad
            // 
            this.txtSalarioCad.AnimateReadOnly = false;
            this.txtSalarioCad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalarioCad.Depth = 0;
            this.txtSalarioCad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalarioCad.Hint = "Sálario Bruto";
            this.txtSalarioCad.LeadingIcon = null;
            this.txtSalarioCad.Location = new System.Drawing.Point(264, 323);
            this.txtSalarioCad.MaxLength = 50;
            this.txtSalarioCad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSalarioCad.Multiline = false;
            this.txtSalarioCad.Name = "txtSalarioCad";
            this.txtSalarioCad.Size = new System.Drawing.Size(164, 50);
            this.txtSalarioCad.TabIndex = 17;
            this.txtSalarioCad.Text = "";
            this.txtSalarioCad.TrailingIcon = null;
            // 
            // txtNascimento
            // 
            this.txtNascimento.AnimateReadOnly = false;
            this.txtNascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNascimento.Depth = 0;
            this.txtNascimento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNascimento.Hint = "Data de nascimento";
            this.txtNascimento.LeadingIcon = null;
            this.txtNascimento.Location = new System.Drawing.Point(36, 246);
            this.txtNascimento.MaxLength = 50;
            this.txtNascimento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNascimento.Multiline = false;
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(164, 50);
            this.txtNascimento.TabIndex = 16;
            this.txtNascimento.Text = "";
            this.txtNascimento.TrailingIcon = null;
            // 
            // txtAdmissao
            // 
            this.txtAdmissao.AnimateReadOnly = false;
            this.txtAdmissao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdmissao.Depth = 0;
            this.txtAdmissao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdmissao.Hint = "Data de admissão";
            this.txtAdmissao.LeadingIcon = null;
            this.txtAdmissao.Location = new System.Drawing.Point(264, 248);
            this.txtAdmissao.MaxLength = 50;
            this.txtAdmissao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAdmissao.Multiline = false;
            this.txtAdmissao.Name = "txtAdmissao";
            this.txtAdmissao.Size = new System.Drawing.Size(164, 50);
            this.txtAdmissao.TabIndex = 15;
            this.txtAdmissao.Text = "";
            this.txtAdmissao.TrailingIcon = null;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.AnimateReadOnly = false;
            this.txtConfSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfSenha.Depth = 0;
            this.txtConfSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfSenha.Hint = "Confirme a senha";
            this.txtConfSenha.LeadingIcon = null;
            this.txtConfSenha.Location = new System.Drawing.Point(264, 166);
            this.txtConfSenha.MaxLength = 50;
            this.txtConfSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfSenha.Multiline = false;
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Password = true;
            this.txtConfSenha.Size = new System.Drawing.Size(164, 50);
            this.txtConfSenha.TabIndex = 14;
            this.txtConfSenha.Text = "";
            this.txtConfSenha.TrailingIcon = null;
            this.txtConfSenha.TextChanged += new System.EventHandler(this.txtConfSenha_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(293, 34);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Cadastrar Usuário";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCadastrar.Depth = 0;
            this.btnCadastrar.HighEmphasis = true;
            this.btnCadastrar.Icon = null;
            this.btnCadastrar.Location = new System.Drawing.Point(543, 367);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCadastrar.Size = new System.Drawing.Size(106, 36);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCadastrar.UseAccentColor = false;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.AllowPromptAsInput = true;
            this.txtTelefone.AnimateReadOnly = false;
            this.txtTelefone.AsciiOnly = false;
            this.txtTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefone.BeepOnError = false;
            this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefone.HidePromptOnLeave = false;
            this.txtTelefone.HideSelection = true;
            this.txtTelefone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtTelefone.LeadingIcon = null;
            this.txtTelefone.Location = new System.Drawing.Point(485, 166);
            this.txtTelefone.Mask = "(00)00000-0000";
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.PrefixSuffixText = null;
            this.txtTelefone.PromptChar = '_';
            this.txtTelefone.ReadOnly = false;
            this.txtTelefone.RejectInputOnFirstFailure = false;
            this.txtTelefone.ResetOnPrompt = true;
            this.txtTelefone.ResetOnSpace = true;
            this.txtTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.ShortcutsEnabled = true;
            this.txtTelefone.Size = new System.Drawing.Size(164, 48);
            this.txtTelefone.SkipLiterals = true;
            this.txtTelefone.TabIndex = 9;
            this.txtTelefone.TabStop = false;
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.TrailingIcon = null;
            this.txtTelefone.UseSystemPasswordChar = false;
            this.txtTelefone.ValidatingType = null;
            this.txtTelefone.Click += new System.EventHandler(this.txtTelefone_Click);
            // 
            // txtTurno
            // 
            this.txtTurno.AutoResize = false;
            this.txtTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTurno.Depth = 0;
            this.txtTurno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtTurno.DropDownHeight = 174;
            this.txtTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTurno.DropDownWidth = 121;
            this.txtTurno.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTurno.FormattingEnabled = true;
            this.txtTurno.IntegralHeight = false;
            this.txtTurno.ItemHeight = 43;
            this.txtTurno.Items.AddRange(new object[] {
            "Integral",
            "Noturno"});
            this.txtTurno.Location = new System.Drawing.Point(36, 324);
            this.txtTurno.MaxDropDownItems = 4;
            this.txtTurno.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(164, 49);
            this.txtTurno.StartIndex = 0;
            this.txtTurno.TabIndex = 8;
            this.txtTurno.SelectedIndexChanged += new System.EventHandler(this.materialComboBox2_SelectedIndexChanged);
            // 
            // txtCargo
            // 
            this.txtCargo.AutoResize = false;
            this.txtCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCargo.Depth = 0;
            this.txtCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtCargo.DropDownHeight = 174;
            this.txtCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCargo.DropDownWidth = 121;
            this.txtCargo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCargo.FormattingEnabled = true;
            this.txtCargo.IntegralHeight = false;
            this.txtCargo.ItemHeight = 43;
            this.txtCargo.Items.AddRange(new object[] {
            "ADM",
            "Comum"});
            this.txtCargo.Location = new System.Drawing.Point(485, 249);
            this.txtCargo.MaxDropDownItems = 4;
            this.txtCargo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(164, 49);
            this.txtCargo.StartIndex = 0;
            this.txtCargo.TabIndex = 7;
            this.txtCargo.SelectedIndexChanged += new System.EventHandler(this.txtCargo_SelectedIndexChanged);
            // 
            // txtCadMatricula
            // 
            this.txtCadMatricula.AnimateReadOnly = false;
            this.txtCadMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCadMatricula.Depth = 0;
            this.txtCadMatricula.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCadMatricula.Hint = "Matrícula";
            this.txtCadMatricula.LeadingIcon = null;
            this.txtCadMatricula.Location = new System.Drawing.Point(485, 89);
            this.txtCadMatricula.MaxLength = 50;
            this.txtCadMatricula.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCadMatricula.Multiline = false;
            this.txtCadMatricula.Name = "txtCadMatricula";
            this.txtCadMatricula.Size = new System.Drawing.Size(164, 50);
            this.txtCadMatricula.TabIndex = 4;
            this.txtCadMatricula.Text = "";
            this.txtCadMatricula.TrailingIcon = null;
            this.txtCadMatricula.TextChanged += new System.EventHandler(this.txtCadMatricula_TextChanged);
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.AnimateReadOnly = false;
            this.txtCadSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCadSenha.Depth = 0;
            this.txtCadSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCadSenha.Hint = "Senha";
            this.txtCadSenha.LeadingIcon = null;
            this.txtCadSenha.Location = new System.Drawing.Point(36, 164);
            this.txtCadSenha.MaxLength = 50;
            this.txtCadSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCadSenha.Multiline = false;
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Password = true;
            this.txtCadSenha.Size = new System.Drawing.Size(164, 50);
            this.txtCadSenha.TabIndex = 2;
            this.txtCadSenha.Text = "";
            this.txtCadSenha.TrailingIcon = null;
            this.txtCadSenha.TextChanged += new System.EventHandler(this.txtCadSenha_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Hint = "E-mail";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(264, 89);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 50);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.Hint = "Nome completo";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(36, 89);
            this.txtNome.MaxLength = 50;
            this.txtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 50);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "";
            this.txtNome.TrailingIcon = null;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // editCad
            // 
            this.editCad.Controls.Add(this.btnDeletar);
            this.editCad.Controls.Add(this.btnPesquisar);
            this.editCad.Controls.Add(this.materialLabel2);
            this.editCad.Controls.Add(this.txtEditarNascimento);
            this.editCad.Controls.Add(this.txtEditarAdmissao);
            this.editCad.Controls.Add(this.txtEditarConfirmar);
            this.editCad.Controls.Add(this.btnModificar);
            this.editCad.Controls.Add(this.txtEditarTelefone);
            this.editCad.Controls.Add(this.txtEditarTurno);
            this.editCad.Controls.Add(this.txtEditarMatricula);
            this.editCad.Controls.Add(this.txtEditarSenha);
            this.editCad.Controls.Add(this.txtEditarEmail);
            this.editCad.Controls.Add(this.txtEditarNome);
            this.editCad.ImageKey = "colaborar.png";
            this.editCad.Location = new System.Drawing.Point(4, 39);
            this.editCad.Name = "editCad";
            this.editCad.Size = new System.Drawing.Size(736, 420);
            this.editCad.TabIndex = 5;
            this.editCad.Text = "Editar cadastro";
            this.editCad.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeletar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeletar.Depth = 0;
            this.btnDeletar.HighEmphasis = true;
            this.btnDeletar.Icon = null;
            this.btnDeletar.Location = new System.Drawing.Point(579, 311);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeletar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeletar.Size = new System.Drawing.Size(84, 36);
            this.btnDeletar.TabIndex = 30;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeletar.UseAccentColor = false;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPesquisar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPesquisar.Depth = 0;
            this.btnPesquisar.HighEmphasis = true;
            this.btnPesquisar.Icon = null;
            this.btnPesquisar.Location = new System.Drawing.Point(451, 72);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPesquisar.Size = new System.Drawing.Size(100, 36);
            this.btnPesquisar.TabIndex = 29;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPesquisar.UseAccentColor = false;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(246, 33);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(219, 19);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "Editar cadastro do colaborador";
            // 
            // txtEditarNascimento
            // 
            this.txtEditarNascimento.AnimateReadOnly = false;
            this.txtEditarNascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditarNascimento.Depth = 0;
            this.txtEditarNascimento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarNascimento.Hint = "Data de nascimento";
            this.txtEditarNascimento.LeadingIcon = null;
            this.txtEditarNascimento.Location = new System.Drawing.Point(483, 213);
            this.txtEditarNascimento.MaxLength = 50;
            this.txtEditarNascimento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditarNascimento.Multiline = false;
            this.txtEditarNascimento.Name = "txtEditarNascimento";
            this.txtEditarNascimento.Size = new System.Drawing.Size(164, 50);
            this.txtEditarNascimento.TabIndex = 27;
            this.txtEditarNascimento.Text = "";
            this.txtEditarNascimento.TrailingIcon = null;
            // 
            // txtEditarAdmissao
            // 
            this.txtEditarAdmissao.AnimateReadOnly = false;
            this.txtEditarAdmissao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditarAdmissao.Depth = 0;
            this.txtEditarAdmissao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarAdmissao.Hint = "Data de admissão";
            this.txtEditarAdmissao.LeadingIcon = null;
            this.txtEditarAdmissao.Location = new System.Drawing.Point(45, 297);
            this.txtEditarAdmissao.MaxLength = 50;
            this.txtEditarAdmissao.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditarAdmissao.Multiline = false;
            this.txtEditarAdmissao.Name = "txtEditarAdmissao";
            this.txtEditarAdmissao.Size = new System.Drawing.Size(164, 50);
            this.txtEditarAdmissao.TabIndex = 26;
            this.txtEditarAdmissao.Text = "";
            this.txtEditarAdmissao.TrailingIcon = null;
            // 
            // txtEditarConfirmar
            // 
            this.txtEditarConfirmar.AnimateReadOnly = false;
            this.txtEditarConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditarConfirmar.Depth = 0;
            this.txtEditarConfirmar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarConfirmar.Hint = "Confirme a senha";
            this.txtEditarConfirmar.LeadingIcon = null;
            this.txtEditarConfirmar.Location = new System.Drawing.Point(273, 213);
            this.txtEditarConfirmar.MaxLength = 50;
            this.txtEditarConfirmar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditarConfirmar.Multiline = false;
            this.txtEditarConfirmar.Name = "txtEditarConfirmar";
            this.txtEditarConfirmar.Size = new System.Drawing.Size(164, 50);
            this.txtEditarConfirmar.TabIndex = 25;
            this.txtEditarConfirmar.Text = "";
            this.txtEditarConfirmar.TrailingIcon = null;
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificar.Depth = 0;
            this.btnModificar.HighEmphasis = true;
            this.btnModificar.Icon = null;
            this.btnModificar.Location = new System.Drawing.Point(473, 311);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModificar.Size = new System.Drawing.Size(99, 36);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificar.UseAccentColor = false;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtEditarTelefone
            // 
            this.txtEditarTelefone.AllowPromptAsInput = true;
            this.txtEditarTelefone.AnimateReadOnly = false;
            this.txtEditarTelefone.AsciiOnly = false;
            this.txtEditarTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEditarTelefone.BeepOnError = false;
            this.txtEditarTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEditarTelefone.Depth = 0;
            this.txtEditarTelefone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarTelefone.HidePromptOnLeave = false;
            this.txtEditarTelefone.HideSelection = true;
            this.txtEditarTelefone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEditarTelefone.LeadingIcon = null;
            this.txtEditarTelefone.Location = new System.Drawing.Point(483, 140);
            this.txtEditarTelefone.Mask = "(00)00000-0000";
            this.txtEditarTelefone.MaxLength = 32767;
            this.txtEditarTelefone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditarTelefone.Name = "txtEditarTelefone";
            this.txtEditarTelefone.PasswordChar = '\0';
            this.txtEditarTelefone.PrefixSuffixText = null;
            this.txtEditarTelefone.PromptChar = '_';
            this.txtEditarTelefone.ReadOnly = false;
            this.txtEditarTelefone.RejectInputOnFirstFailure = false;
            this.txtEditarTelefone.ResetOnPrompt = true;
            this.txtEditarTelefone.ResetOnSpace = true;
            this.txtEditarTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEditarTelefone.SelectedText = "";
            this.txtEditarTelefone.SelectionLength = 0;
            this.txtEditarTelefone.SelectionStart = 0;
            this.txtEditarTelefone.ShortcutsEnabled = true;
            this.txtEditarTelefone.Size = new System.Drawing.Size(164, 48);
            this.txtEditarTelefone.SkipLiterals = true;
            this.txtEditarTelefone.TabIndex = 23;
            this.txtEditarTelefone.TabStop = false;
            this.txtEditarTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEditarTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtEditarTelefone.TrailingIcon = null;
            this.txtEditarTelefone.UseSystemPasswordChar = false;
            this.txtEditarTelefone.ValidatingType = null;
            // 
            // txtEditarTurno
            // 
            this.txtEditarTurno.AutoResize = false;
            this.txtEditarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtEditarTurno.Depth = 0;
            this.txtEditarTurno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtEditarTurno.DropDownHeight = 174;
            this.txtEditarTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEditarTurno.DropDownWidth = 121;
            this.txtEditarTurno.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtEditarTurno.FormattingEnabled = true;
            this.txtEditarTurno.IntegralHeight = false;
            this.txtEditarTurno.ItemHeight = 43;
            this.txtEditarTurno.Items.AddRange(new object[] {
            "Integral",
            "Noturno"});
            this.txtEditarTurno.Location = new System.Drawing.Point(273, 298);
            this.txtEditarTurno.MaxDropDownItems = 4;
            this.txtEditarTurno.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditarTurno.Name = "txtEditarTurno";
            this.txtEditarTurno.Size = new System.Drawing.Size(164, 49);
            this.txtEditarTurno.StartIndex = 0;
            this.txtEditarTurno.TabIndex = 22;
            // 
            // txtEditarMatricula
            // 
            this.txtEditarMatricula.AnimateReadOnly = false;
            this.txtEditarMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditarMatricula.Depth = 0;
            this.txtEditarMatricula.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarMatricula.Hint = "Matrícula";
            this.txtEditarMatricula.LeadingIcon = null;
            this.txtEditarMatricula.Location = new System.Drawing.Point(273, 65);
            this.txtEditarMatricula.MaxLength = 50;
            this.txtEditarMatricula.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditarMatricula.Multiline = false;
            this.txtEditarMatricula.Name = "txtEditarMatricula";
            this.txtEditarMatricula.Size = new System.Drawing.Size(164, 50);
            this.txtEditarMatricula.TabIndex = 20;
            this.txtEditarMatricula.Text = "";
            this.txtEditarMatricula.TrailingIcon = null;
            // 
            // txtEditarSenha
            // 
            this.txtEditarSenha.AnimateReadOnly = false;
            this.txtEditarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditarSenha.Depth = 0;
            this.txtEditarSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarSenha.Hint = "Senha";
            this.txtEditarSenha.LeadingIcon = null;
            this.txtEditarSenha.Location = new System.Drawing.Point(45, 213);
            this.txtEditarSenha.MaxLength = 50;
            this.txtEditarSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditarSenha.Multiline = false;
            this.txtEditarSenha.Name = "txtEditarSenha";
            this.txtEditarSenha.Size = new System.Drawing.Size(164, 50);
            this.txtEditarSenha.TabIndex = 19;
            this.txtEditarSenha.Text = "";
            this.txtEditarSenha.TrailingIcon = null;
            // 
            // txtEditarEmail
            // 
            this.txtEditarEmail.AnimateReadOnly = false;
            this.txtEditarEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditarEmail.Depth = 0;
            this.txtEditarEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarEmail.Hint = "E-mail";
            this.txtEditarEmail.LeadingIcon = null;
            this.txtEditarEmail.Location = new System.Drawing.Point(273, 138);
            this.txtEditarEmail.MaxLength = 50;
            this.txtEditarEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditarEmail.Multiline = false;
            this.txtEditarEmail.Name = "txtEditarEmail";
            this.txtEditarEmail.Size = new System.Drawing.Size(164, 50);
            this.txtEditarEmail.TabIndex = 18;
            this.txtEditarEmail.Text = "";
            this.txtEditarEmail.TrailingIcon = null;
            this.txtEditarEmail.TextChanged += new System.EventHandler(this.materialTextBox6_TextChanged);
            // 
            // txtEditarNome
            // 
            this.txtEditarNome.AnimateReadOnly = false;
            this.txtEditarNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditarNome.Depth = 0;
            this.txtEditarNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEditarNome.Hint = "Nome completo";
            this.txtEditarNome.LeadingIcon = null;
            this.txtEditarNome.Location = new System.Drawing.Point(45, 138);
            this.txtEditarNome.MaxLength = 50;
            this.txtEditarNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEditarNome.Multiline = false;
            this.txtEditarNome.Name = "txtEditarNome";
            this.txtEditarNome.Size = new System.Drawing.Size(164, 50);
            this.txtEditarNome.TabIndex = 17;
            this.txtEditarNome.Text = "";
            this.txtEditarNome.TrailingIcon = null;
            // 
            // txtFinalizar
            // 
            this.txtFinalizar.Controls.Add(this.btnSair);
            this.txtFinalizar.Controls.Add(this.label19);
            this.txtFinalizar.Controls.Add(this.label18);
            this.txtFinalizar.ImageKey = "sair.png";
            this.txtFinalizar.Location = new System.Drawing.Point(4, 39);
            this.txtFinalizar.Name = "txtFinalizar";
            this.txtFinalizar.Size = new System.Drawing.Size(736, 420);
            this.txtFinalizar.TabIndex = 4;
            this.txtFinalizar.Text = "Finalizar";
            this.txtFinalizar.UseVisualStyleBackColor = true;
            this.txtFinalizar.Click += new System.EventHandler(this.txtFinalizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSair.Depth = 0;
            this.btnSair.HighEmphasis = true;
            this.btnSair.Icon = null;
            this.btnSair.Location = new System.Drawing.Point(261, 216);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSair.Size = new System.Drawing.Size(64, 36);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSair.UseAccentColor = false;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(188, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(211, 33);
            this.label19.TabIndex = 1;
            this.label19.Text = "Finalizar sessão";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(174, 181);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(239, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Para finalizar sua sessão clique no botão abaixo !";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sair.png");
            this.imageList1.Images.SetKeyName(1, "Rendimentos.png");
            this.imageList1.Images.SetKeyName(2, "Pagamentos.png");
            this.imageList1.Images.SetKeyName(3, "periodo-de-ferias.png");
            this.imageList1.Images.SetKeyName(4, "Colaborador.png");
            this.imageList1.Images.SetKeyName(5, "colaborar.png");
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerWidth = 210;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.txtPagamentos.ResumeLayout(false);
            this.txtPagamentos.PerformLayout();
            this.txtColaborador.ResumeLayout(false);
            this.txtColaborador.PerformLayout();
            this.editCad.ResumeLayout(false);
            this.editCad.PerformLayout();
            this.txtFinalizar.ResumeLayout(false);
            this.txtFinalizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage txtPagamentos;
        private System.Windows.Forms.TabPage txtColaborador;
        private System.Windows.Forms.TabPage txtFinalizar;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btnCalcular;
        private MaterialSkin.Controls.MaterialTextBox2 matriculaPag;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialComboBox txtTurno;
        private MaterialSkin.Controls.MaterialComboBox txtCargo;
        private MaterialSkin.Controls.MaterialTextBox txtCadMatricula;
        private MaterialSkin.Controls.MaterialTextBox txtCadSenha;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtNome;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtTelefone;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnCadastrar;
        private MaterialSkin.Controls.MaterialTextBox txtConfSenha;
        private MaterialSkin.Controls.MaterialButton btnSair;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private MaterialSkin.Controls.MaterialTextBox txtNascimento;
        private MaterialSkin.Controls.MaterialTextBox txtAdmissao;
        private System.Windows.Forms.TabPage editCad;
        private MaterialSkin.Controls.MaterialTextBox txtEditarNascimento;
        private MaterialSkin.Controls.MaterialTextBox txtEditarAdmissao;
        private MaterialSkin.Controls.MaterialTextBox txtEditarConfirmar;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEditarTelefone;
        private MaterialSkin.Controls.MaterialComboBox txtEditarTurno;
        private MaterialSkin.Controls.MaterialTextBox txtEditarSenha;
        private MaterialSkin.Controls.MaterialTextBox txtEditarEmail;
        private MaterialSkin.Controls.MaterialTextBox txtEditarNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtEditarMatricula;
        private MaterialSkin.Controls.MaterialButton btnPesquisar;
        private MaterialSkin.Controls.MaterialTextBox txtVRPag;
        private MaterialSkin.Controls.MaterialTextBox txtVTPag;
        private MaterialSkin.Controls.MaterialTextBox txtFGTSPag;
        private MaterialSkin.Controls.MaterialTextBox txtINSSPag;
        private MaterialSkin.Controls.MaterialTextBox txtSalarioPag;
        private MaterialSkin.Controls.MaterialTextBox txtNomePag;
        private MaterialSkin.Controls.MaterialTextBox txtDataPag;
        private MaterialSkin.Controls.MaterialTextBox txtSalarioLiqPag;
        private MaterialSkin.Controls.MaterialButton btnBuscarPag;
        private MaterialSkin.Controls.MaterialButton btnDeletar;
        private MaterialSkin.Controls.MaterialTextBox txtSalarioCad;
    }
}