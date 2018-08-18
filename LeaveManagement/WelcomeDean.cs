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
    public partial class WelcomeDean : Form
    {
        public WelcomeDean()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login2 b = new login2();
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewLM vc = new viewLM();
            vc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            resetpass vc = new resetpass();
            vc.Show();
        }
    }
}
