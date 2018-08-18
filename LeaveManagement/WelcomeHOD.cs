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
    public partial class WelcomeHOD : Form
    {
        public WelcomeHOD()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            login3 b = new login3();
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewLM vc = new viewLM();
            vc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            regEmp vc = new regEmp();
            vc.Show();
        }
    }
}
