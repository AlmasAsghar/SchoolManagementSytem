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
    public partial class Class_Details : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HAMZA\DOCUMENTS\COLLEGIO_DATABASE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public Class_Details()
        {
            InitializeComponent();
            ClearData();
            DisplayData();

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Class", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void Class_Details_Load(object sender, EventArgs e)
        {
            
        }

        private void Add_Class_Button_Click(object sender, EventArgs e)
        {

            if (class_IDTextBox.Text != "" && class_RoomNoTextBox.Text != "" && class_MaxStrengthTextBox.Text != "")
            {
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into CLASS (Class_ID,Class_MaxStrength,Class_RoomNo) values('" + class_IDTextBox.Text + "','" + class_MaxStrengthTextBox.Text + "','" + class_RoomNoTextBox.Text + "')";
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("CLASS INSERTED SUCESSFULLY");

                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void ClearData()
        {
            class_IDTextBox.Text = "";
            class_MaxStrengthTextBox.Text = "";
            class_RoomNoTextBox.Text = "";

        }

        private void Class_Back_Button_Click(object sender, EventArgs e)
        {
            System.Threading.Thread mythread = new System.Threading.Thread(new System.Threading.ThreadStart(OpenNewFromBack));

            mythread.Start();

            this.Hide();
        }


        public static void OpenNewFromBack()
        {

            Application.Run(new Admin_Portal());//Create an instance of your new form. No need to call show method.

        }

        private void Update_Class_Button_Click(object sender, EventArgs e)
        {
            if (class_IDTextBox.Text !="" && class_RoomNoTextBox.Text !="" && class_MaxStrengthTextBox.Text!="")
                {

                cmd = new SqlCommand("UPDATE Class set Class_MaxStrength=@max, Class_RoomNo =@room WHERE Class_ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", class_IDTextBox.Text);
                cmd.Parameters.AddWithValue("@max", class_MaxStrengthTextBox.Text);
                cmd.Parameters.AddWithValue("@room", class_RoomNoTextBox.Text);
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
            class_IDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            class_MaxStrengthTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            class_RoomNoTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
}
