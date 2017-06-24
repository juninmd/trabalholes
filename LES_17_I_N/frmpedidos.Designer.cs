namespace LES_17_I_N
{
    partial class frmpedidos
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvgpeduto = new System.Windows.Forms.DataGridView();
            this.tbcpeduto = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtproestoque = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtpronome = new System.Windows.Forms.TextBox();
            this.txtprototal = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtprounidade = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtproqtd = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtprocodi = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvgprodutos = new System.Windows.Forms.DataGridView();
            this.cboclientes = new System.Windows.Forms.ComboBox();
            this.dptpeddtem = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtpedcodi = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgpeduto)).BeginInit();
            this.tbcpeduto.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgprodutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvgpeduto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvgpeduto
            // 
            this.dvgpeduto.AllowUserToAddRows = false;
            this.dvgpeduto.AllowUserToDeleteRows = false;
            this.dvgpeduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgpeduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgpeduto.Location = new System.Drawing.Point(3, 3);
            this.dvgpeduto.Name = "dvgpeduto";
            this.dvgpeduto.ReadOnly = true;
            this.dvgpeduto.RowHeadersVisible = false;
            this.dvgpeduto.Size = new System.Drawing.Size(670, 429);
            this.dvgpeduto.TabIndex = 0;
            this.dvgpeduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgpeduto_CellDoubleClick);
            // 
            // tbcpeduto
            // 
            this.tbcpeduto.Controls.Add(this.tabPage1);
            this.tbcpeduto.Controls.Add(this.tabPage2);
            this.tbcpeduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcpeduto.Location = new System.Drawing.Point(0, 0);
            this.tbcpeduto.Name = "tbcpeduto";
            this.tbcpeduto.SelectedIndex = 0;
            this.tbcpeduto.Size = new System.Drawing.Size(684, 461);
            this.tbcpeduto.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.cboclientes);
            this.tabPage2.Controls.Add(this.dptpeddtem);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.txtpedcodi);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtproestoque);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnAdicionarProduto);
            this.groupBox2.Controls.Add(this.txtpronome);
            this.groupBox2.Controls.Add(this.txtprototal);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtprounidade);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtproqtd);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtprocodi);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(16, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 78);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados item";
            // 
            // txtproestoque
            // 
            this.txtproestoque.Location = new System.Drawing.Point(101, 47);
            this.txtproestoque.Name = "txtproestoque";
            this.txtproestoque.ReadOnly = true;
            this.txtproestoque.Size = new System.Drawing.Size(32, 20);
            this.txtproestoque.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Remover Item";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(143, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Descrição:";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Enabled = false;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(483, 16);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(156, 23);
            this.btnAdicionarProduto.TabIndex = 42;
            this.btnAdicionarProduto.Text = "Adicionar/Editar Item";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtpronome
            // 
            this.txtpronome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpronome.Location = new System.Drawing.Point(201, 15);
            this.txtpronome.Name = "txtpronome";
            this.txtpronome.Size = new System.Drawing.Size(276, 20);
            this.txtpronome.TabIndex = 3;
            // 
            // txtprototal
            // 
            this.txtprototal.Enabled = false;
            this.txtprototal.Location = new System.Drawing.Point(351, 48);
            this.txtprototal.Mask = "0000";
            this.txtprototal.Name = "txtprototal";
            this.txtprototal.Size = new System.Drawing.Size(126, 20);
            this.txtprototal.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(311, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Total:";
            // 
            // txtprounidade
            // 
            this.txtprounidade.Location = new System.Drawing.Point(201, 47);
            this.txtprounidade.Mask = "0000";
            this.txtprounidade.Name = "txtprounidade";
            this.txtprounidade.Size = new System.Drawing.Size(97, 20);
            this.txtprounidade.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(132, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Pr. Unidade:";
            // 
            // txtproqtd
            // 
            this.txtproqtd.Location = new System.Drawing.Point(66, 47);
            this.txtproqtd.Mask = "0000";
            this.txtproqtd.Name = "txtproqtd";
            this.txtproqtd.Size = new System.Drawing.Size(34, 20);
            this.txtproqtd.TabIndex = 3;
            this.txtproqtd.Leave += new System.EventHandler(this.txtproqtd_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Qtde:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Código:";
            // 
            // txtprocodi
            // 
            this.txtprocodi.Location = new System.Drawing.Point(66, 15);
            this.txtprocodi.Mask = "00000";
            this.txtprocodi.Name = "txtprocodi";
            this.txtprocodi.Size = new System.Drawing.Size(67, 20);
            this.txtprocodi.TabIndex = 1;
            this.txtprocodi.Leave += new System.EventHandler(this.txtprodcodi_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvgprodutos);
            this.groupBox1.Location = new System.Drawing.Point(16, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 164);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens";
            // 
            // dvgprodutos
            // 
            this.dvgprodutos.AllowUserToAddRows = false;
            this.dvgprodutos.AllowUserToDeleteRows = false;
            this.dvgprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgprodutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgprodutos.Location = new System.Drawing.Point(3, 16);
            this.dvgprodutos.Name = "dvgprodutos";
            this.dvgprodutos.ReadOnly = true;
            this.dvgprodutos.RowHeadersVisible = false;
            this.dvgprodutos.Size = new System.Drawing.Size(638, 145);
            this.dvgprodutos.TabIndex = 1;
            // 
            // cboclientes
            // 
            this.cboclientes.FormattingEnabled = true;
            this.cboclientes.Location = new System.Drawing.Point(65, 59);
            this.cboclientes.Name = "cboclientes";
            this.cboclientes.Size = new System.Drawing.Size(345, 21);
            this.cboclientes.TabIndex = 36;
            // 
            // dptpeddtem
            // 
            this.dptpeddtem.CustomFormat = "";
            this.dptpeddtem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptpeddtem.Location = new System.Drawing.Point(184, 19);
            this.dptpeddtem.Name = "dptpeddtem";
            this.dptpeddtem.Size = new System.Drawing.Size(146, 20);
            this.dptpeddtem.TabIndex = 35;
            this.dptpeddtem.Value = new System.DateTime(2016, 12, 2, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Obs:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(593, 138);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 18;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(512, 138);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 17;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(416, 138);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(90, 23);
            this.btnincluir.TabIndex = 16;
            this.btnincluir.Text = "Incluir / Gravar";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Forma:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(65, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(345, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(65, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtpedcodi
            // 
            this.txtpedcodi.Location = new System.Drawing.Point(65, 22);
            this.txtpedcodi.Mask = "00000";
            this.txtpedcodi.Name = "txtpedcodi";
            this.txtpedcodi.Size = new System.Drawing.Size(67, 20);
            this.txtpedcodi.TabIndex = 1;
            this.txtpedcodi.Leave += new System.EventHandler(this.txtpedccodi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(416, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 126);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Total itens:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Desconto em %:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(125, 92);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Desconto em R$:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(125, 67);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Total Liquido:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 39;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 39;
            // 
            // frmpedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tbcpeduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmpedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos pedidos";
            this.Load += new System.EventHandler(this.frmpedidos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmpedidos_KeyDown);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgpeduto)).EndInit();
            this.tbcpeduto.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgprodutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dvgpeduto;
        private System.Windows.Forms.TabControl tbcpeduto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox txtpedcodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dptpeddtem;
        private System.Windows.Forms.ComboBox cboclientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvgprodutos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpronome;
        private System.Windows.Forms.MaskedTextBox txtproqtd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtprounidade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtprototal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox txtprocodi;
        private System.Windows.Forms.TextBox txtproestoque;
    }
}