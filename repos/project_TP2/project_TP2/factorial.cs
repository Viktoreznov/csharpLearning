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
    public partial class factorial : Form
    {

        public factorial()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Visible = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int x = int.Parse(value.Text);
            int fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact *= i;
            }
            res.Text = x + "! = " + fact;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
