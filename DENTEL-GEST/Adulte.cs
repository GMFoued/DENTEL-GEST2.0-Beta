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
    
    public partial class Adulte : Form
    {
    
        SqlDataReader drd;
        public Adulte()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adulte_Load(object sender, EventArgs e)
        {
       
           
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            string req5 = "select Nom_Acte FROM Acte ";
            SqlCommand cmd5 = new SqlCommand(req5, connection);
            cmd5.CommandText = req5;
            connection.Open();
            drd = cmd5.ExecuteReader();
            while(drd.Read())
            {
                comboBox1.Items.Add(drd.GetString(0));
            }
            connection.Close();

            // Liste Patients

          
            string req4 = "select Nom_Prenom FROM Patient";
            SqlCommand cmd4 = new SqlCommand(req4, connection);
            cmd4.CommandText = req4;
            connection.Open();
            drd = cmd4.ExecuteReader();

            while (drd.Read())
            {
                listBox1.Items.Add(drd["Nom_Prenom"]);
            }

            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            string req5 = "select Prix_Acte FROM Acte where Nom_Acte = '"+comboBox1.SelectedItem.ToString()+"' ";
            SqlCommand cmd = new SqlCommand(req5, connection);
            cmd.CommandText = req5;
            connection.Open();
            drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                textBox6.Text = drd["Prix_acte"].ToString();
            }
            connection.Close();


            
           
        }

        private void dent24_Click(object sender, EventArgs e)
        {
            textBox2.Text = 24.ToString();
        }


        private void dent21_Click(object sender, EventArgs e)
        {
            textBox2.Text = 21.ToString();
        }

        private void dent11_Click(object sender, EventArgs e)
        {
            textBox2.Text = 11.ToString();
        }

        private void dent12_Click(object sender, EventArgs e)
        {
            textBox2.Text = 12.ToString();
        }

        private void dent13_Click(object sender, EventArgs e)
        {
            textBox2.Text = 13.ToString();
        }

        private void dent14_Click(object sender, EventArgs e)
        {
            textBox2.Text = 14.ToString();
        }

        private void dent15_Click(object sender, EventArgs e)
        {
            textBox2.Text = 15.ToString();
        }

        private void dent16_Click(object sender, EventArgs e)
        {
            textBox2.Text = 16.ToString();
        }

        private void dent17_Click(object sender, EventArgs e)
        {
            textBox2.Text = 17.ToString();
        }

        private void dent18_Click(object sender, EventArgs e)
        {
            textBox2.Text = 18.ToString();
        }

        private void dent48_Click(object sender, EventArgs e)
        {
            textBox2.Text = 48.ToString();
        }

        private void dent47_Click(object sender, EventArgs e)
        {
            textBox2.Text = 47.ToString();
        }

        private void dent46_Click(object sender, EventArgs e)
        {
            textBox2.Text = 46.ToString();
        }

        private void dent45_Click(object sender, EventArgs e)
        {
            textBox2.Text = 45.ToString();
        }

        private void dent44_Click(object sender, EventArgs e)
        {
            textBox2.Text = 44.ToString();
        }

        private void dent43_Click(object sender, EventArgs e)
        {
            textBox2.Text = 43.ToString();
        }

        private void dent42_Click(object sender, EventArgs e)
        {
            textBox2.Text = 42.ToString();
        }

        private void dent41_Click(object sender, EventArgs e)
        {
            textBox2.Text = 41.ToString();
        }

        private void dent31_Click(object sender, EventArgs e)
        {
            textBox2.Text = 31.ToString();
        }

        private void dent32_Click(object sender, EventArgs e)
        {
            textBox2.Text = 32.ToString();
        }

        private void dent33_Click(object sender, EventArgs e)
        {
            textBox2.Text = 33.ToString();
        }

        private void dent34_Click(object sender, EventArgs e)
        {
            textBox2.Text = 34.ToString();
        }

        private void dent35_Click(object sender, EventArgs e)
        {
            textBox2.Text = 35.ToString();
        }

        private void dent36_Click(object sender, EventArgs e)
        {
            textBox2.Text = 36.ToString();
        }

        private void dent37_Click(object sender, EventArgs e)
        {
            textBox2.Text = 37.ToString();
        }

        private void dent38_Click(object sender, EventArgs e)
        {
            textBox2.Text = 38.ToString();
        }

        private void dent28_Click(object sender, EventArgs e)
        {
            textBox2.Text = 28.ToString();
        }

        private void dent27_Click(object sender, EventArgs e)
        {
            textBox2.Text = 27.ToString();
        }

        private void dent26_Click(object sender, EventArgs e)
        {
            textBox2.Text = 26.ToString();
        }

        private void dent25_Click(object sender, EventArgs e)
        {
            textBox2.Text = 25.ToString();
        }

        private void dent23_Click(object sender, EventArgs e)
        {
            textBox2.Text = 23.ToString();
        }

        private void dent22_Click(object sender, EventArgs e)
        {
            textBox2.Text = 22.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            string req = "select ID_Patient,Nom_Prenom,Age FROM Patient WHERE Nom_Prenom ='" + listBox1.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(req, connection);
            cmd.CommandText = req;
            connection.Open();
            drd = cmd.ExecuteReader();
            while(drd.Read())
            {
                textBox1.Text = drd["Nom_Prenom"].ToString();
                textBox8.Text = drd["ID_Patient"].ToString();
                textBox9.Text = drd["Age"].ToString();
            }
            connection.Close();

            int age = int.Parse(textBox9.Text);

            if(age > 13)
            {
                // 
                // panel4.Size = new Size(443, 651);
                
                panel4.BringToFront();
                panel4.Enabled = true;
                panel6.Enabled= false;
             

            }
            else
            {
                //
                //panel6.Size = new Size(443, 651);
                
                panel6.BringToFront();
                panel6.Enabled = true;
                panel4.Enabled = false;
               


            }

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dent61_Click(object sender, EventArgs e)
        {
            textBox2.Text = 61.ToString();
        }

        private void Dent62_Click(object sender, EventArgs e)
        {
            textBox2.Text = 62.ToString();
        }

        private void Dent63_Click(object sender, EventArgs e)
        {
            textBox2.Text = 63.ToString();
        }

        private void Dent64_Click(object sender, EventArgs e)
        {
            textBox2.Text = 64.ToString();
        }

        private void Dent65_Click(object sender, EventArgs e)
        {
            textBox2.Text = 65.ToString();
        }

        private void Dent75_Click(object sender, EventArgs e)
        {
            textBox2.Text = 75.ToString();
        }

        private void Dent74_Click(object sender, EventArgs e)
        {
            textBox2.Text = 74.ToString();
        }

        private void Dent73_Click(object sender, EventArgs e)
        {
            textBox2.Text = 73.ToString();
        }

        private void Dent72_Click(object sender, EventArgs e)
        {
            textBox2.Text = 72.ToString();
        }

        private void Dent71_Click(object sender, EventArgs e)
        {
            textBox2.Text = 71.ToString();
        }

        private void Dent81_Click(object sender, EventArgs e)
        {
            textBox2.Text = 81.ToString();
        }

        private void Dent82_Click(object sender, EventArgs e)
        {
            textBox2.Text = 82.ToString();
        }

        private void Dent83_Click(object sender, EventArgs e)
        {
            textBox2.Text = 83.ToString();
        }

        private void Dent84_Click(object sender, EventArgs e)
        {
            textBox2.Text = 84.ToString();
        }

        private void Dent85_Click(object sender, EventArgs e)
        {
            textBox2.Text = 85.ToString();
        }

        private void Dent55_Click(object sender, EventArgs e)
        {
            textBox2.Text = 55.ToString();
        }

        private void Dent54_Click(object sender, EventArgs e)
        {
            textBox2.Text = 54.ToString();
        }

        private void Dent53_Click(object sender, EventArgs e)
        {
            textBox2.Text = 53.ToString();
        }

        private void Dent52_Click(object sender, EventArgs e)
        {
            textBox2.Text = 52.ToString();
        }

        private void Dent51_Click(object sender, EventArgs e)
        {
            textBox2.Text = 51.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var prix = decimal.Parse(textBox6.Text);
            var pay = decimal.Parse(textBox3.Text);
            var res = prix - pay;
            textBox4.Text = res.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
