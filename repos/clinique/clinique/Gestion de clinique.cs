using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace clinique
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        String connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=clinique;Integrated Security=True;Pooling=False";
        char sexepat;
        int cinp,cinpEspDoc;
        string mdc = "";
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            String query = "select * from Consultation";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            conn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds,"Consultation");
            listPatient.DisplayMember = "cin_p";
            listPatient.ValueMember = "num_cons";
            listPatient.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void ajout_Click(object sender, EventArgs e)
        {
            if (Homme.Checked)
                sexepat = 'H';
            else
                sexepat = 'F';

            String query = "insert into Patient (cin_p,nom_p,prenom_p,sexe_p,age_p,poids,adress_p,tel_p) values ('"+this.cin_pat.Text+"','"+this.nompat.Text+"','"+this.prenompat.Text+"','"+this.sexepat+"','"+this.agepat.Text+"','"+this.poidspat.Text+"','"+this.adressepat.Text+"','"+this.telpat.Text+"')";
            SqlCommand insertData = new SqlCommand(query, conn);
            SqlDataReader patReader;
            try
            {
                conn.Open();
                patReader = insertData.ExecuteReader();
                MessageBox.Show("Succefuly insert Patient Data");
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void recherche_Click(object sender, EventArgs e)
        {
            
        }

        private void check_Click(object sender, EventArgs e)
        {
           
            conn.Open();
            String query = "select * from [Patient] where cin_p = @cinPatient";
            SqlCommand findPat = new SqlCommand(query,conn);
            findPat.Parameters.AddWithValue("@cinPatient",cinPat.Text);
            using (SqlDataReader findReader = findPat.ExecuteReader())
            {
                if (findReader.Read())
                {
                    np.Text = "Nom et Prenom : " + findReader["nom_p"] + " " + findReader["prenom_p"];
                    cinp = int.Parse(cinPat.Text);
                }
                else
                    MessageBox.Show("Data not retrieved");
                
                
            }
            conn.Close();
        }

        private void listPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            cinpEspDoc = int.Parse(listPatient.GetItemText(listPatient.SelectedItem));
            
            string query2 = "select * from Patient where cin_p = @cin";
            try
            {
                conn.Open();
            SqlCommand findPat = new SqlCommand(query2, conn);
                findPat.Parameters.AddWithValue("@cin", cinpEspDoc);
                using (SqlDataReader sdr = findPat.ExecuteReader())
                {
                    if (sdr.Read())
                    {
                        npespaceDoc.Text = "Nom & Prenom : " + sdr["nom_p"] + " " + sdr["prenom_p"];
                        cinEspaceDoc.Text = "Cin : " + sdr["cin_p"];
                        poidEspaceDoc.Text = "Poid : "+sdr["poids"];
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                conn.Close();
            }
        }

        private void medicament_Click(object sender, EventArgs e)
        {
            using (var form = new medicament())
            {
                var result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    mdc = form.ReturnValue;
                }
            }
        }

        private void specDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from [Admins] where specialite = '" + this.specDoc.GetItemText(specDoc.SelectedItem) + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Admins");
                docDispo.DisplayMember = "nom_a";
                docDispo.ValueMember = "prenom_a";
                docDispo.DataSource = ds.Tables[0];
                addCons.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void endCOns_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "update [Consultation] set rapport='" + this.rapport.Text + "',traitement = '" + this.mdc + "';";
                SqlCommand updateCons = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader sdrUpdate = updateCons.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (sdrUpdate.Read())
                {

                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                conn.Close();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string query = "insert into [Admins] (cin_a,nom_a,prenom_a,tel_a,adresse_a,username,password) values ('" + int.Parse(cina.Text)+"','"+noma.Text+"','"+prenoma.Text+"','"+int.Parse(numtela.Text)+"','"+adressa.Text+"','"+username.Text+"','"+password.Text+"')";
            SqlCommand cm = new SqlCommand(query, conn);
            SqlDataReader sdr;
            try
            {
                conn.Open();
                sdr = cm.ExecuteReader();
                MessageBox.Show("Doc/Admin et Ajouter AVEC sUCCES");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string quer = "delete [Admins] where cin_a = @cin";
            SqlCommand rm = new SqlCommand(quer, conn);
            rm.Parameters.AddWithValue("@cin", int.Parse(removeCin.Text));
            SqlDataReader sdr;
            try
            {
                conn.Open();
                sdr = rm.ExecuteReader();
                MessageBox.Show("date removed");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string quer = "delete [Patient] where cin_p = @cin";
            SqlCommand rm = new SqlCommand(quer, conn);
            rm.Parameters.AddWithValue("@cin", int.Parse(cinDelete.Text));
            SqlDataReader sdr;
            try
            {
                conn.Open();
                sdr = rm.ExecuteReader();
                MessageBox.Show("data removed");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void addCons_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int consNumber = random.Next(1, 999999);
            MessageBox.Show(consNumber.ToString());
            String query = "insert into [Consultation] (num_cons,date_cons,specialite,nom_doc,etat_cons,cin_p) values ('"+consNumber+"','"+this.dateCons.Value+"','"+this.specDoc.GetItemText(specDoc.SelectedItem)+"','"+this.docDispo.GetItemText(docDispo.SelectedItem)+"','F','"+cinp+"')";
            SqlCommand cm = new SqlCommand(query, conn);
            SqlDataReader sdr;
            try
            {
                conn.Open();
                sdr = cm.ExecuteReader();
                MessageBox.Show("Consultation ajouter avec succes");

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
