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
    public partial class RegisterStudent : Form
    {
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            displayFacultyData();
        }

        private void displayFacultyData()
        {
            using(SqlConnection conn = Connection.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from faculty", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbfaculty.DisplayMember = "facultyName";
                cmbfaculty.ValueMember = "facultyId";
                cmbfaculty.DataSource = dt;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
    if(txtFullname.Text == "" || txtAddress.Text == "" || txtperson.Text == "" || txtdate.Text == "" || txtPhone.Text == "" || txtPlace.Text == "" || comboBox1.Text == "" || txtfee.Text == "")
            {
                MessageBox.Show("please fill all the field");
            }
            else
            {
                using (SqlConnection conn = Connection.connect())
                {
                    SqlCommand cmd = new SqlCommand("insert into student(studentName,studentAddress,studentPhone,studentPbirth,studentsex,studentDbirth,studentContactperson,studentFee,facultyId) values(@stdName,@stdAddress,@stdPhone,@stdPbirth,@stdSex,@stdDbirth,@stdContactPerson,@stdFee,@facultyId)", conn);
                    cmd.Parameters.AddWithValue("@stdName", txtFullname.Text);
                    cmd.Parameters.AddWithValue("@stdAddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@stdPhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@stdPbirth", txtPlace.Text);
                    cmd.Parameters.AddWithValue("@stdSex", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@stdDbirth", txtdate.Text);
                    cmd.Parameters.AddWithValue("@stdContactPerson", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@stdFee", txtfee.Text);
                    cmd.Parameters.AddWithValue("@facultyId", cmbfaculty.SelectedValue);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Registered ", "Success Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
          
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
