
using System;

namespace SistemaCadastro
{
    partial class NovoFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_cnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_endereço = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtivo = new System.Windows.Forms.CheckBox();
            this.n_nivel = new System.Windows.Forms.NumericUpDown();
            this.nivel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banco_LeoDataSet4 = new SistemaCadastro.Banco_LeoDataSet4();
            this.produtosTableAdapter = new SistemaCadastro.Banco_LeoDataSet4TableAdapters.ProdutosTableAdapter();
            this.cadastroFornecedorTableAdapter1 = new SistemaCadastro.Banco_LeoDataSet1TableAdapters.CadastroFornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_LeoDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(146, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(186, 68);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 20);
            this.tb_username.TabIndex = 2;
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.Location = new System.Drawing.Point(186, 94);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(100, 20);
            this.tb_cnpj.TabIndex = 4;
            this.tb_cnpj.TextChanged += new System.EventHandler(this.tb_cnpj_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CNPJ";
            // 
            // tb_endereço
            // 
            this.tb_endereço.Location = new System.Drawing.Point(186, 120);
            this.tb_endereço.Name = "tb_endereço";
            this.tb_endereço.Size = new System.Drawing.Size(100, 20);
            this.tb_endereço.TabIndex = 6;
            this.tb_endereço.TextChanged += new System.EventHandler(this.tb_endereço_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(227, 184);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtivo
            // 
            this.btnAtivo.AutoSize = true;
            this.btnAtivo.Location = new System.Drawing.Point(146, 146);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(50, 17);
            this.btnAtivo.TabIndex = 8;
            this.btnAtivo.Text = "Ativo";
            this.btnAtivo.UseVisualStyleBackColor = true;
            this.btnAtivo.CheckedChanged += new System.EventHandler(this.btnAtivo_CheckedChanged);
            // 
            // n_nivel
            // 
            this.n_nivel.Location = new System.Drawing.Point(255, 147);
            this.n_nivel.Name = "n_nivel";
            this.n_nivel.Size = new System.Drawing.Size(120, 20);
            this.n_nivel.TabIndex = 9;
            this.n_nivel.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Location = new System.Drawing.Point(216, 149);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(33, 13);
            this.nivel.TabIndex = 10;
            this.nivel.Text = "Nível";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.fornecedorIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.produtosBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 296);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(429, 231);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorIdDataGridViewTextBoxColumn
            // 
            this.fornecedorIdDataGridViewTextBoxColumn.DataPropertyName = "FornecedorId";
            this.fornecedorIdDataGridViewTextBoxColumn.HeaderText = "FornecedorId";
            this.fornecedorIdDataGridViewTextBoxColumn.Name = "fornecedorIdDataGridViewTextBoxColumn";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.banco_LeoDataSet4;
            // 
            // banco_LeoDataSet4
            // 
            this.banco_LeoDataSet4.DataSetName = "Banco_LeoDataSet4";
            this.banco_LeoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // cadastroFornecedorTableAdapter1
            // 
            this.cadastroFornecedorTableAdapter1.ClearBeforeFill = true;
            // 
            // NovoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 570);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.nivel);
            this.Controls.Add(this.n_nivel);
            this.Controls.Add(this.btnAtivo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tb_endereço);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cnpj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovoFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovoUsuario";
            this.Load += new System.EventHandler(this.NovoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banco_LeoDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        //private void Tb_username_TextChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_cnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_endereço;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox btnAtivo;
        private System.Windows.Forms.NumericUpDown n_nivel;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Banco_LeoDataSet4 banco_LeoDataSet4;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Banco_LeoDataSet4TableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorIdDataGridViewTextBoxColumn;
        private Banco_LeoDataSet1TableAdapters.CadastroFornecedorTableAdapter cadastroFornecedorTableAdapter1;
    }
}