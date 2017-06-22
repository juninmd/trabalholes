namespace LES_17_I_N
{
    partial class frmgrupo
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
            this.tbcgrupo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvgrupo = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgruponome = new System.Windows.Forms.TextBox();
            this.txtgrupocodi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcgrupo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrupo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcgrupo
            // 
            this.tbcgrupo.Controls.Add(this.tabPage1);
            this.tbcgrupo.Controls.Add(this.tabPage2);
            this.tbcgrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcgrupo.Location = new System.Drawing.Point(0, 0);
            this.tbcgrupo.Name = "tbcgrupo";
            this.tbcgrupo.SelectedIndex = 0;
            this.tbcgrupo.Size = new System.Drawing.Size(384, 361);
            this.tbcgrupo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvgrupo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvgrupo
            // 
            this.dgvgrupo.AllowUserToAddRows = false;
            this.dgvgrupo.AllowUserToDeleteRows = false;
            this.dgvgrupo.AllowUserToOrderColumns = true;
            this.dgvgrupo.AllowUserToResizeRows = false;
            this.dgvgrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvgrupo.Location = new System.Drawing.Point(3, 3);
            this.dgvgrupo.Name = "dgvgrupo";
            this.dgvgrupo.ReadOnly = true;
            this.dgvgrupo.RowHeadersVisible = false;
            this.dgvgrupo.Size = new System.Drawing.Size(370, 329);
            this.dgvgrupo.TabIndex = 0;
            this.dgvgrupo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgrupo_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtgruponome);
            this.tabPage2.Controls.Add(this.txtgrupocodi);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtgruponome
            // 
            this.txtgruponome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgruponome.Location = new System.Drawing.Point(118, 55);
            this.txtgruponome.Name = "txtgruponome";
            this.txtgruponome.Size = new System.Drawing.Size(250, 20);
            this.txtgruponome.TabIndex = 2;
            // 
            // txtgrupocodi
            // 
            this.txtgrupocodi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgrupocodi.Location = new System.Drawing.Point(118, 29);
            this.txtgrupocodi.Name = "txtgrupocodi";
            this.txtgrupocodi.Size = new System.Drawing.Size(50, 20);
            this.txtgrupocodi.TabIndex = 1;
            this.txtgrupocodi.Leave += new System.EventHandler(this.txtgrupocodi_Leave);
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
            // frmgrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcgrupo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmgrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção do grupo";
            this.Load += new System.EventHandler(this.frmgrupo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmgrupo_KeyDown);
            this.tbcgrupo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrupo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcgrupo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgruponome;
        private System.Windows.Forms.TextBox txtgrupocodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.DataGridView dgvgrupo;
    }
}