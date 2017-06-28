namespace LES_17_I_N
{
    partial class frmsenha
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtususenha = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkmostrasenha = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblchances = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(207, 107);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtususenha
            // 
            this.txtususenha.Location = new System.Drawing.Point(24, 60);
            this.txtususenha.Name = "txtususenha";
            this.txtususenha.PasswordChar = '*';
            this.txtususenha.Size = new System.Drawing.Size(262, 20);
            this.txtususenha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // chkmostrasenha
            // 
            this.chkmostrasenha.AutoSize = true;
            this.chkmostrasenha.Location = new System.Drawing.Point(197, 40);
            this.chkmostrasenha.Name = "chkmostrasenha";
            this.chkmostrasenha.Size = new System.Drawing.Size(85, 17);
            this.chkmostrasenha.TabIndex = 3;
            this.chkmostrasenha.Text = "Exibir Senha";
            this.chkmostrasenha.UseVisualStyleBackColor = true;
            this.chkmostrasenha.CheckedChanged += new System.EventHandler(this.chkmostrasenha_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sua senha expirou, é importante que troque ela!";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(24, 107);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chances para trocar antes de bloquear:";
            // 
            // lblchances
            // 
            this.lblchances.AutoSize = true;
            this.lblchances.Location = new System.Drawing.Point(221, 83);
            this.lblchances.Name = "lblchances";
            this.lblchances.Size = new System.Drawing.Size(13, 13);
            this.lblchances.TabIndex = 7;
            this.lblchances.Text = "0";
            // 
            // frmsenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 142);
            this.Controls.Add(this.lblchances);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkmostrasenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtususenha);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox txtususenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkmostrasenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblchances;
    }
}