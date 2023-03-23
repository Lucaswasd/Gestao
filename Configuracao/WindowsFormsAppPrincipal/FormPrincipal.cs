using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuarios frm = new FormBuscarUsuarios())
            {
                frm.ShowDialog();
            }
        }

        

        private void permissõesDeGruposDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormPermissao frm = new FormPermissao())
            {
                frm.ShowDialog();
            }
        }

        private void gruposDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormGrupoUsuario frm = new FormGrupoUsuario())
            {
                frm.ShowDialog();
            }

        }
    }
}
