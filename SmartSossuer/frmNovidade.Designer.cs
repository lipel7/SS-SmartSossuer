namespace SmartSossuer
{
    partial class frmNovidade
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
            this.btnSairNovi = new System.Windows.Forms.Button();
            this.btnLimparNovi = new System.Windows.Forms.Button();
            this.btnSalvarNovi = new System.Windows.Forms.Button();
            this.rtbDescricaoNovi = new System.Windows.Forms.RichTextBox();
            this.txtTituloNovi = new System.Windows.Forms.TextBox();
            this.lblDescricaoNovi = new System.Windows.Forms.Label();
            this.lblTituloNovi = new System.Windows.Forms.Label();
            this.lblNovidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSairNovi
            // 
            this.btnSairNovi.Location = new System.Drawing.Point(322, 395);
            this.btnSairNovi.Name = "btnSairNovi";
            this.btnSairNovi.Size = new System.Drawing.Size(75, 23);
            this.btnSairNovi.TabIndex = 39;
            this.btnSairNovi.Text = "Sair";
            this.btnSairNovi.UseVisualStyleBackColor = true;
            this.btnSairNovi.Click += new System.EventHandler(this.btnSairNovi_Click);
            // 
            // btnLimparNovi
            // 
            this.btnLimparNovi.Location = new System.Drawing.Point(214, 395);
            this.btnLimparNovi.Name = "btnLimparNovi";
            this.btnLimparNovi.Size = new System.Drawing.Size(75, 23);
            this.btnLimparNovi.TabIndex = 38;
            this.btnLimparNovi.Text = "Limpar";
            this.btnLimparNovi.UseVisualStyleBackColor = true;
            // 
            // btnSalvarNovi
            // 
            this.btnSalvarNovi.Location = new System.Drawing.Point(106, 395);
            this.btnSalvarNovi.Name = "btnSalvarNovi";
            this.btnSalvarNovi.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarNovi.TabIndex = 37;
            this.btnSalvarNovi.Text = "Salvar";
            this.btnSalvarNovi.UseVisualStyleBackColor = true;
            // 
            // rtbDescricaoNovi
            // 
            this.rtbDescricaoNovi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtbDescricaoNovi.Location = new System.Drawing.Point(16, 164);
            this.rtbDescricaoNovi.Name = "rtbDescricaoNovi";
            this.rtbDescricaoNovi.Size = new System.Drawing.Size(467, 211);
            this.rtbDescricaoNovi.TabIndex = 36;
            this.rtbDescricaoNovi.Text = "";
            // 
            // txtTituloNovi
            // 
            this.txtTituloNovi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTituloNovi.Location = new System.Drawing.Point(71, 81);
            this.txtTituloNovi.Name = "txtTituloNovi";
            this.txtTituloNovi.Size = new System.Drawing.Size(262, 20);
            this.txtTituloNovi.TabIndex = 35;
            // 
            // lblDescricaoNovi
            // 
            this.lblDescricaoNovi.AutoSize = true;
            this.lblDescricaoNovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoNovi.Location = new System.Drawing.Point(13, 143);
            this.lblDescricaoNovi.Name = "lblDescricaoNovi";
            this.lblDescricaoNovi.Size = new System.Drawing.Size(163, 18);
            this.lblDescricaoNovi.TabIndex = 34;
            this.lblDescricaoNovi.Text = "Descrição da novidade:";
            // 
            // lblTituloNovi
            // 
            this.lblTituloNovi.AutoSize = true;
            this.lblTituloNovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNovi.Location = new System.Drawing.Point(17, 80);
            this.lblTituloNovi.Name = "lblTituloNovi";
            this.lblTituloNovi.Size = new System.Drawing.Size(48, 18);
            this.lblTituloNovi.TabIndex = 33;
            this.lblTituloNovi.Text = "Titulo:";
            // 
            // lblNovidade
            // 
            this.lblNovidade.AutoSize = true;
            this.lblNovidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovidade.Location = new System.Drawing.Point(16, 17);
            this.lblNovidade.Name = "lblNovidade";
            this.lblNovidade.Size = new System.Drawing.Size(145, 20);
            this.lblNovidade.TabIndex = 32;
            this.lblNovidade.Text = "Adicionar Novidade";
            // 
            // frmNovidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(497, 434);
            this.Controls.Add(this.btnSairNovi);
            this.Controls.Add(this.btnLimparNovi);
            this.Controls.Add(this.btnSalvarNovi);
            this.Controls.Add(this.rtbDescricaoNovi);
            this.Controls.Add(this.txtTituloNovi);
            this.Controls.Add(this.lblDescricaoNovi);
            this.Controls.Add(this.lblTituloNovi);
            this.Controls.Add(this.lblNovidade);
            this.Name = "frmNovidade";
            this.ShowIcon = false;
            this.Text = "Adicionar Novidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSairNovi;
        private System.Windows.Forms.Button btnLimparNovi;
        private System.Windows.Forms.Button btnSalvarNovi;
        private System.Windows.Forms.RichTextBox rtbDescricaoNovi;
        private System.Windows.Forms.TextBox txtTituloNovi;
        private System.Windows.Forms.Label lblDescricaoNovi;
        private System.Windows.Forms.Label lblTituloNovi;
        private System.Windows.Forms.Label lblNovidade;
    }
}