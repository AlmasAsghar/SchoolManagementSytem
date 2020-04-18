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
    public partial class Student_details : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HAMZA\DOCUMENTS\COLLEGIO_DATABASE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd,cmd1;
        SqlDataAdapter adapt;

        public Student_details()
        {
            InitializeComponent();
            DisplayData();
            ClearData();
            FillCombo();
        }


        private void Student_details_Load(object sender, EventArgs e)
        {

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Student", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void ClearData()
        {
            student_IDTextBox.Text = "";
            student_FNameTextBox.Text = "";
            student_LNameTextBox.Text = "";
            student_PhoneNumTextBox.Text = "";
            student_EmailTextBox.Text = "";
            student_AddressTextBox.Text = "";
            date_of_AdmissionDateTimePicker.Text = "";
        }

        private void Add_Student_Click(object sender, EventArgs e)
        {
            
            if (student_IDTextBox.Text != "" && student_FNameTextBox.Text != "" && choose_classID_comboBox.Text!="" && student_PhoneNumTextBox.Text != ""  && student_AddressTextBox.Text != "" && date_of_AdmissionDateTimePicker.Text != "" )
            {
                cmd = new SqlCommand("insert into Student( Student_ID,Student_FName,Student_LName,Student_Address,Student_PhoneNum,Student_Email,Date_of_Admission,Class_ID) values(@id,@fname,@lname,@address,@phone,@email,@dateOfAdmission,@classID)", con);
                cmd1 = new SqlCommand("insert into Attendance (Class_ID,Student_ID) values(@classID1,@id1)", con);

                con.Open();
                cmd.Parameters.AddWithValue("@id", student_IDTextBox.Text);
                cmd1.Parameters.AddWithValue("@id1", student_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@fname", student_FNameTextBox.Text);
                cmd.Parameters.AddWithValue("@lname", student_LNameTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", student_PhoneNumTextBox.Text);
                cmd.Parameters.AddWithValue("@email", student_EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@address", student_AddressTextBox.Text);
                cmd.Parameters.AddWithValue("@dateOfAdmission", date_of_AdmissionDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@classID", choose_classID_comboBox.Text);
                cmd1.Parameters.AddWithValue("@classID1", choose_classID_comboBox.Text);

                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
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

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (student_IDTextBox.Text != ""  && student_FNameTextBox.Text != "" &&  student_PhoneNumTextBox.Text != "" && student_AddressTextBox.Text != "" && date_of_AdmissionDateTimePicker.Text != "" && choose_classID_comboBox.Text != "")
            {
                cmd = new SqlCommand("UPDATE Student set Student_FName=@fname,Student_LName=@lname,Student_PhoneNum=@phone,Student_Email=@email,Student_Address=@address,Date_of_Admission=@dateOfAdmission,Class_ID=@classID WHERE Student_ID=@id", con);
                cmd1 = new SqlCommand("Update Attendance set Class_ID=@classID1 where Student_ID=@id1", con);

                con.Open();
                cmd.Parameters.AddWithValue("@id", student_IDTextBox.Text);

                cmd1.Parameters.AddWithValue("@id1", student_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@fname", student_FNameTextBox.Text);
                cmd.Parameters.AddWithValue("@lname", student_LNameTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", student_PhoneNumTextBox.Text);
                cmd.Parameters.AddWithValue("@email", student_EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@address", student_AddressTextBox.Text);
                cmd.Parameters.AddWithValue("@dateOfAdmission", date_of_AdmissionDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@classID", choose_classID_comboBox.Text);
                cmd1.Parameters.AddWithValue("@classID1", choose_classID_comboBox.Text);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
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

        private void Delete_Student_Click(object sender, EventArgs e)
        {
            if (student_IDTextBox.Text != "")
            {
                cmd = new SqlCommand("delete Student where Student_ID=@id", con);
                cmd1 = new SqlCommand("delete Attendance where Student_ID=@id1", con);

                con.Open();
                cmd.Parameters.AddWithValue("@id", student_IDTextBox.Text);
                cmd1.Parameters.AddWithValue("@id1", student_IDTextBox.Text);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
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

        private void Back_Student_Click(object sender, EventArgs e)
        {
            (new Admin_Portal()).Show();
            this.Hide();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            student_IDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            student_FNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            student_LNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            student_AddressTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            student_PhoneNumTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            student_EmailTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            date_of_AdmissionDateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            choose_classID_comboBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

    

        private void Student_details_Shown(object sender, EventArgs e)
        {

        }

        private void FillCombo()
        {
            SqlCommand cmd= new SqlCommand("Select Class_ID from Class", con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    choose_classID_comboBox.Items.Add(dr["Class_ID"]);
                }

                dr.Close();
                con.Close();
               
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }
        }
    }
}
