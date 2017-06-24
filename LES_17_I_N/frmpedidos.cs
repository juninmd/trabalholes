using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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

        public bool edicao { get; set; }

        public List<string> Ramos { get; set; }

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


            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                PedidoDao.Update(entidade);
            else
            {
                PedidoDao.Insert(entidade);
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
                txtpedcodi.Text = dr["PROCODI"].ToString();


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
            txtpedcodi.Text = dvgpeduto.Rows[e.RowIndex].Cells["PROCODI"].Value.ToString();
            txtpedccodi_Leave(null, null);
            tbcpeduto.SelectedIndex = 1;

            edicao = true;
        }

        private void frmpedidos_Load(object sender, EventArgs e)
        {
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
            
            btnAdicionarProduto.Enabled = true;
        }
    }
}
