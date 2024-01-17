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
    public partial class faculty : Form
    {
        public faculty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(txtFaculty.Text == "")
            {
                MessageBox.Show("please fill inthe fields");
            }
            else
            {
                using (SqlConnection conn = Connection.connect())
                {
                    SqlCommand cmd = new SqlCommand("insert into faculty(facultyName) values(@facultyName)", conn);
                    cmd.Parameters.AddWithValue("@facultyName", txtFaculty.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added Faculty", "Success Addedd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void faculty_Load(object sender, EventArgs e)
        {
            displayDataFaculty();
        }

        private void displayDataFaculty()
        {
            using(SqlConnection conn = Connection.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from faculty", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

               dataGridView1.DataSource = dt;
            }
        }

        private void txtFaculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
