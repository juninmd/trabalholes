namespace LES_17_I_N
{
    partial class frmhorario
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
            this.tbcestado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvgestado = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txthoruf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txthoricms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbltip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txthornome = new System.Windows.Forms.TextBox();
            this.txthorcodi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcestado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgestado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcestado
            // 
            this.tbcestado.Controls.Add(this.tabPage1);
            this.tbcestado.Controls.Add(this.tabPage2);
            this.tbcestado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcestado.Location = new System.Drawing.Point(0, 0);
            this.tbcestado.Name = "tbcestado";
            this.tbcestado.SelectedIndex = 0;
            this.tbcestado.Size = new System.Drawing.Size(384, 361);
            this.tbcestado.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvgestado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvgestado
            // 
            this.dvgestado.AllowUserToAddRows = false;
            this.dvgestado.AllowUserToDeleteRows = false;
            this.dvgestado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgestado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgestado.Location = new System.Drawing.Point(3, 3);
            this.dvgestado.Name = "dvgestado";
            this.dvgestado.ReadOnly = true;
            this.dvgestado.RowHeadersVisible = false;
            this.dvgestado.Size = new System.Drawing.Size(370, 329);
            this.dvgestado.TabIndex = 0;
            this.dvgestado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgestado_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txthoruf);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txthoricms);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbltip);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txthornome);
            this.tabPage2.Controls.Add(this.txthorcodi);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txthoruf
            // 
            this.txthoruf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthoruf.Location = new System.Drawing.Point(118, 154);
            this.txthoruf.Name = "txthoruf";
            this.txthoruf.Size = new System.Drawing.Size(50, 20);
            this.txthoruf.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "UF:";
            // 
            // txthoricms
            // 
            this.txthoricms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthoricms.Location = new System.Drawing.Point(118, 121);
            this.txthoricms.Name = "txthoricms";
            this.txthoricms.Size = new System.Drawing.Size(250, 20);
            this.txthoricms.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CMS:";
            // 
            // cbltip
            // 
            this.cbltip.FormattingEnabled = true;
            this.cbltip.Location = new System.Drawing.Point(118, 87);
            this.cbltip.Name = "cbltip";
            this.cbltip.Size = new System.Drawing.Size(250, 21);
            this.cbltip.TabIndex = 9;
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
            // txthornome
            // 
            this.txthornome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthornome.Location = new System.Drawing.Point(118, 55);
            this.txthornome.Name = "txthornome";
            this.txthornome.Size = new System.Drawing.Size(250, 20);
            this.txthornome.TabIndex = 2;
            // 
            // txthorcodi
            // 
            this.txthorcodi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthorcodi.Location = new System.Drawing.Point(118, 29);
            this.txthorcodi.Name = "txthorcodi";
            this.txthorcodi.Size = new System.Drawing.Size(50, 20);
            this.txthorcodi.TabIndex = 1;
            this.txthorcodi.Leave += new System.EventHandler(this.txtpaicodi_Leave);
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
            // frmhorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcestado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmhorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Horários";
            this.Load += new System.EventHandler(this.frmhoraio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmhoraio_KeyDown);
            this.tbcestado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgestado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcestado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthornome;
        private System.Windows.Forms.TextBox txthorcodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbltip;
        private System.Windows.Forms.DataGridView dvgestado;
        private System.Windows.Forms.TextBox txthoruf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthoricms;
        private System.Windows.Forms.Label label4;
    }
}