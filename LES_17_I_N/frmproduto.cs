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
        public UnidadeDao UnidadeDao = new UnidadeDao();
        public GrupoDao GrupoDao = new GrupoDao();

        public List<string> Unidades { get; set; }
        public List<string> Grupos { get; set; }

        public bool edicao { get; set; }

        private void limpar()
        {
            txtprocodi.Clear(); // Limpa o textbox
            txtprocodi.Focus(); // Vai para o textbox código
            txtprocodi.Clear();
            txtpronome.Clear();
            txtprocust.Clear();
            txtproqtes.Clear();
            txtproloca.Clear();
            txtprolucr.Clear();
            txtproobs.Clear();
            txtprovend.Clear();
            cbogrupos.SelectedItem = null;
            cbounidade.SelectedItem = null;
            edicao = false;
            DgvDados();
        }

        private ProdutoModel Entidade()
        {
            if (String.IsNullOrEmpty(txtprocodi.Text) ||
                String.IsNullOrEmpty(txtpronome.Text) ||
                cbogrupos.SelectedItem == null ||
                String.IsNullOrEmpty(txtprocust.Text) ||
                String.IsNullOrEmpty(txtproqtes.Text) ||
                String.IsNullOrEmpty(txtproloca.Text) ||
                String.IsNullOrEmpty(txtprolucr.Text) ||
                String.IsNullOrEmpty(txtproobs.Text) ||
                String.IsNullOrEmpty(txtprovend.Text) ||
                cbounidade.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new ProdutoModel
            {
                PROCODI = int.Parse(txtprocodi.Text),
                PRONOME = txtpronome.Text,
                PROCUST = double.Parse(txtprocust.Text),
                PROESTO = txtproqtes.Text,
                PROLOCA = txtproloca.Text,
                PROMARG = double.Parse(txtprolucr.Text),
                PROOBS = txtproobs.Text,
                PROVEND = double.Parse(txtprovend.Text),
                GRUCODI = cbogrupos.SelectedItem.ToString().Split('-')[0],
                UNICODI = cbounidade.SelectedItem.ToString().Split('-')[0],
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
            txtprocodi.Focus();
        }


        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtprocodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            ProdutoDao.Delete(int.Parse(txtprocodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = ProdutoDao.GetAll();
            dgvpro.DataSource = dt;

            cbogrupos.Items.Clear();
            cbogrupos.Items.AddRange(Grupos.ToArray());

            cbounidade.Items.Clear();
            cbounidade.Items.AddRange(Unidades.ToArray());
        }

        private void frmproduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmproduto_Load(object sender, EventArgs e)
        {
            Unidades = getUnidades();
            Grupos = getGrupos();
            DgvDados();
        }


        private List<string> getUnidades()
        {
            var lista = new List<string>();
            var itens = UnidadeDao.GetAll();
            foreach (var item in itens.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["UNICODI"]} - {row["UNINOME"]}");
            }
            return lista;
        }


        private List<string> getGrupos()
        {
            var lista = new List<string>();
            var itens = GrupoDao.GetAll();
            foreach (var item in itens.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["GRUCODI"]} - {row["GRUNOME"]}");
            }
            return lista;
        }
        private void txtprocodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtprocodi.Text))
                return;

            var dr = ProdutoDao.GetById(int.Parse(txtprocodi.Text));
            if (dr.Read())
            {
                txtprocodi.Text = dr["PROCODI"].ToString();
                txtpronome.Text = dr["PRONOME"].ToString();
                txtprocust.Text = dr["PROCUST"].ToString();
                txtproqtes.Text = dr["PROESTO"].ToString();
                txtproloca.Text = dr["PROLOCA"].ToString();
                txtprolucr.Text = dr["PROMARG"].ToString();
                txtproobs.Text = dr["PROOBS"].ToString();
                txtprovend.Text = dr["PROVEND"].ToString();

                cbogrupos.SelectedItem = Grupos.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["GRUCODI"].ToString());
                cbounidade.SelectedItem = Unidades.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["UNICODI"].ToString());
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
                    txtpronome.Text = "";
                    txtpronome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcpro.SelectedIndex = 0;
        }

        private void dgvprod_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtprocodi.Text = dgvpro.Rows[e.RowIndex].Cells["PROCODI"].Value.ToString();
            txtprocodi_Leave(null, null);
            tbcpro.SelectedIndex = 1;
            txtpronome.Focus();
            edicao = true;
        }
    }
}
