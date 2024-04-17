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
    public partial class FornecedoresForm : Form
    {

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cadastroFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_LeoDataSet1 = new SistemaCadastro.Banco_LeoDataSet1();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txbPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.banco_LeoDataSet = new SistemaCadastro.Banco_LeoDataSet();
            this.bancoLeoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoLeoDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new SistemaCadastro.Banco_LeoDataSetTableAdapters.UsuarioTableAdapter();
            this.cadastroFornecedorTableAdapter = new SistemaCadastro.Banco_LeoDataSet1TableAdapters.CadastroFornecedorTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_LeoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_LeoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoLeoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoLeoDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nomeDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.nivelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cadastroFornecedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 185);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cadastroFornecedorBindingSource
            // 
            this.cadastroFornecedorBindingSource.DataMember = "CadastroFornecedor";
            this.cadastroFornecedorBindingSource.DataSource = this.banco_LeoDataSet1;
            // 
            // banco_LeoDataSet1
            // 
            this.banco_LeoDataSet1.DataSetName = "Banco_LeoDataSet1";
            this.banco_LeoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(79, 283);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(472, 283);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button4_Click);
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(149, 63);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(267, 20);
            this.txbPesquisar.TabIndex = 5;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(90, 66);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 6;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // banco_LeoDataSet
            // 
            this.banco_LeoDataSet.DataSetName = "Banco_LeoDataSet";
            this.banco_LeoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bancoLeoDataSetBindingSource
            // 
            this.bancoLeoDataSetBindingSource.DataSource = this.banco_LeoDataSet;
            this.bancoLeoDataSetBindingSource.Position = 0;
            // 
            // bancoLeoDataSetBindingSource1
            // 
            this.bancoLeoDataSetBindingSource1.DataSource = this.banco_LeoDataSet;
            this.bancoLeoDataSetBindingSource1.Position = 0;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.bancoLeoDataSetBindingSource1;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // cadastroFornecedorTableAdapter
            // 
            this.cadastroFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            // 
            // nivelDataGridViewTextBoxColumn
            // 
            this.nivelDataGridViewTextBoxColumn.DataPropertyName = "Nivel";
            this.nivelDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelDataGridViewTextBoxColumn.Name = "nivelDataGridViewTextBoxColumn";
            // 
            // FornecedoresForm
            // 
            this.ClientSize = new System.Drawing.Size(766, 453);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txbPesquisar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FornecedoresForm";
            this.Load += new System.EventHandler(this.FornecedoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_LeoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_LeoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoLeoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoLeoDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Verificar se o evento foi acionado pelo botão na célula
                DataGridViewColumn columnId = dataGridView1.Columns["Id"];
                if (columnId != null && e.ColumnIndex == columnId.Index && e.RowIndex >= 0)
                {
                    // Obter o Id do fornecedor selecionado na célula clicada
                    int mfornecedorId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    // Criar uma instância do formulário NovoFornecedor, passando o Id do fornecedor selecionado
                    NovoFornecedor novoFornecedor = new NovoFornecedor(mfornecedorId);

                    // Exibir o formulário NovoFornecedor
                    novoFornecedor.Show();
                }
                else
                    MessageBox.Show("Algum problema aconteceu");
            }

            //-------------------------------------------------------------------------- Codigo antigo abaixo
            //{
            //    // Cria uma instância do formulário de cadastro de clientes
            //    NovoFornecedor cadastroForm = new NovoFornecedor();

            //    // Exibe o formulário de cadastro de clientes
            //    cadastroForm.Show();

            //}
            //-------------------------------------------------------------------------- Codigo antigo abaixo
            //// Verifica se o clique ocorreu em uma célula válida
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    // Obtém o ID do fornecedor selecionado
            //    int fornecedorId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

            //    // Consulta SQL para recuperar os produtos relacionados ao fornecedor selecionado
            //    string query = "SELECT * FROM Produtos WHERE FornecedorId = @FornecedorId";

            //    // Executa a consulta SQL
            //    DataTable produtosTable = null;
            //    using (SqlConnection connection = new SqlConnection("sua_string_de_conexao"))
            //    {
            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            // Adiciona o parâmetro @FornecedorId à consulta
            //            command.Parameters.AddWithValue("@FornecedorId", fornecedorId);

            //            // Abre a conexão com o banco de dados
            //            connection.Open();

            //            // Executa o comando SQL e preenche o DataTable com os resultados
            //            using (SqlDataReader reader = command.ExecuteReader())
            //            {
            //                produtosTable = new DataTable();
            //                produtosTable.Load(reader);
            //            }
            //        }
            //    }

            //    // Preenche a DataGridView de produtos com os dados obtidos
            //    NovoFornecedor.DataSource = produtosTable;
            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Cria uma instância do formulário de cadastro de clientes
                NovoFornecedor cadastroForm = new NovoFornecedor();

                // Exibe o formulário de cadastro de clientes
                cadastroForm.Show();

            }
        }

        private void FornecedoresForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco_LeoDataSet1.CadastroFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroFornecedorTableAdapter.Fill(this.banco_LeoDataSet1.CadastroFornecedor);
            // TODO: esta linha de código carrega dados na tabela 'banco_LeoDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.banco_LeoDataSet.Usuario);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                // Cria uma instância do formulário de cadastro de clientes
                NovoFornecedor cadastroForm = new NovoFornecedor();

                // Exibe o formulário de cadastro de clientes
                cadastroForm.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                // Cria uma instância do formulário de cadastro de clientes
                NovoFornecedor cadastroForm = new NovoFornecedor();

                // Exibe o formulário de cadastro de clientes
                cadastroForm.Show();

            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Não necessario, iria abrir outra janela
            //{
            //    ProdutosForm produtosForm = new ProdutosForm();

            //    // Exibindo o formulário de cadastro de fornecedores
            //    produtosForm.Show();
            //}
        }
    }
}