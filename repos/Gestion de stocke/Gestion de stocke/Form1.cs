using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_stocke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void afficherFacruesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddClients fac = new frmAddClients();
            fac.Show();
        }

        private void listDesClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListClients flc = new frmListClients();
            flc.Show();
        }
    }
}
