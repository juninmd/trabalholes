using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LES_17_I_N.Dao;
using LES_17_I_N.Model;

namespace LES_17_I_N
{
    public partial class frmendereco : Form
    {
        public frmendereco()
        {
            InitializeComponent();
        }
        public frmendereco(string cep)
        {
            InitializeComponent();
            txtendcodi.Text = cep;
            avancar();
            Bairros = GetBairros();
            txtendnome.Focus();
            ShowDialog();

        }
        public BairroDao BairroDao = new BairroDao();
        public EnderecoDao EnderecoDao = new EnderecoDao();

        public List<string> Bairros { get; set; }

        public bool edicao { get; set; }

        private void limpar()
        {
            txtendcodi.Clear(); // Limpa o textbox
            txtendnome.Clear(); // Limpa o textbox
            txtendcodi.Focus(); // Vai para o textbox código
            cblbai.SelectedItem = null;
            edicao = false;
            DgvDados();
        }

        private EnderecoModel Entidade()
        {
            if (String.IsNullOrEmpty(txtendcodi.Text) ||
                String.IsNullOrEmpty(txtendnome.Text) ||
                (cblbai.SelectedItem) == null)
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new EnderecoModel
            {
                ENDCEP = txtendcodi.Text,
                ENDENDE = txtendnome.Text,
                BAICODI = int.Parse(cblbai.Text.Split('-')[0])
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                EnderecoDao.Update(entidade);
            else
            {
                EnderecoDao.Insert(entidade);
            }

            limpar();
            txtendcodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            EnderecoDao.Update(entidade);
            limpar();
            txtendcodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtendcodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            EnderecoDao.Delete(txtendcodi.Text);
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = EnderecoDao.GetAll();
            cblbai.Items.Clear();
            cblbai.Items.AddRange(Bairros.ToArray());
            if (dt.Rows.Count > 0)
                dvgbairro.DataSource = dt;
        }

        private void frmendereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmendereco_Load(object sender, EventArgs e)
        {
            Bairros = GetBairros();
            DgvDados();
        }

        private List<string> GetBairros()
        {
            var lista = new List<string>();
            var all = BairroDao.GetAll();
            foreach (var item in all.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["BAICODI"]} - {row["BAINOME"]}");
            }
            return lista;
        }

        public void txtendcodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtendcodi.Text))
                return;

            var dr = EnderecoDao.GetById(txtendcodi.Text);
            if (dr.Read())
            {
                txtendcodi.Text = dr["ENDCEP"].ToString();
                txtendnome.Text = dr["ENDENDE"].ToString();
                cblbai.SelectedItem = Bairros.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["BAICODI"].ToString());
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
                    txtendnome.Text = "";
                    txtendnome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcbairro.SelectedIndex = 0;
        }

        public void avancar()
        {
            tbcbairro.SelectedIndex = 1;
        }

        private void dvgbairro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtendcodi.Text = dvgbairro.Rows[e.RowIndex].Cells["ENDCEP"].Value.ToString();
            txtendcodi_Leave(null, null);
            tbcbairro.SelectedIndex = 1;
            txtendnome.Focus();
            edicao = true;
            cblbai.SelectedItem = Bairros.FirstOrDefault(q => q.Split('-')[0].Trim() == dvgbairro.Rows[e.RowIndex].Cells["BAICODI"].Value.ToString());
        }
    }
}
