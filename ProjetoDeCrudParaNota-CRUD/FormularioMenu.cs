using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroMenu
{
    public partial class FormularioMenu : Form
    {
        public FormularioMenu()
        {
            InitializeComponent();
        }

        private void AbrirCadastroDeFuncionariosClick(object sender, EventArgs e)
        {
            Cadastro formCadastro = new Cadastro();
            formCadastro.Show();
        }

        private void SairClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar?",
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
