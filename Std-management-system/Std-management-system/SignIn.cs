using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Std_management_system
{
    public partial class SignIn : Form
    {
        Dashboard dashboard = new Dashboard();
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Log in Successfully");

                this.Hide();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection conn = Connection.connect())
            {
                string sql = "select * from users where username=@username and password=@pass";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pass", password);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string type = dr["userType"].ToString();

                    if (type == "teacher")
                    {
                        dashboard.financeToolStripMenuItem.Visible = false;
                        dashboard.addmissionToolStripMenuItem.Visible = false;
                        dashboard.facultyToolStripMenuItem.Visible = false;
                        dashboard.courseToolStripMenuItem.Visible=false;
                    }

                }
                return dr.HasRows;
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtusername.Text == "Username")
            {
                txtusername.Clear();
            }
        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtpassword.Text == "password")
            {
                txtpassword.Clear();
                txtpassword.PasswordChar = '*';
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpassword_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
