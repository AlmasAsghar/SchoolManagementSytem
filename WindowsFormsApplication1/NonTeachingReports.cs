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
    public partial class NonTeachingReports : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HAMZA\DOCUMENTS\COLLEGIO_DATABASE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adapt;

        public NonTeachingReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (staff_IDTextBox.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Non_Teaching_Staff where NT_Staff_ID='" + staff_IDTextBox.Text + "' ", con);
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
            if (staff_FNameTextBox.Text != "" && staff_LNameTextBox.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Non_Teaching_Staff where NT_First_Name='" + staff_FNameTextBox.Text + "' AND NT_Last_Name='" + staff_LNameTextBox.Text + "'  ", con);
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
            if (staff_HiredateDateTimePicker.Text != "" && dateTimePicker1.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Non_Teaching_Staff where NT_Hiredate Between '" + staff_HiredateDateTimePicker.Text + "' and '" + dateTimePicker1.Text + "'  ", con);
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
            if (staff_SalaryTextBox.Text != "" && textBox1.Text != "")
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Non_Teaching_Staff where NT_Salary Between '" + staff_SalaryTextBox.Text + "' and '" + textBox1.Text + "'  ", con);
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
