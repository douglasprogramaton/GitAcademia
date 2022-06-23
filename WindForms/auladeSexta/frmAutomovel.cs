using auladeSexta;
namespace auladeSexta
{
    public partial class frmAutomovel : Form
    {
        static List<Carro> carros = new List<Carro>();
        public frmAutomovel()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbFabricanteCarro.Clear();
           tbModeloCarro.Clear();
            foreach (int checados in lbOpcionais.CheckedIndices)
            {
                lbOpcionais.SetItemChecked(checados, false);
            }
            cbPortas.ResetText();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Modelo =" + tbModeloCarro.Text);
            //MessageBox.Show("Fabricante =" + tbFabricanteCarro.Text);
            bool ac = false, dh = false, abs = false, ve = false, ab = false;
            int portas;
            foreach (string opc in lbOpcionais.CheckedItems)
            {
                if (opc == "Ar condicionado")
                {
                    ac = true;
                }
                if (opc == "Direção hidráulica")
                {
                    dh = true;
                }
                if (opc == "Freios ABS")
                {
                    abs = true;
                }
                if (opc == "Vidros elétricos")
                {
                    ve = true;
                }
                if (opc == "Air bag")
                {
                    ab = true;
                }
            }
            portas = 0;
            if (cbPortas.Text == "2 portas") portas = 2;
            else if (cbPortas.Text == "3 portas") portas = 3;
            else if (cbPortas.Text == "4 portas") portas = 4;
            else if (cbPortas.Text == "5 portas") portas = 5;
            Carro c =new Carro(tbModeloCarro.Text, tbFabricanteCarro.Text, ac, dh, abs, ve, ab, portas);

            tbFabricanteCarro.Clear();
            tbFabricanteCarro.Clear();
            //lbOpcionais.ClearSelected();
            /*lbOpcionais.Items.Clear();
            lbOpcionais.Items.Add("Asas");*/
            foreach (int checados in lbOpcionais.CheckedIndices)
            {
                lbOpcionais.SetItemChecked(checados, false);
            }

            cbPortas.ResetText();
        }
        static void MostraListadeCarros()
        {
            foreach (Carro c in carros)
            {
                MessageBox.Show("Carro " + c.modelo + "\nFabricante " + c.fabricante + "\nDH " + c.dh + "\nAr " + c.ar + "\nABS " + c.abs + "\nAir bag " + c.airbag + "\nVidros eletrico " + c.ve + "\nPortas " + c.portas);
            }
        }

        private void frmAutomovel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgAutomoveis.Rows.Clear();
            foreach (Carro c in carros)
            {
                dgAutomoveis.Rows.Add(c.modelo, c.fabricante, c.ar, c.dh, c.abs, c.ve, c.airbag, c.portas);
            }


        }
    }
}