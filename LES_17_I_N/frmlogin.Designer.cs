namespace LES_17_I_N
{
    partial class frmlogin
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtususenha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusulogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkmostrasenha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(26, 221);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(222, 221);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "OK";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtususenha
            // 
            this.txtususenha.Location = new System.Drawing.Point(26, 163);
            this.txtususenha.Name = "txtususenha";
            this.txtususenha.PasswordChar = '*';
            this.txtususenha.Size = new System.Drawing.Size(262, 20);
            this.txtususenha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
            // 
            // txtusulogin
            // 
            this.txtusulogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusulogin.Location = new System.Drawing.Point(26, 101);
            this.txtusulogin.MaxLength = 20;
            this.txtusulogin.Name = "txtusulogin";
            this.txtusulogin.Size = new System.Drawing.Size(262, 20);
            this.txtusulogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // chkmostrasenha
            // 
            this.chkmostrasenha.AutoSize = true;
            this.chkmostrasenha.Location = new System.Drawing.Point(199, 143);
            this.chkmostrasenha.Name = "chkmostrasenha";
            this.chkmostrasenha.Size = new System.Drawing.Size(85, 17);
            this.chkmostrasenha.TabIndex = 3;
            this.chkmostrasenha.Text = "Exibir Senha";
            this.chkmostrasenha.UseVisualStyleBackColor = true;
            this.chkmostrasenha.CheckedChanged += new System.EventHandler(this.chkmostrasenha_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 47);
            this.label3.TabIndex = 7;
            this.label3.Text = "LES 17 I N";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkmostrasenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusulogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtususenha);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.MaskedTextBox txtususenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusulogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkmostrasenha;
        private System.Windows.Forms.Label label3;
    }
}