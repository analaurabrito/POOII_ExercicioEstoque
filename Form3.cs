using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTel003
{
    public partial class Form3 : Form
    {
        Form1 origem;
        public Form3(Form1 origem)
        {
            InitializeComponent();
            this.origem = origem;
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int proxID = origem.listaProdutos.Count + 1;
            Produto novo = new Produto(proxID, txbNome.Text, txbMarca.Text, txbQuantidade.Text);
            
            var inserir = origem.conexao.CreateCommand();
            inserir.CommandText = "INSERT INTO Produto (Nome, Marca, Quantidade)" + "VALUES (@nome, @marca, @quantidade)";

            var paramNome = new SqlParameter("nome", novo.nome);
            var paramMarca = new SqlParameter("marca", novo.marca);
            var paramQuant = new SqlParameter("quantidade", novo.quantidade);

            inserir.Parameters.Add(paramNome);
            inserir.Parameters.Add(paramMarca);
            inserir.Parameters.Add(paramQuant);

            inserir.ExecuteNonQuery();
            Console.WriteLine("Produto inserido no banco!");

            origem.listaProdutos.Add(novo);

            origem.dgvProdutos.DataSource = null;
            origem.dgvProdutos.DataSource = origem.listaProdutos;
            origem.dgvProdutos.Refresh();
            
            this.Close();
        }
    }
}
