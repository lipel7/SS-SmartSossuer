namespace SmartSossuer
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.novidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarNovaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDosEquipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoCadastraisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.tsmRegistro,
            this.infoCadastraisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdicionar,
            this.tsmSair});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // tsmAdicionar
            // 
            this.tsmAdicionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novidadesToolStripMenuItem,
            this.adicionarNovaCategoriaToolStripMenuItem,
            this.manutençãoDosEquipamentosToolStripMenuItem,
            this.unidadesToolStripMenuItem});
            this.tsmAdicionar.Name = "tsmAdicionar";
            this.tsmAdicionar.Size = new System.Drawing.Size(125, 22);
            this.tsmAdicionar.Text = "Adicionar";
            // 
            // novidadesToolStripMenuItem
            // 
            this.novidadesToolStripMenuItem.Name = "novidadesToolStripMenuItem";
            this.novidadesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.novidadesToolStripMenuItem.Text = "Novidades";
            this.novidadesToolStripMenuItem.Click += new System.EventHandler(this.novidadesToolStripMenuItem_Click);
            // 
            // adicionarNovaCategoriaToolStripMenuItem
            // 
            this.adicionarNovaCategoriaToolStripMenuItem.Name = "adicionarNovaCategoriaToolStripMenuItem";
            this.adicionarNovaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.adicionarNovaCategoriaToolStripMenuItem.Text = "Nova Categoria";
            this.adicionarNovaCategoriaToolStripMenuItem.Click += new System.EventHandler(this.adicionarNovaCategoriaToolStripMenuItem_Click);
            // 
            // manutençãoDosEquipamentosToolStripMenuItem
            // 
            this.manutençãoDosEquipamentosToolStripMenuItem.Name = "manutençãoDosEquipamentosToolStripMenuItem";
            this.manutençãoDosEquipamentosToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.manutençãoDosEquipamentosToolStripMenuItem.Text = "Manutenção dos Equipamentos";
            this.manutençãoDosEquipamentosToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDosEquipamentosToolStripMenuItem_Click);
            // 
            // unidadesToolStripMenuItem
            // 
            this.unidadesToolStripMenuItem.Name = "unidadesToolStripMenuItem";
            this.unidadesToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.unidadesToolStripMenuItem.Text = "Unidades";
            this.unidadesToolStripMenuItem.Click += new System.EventHandler(this.unidadesToolStripMenuItem_Click);
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(125, 22);
            this.tsmSair.Text = "Sair";
            this.tsmSair.Click += new System.EventHandler(this.tsmSair_Click);
            // 
            // tsmRegistro
            // 
            this.tsmRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioToolStripMenuItem});
            this.tsmRegistro.Name = "tsmRegistro";
            this.tsmRegistro.Size = new System.Drawing.Size(62, 20);
            this.tsmRegistro.Text = "Registro";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionário";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // infoCadastraisToolStripMenuItem
            // 
            this.infoCadastraisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.novidadesToolStripMenuItem1,
            this.unidadesToolStripMenuItem1});
            this.infoCadastraisToolStripMenuItem.Name = "infoCadastraisToolStripMenuItem";
            this.infoCadastraisToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.infoCadastraisToolStripMenuItem.Text = "Info. Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.clientesToolStripMenuItem.Text = "Cliente";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // novidadesToolStripMenuItem1
            // 
            this.novidadesToolStripMenuItem1.Name = "novidadesToolStripMenuItem1";
            this.novidadesToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.novidadesToolStripMenuItem1.Text = "Novidades";
            this.novidadesToolStripMenuItem1.Click += new System.EventHandler(this.novidadesToolStripMenuItem1_Click);
            // 
            // unidadesToolStripMenuItem1
            // 
            this.unidadesToolStripMenuItem1.Name = "unidadesToolStripMenuItem1";
            this.unidadesToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.unidadesToolStripMenuItem1.Text = "Unidades";
            this.unidadesToolStripMenuItem1.Click += new System.EventHandler(this.unidadesToolStripMenuItem1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAdicionar;
        private System.Windows.Forms.ToolStripMenuItem novidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarNovaCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDosEquipamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistro;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoCadastraisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unidadesToolStripMenuItem1;
    }
}