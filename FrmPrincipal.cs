using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /*   private void button1_Click(object sender, EventArgs e)
           {
               // Cria uma instância do formulário de cadastro de clientes
              // FornecedoresForm fornecedoresForm = new FornecedoresForm();

               // Exibe o formulário de cadastro de clientes
              // fornecedoresForm.Show();

               /*{
                   // Cria uma instância do formulário de cadastro de clientes
                   NovoUsuario cadastroForm = new NovoUsuario();

                   // Exibe o formulário de cadastro de clientes
                   cadastroForm.Show();

           }*/

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                //    // Criando uma instância do formulário de cadastro de fornecedores
                FornecedoresForm fornecedoresForm = new FornecedoresForm();

                // Exibindo o formulário de cadastro de fornecedores
                fornecedoresForm.Show();
            }
            // Preservar o código abaixo, está funcionando normalmente

            }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosForm produtosForm = new ProdutosForm();

            // Exibindo o formulário de cadastro de fornecedores
            produtosForm.Show();
        }
    }
 }
