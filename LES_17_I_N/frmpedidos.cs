using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LES_17_I_N.Dao;
using LES_17_I_N.Model;

namespace LES_17_I_N
{
    public partial class frmpedidos : Form
    {
        public frmpedidos()
        {
            InitializeComponent();
        }

        public PedidoDao PedidoDao = new PedidoDao();
        public Pedido_itemDao Pedido_itemDao = new Pedido_itemDao();
        public ProdutoDao ProdutoDao = new ProdutoDao();
        public ClienteDao ClienteDao = new ClienteDao();
        public FuncionarioDao FuncionarioDao = new FuncionarioDao();


        public bool edicao { get; set; }

        public List<string> Clientes { get; set; }
        public List<string> Funcionarios { get; set; }

        private void limpar()
        {
            txtpedcodi.Clear();

            edicao = false;
            DgvDados();
        }

        private PedidoModel Entidade()
        {
            if (String.IsNullOrEmpty(txtpedcodi.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new PedidoModel
            {
                PEDCODI = int.Parse(txtpedcodi.Text),
                PEDDTEM = DateTime.Parse(dtpedem.Text),
                PEDDTBA = DateTime.Parse(dtpbaixa.Text),
                PEDCOND = txtpedcondicao.Text,
                PEDOBS = txtpedobs.Text,
                FUNCODI = int.Parse(cbofuncionario.SelectedItem.ToString().Split('-')[0].Trim()),
                CLICODI = int.Parse(cboclientes.SelectedItem.ToString().Split('-')[0].Trim()),
                PEDDESC = txtdescontoreal.Text == "" ? 0d : double.Parse(txtdescontoreal.Text),
                PEDPERC = txtdescontoporc.Text == "" ? 0d : double.Parse(txtdescontoporc.Text),
                PEDTOTA = double.Parse(txttotalitens.Text),
                PEDLIQU = double.Parse(txttotalliq.Text),
            };
        }

        private List<Pedido_itemModel> EntidadeItens()
        {
            if (dvgprodutos.Rows.Count == 0)
            {
                MessageBox.Show("Adicione ao menos um produto ao pedido!");
                return null;
            }

            var lista = new List<Pedido_itemModel>();

            foreach (var item in dvgprodutos.Rows)
            {
                var c = (DataGridViewRow)item;

                lista.Add(new Pedido_itemModel()
                {
                    ITECODI = int.Parse(c.Cells["ITECODI"].Value.ToString()),
                    ITEQTDE = int.Parse(c.Cells["ITEQTDE"].Value.ToString()),
                    ITETOTA = int.Parse(c.Cells["ITETOTA"].Value.ToString()),
                    ITEVALO = int.Parse(c.Cells["ITEVALO"].Value.ToString()),
                    PEDCODI = int.Parse(txtpedcodi.Text),
                    PROCODI = int.Parse(c.Cells["PROCODI"].Value.ToString()),
                });

            }
            return lista;
        }
        //

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            var entidadef = EntidadeItens();
            if (entidadef == null)
                return;

            //Reseta
            Pedido_itemDao.Delete(entidade.PEDCODI);

            if (edicao)
                PedidoDao.Update(entidade);
            else
                PedidoDao.Insert(entidade);

            foreach (var item in entidadef)
            {
                Pedido_itemDao.Insert(item);
            }

            limpar();
            txtpedcodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpedcodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            PedidoDao.Delete(int.Parse(txtpedcodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = PedidoDao.GetAll();
            dvgpeduto.DataSource = dt;

            cboclientes.Items.Clear();
            cboclientes.Items.AddRange(Clientes.ToArray());

            cbofuncionario.Items.Clear();
            cbofuncionario.Items.AddRange(Funcionarios.ToArray());
        }

        private List<string> GetClientes()
        {
            var lista = new List<string>();
            var itens = ClienteDao.GetAll();
            foreach (var item in itens.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["CLICODI"]} - {row["CLINOME"]}");
            }
            return lista;
        }

        private List<string> GetFuncionarios()
        {
            var lista = new List<string>();
            var itens = FuncionarioDao.GetAll();
            foreach (var item in itens.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["FUNCCODI"]} - {row["FUNNOME"]}");
            }
            return lista;
        }

        private void frmpedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void txtpedccodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpedcodi.Text))
                return;

            var dr = PedidoDao.GetById(int.Parse(txtpedcodi.Text));
            if (dr.Read())
            {
                txtpedcodi.Text = dr["PEDCODI"].ToString();
                dtpedem.Text = dr["PEDDTEM"].ToString();
                dtpbaixa.Text = dr["PEDDTBA"].ToString();
                txtpedcondicao.Text = dr["PEDCOND"].ToString();
                txtpedobs.Text = dr["PEDOBS"].ToString();
                txtdescontoreal.Text = dr["PEDDESC"].ToString();
                txtdescontoporc.Text = dr["PEDPERC"].ToString();
                txttotalitens.Text = dr["PEDTOTA"].ToString();
                txttotalliq.Text = dr["PEDLIQU"].ToString();
                cboclientes.SelectedItem = Clientes.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["CLICODI"].ToString());
                cbofuncionario.SelectedItem = Funcionarios.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["FUNCODI"].ToString());
                edicao = true;
            }
            else
            {
                edicao = false;
                if ((MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                {
                    limpar();
                }
                else
                {
                    var tempoCodi = txtpedcodi.Text;
                    limpar();
                    txtpedcodi.Text = tempoCodi;

                }
            }
            dr.Close();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcpeduto.SelectedIndex = 0;
        }

        private void dvgpeduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtpedcodi.Text = dvgpeduto.Rows[e.RowIndex].Cells["PEDCODI"].Value.ToString();
            txtpedccodi_Leave(null, null);
            tbcpeduto.SelectedIndex = 1;

            edicao = true;
        }

        private void frmpedidos_Load(object sender, EventArgs e)
        {
            Clientes = GetClientes();
            Funcionarios = GetFuncionarios();
            DgvDados();
        }

        private void txtprodcodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtprocodi.Text))
                return;

            var dr = ProdutoDao.GetById(int.Parse(txtprocodi.Text));
            if (dr.Read())
            {
                txtpronome.Text = dr["PRONOME"].ToString();
                txtproestoque.Text = dr["PROESTO"].ToString();
                txtprounidade.Text = dr["PROVEND"].ToString();
                txtproqtd.Text = "";
                btnAdicionarProduto.Enabled = true;
            }
            else
            {
                btnAdicionarProduto.Enabled = false;
                MessageBox.Show("Produto não foi encontrado!");
                LimparProduto();
            }
        }

        private void LimparProduto()
        {
            txtprocodi.Clear();
            txtpronome.Clear();
            txtprounidade.Clear();
            txtproestoque.Clear();
            txtproqtd.Clear();
            txtprototal.Clear();
        }


        private void txtproqtd_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtproestoque.Text) ||
                String.IsNullOrEmpty(txtproqtd.Text))
                return;

            if (int.Parse(txtproqtd.Text) > int.Parse(txtproestoque.Text))
            {
                txtproqtd.Text = txtproestoque.Text;
                MessageBox.Show("A Quantidade de itens não deve ser superior ao estoque");
            }
            else if (int.Parse(txtproqtd.Text) <= 0)
            {
                MessageBox.Show("A Quantidade de itens deve ser maior que 0");
            }

            txtprototal.Text = (int.Parse(txtproqtd.Text) * int.Parse(txtprounidade.Text)).ToString();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtproqtd.Text))
            {
                MessageBox.Show("Preencha a quantidade!");
                return;
            }

            var existe = dvgprodutos.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["PROCODI"].Value.ToString().Equals(txtprocodi.Text));

            if (existe != null)
            {
                existe.Selected = true;
                MessageBox.Show("Esse produto já existe na lista de itens");
                return;
            }

            dvgprodutos.Rows.Add(dvgprodutos.Rows.Count + 1, txtprocodi.Text.Trim(),
                txtpronome.Text.Trim(), txtproqtd.Text.Trim(), txtprounidade.Text.Trim(), txtprototal.Text.Trim());


            var soma = dvgprodutos.Rows
                .Cast<DataGridViewRow>()
                .Sum(r => double.Parse(r.Cells["ITETOTA"].Value.ToString()));

            txttotalitens.Text = soma.ToString();

            CalcularResumos(null, null);
            LimparProduto();
        }

        private void CalcularResumos(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txttotalitens.Text))
            {
                txtdescontoporc.Text = txtdescontoreal.Text = txttotalliq.Text = "";
                return;
            }

            var totalItens = double.Parse(txttotalitens.Text);
            var descontoporc = (txtdescontoporc.Text == "0" || String.IsNullOrEmpty(txtdescontoporc.Text)) ? 0d : (totalItens / 100) * double.Parse(txtdescontoporc.Text);
            var descontoreal = (txtdescontoreal.Text == "0" || String.IsNullOrEmpty(txtdescontoreal.Text)) ? 0d : double.Parse(txtdescontoreal.Text);

            var ttotalliq = totalItens - descontoreal - descontoporc;
            txttotalliq.Text = ttotalliq.ToString();
            LimparProduto();
        }

    }
}
