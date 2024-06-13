using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTel003
{
    public partial class Form2 : Form
    {
        Form1 origem;
        //Login adm;
        public Form2(Form1 origem)
        {
            InitializeComponent();
            this.origem = origem;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Login usuario = new Login(txbUsuario.Text, txbSenha.Text);

            if (txbUsuario.Text == "adm" || txbSenha.Text == "12345")
            {
                origem.btnAdicionar.Enabled = true;
                origem.btnRemover.Enabled = true;
                origem.labelADM.Text = "Olá Administrador...";
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário sem permissões", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbxCiente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCiente.Checked)
            {
                btnEntrar.Enabled = true;
            }
        }
    }
}
