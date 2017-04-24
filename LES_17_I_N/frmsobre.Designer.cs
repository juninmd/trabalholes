namespace LES_17_I_N
{
    partial class frmsobre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcidadeuf = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.pctautor = new System.Windows.Forms.PictureBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctautor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cidade-UF:";
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(127, 13);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(245, 20);
            this.txtautor.TabIndex = 4;
            this.txtautor.Text = "Antonio Carlos";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(127, 42);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(245, 20);
            this.txtemail.TabIndex = 5;
            this.txtemail.Text = "jr_acn@hotmail.com";
            // 
            // txtcidadeuf
            // 
            this.txtcidadeuf.Location = new System.Drawing.Point(127, 105);
            this.txtcidadeuf.Name = "txtcidadeuf";
            this.txtcidadeuf.Size = new System.Drawing.Size(245, 20);
            this.txtcidadeuf.TabIndex = 6;
            this.txtcidadeuf.Text = "Franca - SP";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(127, 74);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(245, 20);
            this.txtcelular.TabIndex = 7;
            this.txtcelular.Text = "(16) 99241.1372";
            // 
            // pctautor
            // 
            this.pctautor.Image = global::LES_17_I_N.Properties.Resources.vNlsRbF;
            this.pctautor.Location = new System.Drawing.Point(127, 144);
            this.pctautor.Name = "pctautor";
            this.pctautor.Size = new System.Drawing.Size(245, 205);
            this.pctautor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctautor.TabIndex = 8;
            this.pctautor.TabStop = false;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(25, 311);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmsobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.pctautor);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtcidadeuf);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados do Autor";
            ((System.ComponentModel.ISupportInitialize)(this.pctautor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcidadeuf;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.PictureBox pctautor;
        private System.Windows.Forms.Button btnvoltar;
    }
}