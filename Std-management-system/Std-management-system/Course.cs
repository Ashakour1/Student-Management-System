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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtcourseDesc.Text == "" || txtCoursehours.Text == "" || txtCourseName.Text == "")
            {

            }
            else
            {
                using (SqlConnection conn = Connection.connect())
                {
                    SqlCommand cmd = new SqlCommand("insert into course(courseName,courseHours,courseDesc) values(@courseName,@coursHours,@courseDesc)", conn);
                    cmd.Parameters.AddWithValue("@courseName", txtCourseName.Text);
                    cmd.Parameters.AddWithValue("@coursHours", txtCoursehours.Text);
                    cmd.Parameters.AddWithValue("@courseDesc", txtcourseDesc.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added New Course", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
            }
           
        }
    }
}
