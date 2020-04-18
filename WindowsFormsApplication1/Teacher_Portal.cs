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
    public partial class Teacher_Portal : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HAMZA\DOCUMENTS\COLLEGIO_DATABASE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataSet ds;


        public Teacher_Portal()
        {
            InitializeComponent();
            FillCombo();
        }


        private void Teacher_Portal_Load(object sender, EventArgs e)
        {

        }

 
        private void choose_class_comboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void DisplayData()
        {
            con.Open();

            adapt = new SqlDataAdapter("select Student_ID,Day_1,Day_2,Day_3,Day_4,Day_5,Day_6,Day_7,Day_8,Day_9,Day_10,Day_11,Day_12,Day_13,Day_14,Day_15,Day_16 from Attendance  WHERE  Class_ID='" + choose_classID_comboBox.Text + "' ", con);

           
            ds = new System.Data.DataSet();
            adapt.Fill(ds, "Attendance_Details");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }



        private void select_class_button_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Attendance_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder cmd = new SqlCommandBuilder(adapt);
                adapt.Update(ds, "Attendance_Details");
                MessageBox.Show("Attendance Updated!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }

        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }
    }
}
