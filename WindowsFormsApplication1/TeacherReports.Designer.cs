namespace WindowsFormsApplication1
{
    partial class TeacherReports
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
            System.Windows.Forms.Label teacher_IDLabel;
            System.Windows.Forms.Label teacher_FNameLabel;
            System.Windows.Forms.Label teacher_LNameLabel;
            System.Windows.Forms.Label teacher_HiredateLabel;
            System.Windows.Forms.Label teacher_SalaryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherReports));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teacher_IDTextBox = new System.Windows.Forms.TextBox();
            this.teacher_FNameTextBox = new System.Windows.Forms.TextBox();
            this.teacher_LNameTextBox = new System.Windows.Forms.TextBox();
            this.teacher_HiredateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_SalaryTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            teacher_IDLabel = new System.Windows.Forms.Label();
            teacher_FNameLabel = new System.Windows.Forms.Label();
            teacher_LNameLabel = new System.Windows.Forms.Label();
            teacher_HiredateLabel = new System.Windows.Forms.Label();
            teacher_SalaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(950, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // teacher_IDLabel
            // 
            teacher_IDLabel.AutoSize = true;
            teacher_IDLabel.Location = new System.Drawing.Point(21, 27);
            teacher_IDLabel.Name = "teacher_IDLabel";
            teacher_IDLabel.Size = new System.Drawing.Size(64, 13);
            teacher_IDLabel.TabIndex = 27;
            teacher_IDLabel.Text = "Teacher ID:";
            // 
            // teacher_IDTextBox
            // 
            this.teacher_IDTextBox.Location = new System.Drawing.Point(136, 24);
            this.teacher_IDTextBox.Name = "teacher_IDTextBox";
            this.teacher_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.teacher_IDTextBox.TabIndex = 28;
            // 
            // teacher_FNameLabel
            // 
            teacher_FNameLabel.AutoSize = true;
            teacher_FNameLabel.Location = new System.Drawing.Point(21, 68);
            teacher_FNameLabel.Name = "teacher_FNameLabel";
            teacher_FNameLabel.Size = new System.Drawing.Size(87, 13);
            teacher_FNameLabel.TabIndex = 29;
            teacher_FNameLabel.Text = "Teacher FName:";
            // 
            // teacher_FNameTextBox
            // 
            this.teacher_FNameTextBox.Location = new System.Drawing.Point(136, 65);
            this.teacher_FNameTextBox.Name = "teacher_FNameTextBox";
            this.teacher_FNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.teacher_FNameTextBox.TabIndex = 30;
            // 
            // teacher_LNameLabel
            // 
            teacher_LNameLabel.AutoSize = true;
            teacher_LNameLabel.Location = new System.Drawing.Point(373, 68);
            teacher_LNameLabel.Name = "teacher_LNameLabel";
            teacher_LNameLabel.Size = new System.Drawing.Size(87, 13);
            teacher_LNameLabel.TabIndex = 31;
            teacher_LNameLabel.Text = "Teacher LName:";
            // 
            // teacher_LNameTextBox
            // 
            this.teacher_LNameTextBox.Location = new System.Drawing.Point(488, 65);
            this.teacher_LNameTextBox.Name = "teacher_LNameTextBox";
            this.teacher_LNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.teacher_LNameTextBox.TabIndex = 32;
            // 
            // teacher_HiredateDateTimePicker
            // 
            this.teacher_HiredateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.teacher_HiredateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.teacher_HiredateDateTimePicker.Location = new System.Drawing.Point(209, 102);
            this.teacher_HiredateDateTimePicker.Name = "teacher_HiredateDateTimePicker";
            this.teacher_HiredateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.teacher_HiredateDateTimePicker.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(499, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(162, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(435, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(162, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(435, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "To";
            // 
            // teacher_SalaryTextBox
            // 
            this.teacher_SalaryTextBox.Location = new System.Drawing.Point(218, 150);
            this.teacher_SalaryTextBox.Name = "teacher_SalaryTextBox";
            this.teacher_SalaryTextBox.Size = new System.Drawing.Size(200, 20);
            this.teacher_SalaryTextBox.TabIndex = 41;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(499, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 42;
            // 
            // teacher_HiredateLabel
            // 
            teacher_HiredateLabel.AutoSize = true;
            teacher_HiredateLabel.Location = new System.Drawing.Point(21, 108);
            teacher_HiredateLabel.Name = "teacher_HiredateLabel";
            teacher_HiredateLabel.Size = new System.Drawing.Size(93, 13);
            teacher_HiredateLabel.TabIndex = 43;
            teacher_HiredateLabel.Text = "Teacher Hiredate:";
            // 
            // teacher_SalaryLabel
            // 
            teacher_SalaryLabel.AutoSize = true;
            teacher_SalaryLabel.Location = new System.Drawing.Point(21, 157);
            teacher_SalaryLabel.Name = "teacher_SalaryLabel";
            teacher_SalaryLabel.Size = new System.Drawing.Size(82, 13);
            teacher_SalaryLabel.TabIndex = 44;
            teacher_SalaryLabel.Text = "Teacher Salary:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(731, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(731, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 47;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(731, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 48;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(897, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 61);
            this.button5.TabIndex = 49;
            this.button5.Text = "BACK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TeacherReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 490);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(teacher_HiredateLabel);
            this.Controls.Add(teacher_SalaryLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.teacher_SalaryTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.teacher_HiredateDateTimePicker);
            this.Controls.Add(teacher_IDLabel);
            this.Controls.Add(this.teacher_IDTextBox);
            this.Controls.Add(teacher_FNameLabel);
            this.Controls.Add(this.teacher_FNameTextBox);
            this.Controls.Add(teacher_LNameLabel);
            this.Controls.Add(this.teacher_LNameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TeacherReports";
            this.Text = "TeacherReports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox teacher_IDTextBox;
        private System.Windows.Forms.TextBox teacher_FNameTextBox;
        private System.Windows.Forms.TextBox teacher_LNameTextBox;
        private System.Windows.Forms.DateTimePicker teacher_HiredateDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacher_SalaryTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}