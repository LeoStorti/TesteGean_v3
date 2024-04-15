using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class NovoProduto : Form
    {
        public NovoProduto()
        {
            InitializeComponent();
        }

        private void lblFornecedor_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                // Criando uma instância de ConexaoBanco
                ConexaoBanco conexaoBanco = new ConexaoBanco();

                try
                {
                    // Abrir conexão
                    using (SqlConnection conexao = conexaoBanco.mConexao)
                    {
                        // Criar o comando SQL para inserção
                        string query = "INSERT INTO Produtos (NomeProduto, Fornecedor, Quantidade) VALUES (@NomeProduto, @Fornecedor, @Quantidade)";
                        SqlCommand cmd = new SqlCommand(query, conexao);
                        cmd.Parameters.AddWithValue("@NomeProduto", btnProduto.Text);
                        cmd.Parameters.AddWithValue("@Fornecedor", btnFornecedor.Text);
                        cmd.Parameters.AddWithValue("@Quantidade", btnQuantidade.Text);
                        //cmd.Parameters.AddWithValue("@ProductId", );

                        //cmd.Parameters.AddWithValue("@Nivel", Convert.ToInt32(Math.Round(n_nivel.Value, 0)));

                        // Abrir a conexão, se não estiver aberta
                        if (conexao.State != ConnectionState.Open)
                        {
                            conexao.Open();
                        }

                        // Executar o comando SQL
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Verificar se a inserção foi bem-sucedida
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cadastro do produto salvo com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Falha ao salvar o cadastro do produto.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Exibir mensagem de erro em caso de exceção
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }
    }
}
