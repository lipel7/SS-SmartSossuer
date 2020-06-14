namespace SmartSossuer
{
    partial class frmEquipamentos
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
            this.txtDtEntregaEquip = new System.Windows.Forms.TextBox();
            this.txtDtSolicitacaoEquip = new System.Windows.Forms.TextBox();
            this.btnSairEquip = new System.Windows.Forms.Button();
            this.btnLimparEquip = new System.Windows.Forms.Button();
            this.btnSalvarEquip = new System.Windows.Forms.Button();
            this.rtbDescricaoEquip = new System.Windows.Forms.RichTextBox();
            this.txtEquipamento = new System.Windows.Forms.TextBox();
            this.lblDescricaoEquip = new System.Windows.Forms.Label();
            this.lblDtEntregaEquip = new System.Windows.Forms.Label();
            this.lblDtSolicitacaoEquip = new System.Windows.Forms.Label();
            this.lblEquipamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDtEntregaEquip
            // 
            this.txtDtEntregaEquip.Location = new System.Drawing.Point(166, 137);
            this.txtDtEntregaEquip.Name = "txtDtEntregaEquip";
            this.txtDtEntregaEquip.Size = new System.Drawing.Size(100, 20);
            this.txtDtEntregaEquip.TabIndex = 37;
            // 
            // txtDtSolicitacaoEquip
            // 
            this.txtDtSolicitacaoEquip.Location = new System.Drawing.Point(166, 103);
            this.txtDtSolicitacaoEquip.Name = "txtDtSolicitacaoEquip";
            this.txtDtSolicitacaoEquip.Size = new System.Drawing.Size(100, 20);
            this.txtDtSolicitacaoEquip.TabIndex = 36;
            // 
            // btnSairEquip
            // 
            this.btnSairEquip.Location = new System.Drawing.Point(376, 441);
            this.btnSairEquip.Name = "btnSairEquip";
            this.btnSairEquip.Size = new System.Drawing.Size(75, 23);
            this.btnSairEquip.TabIndex = 35;
            this.btnSairEquip.Text = "Sair";
            this.btnSairEquip.UseVisualStyleBackColor = true;
            this.btnSairEquip.Click += new System.EventHandler(this.btnSairEquip_Click);
            // 
            // btnLimparEquip
            // 
            this.btnLimparEquip.Location = new System.Drawing.Point(268, 441);
            this.btnLimparEquip.Name = "btnLimparEquip";
            this.btnLimparEquip.Size = new System.Drawing.Size(75, 23);
            this.btnLimparEquip.TabIndex = 34;
            this.btnLimparEquip.Text = "Limpar";
            this.btnLimparEquip.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEquip
            // 
            this.btnSalvarEquip.Location = new System.Drawing.Point(160, 441);
            this.btnSalvarEquip.Name = "btnSalvarEquip";
            this.btnSalvarEquip.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEquip.TabIndex = 33;
            this.btnSalvarEquip.Text = "Salvar";
            this.btnSalvarEquip.UseVisualStyleBackColor = true;
            // 
            // rtbDescricaoEquip
            // 
            this.rtbDescricaoEquip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rtbDescricaoEquip.Location = new System.Drawing.Point(29, 214);
            this.rtbDescricaoEquip.Name = "rtbDescricaoEquip";
            this.rtbDescricaoEquip.Size = new System.Drawing.Size(564, 211);
            this.rtbDescricaoEquip.TabIndex = 32;
            this.rtbDescricaoEquip.Text = "";
            // 
            // txtEquipamento
            // 
            this.txtEquipamento.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtEquipamento.Location = new System.Drawing.Point(135, 72);
            this.txtEquipamento.Name = "txtEquipamento";
            this.txtEquipamento.Size = new System.Drawing.Size(300, 20);
            this.txtEquipamento.TabIndex = 31;
            // 
            // lblDescricaoEquip
            // 
            this.lblDescricaoEquip.AutoSize = true;
            this.lblDescricaoEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoEquip.Location = new System.Drawing.Point(30, 193);
            this.lblDescricaoEquip.Name = "lblDescricaoEquip";
            this.lblDescricaoEquip.Size = new System.Drawing.Size(186, 18);
            this.lblDescricaoEquip.TabIndex = 30;
            this.lblDescricaoEquip.Text = "Descrição da manutenção:";
            // 
            // lblDtEntregaEquip
            // 
            this.lblDtEntregaEquip.AutoSize = true;
            this.lblDtEntregaEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtEntregaEquip.Location = new System.Drawing.Point(30, 139);
            this.lblDtEntregaEquip.Name = "lblDtEntregaEquip";
            this.lblDtEntregaEquip.Size = new System.Drawing.Size(116, 18);
            this.lblDtEntregaEquip.TabIndex = 29;
            this.lblDtEntregaEquip.Text = "Data de entrega:";
            // 
            // lblDtSolicitacaoEquip
            // 
            this.lblDtSolicitacaoEquip.AutoSize = true;
            this.lblDtSolicitacaoEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtSolicitacaoEquip.Location = new System.Drawing.Point(30, 105);
            this.lblDtSolicitacaoEquip.Name = "lblDtSolicitacaoEquip";
            this.lblDtSolicitacaoEquip.Size = new System.Drawing.Size(138, 18);
            this.lblDtSolicitacaoEquip.TabIndex = 28;
            this.lblDtSolicitacaoEquip.Text = "Data de solicitação:";
            // 
            // lblEquipamento
            // 
            this.lblEquipamento.AutoSize = true;
            this.lblEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipamento.Location = new System.Drawing.Point(30, 72);
            this.lblEquipamento.Name = "lblEquipamento";
            this.lblEquipamento.Size = new System.Drawing.Size(99, 18);
            this.lblEquipamento.TabIndex = 27;
            this.lblEquipamento.Text = "Equipamento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Manutenção dos equipamentos:";
            // 
            // frmEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(623, 485);
            this.Controls.Add(this.txtDtEntregaEquip);
            this.Controls.Add(this.txtDtSolicitacaoEquip);
            this.Controls.Add(this.btnSairEquip);
            this.Controls.Add(this.btnLimparEquip);
            this.Controls.Add(this.btnSalvarEquip);
            this.Controls.Add(this.rtbDescricaoEquip);
            this.Controls.Add(this.txtEquipamento);
            this.Controls.Add(this.lblDescricaoEquip);
            this.Controls.Add(this.lblDtEntregaEquip);
            this.Controls.Add(this.lblDtSolicitacaoEquip);
            this.Controls.Add(this.lblEquipamento);
            this.Controls.Add(this.label1);
            this.Name = "frmEquipamentos";
            this.ShowIcon = false;
            this.Text = "Manutenção dos Equipamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDtEntregaEquip;
        private System.Windows.Forms.TextBox txtDtSolicitacaoEquip;
        private System.Windows.Forms.Button btnSairEquip;
        private System.Windows.Forms.Button btnLimparEquip;
        private System.Windows.Forms.Button btnSalvarEquip;
        private System.Windows.Forms.RichTextBox rtbDescricaoEquip;
        private System.Windows.Forms.TextBox txtEquipamento;
        private System.Windows.Forms.Label lblDescricaoEquip;
        private System.Windows.Forms.Label lblDtEntregaEquip;
        private System.Windows.Forms.Label lblDtSolicitacaoEquip;
        private System.Windows.Forms.Label lblEquipamento;
        private System.Windows.Forms.Label label1;
    }
}