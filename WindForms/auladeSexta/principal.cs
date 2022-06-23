using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auladeSexta
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAutomovel fauto = new frmAutomovel();
            fauto.ShowDialog();

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAutomovel fauto = new frmAutomovel();
                fauto.ShowDialog();

        }

        private void automóveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutomovel fauto = new frmAutomovel();
            fauto.ShowDialog();
        }
    }   
}
