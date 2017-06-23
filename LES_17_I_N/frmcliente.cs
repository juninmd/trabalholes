using System;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
        }

        public ClienteDao ClienteDao = new ClienteDao();
        public EnderecoDao EnderecoDao = new EnderecoDao();

        public bool edicao { get; set; }

        private void limpar()
        {
            txtclicodi.Clear();
            txtclinome.Clear();
            txtclifantasia.Clear();
            txtcliapelido.Clear();
            txtcliapelido.Clear();
            txtclilimite.Clear();
            txtclipricompra.Clear();
            txtclicnpj.Clear();
            txtcliie.Clear();
            txtcliemail.Clear();
            txtclifone.Clear();
            txtclicelular.Clear();
            txtclicel1.Clear();
            txtclinumero.Clear();
            txtclistatus.Clear();
            txtclicep.Clear();
            txtcliend.Clear();
            txtclicidade.Clear();
            txtclibairro.Clear();
            txtclipais.Clear();
            txtcliestado.Clear();
            edicao = false;
            DgvDados();
        }

        private ClienteModel Entidade()
        {
            if (String.IsNullOrEmpty(txtclicodi.Text) ||
                String.IsNullOrEmpty(txtclinome.Text) ||
                String.IsNullOrEmpty(txtclifantasia.Text) ||
                String.IsNullOrEmpty(txtcliapelido.Text) ||
                String.IsNullOrEmpty(txtclilimite.Text) ||
                String.IsNullOrEmpty(txtclipricompra.Text) ||
                String.IsNullOrEmpty(txtclicnpj.Text) ||
                String.IsNullOrEmpty(txtcliie.Text) ||
                String.IsNullOrEmpty(txtcliemail.Text) ||
                String.IsNullOrEmpty(txtclifone.Text) ||
                String.IsNullOrEmpty(txtclicelular.Text) ||
                String.IsNullOrEmpty(txtclicel1.Text) ||
                String.IsNullOrEmpty(txtclinumero.Text) ||
                String.IsNullOrEmpty(txtclistatus.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new ClienteModel
            {
                CLICODI = int.Parse(txtclicodi.Text),
                CLINOME = txtclinome.Text,
                CLIFANT = txtclifantasia.Text,
                CLIAPEL = txtcliapelido.Text,
                CLILIMI = double.Parse(txtclilimite.Text),
                CLIDTIN = DateTime.Parse(txtclipricompra.Text),
                CLICNPJ = txtclicnpj.Text,
                CLIINES = txtcliie.Text,
                CLIEMAI = txtcliemail.Text,
                CLIFONE = txtclifone.Text,
                CLICELU = txtclicelular.Text,
                CLICEL1 = txtclicel1.Text,
                CLINUME = txtclinumero.Text,
                CLISTAT = int.Parse(txtclistatus.Text),
                ENDCEP = txtclicep.Text
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                ClienteDao.Update(entidade);
            else
            {
                ClienteDao.Insert(entidade);
            }

            limpar();
            txtclicodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtclicodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            ClienteDao.Delete(int.Parse(txtclicodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = ClienteDao.GetAll();
            dvgcliente.DataSource = dt;
        }

        private void frmcliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }


        private void txtcliccodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtclicodi.Text))
                return;

            var dr = ClienteDao.GetById(int.Parse(txtclicodi.Text));
            if (dr.Read())
            {
                txtclicodi.Text = dr["CLICODI"].ToString();
                txtclinome.Text = dr["CLINOME"].ToString();
                txtclifantasia.Text = dr["CLIFANT"].ToString();
                txtcliapelido.Text = dr["CLIAPEL"].ToString();
                txtclilimite.Text = dr["CLILIMI"].ToString();
                txtclipricompra.Text = dr["CLIDTIN"].ToString();
                txtclicnpj.Text = dr["CLICNPJ"].ToString();
                txtcliie.Text = dr["CLIINES"].ToString();
                txtcliemail.Text = dr["CLIEMAI"].ToString();
                txtclifone.Text = dr["CLIFONE"].ToString();
                txtclicelular.Text = dr["CLICELU"].ToString();
                txtclicel1.Text = dr["CLICEL1"].ToString();
                txtclinumero.Text = dr["CLINUME"].ToString();
                txtclistatus.Text = dr["CLISTAT"].ToString();
                txtclicep.Text = dr["ENDCEP"].ToString();

                txtclicep_Leave(null, null);

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
                    var tempoCodi = txtclicodi.Text;
                    limpar();
                    txtclicodi.Text = tempoCodi;
                    txtclinome.Focus();
                }
            }
            dr.Close();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbccliente.SelectedIndex = 0;
        }

        private void dvgcliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtclicodi.Text = dvgcliente.Rows[e.RowIndex].Cells["CLICODI"].Value.ToString();
            txtcliccodi_Leave(null, null);
            tbccliente.SelectedIndex = 1;
            txtclinome.Focus();
            edicao = true;
        }

        private void frmcliente_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void txtclicep_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtclicep.Text))
                return;

            var dr = EnderecoDao.GetFullById(txtclicep.Text);
            if (dr.Read())
            {
                txtclicep.Text = dr["ENDCEP"].ToString();
                txtcliend.Text = dr["ENDENDE"].ToString();
                txtclicidade.Text = dr["MUNNOME"].ToString();
                txtclibairro.Text = dr["BAINOME"].ToString();
                txtcliestado.Text = dr["ESTNOME"].ToString();
                txtclipais.Text = dr["PAINOME"].ToString();
            }
            else
            {
                if ((MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                {
                    LimparCep();
                }
                else
                {
                    var form = new frmendereco(txtclicep.Text);
                    LimparCep();
                }
            }
            dr.Close();

        }
        private void LimparCep()
        {
            txtclicep.Clear();
            txtcliend.Clear();
            txtclicidade.Clear();
            txtclibairro.Clear();
            txtclipais.Clear();
            txtcliestado.Clear();
        }

    }
}
