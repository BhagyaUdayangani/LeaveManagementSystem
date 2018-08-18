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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login1 a = new login1();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login2 a = new login2();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login3 a = new login3();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login4 a = new login4();
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
