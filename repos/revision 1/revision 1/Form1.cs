using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace revision_1
{
    public partial class Form1 : Form
    {
        float x = 2.0f;
        int y;
        f2 f = new f2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = true;
            button1.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
