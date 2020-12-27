using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            n1.Focus();
        }

        private void add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resultat est : "+(int.Parse(n1.Text)+int.Parse(n2.Text)).ToString());
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resultat est : " + (int.Parse(n1.Text) - int.Parse(n2.Text)).ToString());

        }

        private void Mul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resultat est : " + (int.Parse(n1.Text) * int.Parse(n2.Text)).ToString());

        }

        private void Div_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resultat est : " + float.Parse((int.Parse(n1.Text) / int.Parse(n2.Text)).ToString()));
        }

        private void n1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
