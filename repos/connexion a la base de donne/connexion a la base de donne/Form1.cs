using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace connexion_a_la_base_de_donne
{
    public partial class Form1 : Form
    {
        String connQuery = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=test;Integrated Security=True;Pooling=False";
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connQuery);
        }

        private void tryConn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MessageBox.Show("Connection fait avec succeés");
                  
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
