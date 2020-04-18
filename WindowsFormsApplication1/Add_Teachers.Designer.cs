namespace WindowsFormsApplication1
{
    partial class Add_Teachers
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
            System.Windows.Forms.Label teacher_IDLabel;
            System.Windows.Forms.Label teacher_FNameLabel;
            System.Windows.Forms.Label teacher_LNameLabel;
            System.Windows.Forms.Label teacher_EmailLabel;
            System.Windows.Forms.Label teacher_PhoneNumLabel;
            System.Windows.Forms.Label teacher_AddressLabel;
            System.Windows.Forms.Label teacher_HiredateLabel;
            System.Windows.Forms.Label teacher_SalaryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Teachers));
            this.Back_Button = new System.Windows.Forms.Button();
            this.collegio_DatabaseDataSet = new WindowsFormsApplication1.Collegio_DatabaseDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TeacherTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.teacher_IDTextBox = new System.Windows.Forms.TextBox();
            this.teacher_FNameTextBox = new System.Windows.Forms.TextBox();
            this.teacher_LNameTextBox = new System.Windows.Forms.TextBox();
            this.teacher_EmailTextBox = new System.Windows.Forms.TextBox();
            this.teacher_PhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.teacher_AddressTextBox = new System.Windows.Forms.TextBox();
            this.teacher_HiredateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.teacher_SalaryTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UPDATE_TEACHER = new System.Windows.Forms.Button();
            this.ADD_TEACHER = new System.Windows.Forms.Button();
            this.DELETE_TEACHER = new System.Windows.Forms.Button();
            teacher_IDLabel = new System.Windows.Forms.Label();
            teacher_FNameLabel = new System.Windows.Forms.Label();
            teacher_LNameLabel = new System.Windows.Forms.Label();
            teacher_EmailLabel = new System.Windows.Forms.Label();
            teacher_PhoneNumLabel = new System.Windows.Forms.Label();
            teacher_AddressLabel = new System.Windows.Forms.Label();
            teacher_HiredateLabel = new System.Windows.Forms.Label();
            teacher_SalaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher_IDLabel
            // 
            teacher_IDLabel.AutoSize = true;
            teacher_IDLabel.Location = new System.Drawing.Point(29, 44);
            teacher_IDLabel.Name = "teacher_IDLabel";
            teacher_IDLabel.Size = new System.Drawing.Size(64, 13);
            teacher_IDLabel.TabIndex = 19;
            teacher_IDLabel.Text = "Teacher ID:";
            // 
            // teacher_FNameLabel
            // 
            teacher_FNameLabel.AutoSize = true;
            teacher_FNameLabel.Location = new System.Drawing.Point(29, 70);
            teacher_FNameLabel.Name = "teacher_FNameLabel";
            teacher_FNameLabel.Size = new System.Drawing.Size(87, 13);
            teacher_FNameLabel.TabIndex = 23;
            teacher_FNameLabel.Text = "Teacher FName:";
            // 
            // teacher_LNameLabel
            // 
            teacher_LNameLabel.AutoSize = true;
            teacher_LNameLabel.Location = new System.Drawing.Point(29, 96);
            teacher_LNameLabel.Name = "teacher_LNameLabel";
            teacher_LNameLabel.Size = new System.Drawing.Size(87, 13);
            teacher_LNameLabel.TabIndex = 25;
            teacher_LNameLabel.Text = "Teacher LName:";
            // 
            // teacher_EmailLabel
            // 
            teacher_EmailLabel.AutoSize = true;
            teacher_EmailLabel.Location = new System.Drawing.Point(29, 122);
            teacher_EmailLabel.Name = "teacher_EmailLabel";
            teacher_EmailLabel.Size = new System.Drawing.Size(78, 13);
            teacher_EmailLabel.TabIndex = 27;
            teacher_EmailLabel.Text = "Teacher Email:";
            // 
            // teacher_PhoneNumLabel
            // 
            teacher_PhoneNumLabel.AutoSize = true;
            teacher_PhoneNumLabel.Location = new System.Drawing.Point(29, 148);
            teacher_PhoneNumLabel.Name = "teacher_PhoneNumLabel";
            teacher_PhoneNumLabel.Size = new System.Drawing.Size(109, 13);
            teacher_PhoneNumLabel.TabIndex = 29;
            teacher_PhoneNumLabel.Text = "Teacher Phone Num:";
            // 
            // teacher_AddressLabel
            // 
            teacher_AddressLabel.AutoSize = true;
            teacher_AddressLabel.Location = new System.Drawing.Point(29, 174);
            teacher_AddressLabel.Name = "teacher_AddressLabel";
            teacher_AddressLabel.Size = new System.Drawing.Size(91, 13);
            teacher_AddressLabel.TabIndex = 31;
            teacher_AddressLabel.Text = "Teacher Address:";
            // 
            // teacher_HiredateLabel
            // 
            teacher_HiredateLabel.AutoSize = true;
            teacher_HiredateLabel.Location = new System.Drawing.Point(29, 201);
            teacher_HiredateLabel.Name = "teacher_HiredateLabel";
            teacher_HiredateLabel.Size = new System.Drawing.Size(93, 13);
            teacher_HiredateLabel.TabIndex = 33;
            teacher_HiredateLabel.Text = "Teacher Hiredate:";
            // 
            // teacher_SalaryLabel
            // 
            teacher_SalaryLabel.AutoSize = true;
            teacher_SalaryLabel.Location = new System.Drawing.Point(29, 226);
            teacher_SalaryLabel.Name = "teacher_SalaryLabel";
            teacher_SalaryLabel.Size = new System.Drawing.Size(82, 13);
            teacher_SalaryLabel.TabIndex = 35;
            teacher_SalaryLabel.Text = "Teacher Salary:";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(32, 352);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 18;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // collegio_DatabaseDataSet
            // 
            this.collegio_DatabaseDataSet.DataSetName = "Collegio_DatabaseDataSet";
            this.collegio_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.collegio_DatabaseDataSet;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.Non_Teaching_StaffTableAdapter = null;
            this.tableAdapterManager.PrincipalTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = this.teacherTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teacher_IDTextBox
            // 
            this.teacher_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Teacher_ID", true));
            this.teacher_IDTextBox.Location = new System.Drawing.Point(144, 41);
            this.teacher_IDTextBox.Name = "teacher_IDTextBox";
            this.teacher_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.teacher_IDTextBox.TabIndex = 20;
            // 
            // teacher_FNameTextBox
            // 
            this.teacher_FNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Teacher_FName", true));
            this.teacher_FNameTextBox.Location = new System.Drawing.Point(144, 67);
            this.teacher_FNameTextBox.Name = "teacher_FNameTextBox";
            this.teacher_FNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.teacher_FNameTextBox.TabIndex = 24;
            // 
            // teacher_LNameTextBox
            // 
            this.teacher_LNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Teacher_LName", true));
            this.teacher_LNameTextBox.Location = new System.Drawing.Point(144, 93);
            this.teacher_LNameTextBox.Name = "teacher_LNameTextBox";
            this.teacher_LNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.teacher_LNameTextBox.TabIndex = 26;
            // 
            // teacher_EmailTextBox
            // 
            this.teacher_EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Teacher_Email", true));
            this.teacher_EmailTextBox.Location = new System.Drawing.Point(144, 119);
            this.teacher_EmailTextBox.Name = "teacher_EmailTextBox";
            this.teacher_EmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.teacher_EmailTextBox.TabIndex = 28;
            // 
            // teacher_PhoneNumTextBox
            // 
            this.teacher_PhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Teacher_PhoneNum", true));
            this.teacher_PhoneNumTextBox.Location = new System.Drawing.Point(144, 145);
            this.teacher_PhoneNumTextBox.Name = "teacher_PhoneNumTextBox";
            this.teacher_PhoneNumTextBox.Size = new System.Drawing.Size(200, 20);
            this.teacher_PhoneNumTextBox.TabIndex = 30;
            // 
            // teacher_AddressTextBox
            // 
            this.teacher_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Teacher_Address", true));
            this.teacher_AddressTextBox.Location = new System.Drawing.Point(144, 171);
            this.teacher_AddressTextBox.Name = "teacher_AddressTextBox";
            this.teacher_AddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.teacher_AddressTextBox.TabIndex = 32;
            // 
            // teacher_HiredateDateTimePicker
            // 
            this.teacher_HiredateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.teacher_HiredateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.teacherBindingSource, "Teacher_Hiredate", true));
            this.teacher_HiredateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.teacher_HiredateDateTimePicker.Location = new System.Drawing.Point(144, 197);
            this.teacher_HiredateDateTimePicker.Name = "teacher_HiredateDateTimePicker";
            this.teacher_HiredateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.teacher_HiredateDateTimePicker.TabIndex = 34;
            // 
            // teacher_SalaryTextBox
            // 
            this.teacher_SalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teacherBindingSource, "Teacher_Salary", true));
            this.teacher_SalaryTextBox.Location = new System.Drawing.Point(144, 223);
            this.teacher_SalaryTextBox.Name = "teacher_SalaryTextBox";
            this.teacher_SalaryTextBox.Size = new System.Drawing.Size(200, 20);
            this.teacher_SalaryTextBox.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 400);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UPDATE_TEACHER
            // 
            this.UPDATE_TEACHER.Location = new System.Drawing.Point(144, 280);
            this.UPDATE_TEACHER.Name = "UPDATE_TEACHER";
            this.UPDATE_TEACHER.Size = new System.Drawing.Size(90, 42);
            this.UPDATE_TEACHER.TabIndex = 38;
            this.UPDATE_TEACHER.Text = "UPDATE";
            this.UPDATE_TEACHER.UseVisualStyleBackColor = true;
            this.UPDATE_TEACHER.Click += new System.EventHandler(this.UPDATE_TEACHER_Click);
            // 
            // ADD_TEACHER
            // 
            this.ADD_TEACHER.Location = new System.Drawing.Point(22, 280);
            this.ADD_TEACHER.Name = "ADD_TEACHER";
            this.ADD_TEACHER.Size = new System.Drawing.Size(94, 42);
            this.ADD_TEACHER.TabIndex = 39;
            this.ADD_TEACHER.Text = "ADD";
            this.ADD_TEACHER.UseVisualStyleBackColor = true;
            this.ADD_TEACHER.Click += new System.EventHandler(this.ADD_TEACHER_Click);
            // 
            // DELETE_TEACHER
            // 
            this.DELETE_TEACHER.Location = new System.Drawing.Point(258, 280);
            this.DELETE_TEACHER.Name = "DELETE_TEACHER";
            this.DELETE_TEACHER.Size = new System.Drawing.Size(86, 42);
            this.DELETE_TEACHER.TabIndex = 40;
            this.DELETE_TEACHER.Text = "DELETE";
            this.DELETE_TEACHER.UseVisualStyleBackColor = true;
            this.DELETE_TEACHER.Click += new System.EventHandler(this.DELETE_TEACHER_Click);
            // 
            // Add_Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 511);
            this.Controls.Add(this.DELETE_TEACHER);
            this.Controls.Add(this.ADD_TEACHER);
            this.Controls.Add(this.UPDATE_TEACHER);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(teacher_IDLabel);
            this.Controls.Add(this.teacher_IDTextBox);
            this.Controls.Add(teacher_FNameLabel);
            this.Controls.Add(this.teacher_FNameTextBox);
            this.Controls.Add(teacher_LNameLabel);
            this.Controls.Add(this.teacher_LNameTextBox);
            this.Controls.Add(teacher_EmailLabel);
            this.Controls.Add(this.teacher_EmailTextBox);
            this.Controls.Add(teacher_PhoneNumLabel);
            this.Controls.Add(this.teacher_PhoneNumTextBox);
            this.Controls.Add(teacher_AddressLabel);
            this.Controls.Add(this.teacher_AddressTextBox);
            this.Controls.Add(teacher_HiredateLabel);
            this.Controls.Add(this.teacher_HiredateDateTimePicker);
            this.Controls.Add(teacher_SalaryLabel);
            this.Controls.Add(this.teacher_SalaryTextBox);
            this.Controls.Add(this.Back_Button);
            this.MaximumSize = new System.Drawing.Size(1240, 550);
            this.Name = "Add_Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Teachers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private Collegio_DatabaseDataSet collegio_DatabaseDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private Collegio_DatabaseDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private Collegio_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox teacher_IDTextBox;
        private System.Windows.Forms.TextBox teacher_FNameTextBox;
        private System.Windows.Forms.TextBox teacher_LNameTextBox;
        private System.Windows.Forms.TextBox teacher_EmailTextBox;
        private System.Windows.Forms.TextBox teacher_PhoneNumTextBox;
        private System.Windows.Forms.TextBox teacher_AddressTextBox;
        private System.Windows.Forms.DateTimePicker teacher_HiredateDateTimePicker;
        private System.Windows.Forms.TextBox teacher_SalaryTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UPDATE_TEACHER;
        private System.Windows.Forms.Button ADD_TEACHER;
        private System.Windows.Forms.Button DELETE_TEACHER;
    }
}