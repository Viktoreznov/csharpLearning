using System;


using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jeuCouleur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            color_listBox.Items.Add("Rouge");
            color_listBox.Items.Add("Vert");
            color_listBox.Items.Add("Bleu");
            color_listBox.Items.Add("Jaune");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (color_listBox.SelectedIndex == -1)
                MessageBox.Show("Aucune couleur Selectionner", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                switch (color_listBox.SelectedIndex)
                {
                    case 0:
                        this.BackColor = Color.Red;
                        break;
                    case 1:
                        this.BackColor = Color.Green;
                        break;
                    case 2:
                        this.BackColor = Color.Blue;
                        break;
                    case 3:
                        this.BackColor = Color.Yellow;
                        break;
                        
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            color_listBox.SelectedIndex = -1;
        }
    }
}
