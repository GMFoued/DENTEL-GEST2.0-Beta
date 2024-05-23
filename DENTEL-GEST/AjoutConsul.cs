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
    public partial class AjoutConsul : Form
    {
        SqlDataReader drd;
        public AjoutConsul()
        {
            InitializeComponent();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Afficher Nom_Prenom , Age , ID_Patient lors Click sur le Nom_Prenom dans la ListBox

            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            string req4 = "select Nom_Prenom,ID_Patient,Age FROM Patient WHERE Nom_Prenom = '" + listBox1.SelectedItem.ToString() + "'";
            SqlCommand cmd4 = new SqlCommand(req4, connection);
            cmd4.CommandText = req4;
            connection.Open();
            drd = cmd4.ExecuteReader();
            while (drd.Read())
            {
                textBox1.Text = drd["Nom_Prenom"].ToString();
                textBox7.Text = drd["ID_Patient"].ToString();
                textBox8.Text = drd["Age"].ToString();
            }

            connection.Close();

            // afficher les schema du Dents pour chaque Type de Patients

            int age = int.Parse(textBox8.Text);

            if (age > 13)
            {
                panel6.BringToFront();
                panel6.Enabled = true;
                panel5.Enabled = false;
            }
            else
            {
                panel5.BringToFront();
                panel5.Enabled = true;
                panel6.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Afficher le Prix de l'acte selectioné a partir de combobox1

            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            string req3 = "select Prix_Acte FROM Acte WHERE Nom_Acte = '" + comboBox1.SelectedItem.ToString() + "'";
            SqlCommand cmd3 = new SqlCommand(req3, connection);
            cmd3.CommandText = req3;
            connection.Open();
            drd = cmd3.ExecuteReader();
            while (drd.Read())
            {
                textBox3.Text = drd["Prix_Acte"].ToString();
            }

            connection.Close();
            // Afficher les Images Dents pour chaque Acte sélectionée

            string numdent = textBox2.Text;
            Button bt = (Button)this.panel6.Controls["Dent" + numdent.ToString()];
     
            if (comboBox1.SelectedItem.ToString() == "Nettoyage_Dentaire")
            {
                bt.Image = (Image)Properties.Resources.ResourceManager.GetObject("DentacteA" + numdent.ToString());
                

            }
            else if (comboBox1.SelectedItem.ToString() == "Emballage_Dentaire")
            {
                bt.Image = (Image)Properties.Resources.ResourceManager.GetObject("DentacteD" + numdent.ToString());
            

            }
            else if (comboBox1.SelectedItem.ToString() == "Extraction_Dentaire")
            {
                bt.Image = (Image)Properties.Resources.ResourceManager.GetObject("DentacteB" + numdent.ToString());
           


            }

            else
            {
                bt.Image = (Image)Properties.Resources.ResourceManager.GetObject("DentacteE" + numdent.ToString());
               

            }
        }

        private void dent21_Click(object sender, EventArgs e)
        {
            textBox2.Text = 21.ToString();
        }

        private void dent22_Click(object sender, EventArgs e)
        {
            textBox2.Text = 22.ToString();
        }

        private void dent23_Click(object sender, EventArgs e)
        {
            textBox2.Text = 23.ToString();
        }

        private void dent24_Click(object sender, EventArgs e)
        {
            textBox2.Text = 24.ToString();
        }

        private void dent25_Click(object sender, EventArgs e)
        {
            textBox2.Text = 25.ToString();
        }

        private void dent26_Click(object sender, EventArgs e)
        {
            textBox2.Text = 26.ToString();
        }

        private void Dent61_Click(object sender, EventArgs e)
        {
            textBox2.Text = 61.ToString();
        }

        private void Dent65_Click(object sender, EventArgs e)
        {
            textBox2.Text = 65.ToString();
        }

        private void Dent72_Click(object sender, EventArgs e)
        {
            textBox2.Text = 72.ToString();
        }

        private void AjoutConsul_Load(object sender, EventArgs e)
        {
            textBox5.Enabled = false;

            /// Affichage Nom_Acte  Dans le ComboBox
            /// 
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            string req1 = "select Nom_Acte FROM Acte";
            SqlCommand cmd1 = new SqlCommand(req1, connection);
            cmd1.CommandText = req1;
            connection.Open();
            drd = cmd1.ExecuteReader();
            while(drd.Read())
            {
                comboBox1.Items.Add(drd.GetString(0));
            }
            connection.Close();


            // afficher les Nom_Prenom Dans la listBox

            string req2 = "select Nom_Prenom FROM Patient";
            SqlCommand cmd2 = new SqlCommand(req2, connection);
            cmd2.CommandText = req2;
            connection.Open();
            drd = cmd2.ExecuteReader();
            while(drd.Read())
            {
                listBox1.Items.Add(drd["Nom_Prenom"]);
            }
            connection.Close();

        }

        private void dent27_Click(object sender, EventArgs e)
        {
            textBox2.Text = 27.ToString();
        }

        private void dent28_Click(object sender, EventArgs e)
        {
            textBox2.Text = 28.ToString();

        }

        private void dent38_Click(object sender, EventArgs e)
        {
            textBox2.Text = 38.ToString();

        }

        private void dent37_Click(object sender, EventArgs e)
        {
            textBox2.Text = 37.ToString();

        }

        private void dent36_Click(object sender, EventArgs e)
        {
            textBox2.Text = 36.ToString();

        }

        private void dent35_Click(object sender, EventArgs e)
        {
            textBox2.Text = 35.ToString();

        }

        private void dent34_Click(object sender, EventArgs e)
        {
            textBox2.Text = 34.ToString();

        }

        private void dent33_Click(object sender, EventArgs e)
        {
            textBox2.Text = 33.ToString();

        }

        private void dent32_Click(object sender, EventArgs e)
        {
            textBox2.Text = 32.ToString();

        }

        private void dent31_Click(object sender, EventArgs e)
        {
            textBox2.Text = 31.ToString();

        }

        private void dent41_Click(object sender, EventArgs e)
        {
            textBox2.Text = 41.ToString();

        }

        private void dent42_Click(object sender, EventArgs e)
        {
            textBox2.Text = 42.ToString();

        }

        private void dent43_Click(object sender, EventArgs e)
        {
            textBox2.Text = 43.ToString();

        }

        private void dent44_Click(object sender, EventArgs e)
        {
            textBox2.Text = 44.ToString();

        }

        private void dent45_Click(object sender, EventArgs e)
        {
            textBox2.Text = 45.ToString();

        }

        private void dent46_Click(object sender, EventArgs e)
        {
            textBox2.Text = 46.ToString();

        }

        private void dent47_Click(object sender, EventArgs e)
        {
            textBox2.Text = 47.ToString();

        }

        private void dent48_Click(object sender, EventArgs e)
        {
            textBox2.Text = 48.ToString();

        }

        private void dent18_Click(object sender, EventArgs e)
        {
            textBox2.Text = 27.ToString();

        }

        private void dent17_Click(object sender, EventArgs e)
        {
            textBox2.Text = 17.ToString();

        }

        private void dent16_Click(object sender, EventArgs e)
        {
            textBox2.Text = 16.ToString();

        }
     
        private void dent15_Click(object sender, EventArgs e)
        {
            textBox2.Text = 15.ToString();

        }

        private void dent14_Click(object sender, EventArgs e)
        {
            textBox2.Text = 14.ToString();

        }

        private void dent13_Click(object sender, EventArgs e)
        {
            textBox2.Text = 13.ToString();

        }

        private void dent12_Click(object sender, EventArgs e)
        {
            textBox2.Text = 12.ToString();

        }

        private void dent11_Click(object sender, EventArgs e)
        {
            textBox2.Text = 11.ToString();

        }

        private void Dent51_Click(object sender, EventArgs e)
        {
            textBox2.Text = 51.ToString();

        }

        private void Dent52_Click(object sender, EventArgs e)
        {
            textBox2.Text = 52.ToString();

        }

        private void Dent53_Click(object sender, EventArgs e)
        {
            textBox2.Text = 53.ToString();

        }

        private void Dent54_Click(object sender, EventArgs e)
        {
            textBox2.Text = 54.ToString();

        }

        private void Dent55_Click(object sender, EventArgs e)
        {
            textBox2.Text = 55.ToString();

        }

        private void Dent85_Click(object sender, EventArgs e)
        {
            textBox2.Text = 85.ToString();

        }

        private void Dent84_Click(object sender, EventArgs e)
        {
            textBox2.Text = 84.ToString();

        }

        private void Dent83_Click(object sender, EventArgs e)
        {
            textBox2.Text = 83.ToString();

        }

        private void Dent82_Click(object sender, EventArgs e)
        {
            textBox2.Text = 82.ToString();

        }

        private void Dent81_Click(object sender, EventArgs e)
        {
            textBox2.Text = 81.ToString();

        }

        private void Dent71_Click(object sender, EventArgs e)
        {
            textBox2.Text = 71.ToString();

        }

        private void Dent73_Click(object sender, EventArgs e)
        {
            textBox2.Text = 73.ToString();

        }

        private void Dent74_Click(object sender, EventArgs e)
        {
            textBox2.Text = 74.ToString();

        }

        private void Dent75_Click(object sender, EventArgs e)
        {
            textBox2.Text = 75.ToString();

        }

        private void Dent64_Click(object sender, EventArgs e)
        {
            textBox2.Text = 64.ToString();

        }

        private void Dent63_Click(object sender, EventArgs e)
        {
            textBox2.Text = 63.ToString();

        }

        private void Dent62_Click(object sender, EventArgs e)
        {
            textBox2.Text = 62.ToString();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var prix = decimal.Parse(textBox3.Text);

            var pay = decimal.Parse(textBox4.Text);

            var res = prix - pay;

            textBox5.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string numdent = textBox2.Text;
            Button bt = (Button)this.panel6.Controls["Dent" + numdent];
            Image img = bt.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img,typeof(byte[]));
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            SqlCommand cmd = new SqlCommand("insert into Consultation (Nom_Prenom,Date_Consul,ID_Patient,Num_Dent,Acte,Img_Acte,Paye,Reste,Trait) VALUES (@Nom_Prenom,@Date_Consul,@ID_Patient,@Num_Dent,@Acte,@Img_Acte,@Paye,@Reste,@Trait)");

            try
            {
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Nom_Prenom", textBox1.Text);
                cmd.Parameters.AddWithValue("@Date_Consul", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@ID_Patient", textBox7.Text);
                cmd.Parameters.AddWithValue("@Num_Dent", textBox2.Text);
                cmd.Parameters.AddWithValue("@Acte", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Img_Acte", arr);
                cmd.Parameters.AddWithValue("@Trait", textBox6.Text);
                cmd.Parameters.AddWithValue("@Paye", SqlDbType.SmallMoney).Value = Decimal.Parse(textBox4.Text);
                cmd.Parameters.AddWithValue("@Reste", SqlDbType.SmallMoney).Value = Decimal.Parse(textBox5.Text);


                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Consultation ajouté avec sucée");
                connection.Close();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
