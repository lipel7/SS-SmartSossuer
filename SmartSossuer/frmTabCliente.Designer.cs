namespace SmartSossuer
{
    partial class frmTabCliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblTabCpfClie = new System.Windows.Forms.Label();
            this.lblTabClie = new System.Windows.Forms.Label();
            this.txtTabCpfClie = new System.Windows.Forms.TextBox();
            this.btnSairTabClie = new System.Windows.Forms.Button();
            this.btnDeletarTabClie = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // lblTabCpfClie
            // 
            this.lblTabCpfClie.AutoSize = true;
            this.lblTabCpfClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabCpfClie.Location = new System.Drawing.Point(12, 82);
            this.lblTabCpfClie.Name = "lblTabCpfClie";
            this.lblTabCpfClie.Size = new System.Drawing.Size(170, 16);
            this.lblTabCpfClie.TabIndex = 12;
            this.lblTabCpfClie.Text = "Digite o CPF para localizar:";
            // 
            // lblTabClie
            // 
            this.lblTabClie.AutoSize = true;
            this.lblTabClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabClie.Location = new System.Drawing.Point(11, 18);
            this.lblTabClie.Name = "lblTabClie";
            this.lblTabClie.Size = new System.Drawing.Size(140, 20);
            this.lblTabClie.TabIndex = 11;
            this.lblTabClie.Text = "Tabela de Clientes";
            // 
            // txtTabCpfClie
            // 
            this.txtTabCpfClie.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTabCpfClie.Location = new System.Drawing.Point(15, 101);
            this.txtTabCpfClie.Name = "txtTabCpfClie";
            this.txtTabCpfClie.Size = new System.Drawing.Size(280, 20);
            this.txtTabCpfClie.TabIndex = 10;
            // 
            // btnSairTabClie
            // 
            this.btnSairTabClie.Location = new System.Drawing.Point(389, 462);
            this.btnSairTabClie.Name = "btnSairTabClie";
            this.btnSairTabClie.Size = new System.Drawing.Size(75, 23);
            this.btnSairTabClie.TabIndex = 9;
            this.btnSairTabClie.Text = "Sair";
            this.btnSairTabClie.UseVisualStyleBackColor = true;
            this.btnSairTabClie.Click += new System.EventHandler(this.btnSairTabClie_Click);
            // 
            // btnDeletarTabClie
            // 
            this.btnDeletarTabClie.Location = new System.Drawing.Point(117, 462);
            this.btnDeletarTabClie.Name = "btnDeletarTabClie";
            this.btnDeletarTabClie.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarTabClie.TabIndex = 8;
            this.btnDeletarTabClie.Text = "Deletar";
            this.btnDeletarTabClie.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(15, 143);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(549, 303);
            this.dgvCliente.TabIndex = 7;
            // 
            // frmTabCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(574, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTabCpfClie);
            this.Controls.Add(this.lblTabClie);
            this.Controls.Add(this.txtTabCpfClie);
            this.Controls.Add(this.btnSairTabClie);
            this.Controls.Add(this.btnDeletarTabClie);
            this.Controls.Add(this.dgvCliente);
            this.Name = "frmTabCliente";
            this.ShowIcon = false;
            this.Text = "Tabela Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTabCpfClie;
        private System.Windows.Forms.Label lblTabClie;
        private System.Windows.Forms.TextBox txtTabCpfClie;
        private System.Windows.Forms.Button btnSairTabClie;
        private System.Windows.Forms.Button btnDeletarTabClie;
        private System.Windows.Forms.DataGridView dgvCliente;
    }
}