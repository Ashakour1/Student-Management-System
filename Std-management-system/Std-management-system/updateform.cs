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
    public partial class updateform : Form
    {
        public updateform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlCommand cmd = new SqlCommand("update student set studentName = @stdName, studentAddress=@stdAddress, studentPhone=@stdPhone, studentPbirth=@stdplace, studentsex=@stdSex, studentDbirth=@stdBirth, studentContactperson=@stdContact, studentFee=@stdFee,facultyId=@facultyId where studentId = @studentId", conn);
                cmd.Parameters.AddWithValue("@studentId", label.Text);
                cmd.Parameters.AddWithValue("@stdName", txtFullname.Text);
                cmd.Parameters.AddWithValue("@stdAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@stdPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@stdplace", txtPlace.Text);
                cmd.Parameters.AddWithValue("@stdSex", comboBox1.Text);
                cmd.Parameters.AddWithValue("@stdBirth", txtdate.Text);
                cmd.Parameters.AddWithValue("@stdContact", txtAddress.Text);
                cmd.Parameters.AddWithValue("@stdFee", txtfee.Text);
                cmd.Parameters.AddWithValue("@facultyId", cmbfaculty.SelectedValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearText();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlCommand cmd = new SqlCommand("DeleteStudentAndFinance", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@studentId", label.Text); ;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearText();
            }
           
        }

        private void clearText()
        {
            txtFullname.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtperson.Clear();
            txtdate.Clear();
            txtfee.Clear();
            txtPlace.Clear();
        }

        private void updateform_Load(object sender, EventArgs e)
        {

        }
    }
}
