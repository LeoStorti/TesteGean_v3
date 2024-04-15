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
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
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
            //DivideByZeroException 345
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
