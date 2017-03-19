namespace LES_17_I_N
{
    partial class frmestado
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
            this.tbcpais = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvpais = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpainome = new System.Windows.Forms.TextBox();
            this.txtpaicodi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cblPais = new System.Windows.Forms.ComboBox();
            this.tbcpais.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpais)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcpais
            // 
            this.tbcpais.Controls.Add(this.tabPage1);
            this.tbcpais.Controls.Add(this.tabPage2);
            this.tbcpais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcpais.Location = new System.Drawing.Point(0, 0);
            this.tbcpais.Name = "tbcpais";
            this.tbcpais.SelectedIndex = 0;
            this.tbcpais.Size = new System.Drawing.Size(384, 361);
            this.tbcpais.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvpais);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvpais
            // 
            this.dgvpais.AllowUserToAddRows = false;
            this.dgvpais.AllowUserToDeleteRows = false;
            this.dgvpais.AllowUserToOrderColumns = true;
            this.dgvpais.AllowUserToResizeRows = false;
            this.dgvpais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpais.Location = new System.Drawing.Point(3, 3);
            this.dgvpais.Name = "dgvpais";
            this.dgvpais.ReadOnly = true;
            this.dgvpais.RowHeadersVisible = false;
            this.dgvpais.Size = new System.Drawing.Size(370, 329);
            this.dgvpais.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cblPais);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtpainome);
            this.tabPage2.Controls.Add(this.txtpaicodi);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtpainome
            // 
            this.txtpainome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpainome.Location = new System.Drawing.Point(118, 55);
            this.txtpainome.Name = "txtpainome";
            this.txtpainome.Size = new System.Drawing.Size(250, 20);
            this.txtpainome.TabIndex = 2;
            // 
            // txtpaicodi
            // 
            this.txtpaicodi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpaicodi.Location = new System.Drawing.Point(118, 29);
            this.txtpaicodi.Name = "txtpaicodi";
            this.txtpaicodi.Size = new System.Drawing.Size(50, 20);
            this.txtpaicodi.TabIndex = 1;
            this.txtpaicodi.Leave += new System.EventHandler(this.txtpaicodi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "País: ";
            // 
            // cblPais
            // 
            this.cblPais.FormattingEnabled = true;
            this.cblPais.Location = new System.Drawing.Point(118, 87);
            this.cblPais.Name = "cblPais";
            this.cblPais.Size = new System.Drawing.Size(250, 21);
            this.cblPais.TabIndex = 9;
            // 
            // frmestado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcpais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmestado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Estados";
            this.Load += new System.EventHandler(this.frmestado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmestado_KeyDown);
            this.tbcpais.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpais)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcpais;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpainome;
        private System.Windows.Forms.TextBox txtpaicodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.DataGridView dgvpais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cblPais;
    }
}