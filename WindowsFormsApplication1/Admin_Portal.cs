using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Admin_Portal : Form
    {
        public Admin_Portal()
        {
            InitializeComponent();
        }

        private void Admin_Portal_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Add_Teachers().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new NonTeachingStaff_Details().Show();
            this.Hide();
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            new Principal_Details().Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new Student_details().Show();
            this.Hide();

        }
        
        private void button24_Click(object sender, EventArgs e)
        {
            new Class_Details().Show();
            this.Hide();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }
    }
}
