using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmfuncionario : Form
    {
        public frmfuncionario()
        {
            InitializeComponent();
        }

        public FuncionarioDao FuncionarioDao = new FuncionarioDao();
        public PaisDao PaisDao = new PaisDao();

        public List<string> Paises { get; set; }

        public bool edicao { get; set; }

        private void limpar()
        {
            txtfuncodi.Clear();
            txtfunnome.Clear();
            txtfundtna.Clear();
            txtfuncpf.Clear();
            txtfunrg.Clear();
            txtfunsala.Clear();
            txtfunfone.Clear();
            txtfuncelular.Clear();
            txtfuncel1.Clear();
            txtfuncep.Clear();
            txtfunend.Clear();
            txtfuncidade.Clear();
            txtfunbairro.Clear();
            txtfuncodi.Clear();
            cblfunc.SelectedItem = null;
            cblfunhorario.SelectedItem = null;
            edicao = false;
            DgvDados();
        }

        private FuncionarioModel Entidade()
        {
            if (String.IsNullOrEmpty(txtfuncodi.Text) ||
                String.IsNullOrEmpty(txtfunnome.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new FuncionarioModel
            {
                FUNCODI = int.Parse(txtfuncodi.Text),
                FUNNOME = txtfunnome.Text,
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                FuncionarioDao.Update(entidade);
            else
            {
                FuncionarioDao.Insert(entidade);
            }

            limpar();
            txtfuncodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            FuncionarioDao.Update(entidade);
            limpar();
            txtfuncodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfuncodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            FuncionarioDao.Delete(int.Parse(txtfuncodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = FuncionarioDao.GetAll();
            cblfunc.Items.Clear();
            cblfunhorario.Items.Clear();
            if (dt.Rows.Count > 0)
                dvgfuncionario.DataSource = dt;
        }

        private void frmfuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private List<string> GetPaises()
        {
            var lista = new List<string>();
            var pais = PaisDao.GetAll();
            foreach (var item in pais.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["PAICODI"]} - {row["PAINOME"]}");
            }
            return lista;
        }

        private void txtpaicodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfuncodi.Text))
                return;

            var dr = FuncionarioDao.GetById(int.Parse(txtfuncodi.Text));
            if (dr.Read())
            {
                txtfuncodi.Text = dr["FUNCODI"].ToString();
                txtfunnome.Text = dr["FUNNOME"].ToString();
                txtfundtna.Text = dr["FUNDTNA"].ToString();
                txtfuncpf.Text = dr["FUNCPF"].ToString();
                txtfunrg.Text = dr["FUNRG"].ToString();
                txtfunsala.Text = dr["FUNSALA"].ToString();
                txtfunfone.Text = dr["FUNFONE"].ToString();
                txtfuncelular.Text = dr["FUNCELU"].ToString();
                txtfuncel1.Text = dr["FUNCEL1"].ToString();
                txtfuncep.Text = dr["FUNCEP"].ToString();
                txtfunend.Text = dr["FUNDTNA"].ToString();
                txtfuncidade.Text = dr["FUNDTNA"].ToString();
                txtfunbairro.Text = dr["FUNDTNA"].ToString();
                txtfunpais.Text = dr["FUNDTNA"].ToString();

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
                    txtfunnome.Text = "";
                    txtfunnome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcfuncionario.SelectedIndex = 0;
        }

        private void dvgfuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtfuncodi.Text = dvgfuncionario.Rows[e.RowIndex].Cells["FUNCODI"].Value.ToString();
            txtpaicodi_Leave(null, null);
            tbcfuncionario.SelectedIndex = 1;
            txtfunnome.Focus();
            edicao = true;
        }

        private void frmfuncionario_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

    }
}
