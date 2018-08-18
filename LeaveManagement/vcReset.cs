using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LeaveManagement
{
    public partial class vcReset : Form
    {
        public vcReset()
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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bhagya Udayanandani\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from Vlogin 'Password='" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                WelcomeVC a = new WelcomeVC();
                a.Show();
            }
            else
            {
                MessageBox.Show("Please check your password and username");
            }
        }
    }
}
