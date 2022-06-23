namespace ESTACIONAMENTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// botão de saida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Sair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja mesmo sair ?","ESTACIONAMENTO",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// botão de minimizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// botão de cadastro referenta a painel sentral 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cadastros_Click_1(object sender, EventArgs e)
        {
            frmCadastros cadastros = new frmCadastros();
            cadastros.TopLevel = false;
            cadastros.Dock = DockStyle.Fill;
            panel_Central.Controls.Clear();
            panel_Central.Controls.Add(cadastros);
            cadastros.Show();
            panel_Selecao.Top = button_Cadastros.Top;
        }
        /// <summary>
        /// botão início
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Inicio_Click(object sender, EventArgs e)
        {
            panel_Central.Controls.Clear();
            panel_Selecao.Top = button_Inicio.Top;
        }
    }
}