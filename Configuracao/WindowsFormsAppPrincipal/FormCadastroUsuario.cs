using BLL;
using Models;
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
    public partial class FormCadastroUsuario : Form
    {
        private bool alterar;
        public FormCadastroUsuario(bool _alterar = false, int _id = 0)
        {
            InitializeComponent();
            this.alterar = _alterar;

            if(alterar)
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(_id);
           /*if (alterar)
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarPorId(_Id);
            }*/
        }



        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            try
            {
                usuarioBindingSource.EndEdit();
                if (!alterar)
                    usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, confirmacaotextBox.Text);
                else
                    usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current, confirmacaotextBox.Text);
                
                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            if (!alterar)
            usuarioBindingSource.AddNew();
            //usuariobindingsource adicionando um novo registro
            //coloca o binding source emum extado de insercao
        }

        private void FormCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
