using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DENTEL_GEST
{
   
    public partial class Home : Form
    {
        Timer bg = new Timer();
        UserControl1 patient = new UserControl1();
        UserControl2 agenda = new UserControl2();
        UserControl3 consult = new UserControl3();
        UserControl4 param = new UserControl4();
        public Home()
        {
            InitializeComponent();
            bg.Tick += (s, e) => { label1.Text = DateTime.Now.ToString(); };
            bg.Interval = 500;
            bg.Start();
            
        }
      
        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
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

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Add(patient);
            patient.Show();
            agenda.Hide();
            consult.Hide();
            patient.Dock = DockStyle.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Add(agenda);
            agenda.Show();
            patient.Hide();
            consult.Hide();
            agenda.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Add(consult);
            consult.Show();
            patient.Hide();
            agenda.Hide();
            consult.Dock = DockStyle.Fill;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.panel4.Controls.Add(param);
            param.Show();
            consult.Hide();
            patient.Hide();
            agenda.Hide();
            param.Dock = DockStyle.Fill;
        }
    }
}
