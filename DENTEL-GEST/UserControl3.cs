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
    public partial class UserControl3 : UserControl
    {
        SqlDataReader drd2;
        public UserControl3()
        {
            InitializeComponent();
            
        }

        public void refrechdt()
        {
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            string req1 = "select * from Consultation";
            SqlDataAdapter adapter = new SqlDataAdapter(req1, connection);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1, "Consultation");
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            timer1.Start();

            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");
            string req4 = "select Nom_Prenom FROM Patient";
            SqlCommand cmd4 = new SqlCommand(req4, connection);
            cmd4.CommandText = req4;
            connection.Open();
            drd2 = cmd4.ExecuteReader();

            while(drd2.Read())
            {
                listBox1.Items.Add(drd2["Nom_Prenom"]);
            }

            connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refrechdt();
            timer1.Start();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AjoutConsul ajtc = new AjoutConsul();
            ajtc.Show();           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

      
    }
}
