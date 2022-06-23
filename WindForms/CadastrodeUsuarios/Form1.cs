namespace CadastrodeUsuarios
{
    public partial class Form1 : Form
    {

        string nome;
        string telefone;
        string cpf;
        string senha;
        string login;
        string status;
        bool ativo;
        bool inativo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool ativo = false, inativo = false;
           
            foreach (string opc in cbStatus.CheckedItems)
            {
                if (opc == "Ativo")
                {
                    ativo = true;
                }
                if (opc == "inativo")
                {
                    inativo = true;
                }
               
            }
            string cadastro;

            cadastro = "";
            if (cbTipo.Text == "administrador") cadastro = "administrador";
           
            else if (cbTipo.Text == "usuário") cadastro = "usuário";

            Usuario usuario = new Usuario(tbNome.Text, tbTelefone.Text, tbCpf.Text, tbLogin.Text, tbSenha.Text, cbTipo.Text,cbStatus.Text, ativo,inativo, cadastro) ;
            usuario.Exibir();
        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbTelefone.Clear();   
            tbCpf.Clear();
            tbLogin.Clear();
            tbSenha.Clear();
            cbTipo.ResetText();
            foreach (int checados in cbStatus.CheckedIndices)
            {
                cbStatus.SetItemChecked(checados, false);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.atos_transparente;
        }
    }
}