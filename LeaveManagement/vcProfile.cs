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
    public partial class vcProfile : Form
    {
        public vcProfile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeVC b = new WelcomeVC();
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aprofile a = new Aprofile();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eprofile b = new Eprofile();
            b.Show();
        }
    }
}
