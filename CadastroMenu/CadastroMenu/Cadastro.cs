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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BTNCadastro(object sender, EventArgs e)
        {



            try
            {

            }
            catch (Exception)
            {

            }



        }

        private void BTNLimpar_Limpar(object sender, EventArgs e)
        {
            TXTNome.Text = "";
            mtxtCPF.Text = "";
            mtxtSalario.Text = "";
            DTPDataDeNascimento.Text = "";
            CBCargo.Text = "Selecione Uma Opcao";
            CBSItuacao.Text = "Selecione Uma Opcao";

        }

        private void BTNFechar_Fechar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar?",
                "Question",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void TXTNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load_1(object sender, EventArgs e)
        {

        }

        private void validatedNome(object sender, EventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            if (TXTNome.Text == "")
            {
                error.SetError(TXTNome, "Campo obrigatorio");
            }
        }

        private void TXTNome_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            if (TXTNome.Text == "")
            {
                error.SetError(TXTNome, "Campo obrigatorio");
            }
        }
    }
}
