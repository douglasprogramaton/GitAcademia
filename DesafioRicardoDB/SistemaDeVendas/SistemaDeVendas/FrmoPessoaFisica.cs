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
    public partial class FrmoPessoaFisica : Form
    {
        public FrmoPessoaFisica()
        {
            InitializeComponent();
        }

        private void FrmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Meusformularios.FormsPessoaFisica = null;
        }

        private void FrmoPessoaFisica_Load(object sender, EventArgs e)
        {
            this.pessoaBindingSource.DataSource =
                DataContextFactory.DataContext.Pessoa;
        }
        public Pessoa Pessoacorrent
        { get
            {
                return (Pessoa)this.pessoaBindingSource.Current;
            } 
        }

        private void button_novo_Click(object sender, EventArgs e)
        {
            this.pessoaBindingSource.AddNew();
            

        }

        private void button_gravar_Click(object sender, EventArgs e)
        {
            this.pessoaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Pessoa armazenada com sucesso!");

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.pessoaBindingSource.CancelEdit();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?","Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.pessoaBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Pessoa excluida com sucesso!");
            }
        }

        private void telefoneLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
