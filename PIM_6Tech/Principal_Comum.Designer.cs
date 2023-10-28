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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Folha_Pag = new System.Windows.Forms.TabPage();
            this.Rend_Anual = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ferias = new System.Windows.Forms.TabPage();
            this.Editar_Cad = new System.Windows.Forms.TabPage();
            this.Finalizar = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Folha_Pag);
            this.materialTabControl1.Controls.Add(this.Rend_Anual);
            this.materialTabControl1.Controls.Add(this.ferias);
            this.materialTabControl1.Controls.Add(this.Editar_Cad);
            this.materialTabControl1.Controls.Add(this.Finalizar);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Folha_Pag
            // 
            this.Folha_Pag.ImageKey = "Pagamentos.png";
            this.Folha_Pag.Location = new System.Drawing.Point(4, 39);
            this.Folha_Pag.Name = "Folha_Pag";
            this.Folha_Pag.Padding = new System.Windows.Forms.Padding(3);
            this.Folha_Pag.Size = new System.Drawing.Size(786, 340);
            this.Folha_Pag.TabIndex = 0;
            this.Folha_Pag.Text = "Folha de pagamento";
            this.Folha_Pag.UseVisualStyleBackColor = true;
            // 
            // Rend_Anual
            // 
            this.Rend_Anual.ImageKey = "Rendimentos.png";
            this.Rend_Anual.Location = new System.Drawing.Point(4, 39);
            this.Rend_Anual.Name = "Rend_Anual";
            this.Rend_Anual.Padding = new System.Windows.Forms.Padding(3);
            this.Rend_Anual.Size = new System.Drawing.Size(786, 340);
            this.Rend_Anual.TabIndex = 1;
            this.Rend_Anual.Text = "Rendimentos anuais";
            this.Rend_Anual.UseVisualStyleBackColor = true;
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
            // ferias
            // 
            this.ferias.ImageKey = "periodo-de-ferias.png";
            this.ferias.Location = new System.Drawing.Point(4, 39);
            this.ferias.Name = "ferias";
            this.ferias.Size = new System.Drawing.Size(786, 340);
            this.ferias.TabIndex = 2;
            this.ferias.Text = "Férias";
            this.ferias.UseVisualStyleBackColor = true;
            // 
            // Editar_Cad
            // 
            this.Editar_Cad.ImageKey = "Colaborador.png";
            this.Editar_Cad.Location = new System.Drawing.Point(4, 39);
            this.Editar_Cad.Name = "Editar_Cad";
            this.Editar_Cad.Size = new System.Drawing.Size(786, 340);
            this.Editar_Cad.TabIndex = 3;
            this.Editar_Cad.Text = "Editar cadastro";
            this.Editar_Cad.UseVisualStyleBackColor = true;
            // 
            // Finalizar
            // 
            this.Finalizar.ImageKey = "sair.png";
            this.Finalizar.Location = new System.Drawing.Point(4, 39);
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Size = new System.Drawing.Size(786, 340);
            this.Finalizar.TabIndex = 4;
            this.Finalizar.Text = "Finalizar sessão";
            this.Finalizar.UseVisualStyleBackColor = true;
            // 
            // Principal_Comum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Principal_Comum";
            this.Text = "Principal_Comum";
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Folha_Pag;
        private System.Windows.Forms.TabPage Rend_Anual;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage ferias;
        private System.Windows.Forms.TabPage Editar_Cad;
        private System.Windows.Forms.TabPage Finalizar;
    }
}