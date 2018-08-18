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
    public partial class sendLRM : Form
    {
        public sendLRM()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeOE vc = new WelcomeOE();
            vc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sendLRF vc = new sendLRF();
            vc.Show();
        }
    }
}
