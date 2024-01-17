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
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection.connect())
            {

                SqlCommand cmd = new SqlCommand("insert into scores(scoreNumber,studentId,courseId) values(@score,@studentId,@courseId)", conn);
                cmd.Parameters.AddWithValue("@score", txtScoreNumber.Text);
                cmd.Parameters.AddWithValue("@studentId", studentCmb.SelectedValue);
                cmd.Parameters.AddWithValue("@courseId", courseCmb.SelectedValue);
                cmd.ExecuteNonQuery();
                displayScoreData();
                MessageBox.Show("Successfully added Score", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Score_Load(object sender, EventArgs e)
        {
            displayStudentData();
            displayCourseData();
            displayScoreData();
        }

        private void displayScoreData()
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT st.studentName,s.scoreNumber, s.scoreNumber, c.courseName FROM Scores s INNER JOIN student st ON s.studentId = st.studentId\r\nINNER JOIN course c ON s.courseId = c.courseId; ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
        }

        private void displayCourseData()
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from course", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


                courseCmb.DisplayMember = "courseName";
                courseCmb.ValueMember = "courseId";
                courseCmb.DataSource = dt;

            }
        }

        private void displayStudentData()
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from student", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


                studentCmb.DisplayMember = "studentName";
                studentCmb.ValueMember = "studentId";
                studentCmb.DataSource = dt;

            }
        }
    }
}
