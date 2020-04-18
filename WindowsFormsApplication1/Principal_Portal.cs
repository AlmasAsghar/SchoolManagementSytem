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
    public partial class Principal_Portal : Form
    {
        public Principal_Portal()
        {
            InitializeComponent();
        }

        private void View_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            new TeacherReports().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new NonTeachingReports().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new StudentReports().Show();
            this.Hide();
        }
    }
}
