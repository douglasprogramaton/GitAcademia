namespace GaragemDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        /// <summary>
        /// Evento fechar onde pergunta ao usuario se deseja mesmo sair do estacionamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair ?", "ESTACIONAMENTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastros = new frmCadastro();//chamando frmCadastrar   
            cadastros.TopLevel = false;// avisa que nao é painel de topo
            cadastros.Dock = DockStyle.Fill;// avisa que vai ter dockStule = fill que significa preencher
            panel_centro.Controls.Clear();//limpa o painel
            panel_centro.Controls.Add(cadastros);// adiciona do forms no painel
            cadastros.Show();// manda aparecer
            panel_escolha.Top = button_cadastrar.Top;// faz o panel_escolha indicar onde esta posicionado
        }

   

        private void button_inicio_Click(object sender, EventArgs e)
        {
            panel_centro.Controls.Clear();//limpa
            panel_escolha.Top = button_inicio.Top;
        }
    }
}