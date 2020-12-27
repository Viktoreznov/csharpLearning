using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nom.Text = "";
            ex.Text = "";
            prenom.Text = "";
            ds.Text = "";
            tp.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float dss, exx, tpp,res;
            String nomPrenom = nom.Text + " " + prenom.Text;

            dss = float.Parse(ds.Text);
            exx = float.Parse(ex.Text);
            tpp = float.Parse(tp.Text);

            res = (dss + exx + tpp) / 3;
            String val = nomPrenom + "   " + res;
            lb.Items.Add(val);
            
        }
    }
}
