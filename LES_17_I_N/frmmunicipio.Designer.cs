namespace LES_17_I_N
{
    partial class frmmunicipio
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
            this.tbcmunicipio = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvgmunicipio = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cblest = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmunnome = new System.Windows.Forms.TextBox();
            this.txtmuncodi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcmunicipio.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgmunicipio)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcmunicipio
            // 
            this.tbcmunicipio.Controls.Add(this.tabPage1);
            this.tbcmunicipio.Controls.Add(this.tabPage2);
            this.tbcmunicipio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcmunicipio.Location = new System.Drawing.Point(0, 0);
            this.tbcmunicipio.Name = "tbcmunicipio";
            this.tbcmunicipio.SelectedIndex = 0;
            this.tbcmunicipio.Size = new System.Drawing.Size(384, 361);
            this.tbcmunicipio.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvgmunicipio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvgmunicipio
            // 
            this.dvgmunicipio.AllowUserToAddRows = false;
            this.dvgmunicipio.AllowUserToDeleteRows = false;
            this.dvgmunicipio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgmunicipio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgmunicipio.Location = new System.Drawing.Point(3, 3);
            this.dvgmunicipio.Name = "dvgmunicipio";
            this.dvgmunicipio.ReadOnly = true;
            this.dvgmunicipio.RowHeadersVisible = false;
            this.dvgmunicipio.Size = new System.Drawing.Size(370, 329);
            this.dvgmunicipio.TabIndex = 0;
            this.dvgmunicipio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgmunicipio_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cblest);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtmunnome);
            this.tabPage2.Controls.Add(this.txtmuncodi);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cblest
            // 
            this.cblest.FormattingEnabled = true;
            this.cblest.Location = new System.Drawing.Point(118, 87);
            this.cblest.Name = "cblest";
            this.cblest.Size = new System.Drawing.Size(250, 21);
            this.cblest.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado: ";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(275, 294);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(194, 294);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 6;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(32, 294);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(156, 23);
            this.btnincluir.TabIndex = 4;
            this.btnincluir.Text = "Incluir / Gravar";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtmunnome
            // 
            this.txtmunnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmunnome.Location = new System.Drawing.Point(118, 55);
            this.txtmunnome.Name = "txtmunnome";
            this.txtmunnome.Size = new System.Drawing.Size(250, 20);
            this.txtmunnome.TabIndex = 2;
            // 
            // txtmuncodi
            // 
            this.txtmuncodi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmuncodi.Location = new System.Drawing.Point(118, 29);
            this.txtmuncodi.Name = "txtmuncodi";
            this.txtmuncodi.Size = new System.Drawing.Size(50, 20);
            this.txtmuncodi.TabIndex = 1;
            this.txtmuncodi.Leave += new System.EventHandler(this.txtpaicodi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // frmmunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcmunicipio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos municipios";
            this.Load += new System.EventHandler(this.frmmunicipio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmmunicipio_KeyDown);
            this.tbcmunicipio.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgmunicipio)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcmunicipio;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmunnome;
        private System.Windows.Forms.TextBox txtmuncodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cblest;
        private System.Windows.Forms.DataGridView dvgmunicipio;
    }
}