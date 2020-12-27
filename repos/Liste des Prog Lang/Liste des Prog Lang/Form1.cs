using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liste_des_Prog_Lang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ls1.Items.Add("C");
            ls1.Items.Add("C++");
            ls1.Items.Add("C#");
            ls1.Items.Add("Java");
            ls1.Items.Add("Python");
            ls1.Items.Add("Ruby");
        }

        private void rl_Click(object sender, EventArgs e)
        {
            ls2.Items.Add(ls1.GetItemText(ls1.SelectedItem));
            ls1.Items.Remove(ls1.GetItemText(ls1.SelectedItem));
        }

        private void lr_Click(object sender, EventArgs e)
        {
            ls1.Items.Add(ls2.GetItemText(ls2.SelectedItem));
            ls2.Items.Remove(ls2.GetItemText(ls2.SelectedItem));
        }

        private void rla_Click(object sender, EventArgs e)
        {
            ls2.Items.AddRange(ls1.Items);
            ls1.Items.Clear();
        }

        private void lra_Click(object sender, EventArgs e)
        {
            ls1.Items.AddRange(ls2.Items);
            ls2.Items.Clear();    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // this will take it up
            String aux;
            aux = ls1.Items[0].ToString();
            ls1.Items[0] = ls1.SelectedItem;
            ls1.Items[ls1.SelectedIndex] = aux;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //this will take it Down
            String aux;
            aux = ls1.Items[ls1.Items.Count - 1].ToString();
            ls1.Items[ls1.Items.Count - 1] = ls1.SelectedItem;
            ls1.Items[ls1.SelectedIndex] = aux;
        }
    }
}
