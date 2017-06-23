using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmproduto : Form
    {
        public frmproduto()
        {
            InitializeComponent();
        }

        public ProdutoDao ProdutoDao = new ProdutoDao();
        public EnderecoDao EnderecoDao = new EnderecoDao();
        public RamoDao RamoDao = new RamoDao();

        public bool edicao { get; set; }

        public List<string> Ramos { get; set; }

        private void limpar()
        {
            txtprodcodi.Clear();
            txtprodnome.Clear();
            txtprodfantasia.Clear();
            txtprodapelido.Clear();
            txtprodapelido.Clear();
            txtprodlimite.Clear();
            txtprodpricompra.Clear();
            txtprodcnpj.Clear();
            txtprodie.Clear();
            txtprodemail.Clear();
            txtprodfone.Clear();
            txtprodcelular.Clear();
            txtprodcel1.Clear();
            txtprodnumero.Clear();
            txtprodstatus.Clear();
            txtprodcep.Clear();
            txtprodend.Clear();
            txtprodcidade.Clear();
            txtprodbairro.Clear();
            txtprodpais.Clear();
            txtprodestado.Clear();
            cblcliramo.SelectedItem = null;
            edicao = false;
            DgvDados();
        }

        private ProdutoModel Entidade()
        {
            if (String.IsNullOrEmpty(txtprodcodi.Text) ||
                String.IsNullOrEmpty(txtprodnome.Text) ||
                String.IsNullOrEmpty(txtprodfantasia.Text) ||
                String.IsNullOrEmpty(txtprodapelido.Text) ||
                String.IsNullOrEmpty(txtprodlimite.Text) ||
                String.IsNullOrEmpty(txtprodpricompra.Text) ||
                String.IsNullOrEmpty(txtprodcnpj.Text) ||
                String.IsNullOrEmpty(txtprodie.Text) ||
                String.IsNullOrEmpty(txtprodemail.Text) ||
                String.IsNullOrEmpty(txtprodfone.Text) ||
                String.IsNullOrEmpty(txtprodcelular.Text) ||
                String.IsNullOrEmpty(txtprodcel1.Text) ||
                String.IsNullOrEmpty(txtprodnumero.Text) ||
                String.IsNullOrEmpty(txtprodstatus.Text) ||
                cblcliramo.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new ProdutoModel
            {
                PROCODI = int.Parse(txtprodcodi.Text),
                PRONOME = txtprodnome.Text,
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                ProdutoDao.Update(entidade);
            else
            {
                ProdutoDao.Insert(entidade);
            }

            limpar();
            txtprodcodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtprodcodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            ProdutoDao.Delete(int.Parse(txtprodcodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = ProdutoDao.GetAll();

            cblcliramo.Items.Clear();
            cblcliramo.Items.AddRange(Ramos.ToArray());

            dvgproduto.DataSource = dt;
        }

        private void frmproduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }


        private void txtprodccodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtprodcodi.Text))
                return;

            var dr = ProdutoDao.GetById(int.Parse(txtprodcodi.Text));
            if (dr.Read())
            {
                txtprodcodi.Text = dr["PROCODI"].ToString();
                txtprodnome.Text = dr["PRONOME"].ToString();
                txtprodfantasia.Text = dr["PROFANT"].ToString();
                txtprodapelido.Text = dr["PROAPEL"].ToString();
                txtprodlimite.Text = dr["PROLIMI"].ToString();
                txtprodpricompra.Text = dr["PRODTIN"].ToString();
                txtprodcnpj.Text = dr["PROCNPJ"].ToString();
                txtprodie.Text = dr["PROINES"].ToString();
                txtprodemail.Text = dr["PROEMAI"].ToString();
                txtprodfone.Text = dr["PROFONE"].ToString();
                txtprodcelular.Text = dr["PROCELU"].ToString();
                txtprodcel1.Text = dr["PROCEL1"].ToString();
                txtprodnumero.Text = dr["PRONUME"].ToString();
                txtprodstatus.Text = dr["PROSTAT"].ToString();
                txtprodcep.Text = dr["ENDCEP"].ToString();

                cblcliramo.SelectedItem = Ramos.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["RAMCODI"].ToString());
                txtprodcep_Leave(null, null);

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
                    var tempoCodi = txtprodcodi.Text;
                    limpar();
                    txtprodcodi.Text = tempoCodi;
                    txtprodnome.Focus();
                }
            }
            dr.Close();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcproduto.SelectedIndex = 0;
        }

        private void dvgproduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtprodcodi.Text = dvgproduto.Rows[e.RowIndex].Cells["PROCODI"].Value.ToString();
            txtprodccodi_Leave(null, null);
            tbcproduto.SelectedIndex = 1;
            txtprodnome.Focus();
            edicao = true;
        }

        private void frmproduto_Load(object sender, EventArgs e)
        {
            Ramos = getRamos();
            DgvDados();
        }

        private List<string> getRamos()
        {
            var lista = new List<string>();
            var itens = RamoDao.GetAll();
            foreach (var item in itens.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["RAMCODI"]} - {row["RAMNOME"]}");
            }
            return lista;
        }

        private void txtprodcep_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtprodcep.Text))
                return;

            var dr = EnderecoDao.GetFullById(txtprodcep.Text);
            if (dr.Read())
            {
                txtprodcep.Text = dr["ENDCEP"].ToString();
                txtprodend.Text = dr["ENDENDE"].ToString();
                txtprodcidade.Text = dr["MUNNOME"].ToString();
                txtprodbairro.Text = dr["BAINOME"].ToString();
                txtprodestado.Text = dr["ESTNOME"].ToString();
                txtprodpais.Text = dr["PAINOME"].ToString();
            }
            else
            {
                if ((MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                {
                    LimparCep();
                }
                else
                {
                    var form = new frmendereco(txtprodcep.Text);
                    LimparCep();
                }
            }
            dr.Close();

        }
        private void LimparCep()
        {
            txtprodcep.Clear();
            txtprodend.Clear();
            txtprodcidade.Clear();
            txtprodbairro.Clear();
            txtprodpais.Clear();
            txtprodestado.Clear();
        }

    }
}
