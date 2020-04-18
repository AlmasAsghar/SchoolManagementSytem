namespace WindowsFormsApplication1
{
    partial class NonTeachingStaff_Details
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
            System.Windows.Forms.Label nT_Staff_IDLabel;
            System.Windows.Forms.Label nT_First_NameLabel;
            System.Windows.Forms.Label nT_Last_NameLabel;
            System.Windows.Forms.Label nT_JobTitleLabel;
            System.Windows.Forms.Label nT_EmailLabel;
            System.Windows.Forms.Label nT_PhoneNumberLabel;
            System.Windows.Forms.Label nT_AddressLabel;
            System.Windows.Forms.Label nT_HiredateLabel;
            System.Windows.Forms.Label nT_SalaryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NonTeachingStaff_Details));
            this.Back_Button = new System.Windows.Forms.Button();
            this.collegio_DatabaseDataSet = new WindowsFormsApplication1.Collegio_DatabaseDataSet();
            this.non_Teaching_StaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.non_Teaching_StaffTableAdapter = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.Non_Teaching_StaffTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.nT_Staff_IDTextBox = new System.Windows.Forms.TextBox();
            this.nT_First_NameTextBox = new System.Windows.Forms.TextBox();
            this.nT_Last_NameTextBox = new System.Windows.Forms.TextBox();
            this.nT_JobTitleTextBox = new System.Windows.Forms.TextBox();
            this.nT_EmailTextBox = new System.Windows.Forms.TextBox();
            this.nT_PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.nT_AddressTextBox = new System.Windows.Forms.TextBox();
            this.nT_HiredateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nT_SalaryTextBox = new System.Windows.Forms.TextBox();
            this.Add_Class_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete_NT = new System.Windows.Forms.Button();
            this.Update_NT = new System.Windows.Forms.Button();
            nT_Staff_IDLabel = new System.Windows.Forms.Label();
            nT_First_NameLabel = new System.Windows.Forms.Label();
            nT_Last_NameLabel = new System.Windows.Forms.Label();
            nT_JobTitleLabel = new System.Windows.Forms.Label();
            nT_EmailLabel = new System.Windows.Forms.Label();
            nT_PhoneNumberLabel = new System.Windows.Forms.Label();
            nT_AddressLabel = new System.Windows.Forms.Label();
            nT_HiredateLabel = new System.Windows.Forms.Label();
            nT_SalaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.non_Teaching_StaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nT_Staff_IDLabel
            // 
            nT_Staff_IDLabel.AutoSize = true;
            nT_Staff_IDLabel.Location = new System.Drawing.Point(30, 46);
            nT_Staff_IDLabel.Name = "nT_Staff_IDLabel";
            nT_Staff_IDLabel.Size = new System.Drawing.Size(64, 13);
            nT_Staff_IDLabel.TabIndex = 15;
            nT_Staff_IDLabel.Text = "NT Staff ID:";
            // 
            // nT_First_NameLabel
            // 
            nT_First_NameLabel.AutoSize = true;
            nT_First_NameLabel.Location = new System.Drawing.Point(30, 72);
            nT_First_NameLabel.Name = "nT_First_NameLabel";
            nT_First_NameLabel.Size = new System.Drawing.Size(78, 13);
            nT_First_NameLabel.TabIndex = 17;
            nT_First_NameLabel.Text = "NT First Name:";
            // 
            // nT_Last_NameLabel
            // 
            nT_Last_NameLabel.AutoSize = true;
            nT_Last_NameLabel.Location = new System.Drawing.Point(30, 98);
            nT_Last_NameLabel.Name = "nT_Last_NameLabel";
            nT_Last_NameLabel.Size = new System.Drawing.Size(79, 13);
            nT_Last_NameLabel.TabIndex = 19;
            nT_Last_NameLabel.Text = "NT Last Name:";
            // 
            // nT_JobTitleLabel
            // 
            nT_JobTitleLabel.AutoSize = true;
            nT_JobTitleLabel.Location = new System.Drawing.Point(30, 124);
            nT_JobTitleLabel.Name = "nT_JobTitleLabel";
            nT_JobTitleLabel.Size = new System.Drawing.Size(68, 13);
            nT_JobTitleLabel.TabIndex = 21;
            nT_JobTitleLabel.Text = "NT Job Title:";
            // 
            // nT_EmailLabel
            // 
            nT_EmailLabel.AutoSize = true;
            nT_EmailLabel.Location = new System.Drawing.Point(30, 150);
            nT_EmailLabel.Name = "nT_EmailLabel";
            nT_EmailLabel.Size = new System.Drawing.Size(53, 13);
            nT_EmailLabel.TabIndex = 23;
            nT_EmailLabel.Text = "NT Email:";
            // 
            // nT_PhoneNumberLabel
            // 
            nT_PhoneNumberLabel.AutoSize = true;
            nT_PhoneNumberLabel.Location = new System.Drawing.Point(30, 176);
            nT_PhoneNumberLabel.Name = "nT_PhoneNumberLabel";
            nT_PhoneNumberLabel.Size = new System.Drawing.Size(99, 13);
            nT_PhoneNumberLabel.TabIndex = 25;
            nT_PhoneNumberLabel.Text = "NT Phone Number:";
            // 
            // nT_AddressLabel
            // 
            nT_AddressLabel.AutoSize = true;
            nT_AddressLabel.Location = new System.Drawing.Point(30, 202);
            nT_AddressLabel.Name = "nT_AddressLabel";
            nT_AddressLabel.Size = new System.Drawing.Size(66, 13);
            nT_AddressLabel.TabIndex = 27;
            nT_AddressLabel.Text = "NT Address:";
            // 
            // nT_HiredateLabel
            // 
            nT_HiredateLabel.AutoSize = true;
            nT_HiredateLabel.Location = new System.Drawing.Point(30, 229);
            nT_HiredateLabel.Name = "nT_HiredateLabel";
            nT_HiredateLabel.Size = new System.Drawing.Size(68, 13);
            nT_HiredateLabel.TabIndex = 29;
            nT_HiredateLabel.Text = "NT Hiredate:";
            // 
            // nT_SalaryLabel
            // 
            nT_SalaryLabel.AutoSize = true;
            nT_SalaryLabel.Location = new System.Drawing.Point(30, 254);
            nT_SalaryLabel.Name = "nT_SalaryLabel";
            nT_SalaryLabel.Size = new System.Drawing.Size(57, 13);
            nT_SalaryLabel.TabIndex = 31;
            nT_SalaryLabel.Text = "NT Salary:";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(33, 374);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 14;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // collegio_DatabaseDataSet
            // 
            this.collegio_DatabaseDataSet.DataSetName = "Collegio_DatabaseDataSet";
            this.collegio_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // non_Teaching_StaffBindingSource
            // 
            this.non_Teaching_StaffBindingSource.DataMember = "Non_Teaching_Staff";
            this.non_Teaching_StaffBindingSource.DataSource = this.collegio_DatabaseDataSet;
            // 
            // non_Teaching_StaffTableAdapter
            // 
            this.non_Teaching_StaffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.Non_Teaching_StaffTableAdapter = this.non_Teaching_StaffTableAdapter;
            this.tableAdapterManager.PrincipalTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nT_Staff_IDTextBox
            // 
            this.nT_Staff_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.non_Teaching_StaffBindingSource, "NT_Staff_ID", true));
            this.nT_Staff_IDTextBox.Location = new System.Drawing.Point(135, 43);
            this.nT_Staff_IDTextBox.Name = "nT_Staff_IDTextBox";
            this.nT_Staff_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.nT_Staff_IDTextBox.TabIndex = 16;
            this.nT_Staff_IDTextBox.TextChanged += new System.EventHandler(this.nT_Staff_IDTextBox_TextChanged);
            // 
            // nT_First_NameTextBox
            // 
            this.nT_First_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.non_Teaching_StaffBindingSource, "NT_First_Name", true));
            this.nT_First_NameTextBox.Location = new System.Drawing.Point(135, 69);
            this.nT_First_NameTextBox.Name = "nT_First_NameTextBox";
            this.nT_First_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nT_First_NameTextBox.TabIndex = 18;
            // 
            // nT_Last_NameTextBox
            // 
            this.nT_Last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.non_Teaching_StaffBindingSource, "NT_Last_Name", true));
            this.nT_Last_NameTextBox.Location = new System.Drawing.Point(135, 95);
            this.nT_Last_NameTextBox.Name = "nT_Last_NameTextBox";
            this.nT_Last_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nT_Last_NameTextBox.TabIndex = 20;
            // 
            // nT_JobTitleTextBox
            // 
            this.nT_JobTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.non_Teaching_StaffBindingSource, "NT_JobTitle", true));
            this.nT_JobTitleTextBox.Location = new System.Drawing.Point(135, 121);
            this.nT_JobTitleTextBox.Name = "nT_JobTitleTextBox";
            this.nT_JobTitleTextBox.Size = new System.Drawing.Size(200, 20);
            this.nT_JobTitleTextBox.TabIndex = 22;
            // 
            // nT_EmailTextBox
            // 
            this.nT_EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.non_Teaching_StaffBindingSource, "NT_Email", true));
            this.nT_EmailTextBox.Location = new System.Drawing.Point(135, 147);
            this.nT_EmailTextBox.Name = "nT_EmailTextBox";
            this.nT_EmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.nT_EmailTextBox.TabIndex = 24;
            // 
            // nT_PhoneNumberTextBox
            // 
            this.nT_PhoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.non_Teaching_StaffBindingSource, "NT_PhoneNumber", true));
            this.nT_PhoneNumberTextBox.Location = new System.Drawing.Point(135, 173);
            this.nT_PhoneNumberTextBox.Name = "nT_PhoneNumberTextBox";
            this.nT_PhoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.nT_PhoneNumberTextBox.TabIndex = 26;
            // 
            // nT_AddressTextBox
            // 
            this.nT_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.non_Teaching_StaffBindingSource, "NT_Address", true));
            this.nT_AddressTextBox.Location = new System.Drawing.Point(135, 199);
            this.nT_AddressTextBox.Name = "nT_AddressTextBox";
            this.nT_AddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.nT_AddressTextBox.TabIndex = 28;
            // 
            // nT_HiredateDateTimePicker
            // 
            this.nT_HiredateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.nT_HiredateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.non_Teaching_StaffBindingSource, "NT_Hiredate", true));
            this.nT_HiredateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nT_HiredateDateTimePicker.Location = new System.Drawing.Point(135, 225);
            this.nT_HiredateDateTimePicker.Name = "nT_HiredateDateTimePicker";
            this.nT_HiredateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.nT_HiredateDateTimePicker.TabIndex = 30;
            // 
            // nT_SalaryTextBox
            // 
            this.nT_SalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.non_Teaching_StaffBindingSource, "NT_Salary", true));
            this.nT_SalaryTextBox.Location = new System.Drawing.Point(135, 251);
            this.nT_SalaryTextBox.Name = "nT_SalaryTextBox";
            this.nT_SalaryTextBox.Size = new System.Drawing.Size(200, 20);
            this.nT_SalaryTextBox.TabIndex = 32;
            // 
            // Add_Class_Button
            // 
            this.Add_Class_Button.Location = new System.Drawing.Point(33, 294);
            this.Add_Class_Button.Name = "Add_Class_Button";
            this.Add_Class_Button.Size = new System.Drawing.Size(87, 35);
            this.Add_Class_Button.TabIndex = 33;
            this.Add_Class_Button.Text = "ADD";
            this.Add_Class_Button.UseVisualStyleBackColor = true;
            this.Add_Class_Button.Click += new System.EventHandler(this.Add_Class_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(352, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 400);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Delete_NT
            // 
            this.Delete_NT.Location = new System.Drawing.Point(249, 290);
            this.Delete_NT.Name = "Delete_NT";
            this.Delete_NT.Size = new System.Drawing.Size(86, 42);
            this.Delete_NT.TabIndex = 42;
            this.Delete_NT.Text = "DELETE";
            this.Delete_NT.UseVisualStyleBackColor = true;
            this.Delete_NT.Click += new System.EventHandler(this.DELETE_TEACHER_Click);
            // 
            // Update_NT
            // 
            this.Update_NT.Location = new System.Drawing.Point(135, 290);
            this.Update_NT.Name = "Update_NT";
            this.Update_NT.Size = new System.Drawing.Size(90, 42);
            this.Update_NT.TabIndex = 43;
            this.Update_NT.Text = "UPDATE";
            this.Update_NT.UseVisualStyleBackColor = true;
            this.Update_NT.Click += new System.EventHandler(this.UPDATE_TEACHER_Click);
            // 
            // NonTeachingStaff_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 511);
            this.Controls.Add(this.Update_NT);
            this.Controls.Add(this.Delete_NT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add_Class_Button);
            this.Controls.Add(nT_Staff_IDLabel);
            this.Controls.Add(this.nT_Staff_IDTextBox);
            this.Controls.Add(nT_First_NameLabel);
            this.Controls.Add(this.nT_First_NameTextBox);
            this.Controls.Add(nT_Last_NameLabel);
            this.Controls.Add(this.nT_Last_NameTextBox);
            this.Controls.Add(nT_JobTitleLabel);
            this.Controls.Add(this.nT_JobTitleTextBox);
            this.Controls.Add(nT_EmailLabel);
            this.Controls.Add(this.nT_EmailTextBox);
            this.Controls.Add(nT_PhoneNumberLabel);
            this.Controls.Add(this.nT_PhoneNumberTextBox);
            this.Controls.Add(nT_AddressLabel);
            this.Controls.Add(this.nT_AddressTextBox);
            this.Controls.Add(nT_HiredateLabel);
            this.Controls.Add(this.nT_HiredateDateTimePicker);
            this.Controls.Add(nT_SalaryLabel);
            this.Controls.Add(this.nT_SalaryTextBox);
            this.Controls.Add(this.Back_Button);
            this.MaximumSize = new System.Drawing.Size(1240, 550);
            this.Name = "NonTeachingStaff_Details";
            this.Text = "Non Teaching Staff\'s Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_NonTeachingStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.non_Teaching_StaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back_Button;
        private Collegio_DatabaseDataSet collegio_DatabaseDataSet;
        private System.Windows.Forms.BindingSource non_Teaching_StaffBindingSource;
        private Collegio_DatabaseDataSetTableAdapters.Non_Teaching_StaffTableAdapter non_Teaching_StaffTableAdapter;
        private Collegio_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nT_Staff_IDTextBox;
        private System.Windows.Forms.TextBox nT_First_NameTextBox;
        private System.Windows.Forms.TextBox nT_Last_NameTextBox;
        private System.Windows.Forms.TextBox nT_JobTitleTextBox;
        private System.Windows.Forms.TextBox nT_EmailTextBox;
        private System.Windows.Forms.TextBox nT_PhoneNumberTextBox;
        private System.Windows.Forms.TextBox nT_AddressTextBox;
        private System.Windows.Forms.DateTimePicker nT_HiredateDateTimePicker;
        private System.Windows.Forms.TextBox nT_SalaryTextBox;
        private System.Windows.Forms.Button Add_Class_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete_NT;
        private System.Windows.Forms.Button Update_NT;
    }
}