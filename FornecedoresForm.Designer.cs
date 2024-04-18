// FornecedoresForm.cs
using System;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FornecedoresForm : Form
    {
        public FornecedoresForm(int mfornecedorId)
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Lógica para adicionar um novo fornecedor
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Lógica para excluir o fornecedor selecionado
        }

        private void dgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para editar o fornecedor selecionado
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            // Lógica para pesquisar ao pressionar Enter
        }
        private DataGridView dataGridView1;
        private Button btnExcluir;
        private Button btnNovo;
        private TextBox txbPesquisar;
        private Label lblPesquisar;
        private Banco_LeoDataSet banco_LeoDataSet;
        private BindingSource bancoLeoDataSetBindingSource;
        private System.ComponentModel.IContainer components;
        private BindingSource bancoLeoDataSetBindingSource1;
        private BindingSource usuarioBindingSource;
        private Banco_LeoDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private Banco_LeoDataSet1 banco_LeoDataSet1;
        private BindingSource cadastroFornecedorBindingSource;
        private Banco_LeoDataSet1TableAdapters.CadastroFornecedorTableAdapter cadastroFornecedorTableAdapter;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn nivelDataGridViewTextBoxColumn;
        private TabControl tabConsulta;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private NumericUpDown n_nivel;
        private CheckBox btnAtivo;
        private Button btnSalvar;
        private TextBox tb_endereço;
        private Label label3;
        private TextBox tb_cnpj;
        private Label label2;
        private TextBox tb_username;
        private Button btnCancelar;
        private Label label1;
        private DataGridView dataGridView2;
        private Banco_LeoDataSet5 banco_LeoDataSet5;
        private BindingSource cadastroFornecedorBindingSource1;
        private Banco_LeoDataSet5TableAdapters.CadastroFornecedorTableAdapter cadastroFornecedorTableAdapter1;
    }
}
