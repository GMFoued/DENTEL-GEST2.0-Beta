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
    public partial class rdv : Form
    {
        SqlDataReader drd;
        public rdv()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdv_Load(object sender, EventArgs e)
        {
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            string req = "select Nom_Prenom from Patient";
            SqlCommand cmd = new SqlCommand(req, connection);
            cmd.CommandText = req;
            connection.Open();
            drd = cmd.ExecuteReader();
            while(drd.Read())
            {
                listBox1.Items.Add(drd["Nom_Prenom"]);
            }
            connection.Close();
            // rendre les Text Box Enable et Ajouter les Heures aux combobox1

            textBox1.Enabled = false;
            textBox1.Enabled = false;
            comboBox1.Items.Add("08:00");
            comboBox1.Items.Add("09:00");
            comboBox1.Items.Add("10:00");
            comboBox1.Items.Add("11:00");
            comboBox1.Items.Add("12:00");
            comboBox1.Items.Add("14:00");
            comboBox1.Items.Add("15:00");
            comboBox1.Items.Add("16:00");
            comboBox1.Items.Add("17:00");
        }

      
       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            string req = "select ID_Patient,Nom_Prenom from Patient where Nom_Prenom = '" + listBox1.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(req, connection);
            cmd.CommandText = req;
            connection.Open();
            drd = cmd.ExecuteReader();
            while(drd.Read())
            {
                textBox1.Text = drd["ID_Patient"].ToString();
                textBox2.Text = drd["Nom_Prenom"].ToString();
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ajouter les Rendez-Vous a la BaseTest
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            SqlCommand cmd = new SqlCommand("insert into Agenda(ID_Patient,Nom_Prenom,Date_Rdv,Heure_Rdv) VALUES (@ID_Patient,@Nom_Prenom,@Date_Rdv,@Heure_Rdv)");
            try
            {
                cmd.Connection = connection;

                cmd.Parameters.AddWithValue("@ID_Patient", textBox1.Text);
                cmd.Parameters.AddWithValue("@Nom_Prenom", textBox2.Text);
                cmd.Parameters.AddWithValue("@Date_Rdv", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Heure_Rdv", comboBox1.SelectedItem.ToString());

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rendez_Vous enregistré avec succé");
                connection.Close();





            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
