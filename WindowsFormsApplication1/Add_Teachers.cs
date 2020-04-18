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
    public partial class Add_Teachers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HAMZA\DOCUMENTS\COLLEGIO_DATABASE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Add_Teachers()
        {
            InitializeComponent();
            ClearData();
            DisplayData();
        }

      
        private void Add_Teachers_Load(object sender, EventArgs e)
        {
           
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from teacher", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        

        private void ClearData()
        {
            teacher_IDTextBox.Text = "";
            teacher_FNameTextBox.Text = "";
            teacher_LNameTextBox.Text = "";
            teacher_PhoneNumTextBox.Text = "";
            teacher_EmailTextBox.Text = "";
            teacher_AddressTextBox.Text = "";
            teacher_HiredateDateTimePicker.Text = "";
            teacher_SalaryTextBox.Text = "";
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
        

        private void UPDATE_TEACHER_Click(object sender, EventArgs e)
        {
            if (teacher_IDTextBox.Text != ""  && teacher_FNameTextBox.Text != "" && teacher_LNameTextBox.Text != "" && teacher_PhoneNumTextBox.Text != "" && teacher_AddressTextBox.Text != "" && teacher_HiredateDateTimePicker.Text != "" && teacher_SalaryTextBox.Text != "")
            {
                cmd = new SqlCommand("UPDATE teacher set teacher_FName=@fname,teacher_LName=@lname,teacher_PhoneNum=@phone,teacher_Email=@email,teacher_Address=@address,teacher_Hiredate=@hiredate,teacher_Salary=@salary WHERE teacher_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", teacher_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@fname", teacher_FNameTextBox.Text);
                cmd.Parameters.AddWithValue("@lname", teacher_LNameTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", teacher_PhoneNumTextBox.Text);
                cmd.Parameters.AddWithValue("@email", teacher_EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@address", teacher_AddressTextBox.Text);
                cmd.Parameters.AddWithValue("@hiredate", teacher_HiredateDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@salary", teacher_SalaryTextBox.Text);
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

        private void ADD_TEACHER_Click(object sender, EventArgs e)
        {
            if (teacher_IDTextBox.Text != "" && teacher_FNameTextBox.Text != "" && teacher_PhoneNumTextBox.Text != ""  && teacher_AddressTextBox.Text != "" && teacher_HiredateDateTimePicker.Text != "" && teacher_SalaryTextBox.Text != "")
            {
                cmd = new SqlCommand("insert into teacher( teacher_ID,teacher_FName,teacher_LName,teacher_PhoneNum,teacher_Email,teacher_Address,teacher_Hiredate,teacher_Salary) values(@id,@fname,@lname,@phone,@email,@address,@hiredate,@salary)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", teacher_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@fname", teacher_FNameTextBox.Text);
                cmd.Parameters.AddWithValue("@lname", teacher_LNameTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", teacher_PhoneNumTextBox.Text);
                cmd.Parameters.AddWithValue("@email", teacher_EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@address", teacher_AddressTextBox.Text);
                cmd.Parameters.AddWithValue("@hiredate", teacher_HiredateDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@salary", teacher_SalaryTextBox.Text);
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

        private void DELETE_TEACHER_Click(object sender, EventArgs e)
        {
            if (teacher_IDTextBox.Text != "")
            {
                cmd = new SqlCommand("delete teacher where teacher_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", teacher_IDTextBox.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            teacher_IDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            teacher_FNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            teacher_LNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            teacher_EmailTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            teacher_PhoneNumTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            teacher_AddressTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            teacher_HiredateDateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            teacher_SalaryTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }
    }
}
