using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billetTrain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            classBox.Items.Add("Premiere Classe");
            classBox.Items.Add("Deuxiemme Classe");

            reduceBox.Items.Add("Pas de reduction");
            reduceBox.Items.Add("Carte Jeune");
            reduceBox.Items.Add("Carte Adult");
            reduceBox.Items.Add("Carte Famille");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double pb = Double.Parse(prixBase.Text);
            Double pht;
            if(classBox.SelectedIndex == 0)
            {
                pht = pb;
            }
            else
            {
                pht = pb + (pb * 0.2);
            }

            if (reduceBox.SelectedIndex == 1)
                pht -= pht * 0.4;
            else if (reduceBox.SelectedIndex == 2)
                pht -= pht * 0.3;
            else if (reduceBox.SelectedIndex == 3)
                pht -= pht * 0.5;

            prixHt.Text = pht.ToString();
            tva.Text = "TVA de 20%";
            prixTtc.Text = (pht + pht * 0.2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            classBox.SelectedIndex = -1;
            reduceBox.SelectedIndex = -1;
            prixBase.Text = "";
            prixHt.Text = "";
            prixTtc.Text = "";
            tva.Text = "";
        }
    }
}
