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
        private int mfornecedorId;

        public FornecedoresForm()
        {
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabConsulta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.n_nivel = new System.Windows.Forms.NumericUpDown();
            this.btnAtivo = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tb_endereço = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.banco_LeoDataSet5 = new SistemaCadastro.Banco_LeoDataSet5();
            this.cadastroFornecedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroFornecedorTableAdapter1 = new SistemaCadastro.Banco_LeoDataSet5TableAdapters.CadastroFornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_LeoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_LeoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoLeoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoLeoDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_LeoDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFornecedorBindingSource1)).BeginInit();
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
            this.dataGridView1.DataSource = this.cadastroFornecedorBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 185);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.btnExcluir.Location = new System.Drawing.Point(10, 223);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(403, 223);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button4_Click);
            // 
            // txbPesquisar
            // 
            this.txbPesquisar.Location = new System.Drawing.Point(83, 6);
            this.txbPesquisar.Name = "txbPesquisar";
            this.txbPesquisar.Size = new System.Drawing.Size(267, 20);
            this.txbPesquisar.TabIndex = 5;
            this.txbPesquisar.TextChanged += new System.EventHandler(this.txbPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(24, 9);
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
            this.menuStrip1.Size = new System.Drawing.Size(1121, 33);
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
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.tabPage1);
            this.tabConsulta.Controls.Add(this.tabPage2);
            this.tabConsulta.Location = new System.Drawing.Point(12, 49);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.SelectedIndex = 0;
            this.tabConsulta.Size = new System.Drawing.Size(901, 468);
            this.tabConsulta.TabIndex = 8;
            this.tabConsulta.SelectedIndexChanged += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            this.tabConsulta.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.lblPesquisar);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.txbPesquisar);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.n_nivel);
            this.tabPage2.Controls.Add(this.btnAtivo);
            this.tabPage2.Controls.Add(this.btnSalvar);
            this.tabPage2.Controls.Add(this.tb_endereço);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_cnpj);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tb_username);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 158);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(429, 231);
            this.dataGridView2.TabIndex = 22;
            // 
            // n_nivel
            // 
            this.n_nivel.Location = new System.Drawing.Point(131, 85);
            this.n_nivel.Name = "n_nivel";
            this.n_nivel.Size = new System.Drawing.Size(120, 20);
            this.n_nivel.TabIndex = 21;
            // 
            // btnAtivo
            // 
            this.btnAtivo.AutoSize = true;
            this.btnAtivo.Location = new System.Drawing.Point(22, 84);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(50, 17);
            this.btnAtivo.TabIndex = 20;
            this.btnAtivo.Text = "Ativo";
            this.btnAtivo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(103, 122);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // tb_endereço
            // 
            this.tb_endereço.Location = new System.Drawing.Point(62, 58);
            this.tb_endereço.Name = "tb_endereço";
            this.tb_endereço.Size = new System.Drawing.Size(100, 20);
            this.tb_endereço.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Endereço";
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(62, 32);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(100, 20);
            this.tb_cnpj.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "CNPJ";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(62, 6);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 20);
            this.tb_username.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(22, 122);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // banco_LeoDataSet5
            // 
            this.banco_LeoDataSet5.DataSetName = "Banco_LeoDataSet5";
            this.banco_LeoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroFornecedorBindingSource1
            // 
            this.cadastroFornecedorBindingSource1.DataMember = "CadastroFornecedor";
            this.cadastroFornecedorBindingSource1.DataSource = this.banco_LeoDataSet5;
            // 
            // cadastroFornecedorTableAdapter1
            // 
            this.cadastroFornecedorTableAdapter1.ClearBeforeFill = true;
            // 
            // FornecedoresForm
            // 
            this.ClientSize = new System.Drawing.Size(1121, 529);
            this.Controls.Add(this.tabConsulta);
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
            this.tabConsulta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_LeoDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroFornecedorBindingSource1)).EndInit();
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

        }

        private void RetornaDadosProdutos()
        {
            throw new NotImplementedException();
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
            // TODO: esta linha de código carrega dados na tabela 'banco_LeoDataSet5.CadastroFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroFornecedorTableAdapter1.Fill(this.banco_LeoDataSet5.CadastroFornecedor);
            // TODO: esta linha de código carrega dados na tabela 'banco_LeoDataSet1.CadastroFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.cadastroFornecedorTableAdapter.Fill(this.banco_LeoDataSet1.CadastroFornecedor);
            // TODO: esta linha de código carrega dados na tabela 'banco_LeoDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.banco_LeoDataSet.Usuario);
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

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is FornecedoresForm form &&
                   mfornecedorId == form.mfornecedorId;
        }
    }
}