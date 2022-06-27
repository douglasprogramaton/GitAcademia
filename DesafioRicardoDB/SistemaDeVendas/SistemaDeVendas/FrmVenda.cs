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
    public partial class FrmVenda : Form
    {
        public FrmVenda()
        {
            InitializeComponent();
        }

        private void FrmVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Meusformularios.FrmVenda = null;
        }
        /// <summary>
        /// função Auxilia no carregamento DataGridView com dados das compras usando tambem o itemvenda
        /// </summary>
        public Venda VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }
        /// <summary>
        /// função que Auxilia no carregamento DataGridView
        /// </summary>
        public ItemVenda ItemCorrente
        {
            get { return (ItemVenda)this.itemVendaBindingSource.Current; }
        }
       
        private void FrmVenda_Load(object sender, EventArgs e)
        {
            this.pessoaBindingSource.DataSource = DataContextFactory.DataContext.Pessoa;

             this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Venda;
              this.produtoBindingSource.DataSource=DataContextFactory.DataContext.Produto;
            this.vendaBindingSource.AddNew();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button_novavenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            ComboBox_codigoPessoa.Enabled = false;
            groupBox_novavenda.Visible = true;
            button_novavenda.Enabled= false;
            //busca os item da DataGridView (todos os itens)
            this.itemVendaBindingSource.DataSource = DataContextFactory.DataContext.ItemVenda.Where(x => x.CodigoProduto == this.VendaCorrente.CodigoVenda);
           
            NovoItem();
        }
        /// <summary>
        /// função de adicionar novos itens.
        /// quando clicar em nova venda ja sera adicionado um novo item para facilitar para o usuário.
        /// </summary>
        private void NovoItem()
        {
            this.itemVendaBindingSource.AddNew();
            //diz que para o novo item de venda que seu código da venda é a venda corrente
            this.ItemCorrente.CodigoVenda =this.VendaCorrente.CodigoVenda;
            //diz que a quantidade ira iniciar em "1" ou seja quando o cliente adicionar uma nova venda essa venda sera de numero 1 ou primeira 
            this.ItemCorrente.Quantidade = 1;
        }

        private void button_novoitem_Click(object sender, EventArgs e)
        {
            this.itemVendaBindingSource.EndEdit();
            //método refresh para atualizar o DataGridView ao clicar em novo item
            DataGridView_itemVenda.Refresh();
            //SubmitchangeS para gravar no Banco de dados
            DataContextFactory.DataContext.SubmitChanges();
            MostrarValoresSomados();
            NovoItem();
        }

        private void DataGridView_itemVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //se o value for diferente de vazio(null) ea coluna for igual a "1"
            if(e.Value !=null&& e.ColumnIndex == 1)
            {//valor sera a descrição do produto
                e.Value = ((Produto)e.Value).Descricao;
            }
        }

        private void codigoProdutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (ComboBox_codigoProduto.SelectedItem !=null)
            {//pega o produto e armazena na variavel "prod" ou seja pega o objeto e armazena na variavel declarada 
                var prod =(Produto)ComboBox_codigoProduto.SelectedItem;
                // casting para dizer que o valor é inteiro
                this.ItemCorrente.CodigoProduto = (int)prod.Codigo;
                this.ItemCorrente.valor=(decimal)prod.Valor;
                // Se o meu combobox for nulo ele não faz nada se for diferente de null significa que eu adicionei um produto
                //e diz que o codigo do produto é o codigo armazenado na variavel "prod" e o valor também
            }
        }
        /// <summary>
        /// realizara o calculo para somar valores e adicionar no DataGridView_itemVenda apresentando o valor total da venda
        /// </summary>
        private void MostrarValoresSomados()
        {
            decimal total=0;
            //foreach para percorrer o DataGridView_itemVenda que pegar o valor e quantidade e somara para mostar o gridview novamente
            foreach (DataGridViewRow dgv in DataGridView_itemVenda.Rows)
            {//converte a celula 2 do DataGridView_itemVenda em double
                decimal valor1 = Convert.ToDecimal(dgv.Cells[2].Value);
                decimal valor2 = Convert.ToDecimal(dgv.Cells[3].Value);
                decimal subtotal =valor1* valor2;
                dgv.Cells[4].Value = subtotal;
                total = total + subtotal;
            }
            this.VendaCorrente.Valor = total;
        }

        private void button_finalizarpedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar a venda ?","confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //cancela o item que esta sendo adicionado ao clicar no botão novo item 
                this.itemVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;//para ele iniciar com desconto igual a zero
                button_novoitem.Enabled = false;
                ComboBox_codigoProduto.Enabled = false; 
                quantidadeTextBox.Enabled = false;              
                valorTextBox.Enabled = false;
                codigoVendaTextBox.Enabled = false;
                TextBox_desconto.ReadOnly = false;
                TextBox_desconto.Focus();
                button_finalizarpedido.Enabled = false;
                button_finalizarvenda.Enabled = true;
            }
        }

        private void button_finalizarvenda_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(TextBox_desconto.Text);
            this.VendaCorrente.ValorPago = (decimal)(this.VendaCorrente.Desconto);//valor pago é o valor da venda menos o desconto
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            TextBox_desconto.Enabled = false;
            button_finalizarvenda.Enabled=false;
            button_imprimir.Enabled=true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
