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
            this.dvgpedidos = new System.Windows.Forms.DataGridView();
            this.tbcpeduto = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpitem = new System.Windows.Forms.GroupBox();
            this.txtproestoque = new System.Windows.Forms.TextBox();
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
            this.dvgitenspedidos = new System.Windows.Forms.DataGridView();
            this.cbofuncionario = new System.Windows.Forms.ComboBox();
            this.cboclientes = new System.Windows.Forms.ComboBox();
            this.dtpbaixa = new System.Windows.Forms.DateTimePicker();
            this.dtpedem = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpedobs = new System.Windows.Forms.TextBox();
            this.txtpedcondicao = new System.Windows.Forms.TextBox();
            this.txtpedcodi = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotalliq = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdescontoreal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdescontoporc = new System.Windows.Forms.TextBox();
            this.txttotalitens = new System.Windows.Forms.TextBox();
            this.PEDCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITECODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEQTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEVALO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITETOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgpedidos)).BeginInit();
            this.tbcpeduto.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpitem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgitenspedidos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvgpedidos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvgpedidos
            // 
            this.dvgpedidos.AllowUserToAddRows = false;
            this.dvgpedidos.AllowUserToDeleteRows = false;
            this.dvgpedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgpedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgpedidos.Location = new System.Drawing.Point(3, 3);
            this.dvgpedidos.Name = "dvgpedidos";
            this.dvgpedidos.ReadOnly = true;
            this.dvgpedidos.RowHeadersVisible = false;
            this.dvgpedidos.Size = new System.Drawing.Size(670, 429);
            this.dvgpedidos.TabIndex = 0;
            this.dvgpedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgpeduto_CellDoubleClick);
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
            this.tabPage2.Controls.Add(this.grpitem);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.cbofuncionario);
            this.tabPage2.Controls.Add(this.cboclientes);
            this.tabPage2.Controls.Add(this.dtpbaixa);
            this.tabPage2.Controls.Add(this.dtpedem);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtpedobs);
            this.tabPage2.Controls.Add(this.txtpedcondicao);
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
            // grpitem
            // 
            this.grpitem.Controls.Add(this.txtproestoque);
            this.grpitem.Controls.Add(this.label12);
            this.grpitem.Controls.Add(this.btnAdicionarProduto);
            this.grpitem.Controls.Add(this.txtpronome);
            this.grpitem.Controls.Add(this.txtprototal);
            this.grpitem.Controls.Add(this.label15);
            this.grpitem.Controls.Add(this.txtprounidade);
            this.grpitem.Controls.Add(this.label14);
            this.grpitem.Controls.Add(this.txtproqtd);
            this.grpitem.Controls.Add(this.label13);
            this.grpitem.Controls.Add(this.label10);
            this.grpitem.Controls.Add(this.txtprocodi);
            this.grpitem.Location = new System.Drawing.Point(16, 169);
            this.grpitem.Name = "grpitem";
            this.grpitem.Size = new System.Drawing.Size(644, 78);
            this.grpitem.TabIndex = 41;
            this.grpitem.TabStop = false;
            this.grpitem.Text = "Dados item";
            // 
            // txtproestoque
            // 
            this.txtproestoque.Location = new System.Drawing.Point(101, 47);
            this.txtproestoque.Name = "txtproestoque";
            this.txtproestoque.ReadOnly = true;
            this.txtproestoque.Size = new System.Drawing.Size(32, 20);
            this.txtproestoque.TabIndex = 44;
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
            this.btnAdicionarProduto.Size = new System.Drawing.Size(156, 52);
            this.btnAdicionarProduto.TabIndex = 42;
            this.btnAdicionarProduto.Text = "Adicionar Item";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtpronome
            // 
            this.txtpronome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpronome.Location = new System.Drawing.Point(201, 15);
            this.txtpronome.Name = "txtpronome";
            this.txtpronome.ReadOnly = true;
            this.txtpronome.Size = new System.Drawing.Size(276, 20);
            this.txtpronome.TabIndex = 3;
            // 
            // txtprototal
            // 
            this.txtprototal.Enabled = false;
            this.txtprototal.Location = new System.Drawing.Point(351, 48);
            this.txtprototal.Mask = "0000";
            this.txtprototal.Name = "txtprototal";
            this.txtprototal.ReadOnly = true;
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
            this.txtprounidade.ReadOnly = true;
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
            this.groupBox1.Controls.Add(this.dvgitenspedidos);
            this.groupBox1.Location = new System.Drawing.Point(16, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 164);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens";
            // 
            // dvgitenspedidos
            // 
            this.dvgitenspedidos.AllowUserToAddRows = false;
            this.dvgitenspedidos.AllowUserToDeleteRows = false;
            this.dvgitenspedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgitenspedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PEDCODI,
            this.ITECODI,
            this.PROCODI,
            this.ITEQTDE,
            this.ITEVALO,
            this.ITETOTA});
            this.dvgitenspedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgitenspedidos.Location = new System.Drawing.Point(3, 16);
            this.dvgitenspedidos.Name = "dvgitenspedidos";
            this.dvgitenspedidos.ReadOnly = true;
            this.dvgitenspedidos.RowHeadersVisible = false;
            this.dvgitenspedidos.Size = new System.Drawing.Size(638, 145);
            this.dvgitenspedidos.TabIndex = 1;
            // 
            // cbofuncionario
            // 
            this.cbofuncionario.FormattingEnabled = true;
            this.cbofuncionario.Location = new System.Drawing.Point(65, 95);
            this.cbofuncionario.Name = "cbofuncionario";
            this.cbofuncionario.Size = new System.Drawing.Size(345, 21);
            this.cbofuncionario.TabIndex = 36;
            // 
            // cboclientes
            // 
            this.cboclientes.FormattingEnabled = true;
            this.cboclientes.Location = new System.Drawing.Point(65, 59);
            this.cboclientes.Name = "cboclientes";
            this.cboclientes.Size = new System.Drawing.Size(345, 21);
            this.cboclientes.TabIndex = 36;
            // 
            // dtpbaixa
            // 
            this.dtpbaixa.CustomFormat = "";
            this.dtpbaixa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpbaixa.Location = new System.Drawing.Point(294, 22);
            this.dtpbaixa.Name = "dtpbaixa";
            this.dtpbaixa.Size = new System.Drawing.Size(82, 20);
            this.dtpbaixa.TabIndex = 35;
            this.dtpbaixa.Value = new System.DateTime(2016, 12, 2, 0, 0, 0, 0);
            // 
            // dtpedem
            // 
            this.dtpedem.CustomFormat = "";
            this.dtpedem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpedem.Location = new System.Drawing.Point(172, 22);
            this.dtpedem.Name = "dtpedem";
            this.dtpedem.Size = new System.Drawing.Size(82, 20);
            this.dtpedem.TabIndex = 35;
            this.dtpedem.Value = new System.DateTime(2016, 12, 2, 0, 0, 0, 0);
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
            this.label3.Location = new System.Drawing.Point(223, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Forma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Func.:";
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
            this.label2.Location = new System.Drawing.Point(138, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // txtpedobs
            // 
            this.txtpedobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpedobs.Location = new System.Drawing.Point(65, 138);
            this.txtpedobs.Name = "txtpedobs";
            this.txtpedobs.Size = new System.Drawing.Size(152, 20);
            this.txtpedobs.TabIndex = 4;
            // 
            // txtpedcondicao
            // 
            this.txtpedcondicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpedcondicao.Location = new System.Drawing.Point(263, 138);
            this.txtpedcondicao.Name = "txtpedcondicao";
            this.txtpedcondicao.Size = new System.Drawing.Size(147, 20);
            this.txtpedcondicao.TabIndex = 4;
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
            this.groupBox3.Controls.Add(this.txttotalliq);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtdescontoreal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtdescontoporc);
            this.groupBox3.Controls.Add(this.txttotalitens);
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
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Total Itens:";
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
            // txttotalliq
            // 
            this.txttotalliq.Location = new System.Drawing.Point(125, 92);
            this.txttotalliq.Name = "txttotalliq";
            this.txttotalliq.ReadOnly = true;
            this.txttotalliq.Size = new System.Drawing.Size(121, 20);
            this.txttotalliq.TabIndex = 39;
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
            // txtdescontoreal
            // 
            this.txtdescontoreal.Location = new System.Drawing.Point(125, 67);
            this.txtdescontoreal.Name = "txtdescontoreal";
            this.txtdescontoreal.Size = new System.Drawing.Size(121, 20);
            this.txtdescontoreal.TabIndex = 39;
            this.txtdescontoreal.Leave += new System.EventHandler(this.CalcularResumos);
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
            // txtdescontoporc
            // 
            this.txtdescontoporc.Location = new System.Drawing.Point(125, 44);
            this.txtdescontoporc.Name = "txtdescontoporc";
            this.txtdescontoporc.Size = new System.Drawing.Size(121, 20);
            this.txtdescontoporc.TabIndex = 39;
            this.txtdescontoporc.Leave += new System.EventHandler(this.CalcularResumos);
            // 
            // txttotalitens
            // 
            this.txttotalitens.Location = new System.Drawing.Point(125, 20);
            this.txttotalitens.Name = "txttotalitens";
            this.txttotalitens.ReadOnly = true;
            this.txttotalitens.Size = new System.Drawing.Size(121, 20);
            this.txttotalitens.TabIndex = 39;
            // 
            // PEDCODI
            // 
            this.PEDCODI.HeaderText = "PEDCODI";
            this.PEDCODI.Name = "PEDCODI";
            this.PEDCODI.ReadOnly = true;
            // 
            // ITECODI
            // 
            this.ITECODI.HeaderText = "ITECODI";
            this.ITECODI.Name = "ITECODI";
            this.ITECODI.ReadOnly = true;
            // 
            // PROCODI
            // 
            this.PROCODI.HeaderText = "PROCODI";
            this.PROCODI.Name = "PROCODI";
            this.PROCODI.ReadOnly = true;
            // 
            // ITEQTDE
            // 
            this.ITEQTDE.HeaderText = "ITEQTDE";
            this.ITEQTDE.Name = "ITEQTDE";
            this.ITEQTDE.ReadOnly = true;
            // 
            // ITEVALO
            // 
            this.ITEVALO.HeaderText = "ITEVALO";
            this.ITEVALO.Name = "ITEVALO";
            this.ITEVALO.ReadOnly = true;
            // 
            // ITETOTA
            // 
            this.ITETOTA.HeaderText = "ITETOTA";
            this.ITETOTA.Name = "ITETOTA";
            this.ITETOTA.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dvgpedidos)).EndInit();
            this.tbcpeduto.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpitem.ResumeLayout(false);
            this.grpitem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgitenspedidos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dvgpedidos;
        private System.Windows.Forms.TabControl tbcpeduto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpedobs;
        private System.Windows.Forms.TextBox txtpedcondicao;
        private System.Windows.Forms.MaskedTextBox txtpedcodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpedem;
        private System.Windows.Forms.ComboBox cboclientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotalitens;
        private System.Windows.Forms.TextBox txtdescontoporc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdescontoreal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotalliq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvgitenspedidos;
        private System.Windows.Forms.GroupBox grpitem;
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
        private System.Windows.Forms.MaskedTextBox txtprocodi;
        private System.Windows.Forms.TextBox txtproestoque;
        private System.Windows.Forms.DateTimePicker dtpbaixa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbofuncionario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEDCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITECODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEQTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEVALO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITETOTA;
    }
}