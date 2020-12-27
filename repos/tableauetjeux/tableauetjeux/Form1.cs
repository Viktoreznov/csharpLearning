using System;
using System.Collections.Generic;
using System.Collections;

using System.Windows.Forms;

namespace tableauetjeux
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList note = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            float val = float.Parse(txt.Text);

            if(val > 20 || val < 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                note.Add(val);
                
            }

            tab.Text += " | " + val;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float total = 0;
            int sup=0, inf=0;
            foreach(float x in note)
            {
                total += x;
            }
            lbmoy.Text = (total / note.Count).ToString();
            foreach (float x in note)
            {
                if (x < 10)
                    inf++;
                else
                    sup++;
            }

            supdix.Text = sup.ToString();
            infdix.Text = inf.ToString();
        }
    }
}
