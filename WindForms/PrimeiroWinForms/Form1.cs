namespace PrimeiroWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BTOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Nome digitado pelo usuário è:" + TXTNome.Text+"e o email digitado é:"+TXTEmail.Text+"Endereço:" + TXTEndereço+"Telefone:" + TXTTelefone+"Bairro:" + TXTBairro+"Cidade:" + TXTCidade+"Sexo:" + TXTSexo);



        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no botão Cancelar");
        }
    }
}