using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LES_17_I_N.Dao;
using LES_17_I_N.Model;

namespace LES_17_I_N
{
    public partial class frmmunicipio : Form
    {
        public frmmunicipio()
        {
            InitializeComponent();
        }
        public MunicipioDao MunicipioDao = new MunicipioDao();
        public EstadoDao EstadoDao = new EstadoDao();

        public List<string> Estados { get; set; }

        public bool edicao { get; set; }

        private void limpar()
        {
            txtmuncodi.Clear(); // Limpa o textbox
            txtmunnome.Clear(); // Limpa o textbox
            txtmuncodi.Focus(); // Vai para o textbox código
            cblest.SelectedItem = null;
            edicao = false;
            DgvDados();
        }

        private MunicipioModel Entidade()
        {
            if (String.IsNullOrEmpty(txtmuncodi.Text) ||
                String.IsNullOrEmpty(txtmunnome.Text) ||
                (cblest.SelectedItem) == null)
            {
                MessageBox.Show("Preencha todos os campos!");
                return null;
            }

            return new MunicipioModel
            {
                MUNCODI = int.Parse(txtmuncodi.Text),
                MUNNOME = txtmunnome.Text,
                ESTCODI = int.Parse(cblest.Text.Split('-')[0])
            };
        }

        private void btnincluir_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            if (edicao)
                MunicipioDao.Update(entidade);
            else
            {
                MunicipioDao.Insert(entidade);
            }

            limpar();
            txtmuncodi.Focus();
        }

        private void btngravar_Click(object sender, System.EventArgs e)
        {
            var entidade = Entidade();
            if (entidade == null)
                return;

            MunicipioDao.Update(entidade);
            limpar();
            txtmuncodi.Focus();
        }

        private void btnexcluir_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(txtmuncodi.Text))
            {
                MessageBox.Show("Preencha o código!");
                return;
            }

            if (!edicao)
            {
                MessageBox.Show("Não é possível excluir algo que não existe!");
                return;
            }

            MunicipioDao.Delete(int.Parse(txtmuncodi.Text));
            this.limpar();
        }

        private void DgvDados()
        {
            var dt = MunicipioDao.GetAll();
            cblest.Items.Clear();
            cblest.Items.AddRange(Estados.ToArray());
            if (dt.Rows.Count > 0)
                dvgmunicipio.DataSource = dt;
        }

        private void frmmunicipio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }

        private void frmmunicipio_Load(object sender, EventArgs e)
        {
            Estados = GetEstados();
            DgvDados();
        }

        private List<string> GetEstados()
        {
            var lista = new List<string>();
            var pais = EstadoDao.GetAll();
            foreach (var item in pais.Rows)
            {
                var row = item as DataRow;
                lista.Add($"{row["ESTCODI"]} - {row["ESTNOME"]}");
            }
            return lista;
        }

        private void txtpaicodi_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtmuncodi.Text))
                return;

            var dr = MunicipioDao.GetById(int.Parse(txtmuncodi.Text));
            if (dr.Read())
            {
                txtmuncodi.Text = dr["MUNCODI"].ToString();
                txtmunnome.Text = dr["MUNNOME"].ToString();
                cblest.SelectedItem = Estados.FirstOrDefault(q => q.Split('-')[0].Trim() == dr["ESTCODI"].ToString());
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
                    txtmunnome.Text = "";
                    txtmunnome.Focus();
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            tbcmunicipio.SelectedIndex = 0;
        }

        private void dvgmunicipio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            txtmuncodi.Text = dvgmunicipio.Rows[e.RowIndex].Cells["MUNCODI"].Value.ToString();
            txtpaicodi_Leave(null, null);
            tbcmunicipio.SelectedIndex = 1;
            txtmunnome.Focus();
            edicao = true;
            cblest.SelectedItem = Estados.FirstOrDefault(q => q.Split('-')[0].Trim() == dvgmunicipio.Rows[e.RowIndex].Cells["ESTCODI"].Value.ToString());
        }
    }
}
