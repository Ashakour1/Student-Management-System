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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        displayAllstudents displayAllstudents = new displayAllstudents();

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addAttendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
            attendence.ShowDialog();
        }

        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.ShowDialog();
        }

        private void addmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allFacultiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faculty faculty = new faculty();
            faculty.ShowDialog();
        }

        

       

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayAllstudents allstudents = new displayAllstudents();
            allstudents.ShowDialog();
        }

        private void chargeMonthlyFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finance finance = new Finance();
            finance.ShowDialog();
        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.ShowDialog();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Score score = new Score();
            score.ShowDialog();
        }

        private void financeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using(SqlConnection conn = Connection.connect())
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS TotalStudents FROM student", conn);
                int totalStudents = (int)cmd.ExecuteScalar();

                lblstudents.Text = $"{totalStudents}";


            }
        }

        
    


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS course FROM course", conn);
                int totalcourse = (int)cmd.ExecuteScalar();

                course.Text = $"{totalcourse}";


            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS totalfaculty FROM faculty", conn);
                int totalfaculty = (int)cmd.ExecuteScalar();

                lbfaculty.Text = $"{totalfaculty}";


            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            
            signIn.ShowDialog();
            
        }
    }
}
