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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // si les deux champs sont vides
            if(textBox1.Text =="" || textBox2.Text=="")
            {
                MessageBox.Show("Veuillez entrer vos paramètres du connexion");
            }

            try
            {
                var dbfile = Application.StartupPath + "\\BaseTest.mdf";
                SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename="+dbfile+";Integrated Security=True;Connect Timeout =30");
                string req = "select * from Connect where login like '" + textBox1.Text.Trim() + "' AND password like '" + textBox2.Text.Trim() + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(req, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count ==1)
                {
                    Home acl = new Home();
                    acl.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vérifier vos paramètres du connexion");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
