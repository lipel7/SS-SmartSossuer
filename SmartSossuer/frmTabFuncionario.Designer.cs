namespace SmartSossuer
{
    partial class frmTabFuncionario
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
            this.lblTabCpfFun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTabCpfFun = new System.Windows.Forms.TextBox();
            this.btnSairTabFun = new System.Windows.Forms.Button();
            this.btnDeletarTabFun = new System.Windows.Forms.Button();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTabCpfFun
            // 
            this.lblTabCpfFun.AutoSize = true;
            this.lblTabCpfFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabCpfFun.Location = new System.Drawing.Point(12, 82);
            this.lblTabCpfFun.Name = "lblTabCpfFun";
            this.lblTabCpfFun.Size = new System.Drawing.Size(170, 16);
            this.lblTabCpfFun.TabIndex = 17;
            this.lblTabCpfFun.Text = "Digite o CPF para localizar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tabela de Funcionários";
            // 
            // txtTabCpfFun
            // 
            this.txtTabCpfFun.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTabCpfFun.Location = new System.Drawing.Point(15, 101);
            this.txtTabCpfFun.Name = "txtTabCpfFun";
            this.txtTabCpfFun.Size = new System.Drawing.Size(280, 20);
            this.txtTabCpfFun.TabIndex = 15;
            // 
            // btnSairTabFun
            // 
            this.btnSairTabFun.Location = new System.Drawing.Point(389, 462);
            this.btnSairTabFun.Name = "btnSairTabFun";
            this.btnSairTabFun.Size = new System.Drawing.Size(75, 23);
            this.btnSairTabFun.TabIndex = 14;
            this.btnSairTabFun.Text = "Sair";
            this.btnSairTabFun.UseVisualStyleBackColor = true;
            this.btnSairTabFun.Click += new System.EventHandler(this.btnSairTabFun_Click);
            // 
            // btnDeletarTabFun
            // 
            this.btnDeletarTabFun.Location = new System.Drawing.Point(117, 462);
            this.btnDeletarTabFun.Name = "btnDeletarTabFun";
            this.btnDeletarTabFun.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarTabFun.TabIndex = 13;
            this.btnDeletarTabFun.Text = "Deletar";
            this.btnDeletarTabFun.UseVisualStyleBackColor = true;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(15, 143);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(549, 303);
            this.dgvFuncionario.TabIndex = 12;
            // 
            // frmTabFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(574, 503);
            this.Controls.Add(this.lblTabCpfFun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTabCpfFun);
            this.Controls.Add(this.btnSairTabFun);
            this.Controls.Add(this.btnDeletarTabFun);
            this.Controls.Add(this.dgvFuncionario);
            this.Name = "frmTabFuncionario";
            this.ShowIcon = false;
            this.Text = "Tabela Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabCpfFun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTabCpfFun;
        private System.Windows.Forms.Button btnSairTabFun;
        private System.Windows.Forms.Button btnDeletarTabFun;
        private System.Windows.Forms.DataGridView dgvFuncionario;
    }
}