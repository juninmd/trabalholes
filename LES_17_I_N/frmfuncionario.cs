using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public DeptoDao DeptoDao = new DeptoDao();
        public FuncaoDao FuncaoDao = new FuncaoDao();
        public HorarioDao HorarioDao = new HorarioDao();
        public EnderecoDao EnderecoDao = new EnderecoDao();

        public List<string> Departamentos { get; set; }
        public List<string> Funcoes { get; set; }
        public List<string> Horarios { get; set; }

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
            txtfunnumero.Clear();
            txtfunpais.Clear();
            txtfunestado.Clear();
            cblfunfunc.SelectedItem = null;
            cblfundep.SelectedItem = null;
            cblfunhorario.SelectedItem = null;
            edicao = false;
            DgvDados();
        }

        private FuncionarioModel Entidade()
        {
            if (String.IsNullOrEmpty(txtfuncodi.Text) ||
                String.IsNullOrEmpty(txtfunnome.Text) ||
                String.IsNullOrEmpty(txtfundtna.Text) ||
                String.IsNullOrEmpty(txtfuncpf.Text) ||
                String.IsNullOrEmpty(txtfunrg.Text) ||
                String.IsNullOrEmpty(txtfunsala.Text) ||
                String.IsNullOrEmpty(txtfunfone.Text) ||
                String.IsNullOrEmpty(txtfuncelular.Text) ||
                String.IsNullOrEmpty(txtfuncel1.Text) ||
                String.IsNullOrEmpty(txtfuncep.Text) ||
                String.IsNullOrEmpty(txtfunend.Text) ||
                String.IsNullOrEmpty(txtfuncidade.Text) ||
                String.IsNullOrEmpty(txtfunbairro.Text) ||
                String.IsNullOrEmpty(txtfuncodi.Text) ||
                String.IsNullOrEmpty(txtfunnumero.Text) ||
                cblfunfunc.SelectedItem == null ||
                cblfundep.SelectedItem == null ||
                cblfunhorario.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new FuncionarioModel
            {
                FUNCODI = int.Parse(txtfuncodi.Text),
                FUNNOME = txtfunnome.Text,
                ENDCEP = txtfuncep.Text,
                FUNCCODI = int.Parse(cblfunfunc.SelectedItem.ToString().Split('-')[0]),
                FUNCEL1 = txtfuncel1.Text,
                FUNCELU = txtfuncelular.Text,
                FUNCPF = txtfuncpf.Text,
                FUNDTNA = DateTime.Parse(txtfundtna.Text),
                FUNFONE = txtfunfone.Text,
                FUNNUME = int.Parse(txtfunnumero.Text),
                FUNRG = txtfunrg.Text,
                FUNSALA = Double.Parse(txtfunsala.Text),
                HORCODI = int.Parse(cblfunhorario.SelectedItem.ToString().Split('-')[0]),
                DEPCODI = int.Parse(cblfundep.SelectedItem.ToString().Split('-')[0])
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
            cblfunfunc.Items.Clear();
            cblfunhorario.Items.Clear();
            cblfundep.Items.Clear();

            cblfundep.Items.AddRange(Departamentos.ToArray());
            cblfunfunc.Items.AddRange(Funcoes.ToArray());
            cblfunhorario.Items.AddRange(Horarios.ToArray());
            if (dt.Rows.Count > 0)
                dvgfuncionario.DataSource = dt;
        }

        private void frmfuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private List<string> getDepartamentos()
        {
            var lista = new List<string>();
            var itens = DeptoDao.GetAll();
            foreach (var item in itens.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["DEPCODI"]} - {row["DEPNOME"]}");
            }
            return lista;
        }


        private List<string> getFuncoes()
        {
            var lista = new List<string>();
            var itens = FuncaoDao.GetAll();
            foreach (var item in itens.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["FUNCCODI"]} - {row["FUNCNOME"]}");
            }
            return lista;
        }

        private List<string> getHorario()
        {
            var lista = new List<string>();
            var itens = HorarioDao.GetAll();
            foreach (var item in itens.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["HORCODI"]} - {row["HORNOME"]}");
            }
            return lista;
        }

        private void txtfunccodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfuncodi.Text))
                return;

            var dr = FuncionarioDao.GetFullById(int.Parse(txtfuncodi.Text));
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
                txtfuncep.Text = dr["ENDCEP"].ToString();
                txtfunend.Text = dr["ENDENDE"].ToString();
                txtfuncidade.Text = dr["MUNNOME"].ToString();
                txtfunbairro.Text = dr["BAINOME"].ToString();
                txtfunestado.Text = dr["ESTNOME"].ToString();
                txtfunpais.Text = dr["PAINOME"].ToString();
                txtfunnumero.Text = dr["FUNNUME"].ToString();

                cblfundep.SelectedItem = Departamentos.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["DEPCODI"].ToString());
                cblfunfunc.SelectedItem = Funcoes.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["FUNCCODI"].ToString());
                cblfunhorario.SelectedItem = Horarios.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["HORCODI"].ToString());
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
                    var tempoCodi = txtfuncodi.Text;
                    limpar();
                    txtfuncodi.Text = tempoCodi;
                    txtfunnome.Focus();
                }
            }
            dr.Close();
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
            txtfunccodi_Leave(null, null);
            tbcfuncionario.SelectedIndex = 1;
            txtfunnome.Focus();
            edicao = true;
        }

        private void frmfuncionario_Load(object sender, EventArgs e)
        {
            Departamentos = getDepartamentos();
            Funcoes = getFuncoes();
            Horarios = getHorario();
            DgvDados();

        }

        private void txtfuncep_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtfuncep.Text))
                return;

            var dr = EnderecoDao.GetFullById(txtfuncep.Text);
            if (dr.Read())
            {
                txtfuncep.Text = dr["ENDCEP"].ToString();
                txtfunend.Text = dr["ENDENDE"].ToString();
                txtfuncidade.Text = dr["MUNNOME"].ToString();
                txtfunbairro.Text = dr["BAINOME"].ToString();
                txtfunestado.Text = dr["ESTNOME"].ToString();
                txtfunpais.Text = dr["PAINOME"].ToString();
            }
            else
            {
                if ((MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                {
                    LimparCep();
                }
                else
                {
                    var form = new frmendereco(txtfuncep.Text);
                    LimparCep();
                }
            }
            dr.Close();

        }
        private void LimparCep()
        {
            txtfuncep.Clear();
            txtfunend.Clear();
            txtfuncidade.Clear();
            txtfunbairro.Clear();
            txtfunpais.Clear();
            txtfunestado.Clear();
        }

    }
}
