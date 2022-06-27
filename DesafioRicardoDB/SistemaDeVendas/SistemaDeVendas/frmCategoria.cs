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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            // fechar formulario categoria
            Meusformularios.FormsCategoria = null;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {   // carregando BindingSource
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void label_categoria_Click(object sender, EventArgs e)
        {

        }

        private void button_novo_Click(object sender, EventArgs e)
        {  //A categoriaBindingSource tras todas as funções, então nao sera nessesario mecher no sql 
            this.categoriaBindingSource.AddNew();
        }

        private void button_gravar_Click(object sender, EventArgs e)
        {
            if (this.Valida())
            {

                this.categoriaBindingSource.EndEdit();

                //Usando a fabrica de conexões para gravar todos os dados no banco de dados
                //o método SubmitChanges grava todoas as alterações no banco de dados
                DataContextFactory.DataContext.SubmitChanges();
                dataGridView_categoria.Refresh();
                MessageBox.Show("Categoria armazenada com sucesso!");
            }
        }
        /// <summary>
        /// Validação da do textbox onde será preenchido a categoria.
        /// </summary>
        /// <returns></returns>
        private bool Valida()
        {
            if (textBox_categoria.Text.Trim() == String.Empty)
            {
                MessageBox.Show("O campo categoria é obrigatorio!");
                // nesse caso o método focus obriga o usuário a preencher o campo categoria
                textBox_categoria.Focus();
                return false;
            }
            return true;
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            //"MessageBoxButtons"--- é o tipo da janeja que escolhi com dois botões (yes ou no)
            //MessageBoxIcon--- icone da janela
            //se o resultado do dialogo for yes será excluido a categoria
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.categoriaPossuiProduto(this.CategoriaCorrente))
                {
                    MessageBox.Show("Não é posssivel excluir");
                }
               else
                {
                    this.categoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria excluida com sucesso!");
                }
           }

        }
        public Categoria CategoriaCorrente
        {
            get
            {
                //retorna um objeto categoria também(retorna o item excluido )
                return (Categoria)this.categoriaBindingSource.Current;
            }
        }
        /// <summary>
        /// busca todos os produtos que o "Codigocategoria" é igual ao "categotia.Codigo"
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        private bool categoriaPossuiProduto(Categoria categoria)
        {// FAZ LISTAGEM DE TODOS OS PRODUTOS QUE O CODIGO DA CATEGORIA FOR IGUAL AO CODIGO DA CATEGORIA PASSADA NO MÉTODO
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


    }
}
