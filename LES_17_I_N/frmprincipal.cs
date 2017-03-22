using System;
using System.Windows.Forms;

namespace LES_17_I_N
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close(); //fecha o formulário atual
        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmpais().Show();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmestado().Show();
        }

        private void municípioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmmunicipio().Show();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmbairro().Show();
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmendereco().Show();
        }

        private void cBOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmcbo().Show();
        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmfuncao().Show();
        }

        private void tipoHorárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmtipohorario().Show();
        }

        private void deptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmdepto().Show();
        }

        private void horárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
