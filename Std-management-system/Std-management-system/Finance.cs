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
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();
        }

        private void Finance_Load(object sender, EventArgs e)
        {
            displayStudentData();
            displayFinanceData();
        }

        private void displayStudentData()
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from student", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DisplayMember = "studentName";
                comboBox1.ValueMember = "studentId";
                comboBox1.DataSource = dt;


            }
        }
        private void displayFinanceData()
        {
            using (SqlConnection conn = Connection.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select s.studentName, s.studentPhone , f.amount , f.description, f.financeDate  from student s inner join finance f on s.studentId = f.studentId;", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if(txtAmount.Text == "" || txtDesc.Text == "")
            {
                MessageBox.Show("Please fill the fields");
            }
            else
            {
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                int studentId = Convert.ToInt32(comboBox1.SelectedValue);

                using (SqlConnection conn = Connection.connect())
                {
                    SqlCommand cmd = new SqlCommand("insert into finance(amount,description,studentId) values(@amount,@desc,@stdId)", conn);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@desc", txtDesc.Text);
                    cmd.Parameters.AddWithValue("@stdId", studentId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Paid Monthly Fees", "Success Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayFinanceData();
                    displayStudentData();
                    clearText();
                }
            }
           
        }

        private void clearText()
        {
            txtAmount.Clear();
            txtDesc.Clear();
            
        }
    }
}
