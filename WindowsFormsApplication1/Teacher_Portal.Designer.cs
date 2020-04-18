namespace WindowsFormsApplication1
{
    partial class Teacher_Portal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Portal));
            this.choose_classID_comboBox = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegio_DatabaseDataSet = new WindowsFormsApplication1.Collegio_DatabaseDataSet();
            this.select_class_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update_Attendance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Logout_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // choose_classID_comboBox
            // 
            this.choose_classID_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.classBindingSource, "Class_ID", true));
            this.choose_classID_comboBox.FormattingEnabled = true;
            this.choose_classID_comboBox.Location = new System.Drawing.Point(112, 29);
            this.choose_classID_comboBox.Name = "choose_classID_comboBox";
            this.choose_classID_comboBox.Size = new System.Drawing.Size(216, 31);
            this.choose_classID_comboBox.TabIndex = 0;
            this.choose_classID_comboBox.SelectedIndexChanged += new System.EventHandler(this.choose_class_comboBox_SelectedIndexChanged);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.collegio_DatabaseDataSet;
            // 
            // collegio_DatabaseDataSet
            // 
            this.collegio_DatabaseDataSet.DataSetName = "Collegio_DatabaseDataSet";
            this.collegio_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // select_class_button
            // 
            this.select_class_button.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.select_class_button.Location = new System.Drawing.Point(363, 29);
            this.select_class_button.Name = "select_class_button";
            this.select_class_button.Size = new System.Drawing.Size(98, 28);
            this.select_class_button.TabIndex = 1;
            this.select_class_button.Text = "Continue";
            this.select_class_button.UseVisualStyleBackColor = true;
            this.select_class_button.Click += new System.EventHandler(this.select_class_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1045, 550);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Update_Attendance
            // 
            this.Update_Attendance.Font = new System.Drawing.Font("Times New Roman", 12.75F);
            this.Update_Attendance.Location = new System.Drawing.Point(584, 22);
            this.Update_Attendance.Name = "Update_Attendance";
            this.Update_Attendance.Size = new System.Drawing.Size(195, 48);
            this.Update_Attendance.TabIndex = 3;
            this.Update_Attendance.Text = "Update Attendance";
            this.Update_Attendance.UseVisualStyleBackColor = true;
            this.Update_Attendance.Click += new System.EventHandler(this.Update_Attendance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class";
            // 
            // Logout_Button
            // 
            this.Logout_Button.Location = new System.Drawing.Point(794, 22);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.Size = new System.Drawing.Size(151, 48);
            this.Logout_Button.TabIndex = 59;
            this.Logout_Button.Text = "Logout";
            this.Logout_Button.UseVisualStyleBackColor = true;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // Teacher_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 741);
            this.Controls.Add(this.Logout_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update_Attendance);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.select_class_button);
            this.Controls.Add(this.choose_classID_comboBox);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(1084, 780);
            this.Name = "Teacher_Portal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher_Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Teacher_Portal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choose_classID_comboBox;
        private Collegio_DatabaseDataSet collegio_DatabaseDataSet;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.Button select_class_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Update_Attendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logout_Button;
    }
}