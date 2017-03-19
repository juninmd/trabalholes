﻿using System;
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
    }
}
