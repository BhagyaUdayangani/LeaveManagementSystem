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
    public partial class WelcomeVC : Form
    {
        public WelcomeVC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewLM b = new viewLM();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            vcProfile vc = new vcProfile();
            vc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            vcReset vc = new vcReset();
            vc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login1 b = new login1();
            b.Show();
        }
    }
}
