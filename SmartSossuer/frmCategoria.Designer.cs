namespace SmartSossuer
{
    partial class frmCategoria
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
            this.btnLimparCat = new System.Windows.Forms.Button();
            this.btnSairCat = new System.Windows.Forms.Button();
            this.btnSalvarCat = new System.Windows.Forms.Button();
            this.rtbDescricaoCategoria = new System.Windows.Forms.RichTextBox();
            this.lblDescricaoCat = new System.Windows.Forms.Label();
            this.txtQuantFunCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoriaTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimparCat
            // 
            this.btnLimparCat.Location = new System.Drawing.Point(275, 449);
            this.btnLimparCat.Name = "btnLimparCat";
            this.btnLimparCat.Size = new System.Drawing.Size(75, 23);
            this.btnLimparCat.TabIndex = 29;
            this.btnLimparCat.Text = "Limpar";
            this.btnLimparCat.UseVisualStyleBackColor = true;
            // 
            // btnSairCat
            // 
            this.btnSairCat.Location = new System.Drawing.Point(384, 449);
            this.btnSairCat.Name = "btnSairCat";
            this.btnSairCat.Size = new System.Drawing.Size(75, 23);
            this.btnSairCat.TabIndex = 28;
            this.btnSairCat.Text = "Sair";
            this.btnSairCat.UseVisualStyleBackColor = true;
            this.btnSairCat.Click += new System.EventHandler(this.btnSairCat_Click);
            // 
            // btnSalvarCat
            // 
            this.btnSalvarCat.Location = new System.Drawing.Point(168, 449);
            this.btnSalvarCat.Name = "btnSalvarCat";
            this.btnSalvarCat.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCat.TabIndex = 27;
            this.btnSalvarCat.Text = "Salvar";
            this.btnSalvarCat.UseVisualStyleBackColor = true;
            // 
            // rtbDescricaoCategoria
            // 
            this.rtbDescricaoCategoria.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtbDescricaoCategoria.Location = new System.Drawing.Point(32, 217);
            this.rtbDescricaoCategoria.Name = "rtbDescricaoCategoria";
            this.rtbDescricaoCategoria.Size = new System.Drawing.Size(564, 211);
            this.rtbDescricaoCategoria.TabIndex = 26;
            this.rtbDescricaoCategoria.Text = "";
            // 
            // lblDescricaoCat
            // 
            this.lblDescricaoCat.AutoSize = true;
            this.lblDescricaoCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoCat.Location = new System.Drawing.Point(29, 196);
            this.lblDescricaoCat.Name = "lblDescricaoCat";
            this.lblDescricaoCat.Size = new System.Drawing.Size(165, 18);
            this.lblDescricaoCat.TabIndex = 25;
            this.lblDescricaoCat.Text = "Descrição da categoria:";
            // 
            // txtQuantFunCategoria
            // 
            this.txtQuantFunCategoria.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtQuantFunCategoria.Location = new System.Drawing.Point(227, 127);
            this.txtQuantFunCategoria.Name = "txtQuantFunCategoria";
            this.txtQuantFunCategoria.Size = new System.Drawing.Size(113, 20);
            this.txtQuantFunCategoria.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Quantidade de funcionarios:";
            // 
            // txtCategoriaTitulo
            // 
            this.txtCategoriaTitulo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCategoriaTitulo.Location = new System.Drawing.Point(110, 76);
            this.txtCategoriaTitulo.Name = "txtCategoriaTitulo";
            this.txtCategoriaTitulo.Size = new System.Drawing.Size(230, 20);
            this.txtCategoriaTitulo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Categoria:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(28, 29);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(232, 20);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "Informações da nova categoria:";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(624, 501);
            this.Controls.Add(this.btnLimparCat);
            this.Controls.Add(this.btnSairCat);
            this.Controls.Add(this.btnSalvarCat);
            this.Controls.Add(this.rtbDescricaoCategoria);
            this.Controls.Add(this.lblDescricaoCat);
            this.Controls.Add(this.txtQuantFunCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategoriaTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCategoria);
            this.Name = "frmCategoria";
            this.ShowIcon = false;
            this.Text = "Informações da Nova Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimparCat;
        private System.Windows.Forms.Button btnSairCat;
        private System.Windows.Forms.Button btnSalvarCat;
        private System.Windows.Forms.RichTextBox rtbDescricaoCategoria;
        private System.Windows.Forms.Label lblDescricaoCat;
        private System.Windows.Forms.TextBox txtQuantFunCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoriaTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategoria;
    }
}