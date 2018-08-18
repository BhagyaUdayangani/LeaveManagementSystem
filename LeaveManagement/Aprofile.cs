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
    public partial class Aprofile : Form
    {
        public Aprofile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            vcProfile b = new vcProfile();
            b.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pvc p = new pvc();
            p.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            pdean b = new pdean();
            b.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            phod u = new phod();
            u.Show();
        }
    }
}
