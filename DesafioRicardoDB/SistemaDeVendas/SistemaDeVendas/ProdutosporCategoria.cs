using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//info.dal para usar as referencias de conexão com o banco de dados
using Infos.DAL;

namespace SistemaDeVendas
{
    public partial class ProdutosporCategoria : Form
    {
        public ProdutosporCategoria()
        {
            InitializeComponent();
        }

        private void ProdutosporCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Meusformularios.produtosporCategoria = null;
        }

        private void ProdutosporCategoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }
        /// <summary>
        /// após buscar passa para o combobox_categoria os valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            this.pesquisar((int)comboBox_categoria.SelectedValue);
        }
        /// <summary>
        /// busca o codigo da categoria
        /// </summary>
        /// <param name="codigoCategoria"></param>
        public void pesquisar(int codigoCategoria)
        {
            this.produtoBindingSource.DataSource =
                //busca especifica ()pesquisa todos os produtos onde o "codigoCategoria" é igual ao "Codigocategoria" 
                DataContextFactory.DataContext.Produto.Where(x => x.Codigocategoria == codigoCategoria);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
