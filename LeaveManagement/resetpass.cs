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
    public partial class resetpass : Form
    {
        public resetpass()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeDean vc = new WelcomeDean();
            vc.Show();
        }
    }
}
