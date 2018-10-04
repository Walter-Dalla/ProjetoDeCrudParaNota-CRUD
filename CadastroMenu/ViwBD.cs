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
    public partial class ViwBD : Form
    {
        public ViwBD()
        {
            InitializeComponent();

        }
        void LimpaForm() {
            TXTCodigo.Text = "";
            TXTNome.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdSelectionChanged(object sender, EventArgs e)
        {
            TXTCodigo.Text = dgvFuncionarios.CurrentRow.Cells["codigo"].Value.ToString();
            TXTNome.Text = dgvFuncionarios.CurrentRow.Cells["nome"].Value.ToString();
        }

        private void TXTCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdNovo(object sender, EventArgs e)
        {
            grpDados.Enabled = true;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
            btnNovo.Enabled = false;
            LimpaForm();
            TXTCodigo.Focus();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnCSalvar(object sender, EventArgs e)
        {
            grpDados.Enabled = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
        }
    }
}
