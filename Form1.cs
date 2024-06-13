using System.Data.SqlClient;

namespace AgendaTel003
{
    public partial class Form1 : Form
    {
        public List<Produto> listaProdutos;
        //public Login adm = new Login("adm", "12345");
        public SqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
            listaProdutos = new List<Produto>();
            conexao = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Estoque;Integrated Security=True;Connect Timeout=30;Encrypt=False;ApplicationIntent=ReadWrite;");

            try
            {
                conexao.Open();
                Console.WriteLine("Conexão criada.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao criar conexão");
            }

            AtualizarLista();

            dgvProdutos.DataSource = listaProdutos;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int selecionado = dgvProdutos.SelectedRows[0].Index;
            int produtoID = listaProdutos[selecionado].id;

            var deletar = conexao.CreateCommand();
            deletar.CommandText = "DELETE FROM Produto WHERE Id = @id ;";

            var paramId = new SqlParameter("id", produtoID);

            deletar.Parameters.Add(paramId);

            deletar.ExecuteNonQuery();
            MessageBox.Show("Produto deletado do banco!");

            listaProdutos.RemoveAt(selecionado);

            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = listaProdutos;
            dgvProdutos.Refresh();
        }

        public void AtualizarLista()
        {
            try
            {
                var comando = conexao.CreateCommand();
                comando.CommandText = "SELECT * FROM Produto;";

                SqlDataReader leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    Produto p = new Produto();
                    p.id = Convert.ToInt32(leitor["Id"]);
                    p.nome = Convert.ToString(leitor["Nome"]);
                    p.marca = Convert.ToString(leitor["Marca"]);
                    p.quantidade = Convert.ToString(leitor["Quantidade"]);

                    listaProdutos.Add(p);
                }

                leitor.Close();

                MessageBox.Show("Lista atualizada com o banco.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lista não foi atualizada com o banco!");
            }
        }
    }
}
