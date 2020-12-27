using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_TP2
{
    public partial class table : Form
    {
        List<float> lesnotes = new List<float>();
        public table()
        {
            InitializeComponent();
        }

        private void noteMat_TextChanged(object sender, EventArgs e)
        {
            if (noteMat.Text != "")
            {
                enrgNote.Enabled = true;
            }
            else
            {
                enrgNote.Enabled = false;
            }
        }

        private void enrgNote_Click(object sender, EventArgs e)
        {
            
            if (float.Parse(noteMat.Text) >= 0 && float.Parse(noteMat.Text) <= 20)
            {
                if (lesnotes.Count < 5)
                {
                    arrayOfNumber.Text = arrayOfNumber.Text + " | " + noteMat.Text;
                    lesnotes.Add(float.Parse(noteMat.Text));
                } else
                {
                    MessageBox.Show("One ne peut pas accepter que 5 note");
                }
            }
            else
                MessageBox.Show("Ajouter Un Note Valide Svp");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float somme = 0.0f;
            int supten = 0; int lessten = 0;
            for(int i = 0; i < lesnotes.Count; i++)
            {
                somme += lesnotes[i];
                if (lesnotes[i] >= 10)
                    supten++;
                else
                    lessten++;
            }
            moy.Text = (somme / lesnotes.Count).ToString();
            more.Text = supten.ToString();
            less.Text = lessten.ToString();
        }
    }
}
