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
            new frmpais().ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmestado().ShowDialog();
        }

        private void municípioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmmunicipio().ShowDialog();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmbairro().ShowDialog();
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmendereco().ShowDialog();
        }

        private void cBOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmcbo().ShowDialog();
        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmfuncao().ShowDialog();
        }

        private void tipoHorárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmtipohorario().ShowDialog();
        }

        private void deptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmdepto().ShowDialog();
        }

        private void horárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmhorario().ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmfuncionario().ShowDialog();

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmsobre().ShowDialog();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmunidade().ShowDialog();
        }

        private void ramosDeAtividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmramo().ShowDialog();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmgrupo().ShowDialog();
        }
    }
}
