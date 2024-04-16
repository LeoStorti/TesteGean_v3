using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SistemaCadastro // Projeto
{
    public partial class NovoFornecedor : Form
    {
        public NovoFornecedor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Criando uma instância de ConexaoBanco
            ConexaoBanco conexaoBanco = new ConexaoBanco();

            try
            {
                // Abrir conexão
                using (SqlConnection conexao = conexaoBanco.mConexao)
                {
                    // Criar o comando SQL para inserção
                    string query = "INSERT INTO CadastroFornecedor (Nome, CNPJ, Endereco, Nivel) VALUES (@Nome, @CNPJ, @Endereco, @Nivel)";
                    SqlCommand cmd = new SqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@Nome", tb_username.Text);
                    cmd.Parameters.AddWithValue("@CNPJ", tb_cnpj.Text);
                    cmd.Parameters.AddWithValue("@Endereco", tb_endereço.Text);
                    cmd.Parameters.AddWithValue("@Nivel", Convert.ToInt32(Math.Round(n_nivel.Value, 0)));

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
                        MessageBox.Show("Cadastro do fornecedor salvo com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Falha ao salvar o cadastro do fornecedor.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibir mensagem de erro em caso de exceção
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_cnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_endereço_TextChanged(object sender, EventArgs e)
        {

        }

        private void NovoUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_LeoDataSet4.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.banco_LeoDataSet4.Produtos);
            //DivideByZeroException 345
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Verifica se o clique ocorreu em uma célula válida
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Obtém o ID do fornecedor selecionado
                    int fornecedorId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Id"].Value);

                    // Consulta SQL para recuperar os produtos relacionados ao fornecedor selecionado
                    string query = "SELECT * FROM Produtos WHERE FornecedorId = @FornecedorId";

                    // Executa a consulta SQL
                    DataTable produtosTable = null;
                    using (SqlConnection connection = new SqlConnection("sua_string_de_conexao"))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Adiciona o parâmetro @FornecedorId à consulta
                            command.Parameters.AddWithValue("@FornecedorId", fornecedorId);

                            // Abre a conexão com o banco de dados
                            connection.Open();

                            // Executa o comando SQL e preenche o DataTable com os resultados
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                produtosTable = new DataTable();
                                produtosTable.Load(reader);
                            }
                        }
                    }

                    // Preenche a DataGridView de produtos com os dados obtidos
                    dataGridView2.DataSource = produtosTable;
                }
            }
        }
    }
}