using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmfuncao : Form
    {
        public frmfuncao()
        {
            InitializeComponent();
        }
        public FuncaoDao FuncaoDao = new FuncaoDao();
        public CboDao CboDao = new CboDao();

        public List<string> cbo { get; set; }

        public bool edicao { get; set; }

        private void limpar()
        {
            txtfunccodi.Clear(); // Limpa o textbox
            txtfuncnome.Clear(); // Limpa o textbox
            txtfunccodi.Focus(); // Vai para o textbox código
            cblcbo.SelectedItem = null;
            edicao = false;
            DgvDados();
        }

        private FuncaoModel Entidade()
        {
            if (String.IsNullOrEmpty(txtfunccodi.Text) ||
                String.IsNullOrEmpty(txtfuncnome.Text) ||
                (cblcbo.SelectedItem) == null)
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new FuncaoModel
            {
                FUNCCODI = int.Parse(txtfunccodi.Text),
                FUNCCNOME = txtfuncnome.Text,
                CBOCODI = int.Parse(cblcbo.Text.Split('-')[0])
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                FuncaoDao.Update(entidade);
            else
            {
                FuncaoDao.Insert(entidade);
            }

            limpar();
            txtfunccodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            FuncaoDao.Update(entidade);
            limpar();
            txtfunccodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfunccodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            FuncaoDao.Delete(int.Parse(txtfunccodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = FuncaoDao.GetAll();
            cblcbo.Items.Clear();
            cblcbo.Items.AddRange(cbo.ToArray());
            if (dt.Rows.Count > 0)
                dvgfuncao.DataSource = dt;
        }

        private void frmfuncao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmfuncao_Load(object sender, EventArgs e)
        {
            cbo = Getcbo();
            DgvDados();
        }

        private List<string> Getcbo()
        {
            var lista = new List<string>();
            var all = CboDao.GetAll();
            foreach (var item in all.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["CBOCODI"]} - {row["CBONOME"]}");
            }
            return lista;
        }

        private void txtfunccodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfunccodi.Text))
                return;

            var dr = FuncaoDao.GetById(int.Parse(txtfunccodi.Text));
            if (dr.Read())
            {
                txtfunccodi.Text = dr["FUNCCODI"].ToString();
                txtfuncnome.Text = dr["FUNCCNOME"].ToString();
                cblcbo.SelectedItem = cbo.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["CBOCODI"].ToString());
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
                    txtfuncnome.Text = "";
                    txtfuncnome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcfuncao.SelectedIndex = 0;
        }

        private void dvgfuncao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtfunccodi.Text = dvgfuncao.Rows[e.RowIndex].Cells["FUNCCODI"].Value.ToString();
            txtfunccodi_Leave(null, null);
            tbcfuncao.SelectedIndex = 1;
            txtfuncnome.Focus();
            edicao = true;
            cblcbo.SelectedItem = cbo.FirstOrDefault(q => q.Split('-')[0].Trim() == dvgfuncao.Rows[e.RowIndex].Cells["CBOCODI"].Value.ToString());
        }
    }
}
