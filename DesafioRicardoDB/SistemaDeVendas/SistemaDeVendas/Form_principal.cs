using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVendas
{
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {// verifica se o Formulario categorias existe?
           
            if (Meusformularios.FormsCategoria == null)
            {
                //se ele for nulo eu crio o formulario categorias
                Meusformularios.FormsCategoria = new frmCategoria();
                //se ele nao for nulo mando mostar e dar o foco na janela. 
                Meusformularios.FormsCategoria.Show();
                Meusformularios.FormsCategoria.Focus();
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nesse caso estou espelhando a funcionalidade do formulario categoria
            if (Meusformularios.FormsProdutos == null)
            {
                Meusformularios.FormsProdutos = new frmProdutos(); 

                Meusformularios.FormsProdutos.Show();
                Meusformularios.FormsProdutos.Focus();
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Meusformularios.produtosporCategoria== null)
            {
                Meusformularios.produtosporCategoria= new ProdutosporCategoria();

              Meusformularios.produtosporCategoria.Show();
              Meusformularios.produtosporCategoria.Focus();
            }
    }

        private void pEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Meusformularios.FormsPessoaFisica == null)
            {
                Meusformularios.FormsPessoaFisica = new FrmoPessoaFisica();

                Meusformularios.FormsPessoaFisica.Show();
                Meusformularios.FormsPessoaFisica.Focus();
            }
        }

        private void Form_principal_Load(object sender, EventArgs e)
        {

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Meusformularios.FrmVenda == null )
            {
                Meusformularios.FrmVenda= new FrmVenda();

                Meusformularios.FrmVenda.Show();
                Meusformularios.FrmVenda.Focus();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
