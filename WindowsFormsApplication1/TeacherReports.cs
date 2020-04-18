using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class TeacherReports : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HAMZA\DOCUMENTS\COLLEGIO_DATABASE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adapt;

        public TeacherReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (teacher_IDTextBox.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from teacher where Teacher_ID='"+teacher_IDTextBox.Text+"' ", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else
            {
                MessageBox.Show("Please Select Record to Search!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (teacher_FNameTextBox.Text != "" && teacher_LNameTextBox.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from teacher where Teacher_FName='" + teacher_FNameTextBox.Text + "' AND Teacher_LName='" + teacher_LNameTextBox.Text + "'  ", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else
            {
                MessageBox.Show("Please Select Record to Search!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (teacher_HiredateDateTimePicker.Text != "" && dateTimePicker1.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from teacher where Teacher_Hiredate Between '" + teacher_HiredateDateTimePicker.Text + "' and '" + dateTimePicker1.Text + "'  ", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else
            {
                MessageBox.Show("Please Select Record to Search!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (teacher_SalaryTextBox.Text != "" && textBox1.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from teacher where Teacher_Salary Between '" + teacher_SalaryTextBox.Text + "' and '" + textBox1.Text + "'  ", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else
            {
                MessageBox.Show("Please Select Record to Search!");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Principal_Portal().Show();
            this.Hide();
        }
    }
}
