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

    public partial class displayAllstudents : Form
    {
        updateform update = new updateform();
        public displayAllstudents()
        {
            InitializeComponent();
        }

        private void displayAllstudents_Load(object sender, EventArgs e)
        {
            displayAllstudent();
            displaydata();
        }

        public void displaydata()
        {
          using(SqlConnection conn = Connection.connect()) {
                SqlDataAdapter da = new SqlDataAdapter("select * from faculty", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                update.cmbfaculty.DisplayMember = "facultyName";
                update.cmbfaculty.ValueMember = "facultyId";
                update.cmbfaculty.DataSource = dt;
            }
        }

        public void displayAllstudent()
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT S.studentId, S.studentName, S.studentAddress, S.studentPhone, S.studentPbirth, S.studentsex, S.studentDbirth , S.studentContactperson, S.studentFee, F.facultyName FROM student S INNER JOIN faculty F ON S.facultyId = F.facultyId", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

               dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            update.label.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.txtFullname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.txtAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            update.txtPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            update.txtPlace.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            update.comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            update.txtdate.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            update.txtperson.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
           update.txtfee.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            update.cmbfaculty.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

          
            
            update.ShowDialog();
        }
    }
}
