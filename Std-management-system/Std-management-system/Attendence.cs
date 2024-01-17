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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Std_management_system
{
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void Attendence_Load(object sender, EventArgs e)
        {
            displayStudentData();
            displayCourseData();
            displayAttendence();
        }

        private void displayAttendence()
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from attendence", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


                dataGridView1.DataSource = dt;

            }
        }

        private void displayStudentData()
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from student", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


                stdCmb.DisplayMember = "studentName";
                stdCmb.ValueMember = "studentId";
                stdCmb.DataSource = dt;

            }
        }
        private void displayCourseData()
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from course", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


                coursecmb.DisplayMember = "courseName";
                coursecmb.ValueMember = "courseId";
                coursecmb.DataSource = dt;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlCommand cmd = new SqlCommand("Insert into attendence(studentId,courseId,attendenceStatus) values(@stdId,@courseId,@attendenceStatus)", conn);
                cmd.Parameters.AddWithValue("@stdId", stdCmb.SelectedValue);
                cmd.Parameters.AddWithValue("@courseId", coursecmb.SelectedValue);
                cmd.Parameters.AddWithValue("@attendenceStatus", status.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
