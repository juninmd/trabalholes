namespace LES_17_I_N
{
    partial class frmusuario
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
            this.tbcusuario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvusuario = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpusuexpira = new System.Windows.Forms.DateTimePicker();
            this.cblnivelacesso = new System.Windows.Forms.ComboBox();
            this.cblfuncionario = new System.Windows.Forms.ComboBox();
            this.txtususenha = new System.Windows.Forms.MaskedTextBox();
            this.txtusuchances = new System.Windows.Forms.MaskedTextBox();
            this.chkcontabloqueada = new System.Windows.Forms.CheckBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusunome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcusuario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcusuario
            // 
            this.tbcusuario.Controls.Add(this.tabPage1);
            this.tbcusuario.Controls.Add(this.tabPage2);
            this.tbcusuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcusuario.Location = new System.Drawing.Point(0, 0);
            this.tbcusuario.Name = "tbcusuario";
            this.tbcusuario.SelectedIndex = 0;
            this.tbcusuario.Size = new System.Drawing.Size(384, 361);
            this.tbcusuario.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvusuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvusuario
            // 
            this.dgvusuario.AllowUserToAddRows = false;
            this.dgvusuario.AllowUserToDeleteRows = false;
            this.dgvusuario.AllowUserToOrderColumns = true;
            this.dgvusuario.AllowUserToResizeRows = false;
            this.dgvusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvusuario.Location = new System.Drawing.Point(3, 3);
            this.dgvusuario.Name = "dgvusuario";
            this.dgvusuario.ReadOnly = true;
            this.dgvusuario.RowHeadersVisible = false;
            this.dgvusuario.Size = new System.Drawing.Size(370, 329);
            this.dgvusuario.TabIndex = 0;
            this.dgvusuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpais_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpusuexpira);
            this.tabPage2.Controls.Add(this.cblnivelacesso);
            this.tabPage2.Controls.Add(this.cblfuncionario);
            this.tabPage2.Controls.Add(this.txtususenha);
            this.tabPage2.Controls.Add(this.txtusuchances);
            this.tabPage2.Controls.Add(this.chkcontabloqueada);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtusunome);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpusuexpira
            // 
            this.dtpusuexpira.Location = new System.Drawing.Point(99, 176);
            this.dtpusuexpira.Name = "dtpusuexpira";
            this.dtpusuexpira.Size = new System.Drawing.Size(249, 20);
            this.dtpusuexpira.TabIndex = 13;
            // 
            // cblnivelacesso
            // 
            this.cblnivelacesso.FormattingEnabled = true;
            this.cblnivelacesso.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cblnivelacesso.Location = new System.Drawing.Point(99, 139);
            this.cblnivelacesso.Name = "cblnivelacesso";
            this.cblnivelacesso.Size = new System.Drawing.Size(108, 21);
            this.cblnivelacesso.TabIndex = 12;
            // 
            // cblfuncionario
            // 
            this.cblfuncionario.FormattingEnabled = true;
            this.cblfuncionario.Location = new System.Drawing.Point(99, 64);
            this.cblfuncionario.Name = "cblfuncionario";
            this.cblfuncionario.Size = new System.Drawing.Size(249, 21);
            this.cblfuncionario.TabIndex = 11;
            // 
            // txtususenha
            // 
            this.txtususenha.Location = new System.Drawing.Point(99, 98);
            this.txtususenha.Name = "txtususenha";
            this.txtususenha.PasswordChar = '*';
            this.txtususenha.Size = new System.Drawing.Size(250, 20);
            this.txtususenha.TabIndex = 8;
            this.txtususenha.ValidatingType = typeof(int);
            // 
            // txtusuchances
            // 
            this.txtusuchances.Location = new System.Drawing.Point(176, 220);
            this.txtusuchances.Mask = "00000";
            this.txtusuchances.Name = "txtusuchances";
            this.txtusuchances.Size = new System.Drawing.Size(46, 20);
            this.txtusuchances.TabIndex = 7;
            this.txtusuchances.ValidatingType = typeof(int);
            // 
            // chkcontabloqueada
            // 
            this.chkcontabloqueada.AutoSize = true;
            this.chkcontabloqueada.Location = new System.Drawing.Point(241, 223);
            this.chkcontabloqueada.Name = "chkcontabloqueada";
            this.chkcontabloqueada.Size = new System.Drawing.Size(107, 17);
            this.chkcontabloqueada.TabIndex = 6;
            this.chkcontabloqueada.Text = "Conta bloqueada";
            this.chkcontabloqueada.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(275, 294);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 5;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(194, 294);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 4;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(32, 294);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(156, 23);
            this.btnincluir.TabIndex = 3;
            this.btnincluir.Text = "Incluir / Gravar";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Chances trocar senha vencida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data expiração:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nível Acesso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionário:";
            // 
            // txtusunome
            // 
            this.txtusunome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusunome.Location = new System.Drawing.Point(99, 30);
            this.txtusunome.MaxLength = 20;
            this.txtusunome.Name = "txtusunome";
            this.txtusunome.Size = new System.Drawing.Size(250, 20);
            this.txtusunome.TabIndex = 1;
            this.txtusunome.Leave += new System.EventHandler(this.txtusucodi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // frmusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Usuários";
            this.Load += new System.EventHandler(this.frmusuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmusuario_KeyDown);
            this.tbcusuario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcusuario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusunome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.DataGridView dgvusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkcontabloqueada;
        private System.Windows.Forms.MaskedTextBox txtusuchances;
        private System.Windows.Forms.MaskedTextBox txtususenha;
        private System.Windows.Forms.ComboBox cblfuncionario;
        private System.Windows.Forms.ComboBox cblnivelacesso;
        private System.Windows.Forms.DateTimePicker dtpusuexpira;
    }
}