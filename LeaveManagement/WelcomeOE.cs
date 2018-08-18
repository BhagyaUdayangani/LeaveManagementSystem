using System;
using System.Windows.Forms;

namespace LeaveManagement
{
    public partial class WelcomeOE : Form
    {
        public WelcomeOE()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            login4 b = new login4();
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewLM b = new viewLM();
            b.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            sendLRM vc = new sendLRM();
            vc.Show();
        }
    }
}
