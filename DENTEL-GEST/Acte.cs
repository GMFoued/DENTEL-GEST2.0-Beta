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
    public partial class Acte : Form
    {
        public Acte()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            SqlCommand cmd = new SqlCommand("insert into Acte (Nom_Acte,Prix_Acte) VALUES (@Nom_Acte,@Prix_Acte)");
            
            try
            {
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Nom_Acte", textBox1.Text);
                cmd.Parameters.AddWithValue("@Prix_Acte", textBox2.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Acte ajouté avec succé");
                connection.Close();
            }
            
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
