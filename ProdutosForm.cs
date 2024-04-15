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
    public partial class ProdutosForm : Form

    {   
        public ProdutosForm()
        {
            InitializeComponent();
        }

        private void ProdutosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_LeoDataSet3.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter1.Fill(this.banco_LeoDataSet3.Produtos);
            // TODO: esta linha de código carrega dados na tabela 'banco_LeoDataSet2.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.banco_LeoDataSet2.Produtos);

        }

        private void CadastroProd_Click(object sender, EventArgs e)
        {
            { // LEONARDO COMENTARIO MEU- Criar formulario de Cadastro para Novo produto
                //// Cria uma instância do formulário de cadastro de clientes
                NovoProduto produtoForm = new NovoProduto();

                //// Exibe o formulário de cadastro de clientes
                produtoForm.Show();

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                // Verifica se há uma linha selecionada no DataGridView
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

                }
                //{
                //    // Obtém o NomeProduto do produto selecionado na linha do DataGridView
                //    string nomeProduto = dataGridView2.SelectedRows[0].Cells["NomeProduto"].Value.ToString();

                //    // Chama o método ExcluirProduto da classe AcessoDadosProdutos passando o nome do produto
                //   acessoDadosProdutos.ExcluirProduto(nomeProduto);

                //    // Atualiza o DataGridView para refletir as mudanças
                //    RetornaDadosProdutos();

                //    // Exibe uma mensagem de sucesso
                //    MessageBox.Show("Produto excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    // Se nenhuma linha estiver selecionada, exibe uma mensagem para selecionar um produto
                //    MessageBox.Show("Por favor, selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}


            }


        }

        private void RetornaDadosProdutos()
        {
            throw new NotImplementedException();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Verifica se o clique foi feito na coluna de um botão de exclusão
                if (e.ColumnIndex == dataGridView2.Columns["Excluir"].Index && e.RowIndex >= 0)
                {
                    // Obtém o valor da célula na coluna "NomeProduto" da linha clicada
                    string nomeProduto = dataGridView2.Rows[e.RowIndex].Cells["NomeProduto"].Value.ToString();

                    // Confirmação para excluir o registro
                    DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o produto " + nomeProduto + "?",
                                                           "Excluir Produto",
                                                           MessageBoxButtons.YesNo,
                                                           MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Código para excluir o produto com base no nome
                        acessoDadosProdutos.ExcluirProduto(nomeProduto);

                        // Atualiza o DataGridView após a exclusão
                        RetornaDadosProdutos();
                    }
                }
            }
        }

        private void ConsultaProd_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            { // LEONARDO COMENTARIO MEU - Criar formulario de Cadastro para Novo produto
                //// Cria uma instância do formulário de cadastro de clientes
                NovoProduto produtoForm = new NovoProduto();

                //// Exibe o formulário de cadastro de clientes
                produtoForm.Show();

            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Não necessário, iria abrir outra janela
            //{
            //    ProdutosForm produtosForm = new ProdutosForm();

            //    // Exibindo o formulário de cadastro de fornecedores
            //    produtosForm.Show();
            //}
        }
    }

    internal class acessoDadosProdutos
    {
        internal static void ExcluirProduto(string nomeProduto)
        {
            throw new NotImplementedException();
        }
    }
}
