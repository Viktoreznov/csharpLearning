using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulaire_multipage
{
    public partial class Form1 : Form
    {
        List<Panel> p = new List<Panel>();
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p.Add(panel1);
            p.Add(panel2);
            p.Add(panel3);
            p[index].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index < p.Count - 1)
            {
                p[++index].BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index > 0 )
            {
                p[--index].BringToFront();
            }
        }
    }
}
