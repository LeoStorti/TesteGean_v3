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
        private int mfornecedorId;

        public static DataTable DataSource { get; internal set; }

        public NovoFornecedor(int lfornecedorId)
        {
            mfornecedorId = lfornecedorId;
            InitializeComponent();
        }

        public NovoFornecedor()
        {
        }

        public void btnSalvar_Click(object sender, EventArgs e)
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
            {
                // Verificar se há um ID de fornecedor válido
                if (mfornecedorId > 0)
                {
                    // Criar uma instância da classe de acesso aos dados
                    ConexaoBanco conexaoBanco = new ConexaoBanco();

                    try
                    {
                        // Consultar o banco de dados para obter os dados do fornecedor com base no ID
                        string query = "SELECT * FROM CadastroFornecedor WHERE Id = @Id";
                        SqlCommand cmd = new SqlCommand(query, conexaoBanco.mConexao);
                        cmd.Parameters.AddWithValue("@Id", mfornecedorId);

                        // Abrir a conexão
                        conexaoBanco.mConexao.Open();

                        // Executar o comando SQL e obter o leitor de dados
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Verificar se há linhas retornadas
                        if (reader.HasRows)
                        {
                            // Ler os dados do fornecedor e preencher os campos do formulário
                            while (reader.Read())
                            {
                                tb_username.Text = reader["Nome"].ToString();
                                tb_cnpj.Text = reader["CNPJ"].ToString();
                                tb_endereço.Text = reader["Endereco"].ToString();
                                //n_nivel.Value = Convert.ToInt32(reader["Nivel"]);
                                // Preencher outros campos conforme necessário
                            }
                            conexaoBanco.mConexao.Close();

                            // Carregar os produtos relacionados ao fornecedor na grid
                            string produtosQuery = "SELECT * FROM Produtos WHERE FornecedorId = @FornecedorId";
                            SqlCommand produtosCmd = new SqlCommand(produtosQuery, conexaoBanco.mConexao);
                            produtosCmd.Parameters.AddWithValue("@FornecedorId", mfornecedorId);
                            SqlDataAdapter adapter = new SqlDataAdapter(produtosCmd);
                            DataTable produtosTable = new DataTable();
                            adapter.Fill(produtosTable);

                            // Definir a fonte de dados da grid como a tabela de produtos
                            dataGridView2.DataSource = produtosTable;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum fornecedor encontrado com esse ID .");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao recuperar os dados do fornecedor: " + ex.Message);
                    }
                    finally
                    {
                       // Fechar a conexão com o banco de dados
                        conexaoBanco.mConexao.Close();
                    }
                }
                else
                {
                    MessageBox.Show("ID de fornecedor inválido.");
                    this.Close(); // Fechar o formulário se o ID do fornecedor não for válido
                }
            }
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

        }
    }
}