namespace WindowsFormsApplication1
{
    partial class Student_details
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
            System.Windows.Forms.Label student_IDLabel;
            System.Windows.Forms.Label student_FNameLabel;
            System.Windows.Forms.Label student_LNameLabel;
            System.Windows.Forms.Label student_AddressLabel;
            System.Windows.Forms.Label student_PhoneNumLabel;
            System.Windows.Forms.Label student_EmailLabel;
            System.Windows.Forms.Label date_of_AdmissionLabel;
            System.Windows.Forms.Label class_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_details));
            this.collegio_DatabaseDataSet = new WindowsFormsApplication1.Collegio_DatabaseDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.student_IDTextBox = new System.Windows.Forms.TextBox();
            this.student_FNameTextBox = new System.Windows.Forms.TextBox();
            this.student_LNameTextBox = new System.Windows.Forms.TextBox();
            this.student_AddressTextBox = new System.Windows.Forms.TextBox();
            this.student_PhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.student_EmailTextBox = new System.Windows.Forms.TextBox();
            this.date_of_AdmissionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Add_Student = new System.Windows.Forms.Button();
            this.Delete_Student = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Back_Student = new System.Windows.Forms.Button();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.ClassTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.classstudentfkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.choose_classID_comboBox = new System.Windows.Forms.ComboBox();
            student_IDLabel = new System.Windows.Forms.Label();
            student_FNameLabel = new System.Windows.Forms.Label();
            student_LNameLabel = new System.Windows.Forms.Label();
            student_AddressLabel = new System.Windows.Forms.Label();
            student_PhoneNumLabel = new System.Windows.Forms.Label();
            student_EmailLabel = new System.Windows.Forms.Label();
            date_of_AdmissionLabel = new System.Windows.Forms.Label();
            class_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classstudentfkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // student_IDLabel
            // 
            student_IDLabel.AutoSize = true;
            student_IDLabel.Location = new System.Drawing.Point(31, 65);
            student_IDLabel.Name = "student_IDLabel";
            student_IDLabel.Size = new System.Drawing.Size(61, 13);
            student_IDLabel.TabIndex = 1;
            student_IDLabel.Text = "Student ID:";
            // 
            // student_FNameLabel
            // 
            student_FNameLabel.AutoSize = true;
            student_FNameLabel.Location = new System.Drawing.Point(31, 91);
            student_FNameLabel.Name = "student_FNameLabel";
            student_FNameLabel.Size = new System.Drawing.Size(84, 13);
            student_FNameLabel.TabIndex = 3;
            student_FNameLabel.Text = "Student FName:";
            // 
            // student_LNameLabel
            // 
            student_LNameLabel.AutoSize = true;
            student_LNameLabel.Location = new System.Drawing.Point(31, 117);
            student_LNameLabel.Name = "student_LNameLabel";
            student_LNameLabel.Size = new System.Drawing.Size(84, 13);
            student_LNameLabel.TabIndex = 5;
            student_LNameLabel.Text = "Student LName:";
            // 
            // student_AddressLabel
            // 
            student_AddressLabel.AutoSize = true;
            student_AddressLabel.Location = new System.Drawing.Point(31, 143);
            student_AddressLabel.Name = "student_AddressLabel";
            student_AddressLabel.Size = new System.Drawing.Size(88, 13);
            student_AddressLabel.TabIndex = 7;
            student_AddressLabel.Text = "Student Address:";
            // 
            // student_PhoneNumLabel
            // 
            student_PhoneNumLabel.AutoSize = true;
            student_PhoneNumLabel.Location = new System.Drawing.Point(31, 169);
            student_PhoneNumLabel.Name = "student_PhoneNumLabel";
            student_PhoneNumLabel.Size = new System.Drawing.Size(106, 13);
            student_PhoneNumLabel.TabIndex = 9;
            student_PhoneNumLabel.Text = "Student Phone Num:";
            // 
            // student_EmailLabel
            // 
            student_EmailLabel.AutoSize = true;
            student_EmailLabel.Location = new System.Drawing.Point(31, 195);
            student_EmailLabel.Name = "student_EmailLabel";
            student_EmailLabel.Size = new System.Drawing.Size(75, 13);
            student_EmailLabel.TabIndex = 11;
            student_EmailLabel.Text = "Student Email:";
            // 
            // date_of_AdmissionLabel
            // 
            date_of_AdmissionLabel.AutoSize = true;
            date_of_AdmissionLabel.Location = new System.Drawing.Point(31, 222);
            date_of_AdmissionLabel.Name = "date_of_AdmissionLabel";
            date_of_AdmissionLabel.Size = new System.Drawing.Size(95, 13);
            date_of_AdmissionLabel.TabIndex = 13;
            date_of_AdmissionLabel.Text = "Date of Admission:";
            // 
            // class_IDLabel
            // 
            class_IDLabel.AutoSize = true;
            class_IDLabel.Location = new System.Drawing.Point(31, 247);
            class_IDLabel.Name = "class_IDLabel";
            class_IDLabel.Size = new System.Drawing.Size(49, 13);
            class_IDLabel.TabIndex = 15;
            class_IDLabel.Text = "Class ID:";
            // 
            // collegio_DatabaseDataSet
            // 
            this.collegio_DatabaseDataSet.DataSetName = "Collegio_DatabaseDataSet";
            this.collegio_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.collegio_DatabaseDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.Non_Teaching_StaffTableAdapter = null;
            this.tableAdapterManager.PrincipalTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // student_IDTextBox
            // 
            this.student_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_ID", true));
            this.student_IDTextBox.Location = new System.Drawing.Point(143, 62);
            this.student_IDTextBox.Name = "student_IDTextBox";
            this.student_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_IDTextBox.TabIndex = 2;
            // 
            // student_FNameTextBox
            // 
            this.student_FNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_FName", true));
            this.student_FNameTextBox.Location = new System.Drawing.Point(143, 88);
            this.student_FNameTextBox.Name = "student_FNameTextBox";
            this.student_FNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_FNameTextBox.TabIndex = 4;
            // 
            // student_LNameTextBox
            // 
            this.student_LNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_LName", true));
            this.student_LNameTextBox.Location = new System.Drawing.Point(143, 114);
            this.student_LNameTextBox.Name = "student_LNameTextBox";
            this.student_LNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_LNameTextBox.TabIndex = 6;
            // 
            // student_AddressTextBox
            // 
            this.student_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_Address", true));
            this.student_AddressTextBox.Location = new System.Drawing.Point(143, 140);
            this.student_AddressTextBox.Name = "student_AddressTextBox";
            this.student_AddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_AddressTextBox.TabIndex = 8;
            // 
            // student_PhoneNumTextBox
            // 
            this.student_PhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_PhoneNum", true));
            this.student_PhoneNumTextBox.Location = new System.Drawing.Point(143, 166);
            this.student_PhoneNumTextBox.Name = "student_PhoneNumTextBox";
            this.student_PhoneNumTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_PhoneNumTextBox.TabIndex = 10;
            // 
            // student_EmailTextBox
            // 
            this.student_EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_Email", true));
            this.student_EmailTextBox.Location = new System.Drawing.Point(143, 192);
            this.student_EmailTextBox.Name = "student_EmailTextBox";
            this.student_EmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_EmailTextBox.TabIndex = 12;
            // 
            // date_of_AdmissionDateTimePicker
            // 
            this.date_of_AdmissionDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.date_of_AdmissionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "Date_of_Admission", true));
            this.date_of_AdmissionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_of_AdmissionDateTimePicker.Location = new System.Drawing.Point(143, 218);
            this.date_of_AdmissionDateTimePicker.Name = "date_of_AdmissionDateTimePicker";
            this.date_of_AdmissionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_AdmissionDateTimePicker.TabIndex = 14;
            // 
            // Add_Student
            // 
            this.Add_Student.Location = new System.Drawing.Point(34, 305);
            this.Add_Student.Name = "Add_Student";
            this.Add_Student.Size = new System.Drawing.Size(75, 23);
            this.Add_Student.TabIndex = 17;
            this.Add_Student.Text = "ADD";
            this.Add_Student.UseVisualStyleBackColor = true;
            this.Add_Student.Click += new System.EventHandler(this.Add_Student_Click);
            // 
            // Delete_Student
            // 
            this.Delete_Student.Location = new System.Drawing.Point(129, 305);
            this.Delete_Student.Name = "Delete_Student";
            this.Delete_Student.Size = new System.Drawing.Size(75, 23);
            this.Delete_Student.TabIndex = 18;
            this.Delete_Student.Text = "DELETE";
            this.Delete_Student.UseVisualStyleBackColor = true;
            this.Delete_Student.Click += new System.EventHandler(this.Delete_Student_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(224, 305);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(75, 23);
            this.Update_Button.TabIndex = 19;
            this.Update_Button.Text = "UPDATE";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Back_Student
            // 
            this.Back_Student.Location = new System.Drawing.Point(34, 352);
            this.Back_Student.Name = "Back_Student";
            this.Back_Student.Size = new System.Drawing.Size(75, 23);
            this.Back_Student.TabIndex = 20;
            this.Back_Student.Text = "Back";
            this.Back_Student.UseVisualStyleBackColor = true;
            this.Back_Student.Click += new System.EventHandler(this.Back_Student_Click);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.collegio_DatabaseDataSet;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 400);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // classstudentfkBindingSource
            // 
            this.classstudentfkBindingSource.DataMember = "class_student_fk";
            this.classstudentfkBindingSource.DataSource = this.classBindingSource;
            // 
            // classBindingSource1
            // 
            this.classBindingSource1.DataMember = "Class";
            this.classBindingSource1.DataSource = this.collegio_DatabaseDataSet;
            // 
            // choose_classID_comboBox
            // 
            this.choose_classID_comboBox.FormattingEnabled = true;
            this.choose_classID_comboBox.Location = new System.Drawing.Point(143, 244);
            this.choose_classID_comboBox.Name = "choose_classID_comboBox";
            this.choose_classID_comboBox.Size = new System.Drawing.Size(200, 21);
            this.choose_classID_comboBox.TabIndex = 23;
            // 
            // Student_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 511);
            this.Controls.Add(this.choose_classID_comboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back_Student);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Delete_Student);
            this.Controls.Add(this.Add_Student);
            this.Controls.Add(student_IDLabel);
            this.Controls.Add(this.student_IDTextBox);
            this.Controls.Add(student_FNameLabel);
            this.Controls.Add(this.student_FNameTextBox);
            this.Controls.Add(student_LNameLabel);
            this.Controls.Add(this.student_LNameTextBox);
            this.Controls.Add(student_AddressLabel);
            this.Controls.Add(this.student_AddressTextBox);
            this.Controls.Add(student_PhoneNumLabel);
            this.Controls.Add(this.student_PhoneNumTextBox);
            this.Controls.Add(student_EmailLabel);
            this.Controls.Add(this.student_EmailTextBox);
            this.Controls.Add(date_of_AdmissionLabel);
            this.Controls.Add(this.date_of_AdmissionDateTimePicker);
            this.Controls.Add(class_IDLabel);
            this.MaximumSize = new System.Drawing.Size(1240, 550);
            this.Name = "Student_details";
            this.Text = "Student_details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Student_details_Load);
            this.Shown += new System.EventHandler(this.Student_details_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classstudentfkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Collegio_DatabaseDataSet collegio_DatabaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Collegio_DatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private Collegio_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox student_IDTextBox;
        private System.Windows.Forms.TextBox student_FNameTextBox;
        private System.Windows.Forms.TextBox student_LNameTextBox;
        private System.Windows.Forms.TextBox student_AddressTextBox;
        private System.Windows.Forms.TextBox student_PhoneNumTextBox;
        private System.Windows.Forms.TextBox student_EmailTextBox;
        private System.Windows.Forms.DateTimePicker date_of_AdmissionDateTimePicker;
        private System.Windows.Forms.Button Add_Student;
        private System.Windows.Forms.Button Delete_Student;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Back_Student;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Collegio_DatabaseDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource classstudentfkBindingSource;
        private System.Windows.Forms.BindingSource classBindingSource1;
        private System.Windows.Forms.ComboBox choose_classID_comboBox;
    }
}