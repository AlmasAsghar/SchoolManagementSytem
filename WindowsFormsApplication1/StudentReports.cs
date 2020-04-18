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
    public partial class StudentReports : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HAMZA\DOCUMENTS\COLLEGIO_DATABASE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public StudentReports()
        {
            InitializeComponent();
            FillCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (student_IDTextBox.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student where Student_ID='" + student_IDTextBox.Text + "' ", con);
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
            if (student_FNameTextBox.Text != "" && student_LNameTextBox.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student where Student_FName='" + student_FNameTextBox.Text + "' AND Student_LName='" + student_LNameTextBox.Text + "'  ", con);
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
            if (dateOfAdmission_DateTimePicker.Text != "" && dateTimePicker1.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student where Date_of_Admission Between '" + dateOfAdmission_DateTimePicker.Text + "' and '" + dateTimePicker1.Text + "'  ", con);
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
            if (choose_classID_comboBox.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Student where Class_ID='" + choose_classID_comboBox.Text + "' ", con);
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

        private void StudentReports_Load(object sender, EventArgs e)
        {

        }

        private void FillCombo()
        {
            cmd = new SqlCommand("Select Class_ID from Class", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    choose_classID_comboBox.Items.Add(dr["Class_ID"]);
                }

                dr.Close();
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }
        }

    }
}
