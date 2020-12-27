using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinique
{
    public partial class medicament : Form
    {
        public String ReturnValue { get; set; }
        public medicament()
        {
            InitializeComponent();
        }

        private void clos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.ReturnValue = medic.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
