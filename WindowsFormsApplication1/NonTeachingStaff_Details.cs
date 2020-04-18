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
    public partial class NonTeachingStaff_Details : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HAMZA\DOCUMENTS\COLLEGIO_DATABASE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adapt;
        SqlCommand cmd;

        public NonTeachingStaff_Details()
        {
            InitializeComponent();
            ClearData();
            DisplayData();
           
        }

        private void Add_NonTeachingStaff_Load(object sender, EventArgs e)
        {
          
        }


        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Non_Teaching_Staff", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            nT_Staff_IDTextBox.Text = "";
            nT_First_NameTextBox.Text = "";
            nT_Last_NameTextBox.Text = "";
            nT_JobTitleTextBox.Text = "";
            nT_PhoneNumberTextBox.Text = "";
            nT_EmailTextBox.Text = "";
            nT_AddressTextBox.Text = "";
            nT_HiredateDateTimePicker.Text = "";
            nT_SalaryTextBox.Text = "";
        }


        private void Back_Button_Click(object sender, EventArgs e)
        {

            System.Threading.Thread mythread = new System.Threading.Thread(new System.Threading.ThreadStart(OpenNewFromBack));

            mythread.Start();

            this.Hide();
        }


        public static void OpenNewFromBack()
        {

            Application.Run(new Admin_Portal());//Create an instance of your new form. No need to call show method.

        }


        private void Add_Class_Button_Click(object sender, EventArgs e)
        {
            if (nT_Staff_IDTextBox.Text != "" && nT_First_NameTextBox.Text != "" && nT_Last_NameTextBox.Text != "" && nT_PhoneNumberTextBox.Text != "" && nT_AddressTextBox.Text != "" && nT_HiredateDateTimePicker.Text != "" && nT_SalaryTextBox.Text != "")
            {
                cmd = new SqlCommand("insert into Non_Teaching_Staff( NT_Staff_ID,NT_First_Name,NT_Last_Name,NT_JobTitle,NT_PhoneNumber,NT_Email,NT_Address,NT_Hiredate,NT_Salary) values(@id,@fname,@lname,@job,@phone,@email,@address,@hiredate,@salary)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", nT_Staff_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@fname", nT_First_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@lname", nT_Last_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@job", nT_JobTitleTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", nT_PhoneNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@email", nT_EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@address", nT_AddressTextBox.Text);
                cmd.Parameters.AddWithValue("@hiredate", nT_HiredateDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@salary", nT_SalaryTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully!");
                ClearData();
                DisplayData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void nT_Staff_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UPDATE_TEACHER_Click(object sender, EventArgs e)
        {
            if (nT_Staff_IDTextBox.Text != "" && nT_First_NameTextBox.Text != "" && nT_Last_NameTextBox.Text != "" && nT_PhoneNumberTextBox.Text != "" && nT_AddressTextBox.Text != "" && nT_HiredateDateTimePicker.Text != "" && nT_SalaryTextBox.Text != "")
            {
                cmd = new SqlCommand("UPDATE Non_Teaching_Staff set NT_First_Name=@fname,NT_Last_Name=@lname,NT_JobTitle=@job,NT_PhoneNumber=@phone,NT_Email=@email,NT_Address=@address,NT_Hiredate=@hiredate,NT_Salary=@salary WHERE NT_Staff_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", nT_Staff_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@fname", nT_First_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@lname", nT_Last_NameTextBox.Text);
                cmd.Parameters.AddWithValue("@job", nT_JobTitleTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", nT_PhoneNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@email", nT_EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@address", nT_AddressTextBox.Text);
                cmd.Parameters.AddWithValue("@hiredate", nT_HiredateDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@salary", nT_SalaryTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully!");
                ClearData();
                DisplayData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }

        private void DELETE_TEACHER_Click(object sender, EventArgs e)
        {
            if (nT_Staff_IDTextBox.Text != "")
            {
                cmd = new SqlCommand("delete Non_Teaching_Staff where NT_Staff_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", nT_Staff_IDTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            nT_Staff_IDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nT_First_NameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            nT_Last_NameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            nT_JobTitleTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            nT_EmailTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            nT_PhoneNumberTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            nT_AddressTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            nT_HiredateDateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            nT_SalaryTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

        }
    }
}
