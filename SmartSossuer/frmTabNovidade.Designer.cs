namespace SmartSossuer
{
    partial class frmTabNovidade
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
            this.lblTabNovidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTabNovidade = new System.Windows.Forms.TextBox();
            this.btnSairTabNovidade = new System.Windows.Forms.Button();
            this.btnDeletarTabNovidade = new System.Windows.Forms.Button();
            this.dgvNovidade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTabNovidade
            // 
            this.lblTabNovidade.AutoSize = true;
            this.lblTabNovidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabNovidade.Location = new System.Drawing.Point(12, 82);
            this.lblTabNovidade.Name = "lblTabNovidade";
            this.lblTabNovidade.Size = new System.Drawing.Size(171, 16);
            this.lblTabNovidade.TabIndex = 17;
            this.lblTabNovidade.Text = "Digite o titulo para localizar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tabela Novidades";
            // 
            // txtTabNovidade
            // 
            this.txtTabNovidade.Location = new System.Drawing.Point(15, 101);
            this.txtTabNovidade.Name = "txtTabNovidade";
            this.txtTabNovidade.Size = new System.Drawing.Size(280, 20);
            this.txtTabNovidade.TabIndex = 15;
            // 
            // btnSairTabNovidade
            // 
            this.btnSairTabNovidade.Location = new System.Drawing.Point(389, 462);
            this.btnSairTabNovidade.Name = "btnSairTabNovidade";
            this.btnSairTabNovidade.Size = new System.Drawing.Size(75, 23);
            this.btnSairTabNovidade.TabIndex = 14;
            this.btnSairTabNovidade.Text = "Sair";
            this.btnSairTabNovidade.UseVisualStyleBackColor = true;
            this.btnSairTabNovidade.Click += new System.EventHandler(this.btnSairTabNovidade_Click);
            // 
            // btnDeletarTabNovidade
            // 
            this.btnDeletarTabNovidade.Location = new System.Drawing.Point(117, 462);
            this.btnDeletarTabNovidade.Name = "btnDeletarTabNovidade";
            this.btnDeletarTabNovidade.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarTabNovidade.TabIndex = 13;
            this.btnDeletarTabNovidade.Text = "Deletar";
            this.btnDeletarTabNovidade.UseVisualStyleBackColor = true;
            // 
            // dgvNovidade
            // 
            this.dgvNovidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNovidade.Location = new System.Drawing.Point(15, 143);
            this.dgvNovidade.Name = "dgvNovidade";
            this.dgvNovidade.Size = new System.Drawing.Size(549, 303);
            this.dgvNovidade.TabIndex = 12;
            // 
            // frmTabNovidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(574, 503);
            this.Controls.Add(this.lblTabNovidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTabNovidade);
            this.Controls.Add(this.btnSairTabNovidade);
            this.Controls.Add(this.btnDeletarTabNovidade);
            this.Controls.Add(this.dgvNovidade);
            this.Name = "frmTabNovidade";
            this.ShowIcon = false;
            this.Text = "Tabela Novidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabNovidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTabNovidade;
        private System.Windows.Forms.Button btnSairTabNovidade;
        private System.Windows.Forms.Button btnDeletarTabNovidade;
        private System.Windows.Forms.DataGridView dgvNovidade;
    }
}