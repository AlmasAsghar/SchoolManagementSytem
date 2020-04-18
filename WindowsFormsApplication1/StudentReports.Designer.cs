namespace WindowsFormsApplication1
{
    partial class StudentReports
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
            System.Windows.Forms.Label teacher_HiredateLabel;
            System.Windows.Forms.Label teacher_SalaryLabel;
            System.Windows.Forms.Label teacher_IDLabel;
            System.Windows.Forms.Label teacher_FNameLabel;
            System.Windows.Forms.Label teacher_LNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentReports));
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateOfAdmission_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.student_IDTextBox = new System.Windows.Forms.TextBox();
            this.student_FNameTextBox = new System.Windows.Forms.TextBox();
            this.student_LNameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.choose_classID_comboBox = new System.Windows.Forms.ComboBox();
            teacher_HiredateLabel = new System.Windows.Forms.Label();
            teacher_SalaryLabel = new System.Windows.Forms.Label();
            teacher_IDLabel = new System.Windows.Forms.Label();
            teacher_FNameLabel = new System.Windows.Forms.Label();
            teacher_LNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(864, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 61);
            this.button5.TabIndex = 71;
            this.button5.Text = "BACK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(731, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 69;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(731, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 68;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 67;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // teacher_HiredateLabel
            // 
            teacher_HiredateLabel.AutoSize = true;
            teacher_HiredateLabel.Location = new System.Drawing.Point(21, 107);
            teacher_HiredateLabel.Name = "teacher_HiredateLabel";
            teacher_HiredateLabel.Size = new System.Drawing.Size(97, 13);
            teacher_HiredateLabel.TabIndex = 65;
            teacher_HiredateLabel.Text = "Date Of Admission:";
            // 
            // teacher_SalaryLabel
            // 
            teacher_SalaryLabel.AutoSize = true;
            teacher_SalaryLabel.Location = new System.Drawing.Point(21, 156);
            teacher_SalaryLabel.Name = "teacher_SalaryLabel";
            teacher_SalaryLabel.Size = new System.Drawing.Size(38, 13);
            teacher_SalaryLabel.TabIndex = 66;
            teacher_SalaryLabel.Text = "Class :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(435, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(162, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "From";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(499, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // dateOfAdmission_DateTimePicker
            // 
            this.dateOfAdmission_DateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateOfAdmission_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfAdmission_DateTimePicker.Location = new System.Drawing.Point(209, 101);
            this.dateOfAdmission_DateTimePicker.Name = "dateOfAdmission_DateTimePicker";
            this.dateOfAdmission_DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfAdmission_DateTimePicker.TabIndex = 57;
            // 
            // teacher_IDLabel
            // 
            teacher_IDLabel.AutoSize = true;
            teacher_IDLabel.Location = new System.Drawing.Point(21, 26);
            teacher_IDLabel.Name = "teacher_IDLabel";
            teacher_IDLabel.Size = new System.Drawing.Size(61, 13);
            teacher_IDLabel.TabIndex = 51;
            teacher_IDLabel.Text = "Student ID:";
            // 
            // student_IDTextBox
            // 
            this.student_IDTextBox.Location = new System.Drawing.Point(136, 23);
            this.student_IDTextBox.Name = "student_IDTextBox";
            this.student_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_IDTextBox.TabIndex = 52;
            // 
            // teacher_FNameLabel
            // 
            teacher_FNameLabel.AutoSize = true;
            teacher_FNameLabel.Location = new System.Drawing.Point(21, 67);
            teacher_FNameLabel.Name = "teacher_FNameLabel";
            teacher_FNameLabel.Size = new System.Drawing.Size(84, 13);
            teacher_FNameLabel.TabIndex = 53;
            teacher_FNameLabel.Text = "Student FName:";
            // 
            // student_FNameTextBox
            // 
            this.student_FNameTextBox.Location = new System.Drawing.Point(136, 64);
            this.student_FNameTextBox.Name = "student_FNameTextBox";
            this.student_FNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_FNameTextBox.TabIndex = 54;
            // 
            // teacher_LNameLabel
            // 
            teacher_LNameLabel.AutoSize = true;
            teacher_LNameLabel.Location = new System.Drawing.Point(373, 67);
            teacher_LNameLabel.Name = "teacher_LNameLabel";
            teacher_LNameLabel.Size = new System.Drawing.Size(84, 13);
            teacher_LNameLabel.TabIndex = 55;
            teacher_LNameLabel.Text = "Student LName:";
            // 
            // student_LNameTextBox
            // 
            this.student_LNameTextBox.Location = new System.Drawing.Point(488, 64);
            this.student_LNameTextBox.Name = "student_LNameTextBox";
            this.student_LNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.student_LNameTextBox.TabIndex = 56;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(908, 264);
            this.dataGridView1.TabIndex = 50;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 70;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // choose_classID_comboBox
            // 
            this.choose_classID_comboBox.FormattingEnabled = true;
            this.choose_classID_comboBox.Location = new System.Drawing.Point(136, 156);
            this.choose_classID_comboBox.Name = "choose_classID_comboBox";
            this.choose_classID_comboBox.Size = new System.Drawing.Size(216, 21);
            this.choose_classID_comboBox.TabIndex = 72;
            // 
            // StudentReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 506);
            this.Controls.Add(this.choose_classID_comboBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(teacher_HiredateLabel);
            this.Controls.Add(teacher_SalaryLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateOfAdmission_DateTimePicker);
            this.Controls.Add(teacher_IDLabel);
            this.Controls.Add(this.student_IDTextBox);
            this.Controls.Add(teacher_FNameLabel);
            this.Controls.Add(this.student_FNameTextBox);
            this.Controls.Add(teacher_LNameLabel);
            this.Controls.Add(this.student_LNameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentReports";
            this.Text = "StudentReports";
            this.Load += new System.EventHandler(this.StudentReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateOfAdmission_DateTimePicker;
        private System.Windows.Forms.TextBox student_IDTextBox;
        private System.Windows.Forms.TextBox student_FNameTextBox;
        private System.Windows.Forms.TextBox student_LNameTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox choose_classID_comboBox;
    }
}