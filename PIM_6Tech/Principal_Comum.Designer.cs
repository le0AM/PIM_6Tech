namespace PIM_6Tech
{
    partial class Principal_Comum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_Comum));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Finalizar = new System.Windows.Forms.TabPage();
            this.Folha_Pag = new System.Windows.Forms.TabPage();
            this.matriculaPag = new MaterialSkin.Controls.MaterialTextBox2();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomePag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSalarioPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtINSSPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFGTSPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtVTPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtVRPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDataPag = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSalarioLiqPag = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBuscarPag = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.btnSair = new MaterialSkin.Controls.MaterialButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Finalizar.SuspendLayout();
            this.Folha_Pag.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // Finalizar
            // 
            this.Finalizar.Controls.Add(this.btnSair);
            this.Finalizar.Controls.Add(this.label19);
            this.Finalizar.Controls.Add(this.label18);
            this.Finalizar.ImageKey = "sair.png";
            this.Finalizar.Location = new System.Drawing.Point(4, 39);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(736, 420);
            this.Finalizar.TabIndex = 4;
            this.Finalizar.Text = "Finalizar sessão";
            this.Finalizar.UseVisualStyleBackColor = true;
            // 
            // Folha_Pag
            // 
            this.Folha_Pag.Controls.Add(this.btnBuscarPag);
            this.Folha_Pag.Controls.Add(this.txtSalarioLiqPag);
            this.Folha_Pag.Controls.Add(this.txtDataPag);
            this.Folha_Pag.Controls.Add(this.txtVRPag);
            this.Folha_Pag.Controls.Add(this.txtVTPag);
            this.Folha_Pag.Controls.Add(this.txtFGTSPag);
            this.Folha_Pag.Controls.Add(this.txtINSSPag);
            this.Folha_Pag.Controls.Add(this.txtSalarioPag);
            this.Folha_Pag.Controls.Add(this.txtNomePag);
            this.Folha_Pag.Controls.Add(this.label6);
            this.Folha_Pag.Controls.Add(this.matriculaPag);
            this.Folha_Pag.ImageKey = "Pagamentos.png";
            this.Folha_Pag.Location = new System.Drawing.Point(4, 39);
            this.Folha_Pag.Name = "Folha_Pag";
            this.Folha_Pag.Padding = new System.Windows.Forms.Padding(3);
            this.Folha_Pag.Size = new System.Drawing.Size(736, 420);
            this.Folha_Pag.TabIndex = 0;
            this.Folha_Pag.Text = "Folha de pagamento";
            this.Folha_Pag.UseVisualStyleBackColor = true;
            this.Folha_Pag.Click += new System.EventHandler(this.Folha_Pag_Click);
            // 
            // matriculaPag
            // 
            this.matriculaPag.AnimateReadOnly = false;
            this.matriculaPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.matriculaPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.matriculaPag.Depth = 0;
            this.matriculaPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.matriculaPag.HideSelection = true;
            this.matriculaPag.Hint = "Insira sua matrícula";
            this.matriculaPag.LeadingIcon = null;
            this.matriculaPag.Location = new System.Drawing.Point(193, 76);
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
            this.matriculaPag.TabIndex = 24;
            this.matriculaPag.TabStop = false;
            this.matriculaPag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.matriculaPag.TrailingIcon = null;
            this.matriculaPag.UseSystemPasswordChar = false;
            this.matriculaPag.Click += new System.EventHandler(this.matriculaPag_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(238, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(547, 33);
            this.label6.TabIndex = 25;
            this.label6.Text = "VISUALIZAÇÃO DA FOLHA DE PAGAMENTO";
            // 
            // txtNomePag
            // 
            this.txtNomePag.AnimateReadOnly = false;
            this.txtNomePag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomePag.Depth = 0;
            this.txtNomePag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomePag.Hint = "Nome";
            this.txtNomePag.LeadingIcon = null;
            this.txtNomePag.Location = new System.Drawing.Point(7, 189);
            this.txtNomePag.MaxLength = 50;
            this.txtNomePag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomePag.Multiline = false;
            this.txtNomePag.Name = "txtNomePag";
            this.txtNomePag.Size = new System.Drawing.Size(164, 50);
            this.txtNomePag.TabIndex = 26;
            this.txtNomePag.Text = "";
            this.txtNomePag.TrailingIcon = null;
            // 
            // txtSalarioPag
            // 
            this.txtSalarioPag.AnimateReadOnly = false;
            this.txtSalarioPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalarioPag.Depth = 0;
            this.txtSalarioPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalarioPag.Hint = "Sálario bruto";
            this.txtSalarioPag.LeadingIcon = null;
            this.txtSalarioPag.Location = new System.Drawing.Point(261, 189);
            this.txtSalarioPag.MaxLength = 50;
            this.txtSalarioPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSalarioPag.Multiline = false;
            this.txtSalarioPag.Name = "txtSalarioPag";
            this.txtSalarioPag.Size = new System.Drawing.Size(164, 50);
            this.txtSalarioPag.TabIndex = 27;
            this.txtSalarioPag.Text = "";
            this.txtSalarioPag.TrailingIcon = null;
            this.txtSalarioPag.TextChanged += new System.EventHandler(this.txtSalarioPag_TextChanged);
            // 
            // txtINSSPag
            // 
            this.txtINSSPag.AnimateReadOnly = false;
            this.txtINSSPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtINSSPag.Depth = 0;
            this.txtINSSPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtINSSPag.Hint = "INSS";
            this.txtINSSPag.LeadingIcon = null;
            this.txtINSSPag.Location = new System.Drawing.Point(512, 189);
            this.txtINSSPag.MaxLength = 50;
            this.txtINSSPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtINSSPag.Multiline = false;
            this.txtINSSPag.Name = "txtINSSPag";
            this.txtINSSPag.Size = new System.Drawing.Size(164, 50);
            this.txtINSSPag.TabIndex = 28;
            this.txtINSSPag.Text = "";
            this.txtINSSPag.TrailingIcon = null;
            // 
            // txtFGTSPag
            // 
            this.txtFGTSPag.AnimateReadOnly = false;
            this.txtFGTSPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFGTSPag.Depth = 0;
            this.txtFGTSPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFGTSPag.Hint = "FGTS";
            this.txtFGTSPag.LeadingIcon = null;
            this.txtFGTSPag.Location = new System.Drawing.Point(7, 275);
            this.txtFGTSPag.MaxLength = 50;
            this.txtFGTSPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFGTSPag.Multiline = false;
            this.txtFGTSPag.Name = "txtFGTSPag";
            this.txtFGTSPag.Size = new System.Drawing.Size(164, 50);
            this.txtFGTSPag.TabIndex = 29;
            this.txtFGTSPag.Text = "";
            this.txtFGTSPag.TrailingIcon = null;
            // 
            // txtVTPag
            // 
            this.txtVTPag.AnimateReadOnly = false;
            this.txtVTPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVTPag.Depth = 0;
            this.txtVTPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVTPag.Hint = "Vale - transporte";
            this.txtVTPag.LeadingIcon = null;
            this.txtVTPag.Location = new System.Drawing.Point(261, 275);
            this.txtVTPag.MaxLength = 50;
            this.txtVTPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVTPag.Multiline = false;
            this.txtVTPag.Name = "txtVTPag";
            this.txtVTPag.Size = new System.Drawing.Size(164, 50);
            this.txtVTPag.TabIndex = 30;
            this.txtVTPag.Text = "";
            this.txtVTPag.TrailingIcon = null;
            // 
            // txtVRPag
            // 
            this.txtVRPag.AnimateReadOnly = false;
            this.txtVRPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVRPag.Depth = 0;
            this.txtVRPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVRPag.Hint = "Vale - refeição";
            this.txtVRPag.LeadingIcon = null;
            this.txtVRPag.Location = new System.Drawing.Point(512, 275);
            this.txtVRPag.MaxLength = 50;
            this.txtVRPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVRPag.Multiline = false;
            this.txtVRPag.Name = "txtVRPag";
            this.txtVRPag.Size = new System.Drawing.Size(164, 50);
            this.txtVRPag.TabIndex = 31;
            this.txtVRPag.Text = "";
            this.txtVRPag.TrailingIcon = null;
            // 
            // txtDataPag
            // 
            this.txtDataPag.AnimateReadOnly = false;
            this.txtDataPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataPag.Depth = 0;
            this.txtDataPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDataPag.Hint = "Mês da Folha ";
            this.txtDataPag.LeadingIcon = null;
            this.txtDataPag.Location = new System.Drawing.Point(361, 74);
            this.txtDataPag.MaxLength = 50;
            this.txtDataPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDataPag.Multiline = false;
            this.txtDataPag.Name = "txtDataPag";
            this.txtDataPag.Size = new System.Drawing.Size(164, 50);
            this.txtDataPag.TabIndex = 32;
            this.txtDataPag.Text = "";
            this.txtDataPag.TrailingIcon = null;
            this.txtDataPag.TextChanged += new System.EventHandler(this.txtDataPag_TextChanged);
            // 
            // txtSalarioLiqPag
            // 
            this.txtSalarioLiqPag.AnimateReadOnly = false;
            this.txtSalarioLiqPag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalarioLiqPag.Depth = 0;
            this.txtSalarioLiqPag.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalarioLiqPag.Hint = "Salario líquido";
            this.txtSalarioLiqPag.LeadingIcon = null;
            this.txtSalarioLiqPag.Location = new System.Drawing.Point(7, 365);
            this.txtSalarioLiqPag.MaxLength = 50;
            this.txtSalarioLiqPag.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSalarioLiqPag.Multiline = false;
            this.txtSalarioLiqPag.Name = "txtSalarioLiqPag";
            this.txtSalarioLiqPag.Size = new System.Drawing.Size(164, 50);
            this.txtSalarioLiqPag.TabIndex = 33;
            this.txtSalarioLiqPag.Text = "";
            this.txtSalarioLiqPag.TrailingIcon = null;
            // 
            // btnBuscarPag
            // 
            this.btnBuscarPag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarPag.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarPag.Depth = 0;
            this.btnBuscarPag.HighEmphasis = true;
            this.btnBuscarPag.Icon = null;
            this.btnBuscarPag.Location = new System.Drawing.Point(314, 133);
            this.btnBuscarPag.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarPag.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarPag.Name = "btnBuscarPag";
            this.btnBuscarPag.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarPag.Size = new System.Drawing.Size(77, 36);
            this.btnBuscarPag.TabIndex = 34;
            this.btnBuscarPag.Text = "Buscar";
            this.btnBuscarPag.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarPag.UseAccentColor = false;
            this.btnBuscarPag.UseVisualStyleBackColor = true;
            this.btnBuscarPag.Click += new System.EventHandler(this.btnBuscarPag_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Folha_Pag);
            this.materialTabControl1.Controls.Add(this.Finalizar);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(744, 463);
            this.materialTabControl1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSair.Depth = 0;
            this.btnSair.HighEmphasis = true;
            this.btnSair.Icon = null;
            this.btnSair.Location = new System.Drawing.Point(277, 240);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSair.Name = "btnSair";
            this.btnSair.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSair.Size = new System.Drawing.Size(64, 36);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSair.UseAccentColor = false;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(257, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(259, 33);
            this.label19.TabIndex = 4;
            this.label19.Text = "FINALIZAR SESSÃO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(190, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(239, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Para finalizar sua sessão clique no botão abaixo !";
            // 
            // Principal_Comum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Principal_Comum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal_Comum";
            this.Finalizar.ResumeLayout(false);
            this.Finalizar.PerformLayout();
            this.Folha_Pag.ResumeLayout(false);
            this.Folha_Pag.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage Finalizar;
        private System.Windows.Forms.TabPage Folha_Pag;
        private MaterialSkin.Controls.MaterialButton btnBuscarPag;
        private MaterialSkin.Controls.MaterialTextBox txtSalarioLiqPag;
        private MaterialSkin.Controls.MaterialTextBox txtDataPag;
        private MaterialSkin.Controls.MaterialTextBox txtVRPag;
        private MaterialSkin.Controls.MaterialTextBox txtVTPag;
        private MaterialSkin.Controls.MaterialTextBox txtFGTSPag;
        private MaterialSkin.Controls.MaterialTextBox txtINSSPag;
        private MaterialSkin.Controls.MaterialTextBox txtSalarioPag;
        private MaterialSkin.Controls.MaterialTextBox txtNomePag;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox2 matriculaPag;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin.Controls.MaterialButton btnSair;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
    }
}