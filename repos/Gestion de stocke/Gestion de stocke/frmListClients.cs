using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_stocke
{
    public partial class frmListClients : Form
    {
        public frmListClients()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDstockDataSet);

        }

        private void frmListClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDstockDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bDstockDataSet.Client);

        }
    }
}
