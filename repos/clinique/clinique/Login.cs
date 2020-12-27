using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace clinique
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        String connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=clinique;Integrated Security=True;Pooling=False";
        SqlConnection conn;

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            
        }

        private void valider_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("Select * from [Admins] where username=@user AND password = @pass", conn);
            command.Parameters.AddWithValue("@user",username.Text);
            command.Parameters.AddWithValue("@pass", Password.Text);
            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Form2 gc = new Form2();
                    gc.Show();
                    this.Hide();
                }
            }

            conn.Close();

        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
