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
namespace DENTEL_GEST
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            /*
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            string req = "select ID_Patient,Nom_Prenom,Adresse,Telephone,Age,Sexe  FROM  Patient";
            SqlDataAdapter adapter = new SqlDataAdapter(req, connection);
            DataSet ds = new DataSet();
            connection.Open();
            adapter.Fill(ds);
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.Columns.Add("0", "ID_Patient");
            dataGridView1.Columns.Add("1", "Nom_Prenom");
            dataGridView1.Columns.Add("2", "Adresse");
            dataGridView1.Columns.Add("3", "Telephone");
            dataGridView1.Columns.Add("4", "Age");
            dataGridView1.Columns.Add("5", "Sexe");
         
            */

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            groupBox1.Enabled = false;          
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            textBox1.Focus();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "0";
            textBox5.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ajout Dans la Base Test
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            SqlCommand cmd = new SqlCommand("insert into Patient (Nom_Prenom,Adresse,Telephone,Age,Sexe,Type) Values (@Nom_Prenom,@Adresse,@Telephone,@Age,@Sexe,@Type)");

            try
            {
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Nom_Prenom", textBox1.Text);
                cmd.Parameters.AddWithValue("@Adresse", textBox2.Text);
                cmd.Parameters.AddWithValue("@Telephone", textBox3.Text);
                cmd.Parameters.AddWithValue("@Age", textBox4.Text);
                cmd.Parameters.AddWithValue("@Type", textBox5.Text);

                if(radioButton1.Checked)
                {
                    cmd.Parameters.AddWithValue("@Sexe", "Homme");

                }
                else
                {
                    cmd.Parameters.AddWithValue("@Sexe", "Femme");
                }

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client ajouté avec sucée");
                connection.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Refrechdt()
        {
            // Fonction Refrecher la DatagridView à L'instant de le click sur le button Enregistrer
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");

            string req1 = "select * from Patient";
            SqlDataAdapter adapter = new SqlDataAdapter(req1, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Patient");
            dataGridView1.DataSource = ds.Tables[0];

        }
      
     

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int val = int.Parse(textBox4.Text);
            if (val < 13)
            {
                textBox5.Text = "Enfant";
            } else
            {
                textBox5.Text = "Adulte";
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refrechdt();
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
