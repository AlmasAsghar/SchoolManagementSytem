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
    public partial class Principal_Details : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HAMZA\DOCUMENTS\COLLEGIO_DATABASE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter adapt;


        public Principal_Details()
        {
            InitializeComponent();
            DisplayData();       
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Principal", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void Back_Button_Click(object sender, EventArgs e)
        {


            //System.Threading.Thread mythread = new System.Threading.Thread(new System.Threading.ThreadStart(OpenNewFromBack));

            //mythread.Start();

            new Admin_Portal().Show();
            this.Hide();
        }


        public static void OpenNewFromBack()
        {

            Application.Run(new Admin_Portal());//Create an instance of your new form. No need to call show method.

        }


        private void Add_Class_Button_Click(object sender, EventArgs e)
        {
            if (principal_IDTextBox.Text != "" && principal_FNameTextBox.Text != "" && principal_LNameTextBox.Text != "" && principal_PhoneNumTextBox.Text != "" && principal_EmailTextBox.Text != "" && principal_AddressTextBox.Text != "" && principal_HiredateDateTimePicker.Text != "" && principal_SalaryTextBox.Text != "")
            {
                cmd = new SqlCommand("insert into Principal( Principal_ID,Principal_FName,Principal_LName,Principal_PhoneNum,Principal_Email,Principal_Address,Principal_Hiredate,Principal_Salary) values(@id,@fname,@lname,@phone,@email,@address,@hiredate,@salary)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", principal_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@fname", principal_FNameTextBox.Text);
                cmd.Parameters.AddWithValue("@lname", principal_LNameTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", principal_PhoneNumTextBox.Text);
                cmd.Parameters.AddWithValue("@email", principal_EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@address", principal_AddressTextBox.Text);
                cmd.Parameters.AddWithValue("@hiredate", principal_HiredateDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@salary", principal_SalaryTextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully!");
                ClearData();
                DisplayData();

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }


        private void ClearData()
        {
            principal_IDTextBox.Text = "";
            principal_FNameTextBox.Text = "";
            principal_LNameTextBox.Text = "";
            principal_PhoneNumTextBox.Text = "";
            principal_EmailTextBox.Text = "";
            principal_AddressTextBox.Text = "";
            principal_HiredateDateTimePicker.Text = "";
            principal_SalaryTextBox.Text = "";
 
        }

        private void principal_update_button_Click(object sender, EventArgs e)
        {
            if (principal_IDTextBox.Text != "" && principal_FNameTextBox.Text != ""  && principal_PhoneNumTextBox.Text != "" && principal_EmailTextBox.Text != "" && principal_AddressTextBox.Text != "" && principal_HiredateDateTimePicker.Text != "" && principal_SalaryTextBox.Text != "")
            {
                cmd = new SqlCommand("UPDATE Principal set Principal_FName=@fname,Principal_LName=@lname,Principal_PhoneNum=@phone,Principal_Email=@email,Principal_Address=@address,Principal_Hiredate=@hiredate,Principal_Salary=@salary WHERE Principal_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", principal_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@fname", principal_FNameTextBox.Text);
                cmd.Parameters.AddWithValue("@lname", principal_LNameTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", principal_PhoneNumTextBox.Text);
                cmd.Parameters.AddWithValue("@email", principal_EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@address", principal_AddressTextBox.Text);
                cmd.Parameters.AddWithValue("@hiredate", principal_HiredateDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@salary", principal_SalaryTextBox.Text);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            principal_IDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            principal_FNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            principal_LNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            principal_PhoneNumTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            principal_EmailTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            principal_AddressTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            principal_HiredateDateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            principal_SalaryTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
           
        }

        private void Principal_delete_button_Click(object sender, EventArgs e)
        {
            if (principal_IDTextBox.Text != "")
            {
                cmd = new SqlCommand("delete Principal where Principal_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", principal_IDTextBox.Text);
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

        private void Principal_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
