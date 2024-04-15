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
namespace SistemaCadastro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtUsuario.Select();
        }

        //Botão Entrar
        public void btnEntrar_Click(object sender, EventArgs e)
        {
            // Criando uma instância de ConexaoBanco
            ConexaoBanco conexaoBanco = new ConexaoBanco();

            try
            {
                // Abrir conexão
                conexaoBanco.mConexao.Open();

                // Consultar o banco de dados
                string query = "SELECT COUNT(*) FROM Usuario WHERE Login = @Login AND Senha = @Senha";
                SqlCommand cmd = new SqlCommand(query, conexaoBanco.mConexao);
                cmd.Parameters.AddWithValue("@Login", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Senha", txtPassword.Text);

                int result = (int)cmd.ExecuteScalar();

                // Fechar a conexão
                conexaoBanco.mConexao.Close();

                // Verificar o resultado da consulta
                if (result > 0)
                {
                    // Ocultar o formulário de login
                    this.Hide();

                    // Mostrar o próximo formulário
                    FrmPrincipal proximaTela = new FrmPrincipal();
                    proximaTela.Show();
                }
                else
                {
                    // Exibir uma mensagem de erro
                    MessageBox.Show("Usuário ou senha inválidos.");
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