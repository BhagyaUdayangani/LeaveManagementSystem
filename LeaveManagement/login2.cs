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
    public partial class login2 : Form
    {
        public login2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bhagya Udayanandani\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from Dlogin where Username='" + textBox1.Text + "'and Password='"+textBox2.Text +"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                WelcomeDean a = new WelcomeDean();
                a.Show();
            }
            else
            {
                MessageBox.Show("Please check your password and username");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 b = new Form1();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 b = new Form1();
            b.Show();
        }
    }
}
