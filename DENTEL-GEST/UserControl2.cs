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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        public void Refrechdt()
        {
            // Fonction Refrecher la DatagridView à L'instant de le click sur le button Enregistrer
            var dbfile = Application.StartupPath + "\\BaseTest.mdf";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + dbfile + ";Integrated Security=True;Connect Timeout =30");

            string req1 = "select * from Agenda";
            SqlDataAdapter adapter = new SqlDataAdapter(req1, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Agenda");
            dataGridView1.DataSource = ds.Tables[0];

        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refrechdt();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rdv rendu = new rdv();
            rendu.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
