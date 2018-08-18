using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveManagement
{
    public partial class Eprofile : Form
    {
        public Eprofile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            vcProfile v = new vcProfile();
            v.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ESL es = new ESL();
            es.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EFL c = new EFL();
            c.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            EINS san = new EINS();
            san.Show();
        }
    }
}
