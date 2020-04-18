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
    public partial class Add_Class : Form
    {
        public Add_Class()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void classBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.collegio_DatabaseDataSet);

        }

        private void classBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.classBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.collegio_DatabaseDataSet);

        }

        private void Add_Class_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegio_DatabaseDataSet.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.collegio_DatabaseDataSet.Class);

        }
    }
}
