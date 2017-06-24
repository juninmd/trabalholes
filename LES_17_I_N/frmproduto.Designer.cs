namespace LES_17_I_N
{
    partial class frmproduto
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
            this.tbcpro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvpro = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtproobs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtproloca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtproqtes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbounidade = new System.Windows.Forms.ComboBox();
            this.txtprovend = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprolucr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprocust = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkgrupo = new System.Windows.Forms.LinkLabel();
            this.cbogrupos = new System.Windows.Forms.ComboBox();
            this.txtpronome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprocodi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.tbcpro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpro)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcpro
            // 
            this.tbcpro.Controls.Add(this.tabPage1);
            this.tbcpro.Controls.Add(this.tabPage2);
            this.tbcpro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcpro.Location = new System.Drawing.Point(0, 0);
            this.tbcpro.Name = "tbcpro";
            this.tbcpro.SelectedIndex = 0;
            this.tbcpro.Size = new System.Drawing.Size(384, 361);
            this.tbcpro.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvpro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvpro
            // 
            this.dgvpro.AllowUserToAddRows = false;
            this.dgvpro.AllowUserToDeleteRows = false;
            this.dgvpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvpro.Location = new System.Drawing.Point(3, 3);
            this.dgvpro.Name = "dgvpro";
            this.dgvpro.ReadOnly = true;
            this.dgvpro.RowHeadersVisible = false;
            this.dgvpro.Size = new System.Drawing.Size(370, 329);
            this.dgvpro.TabIndex = 0;
            this.dgvpro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprod_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtproobs);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtproloca);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtproqtes);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.cbounidade);
            this.tabPage2.Controls.Add(this.txtprovend);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtprolucr);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtprocust);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lnkgrupo);
            this.tabPage2.Controls.Add(this.cbogrupos);
            this.tabPage2.Controls.Add(this.txtpronome);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtprocodi);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtproobs
            // 
            this.txtproobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtproobs.Location = new System.Drawing.Point(73, 205);
            this.txtproobs.MaxLength = 50;
            this.txtproobs.Name = "txtproobs";
            this.txtproobs.Size = new System.Drawing.Size(294, 20);
            this.txtproobs.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(18, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Obs.:";
            // 
            // txtproloca
            // 
            this.txtproloca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtproloca.Location = new System.Drawing.Point(73, 167);
            this.txtproloca.MaxLength = 50;
            this.txtproloca.Name = "txtproloca";
            this.txtproloca.Size = new System.Drawing.Size(294, 20);
            this.txtproloca.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(18, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Local:";
            // 
            // txtproqtes
            // 
            this.txtproqtes.Location = new System.Drawing.Point(73, 237);
            this.txtproqtes.Name = "txtproqtes";
            this.txtproqtes.Size = new System.Drawing.Size(71, 20);
            this.txtproqtes.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(6, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Qt. Estoque:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(11, 132);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 13);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Unidade:";
            // 
            // cbounidade
            // 
            this.cbounidade.FormattingEnabled = true;
            this.cbounidade.Location = new System.Drawing.Point(73, 129);
            this.cbounidade.Name = "cbounidade";
            this.cbounidade.Size = new System.Drawing.Size(294, 21);
            this.cbounidade.TabIndex = 33;
            // 
            // txtprovend
            // 
            this.txtprovend.Location = new System.Drawing.Point(266, 90);
            this.txtprovend.Name = "txtprovend";
            this.txtprovend.Size = new System.Drawing.Size(101, 20);
            this.txtprovend.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(201, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Venda R$:";
            // 
            // txtprolucr
            // 
            this.txtprolucr.Location = new System.Drawing.Point(242, 237);
            this.txtprolucr.Name = "txtprolucr";
            this.txtprolucr.Size = new System.Drawing.Size(105, 20);
            this.txtprolucr.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(188, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Lucro %:";
            // 
            // txtprocust
            // 
            this.txtprocust.Location = new System.Drawing.Point(73, 90);
            this.txtprocust.Name = "txtprocust";
            this.txtprocust.Size = new System.Drawing.Size(122, 20);
            this.txtprocust.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Custo R$:";
            // 
            // lnkgrupo
            // 
            this.lnkgrupo.AutoSize = true;
            this.lnkgrupo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkgrupo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkgrupo.LinkColor = System.Drawing.Color.Black;
            this.lnkgrupo.Location = new System.Drawing.Point(137, 21);
            this.lnkgrupo.Name = "lnkgrupo";
            this.lnkgrupo.Size = new System.Drawing.Size(39, 13);
            this.lnkgrupo.TabIndex = 22;
            this.lnkgrupo.TabStop = true;
            this.lnkgrupo.Text = "Grupo:";
            // 
            // cbogrupos
            // 
            this.cbogrupos.FormattingEnabled = true;
            this.cbogrupos.Location = new System.Drawing.Point(182, 17);
            this.cbogrupos.Name = "cbogrupos";
            this.cbogrupos.Size = new System.Drawing.Size(131, 21);
            this.cbogrupos.TabIndex = 23;
            // 
            // txtpronome
            // 
            this.txtpronome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpronome.Location = new System.Drawing.Point(72, 53);
            this.txtpronome.MaxLength = 50;
            this.txtpronome.Name = "txtpronome";
            this.txtpronome.Size = new System.Drawing.Size(272, 20);
            this.txtpronome.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nome:";
            // 
            // txtprocodi
            // 
            this.txtprocodi.Location = new System.Drawing.Point(73, 17);
            this.txtprocodi.Name = "txtprocodi";
            this.txtprocodi.Size = new System.Drawing.Size(51, 20);
            this.txtprocodi.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Codigo:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(292, 304);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 18;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(211, 304);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 17;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(49, 304);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(156, 23);
            this.btnincluir.TabIndex = 16;
            this.btnincluir.Text = "Incluir / Gravar";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // frmproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcpro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmproduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos produtos";
            this.Load += new System.EventHandler(this.frmproduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmproduto_KeyDown);
            this.tbcpro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcpro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvpro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtproobs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtproloca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtproqtes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cbounidade;
        private System.Windows.Forms.TextBox txtprovend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprolucr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprocust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkgrupo;
        private System.Windows.Forms.ComboBox cbogrupos;
        private System.Windows.Forms.TextBox txtpronome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprocodi;
        private System.Windows.Forms.Label label1;
    }
}