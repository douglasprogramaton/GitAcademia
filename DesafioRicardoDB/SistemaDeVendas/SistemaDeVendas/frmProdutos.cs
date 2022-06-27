using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infos.DAL;

namespace SistemaDeVendas
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Meusformularios.FormsProdutos = null;
        }

        private void codigocategoriaLabel_Click(object sender, EventArgs e)
        {

        }

        private void codigocategoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;



        }

        private void button_novo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();//addnew adiciona novo produto
        }
        /// <summary>
        /// grava o evento e passa uma mensagem dizendo que foi o produto armazendado no estoque .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gravar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();//gravar no banco de dados 
            //método refresh atualiza a categoria do produto.
            DataGridView_produto.Refresh();
            MessageBox.Show("Produto armazenado com sucesso!");
        }
        

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                if (this.categoriaPossuiProduto(this.CategoriaCorrente))
                {
                    MessageBox.Show("Não é posssivel excluir, existem produtos nessa categoria");
                }
                else
                {
                    
                    DataContextFactory.DataContext.SubmitChanges();
                    this.produtoBindingSource.RemoveCurrent();
                    MessageBox.Show("Produto excluido com sucesso!");
                }
            }
        }

        private void produtoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Categoria)e.Value).Descricao;
        }
        /// <summary>
        /// função auxiliar para verificar que o item ja foi excuido
        /// </summary>
        public Categoria CategoriaCorrente
        {
            get
            {
                //retorna um objeto categoria também(retorna o item excluido )
                return (Categoria)this.categoriaBindingSource.Current;
            }
        }
        /// <summary>
        ///  FAZ LISTAGEM DE TODOS OS PRODUTOS QUE O CODIGO DA CATEGORIA FOR IGUAL AO CODIGO DA CATEGORIA PASSADA NO MÉTODO
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        private bool categoriaPossuiProduto(Categoria categoria)
        {
            var produtos = DataContextFactory.DataContext.Produto.Where(x => x.Codigocategoria == categoria.Codigo);
            if (produtos.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void DataGridView_produto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
