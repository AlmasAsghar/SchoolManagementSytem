namespace WindowsFormsApplication1
{
    partial class Principal_Details
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
            System.Windows.Forms.Label principal_IDLabel;
            System.Windows.Forms.Label principal_FNameLabel;
            System.Windows.Forms.Label principal_LNameLabel;
            System.Windows.Forms.Label principal_PhoneNumLabel;
            System.Windows.Forms.Label principal_EmailLabel;
            System.Windows.Forms.Label principal_AddressLabel;
            System.Windows.Forms.Label principal_HiredateLabel;
            System.Windows.Forms.Label principal_SalaryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_Details));
            this.Back_Button = new System.Windows.Forms.Button();
            this.collegio_DatabaseDataSet = new WindowsFormsApplication1.Collegio_DatabaseDataSet();
            this.principalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.principalTableAdapter = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.PrincipalTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.principal_IDTextBox = new System.Windows.Forms.TextBox();
            this.principal_FNameTextBox = new System.Windows.Forms.TextBox();
            this.principal_LNameTextBox = new System.Windows.Forms.TextBox();
            this.principal_PhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.principal_EmailTextBox = new System.Windows.Forms.TextBox();
            this.principal_AddressTextBox = new System.Windows.Forms.TextBox();
            this.principal_HiredateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.principal_SalaryTextBox = new System.Windows.Forms.TextBox();
            this.Add_Class_Button = new System.Windows.Forms.Button();
            this.principalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.principal_update_button = new System.Windows.Forms.Button();
            this.Principal_delete_button = new System.Windows.Forms.Button();
            principal_IDLabel = new System.Windows.Forms.Label();
            principal_FNameLabel = new System.Windows.Forms.Label();
            principal_LNameLabel = new System.Windows.Forms.Label();
            principal_PhoneNumLabel = new System.Windows.Forms.Label();
            principal_EmailLabel = new System.Windows.Forms.Label();
            principal_AddressLabel = new System.Windows.Forms.Label();
            principal_HiredateLabel = new System.Windows.Forms.Label();
            principal_SalaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // principal_IDLabel
            // 
            principal_IDLabel.AutoSize = true;
            principal_IDLabel.Location = new System.Drawing.Point(25, 50);
            principal_IDLabel.Name = "principal_IDLabel";
            principal_IDLabel.Size = new System.Drawing.Size(64, 13);
            principal_IDLabel.TabIndex = 17;
            principal_IDLabel.Text = "Principal ID:";
            // 
            // principal_FNameLabel
            // 
            principal_FNameLabel.AutoSize = true;
            principal_FNameLabel.Location = new System.Drawing.Point(25, 76);
            principal_FNameLabel.Name = "principal_FNameLabel";
            principal_FNameLabel.Size = new System.Drawing.Size(87, 13);
            principal_FNameLabel.TabIndex = 21;
            principal_FNameLabel.Text = "Principal FName:";
            // 
            // principal_LNameLabel
            // 
            principal_LNameLabel.AutoSize = true;
            principal_LNameLabel.Location = new System.Drawing.Point(25, 102);
            principal_LNameLabel.Name = "principal_LNameLabel";
            principal_LNameLabel.Size = new System.Drawing.Size(87, 13);
            principal_LNameLabel.TabIndex = 23;
            principal_LNameLabel.Text = "Principal LName:";
            // 
            // principal_PhoneNumLabel
            // 
            principal_PhoneNumLabel.AutoSize = true;
            principal_PhoneNumLabel.Location = new System.Drawing.Point(25, 128);
            principal_PhoneNumLabel.Name = "principal_PhoneNumLabel";
            principal_PhoneNumLabel.Size = new System.Drawing.Size(109, 13);
            principal_PhoneNumLabel.TabIndex = 25;
            principal_PhoneNumLabel.Text = "Principal Phone Num:";
            // 
            // principal_EmailLabel
            // 
            principal_EmailLabel.AutoSize = true;
            principal_EmailLabel.Location = new System.Drawing.Point(25, 154);
            principal_EmailLabel.Name = "principal_EmailLabel";
            principal_EmailLabel.Size = new System.Drawing.Size(78, 13);
            principal_EmailLabel.TabIndex = 27;
            principal_EmailLabel.Text = "Principal Email:";
            // 
            // principal_AddressLabel
            // 
            principal_AddressLabel.AutoSize = true;
            principal_AddressLabel.Location = new System.Drawing.Point(25, 180);
            principal_AddressLabel.Name = "principal_AddressLabel";
            principal_AddressLabel.Size = new System.Drawing.Size(91, 13);
            principal_AddressLabel.TabIndex = 29;
            principal_AddressLabel.Text = "Principal Address:";
            // 
            // principal_HiredateLabel
            // 
            principal_HiredateLabel.AutoSize = true;
            principal_HiredateLabel.Location = new System.Drawing.Point(25, 207);
            principal_HiredateLabel.Name = "principal_HiredateLabel";
            principal_HiredateLabel.Size = new System.Drawing.Size(93, 13);
            principal_HiredateLabel.TabIndex = 31;
            principal_HiredateLabel.Text = "Principal Hiredate:";
            // 
            // principal_SalaryLabel
            // 
            principal_SalaryLabel.AutoSize = true;
            principal_SalaryLabel.Location = new System.Drawing.Point(25, 232);
            principal_SalaryLabel.Name = "principal_SalaryLabel";
            principal_SalaryLabel.Size = new System.Drawing.Size(82, 13);
            principal_SalaryLabel.TabIndex = 33;
            principal_SalaryLabel.Text = "Principal Salary:";
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(140, 345);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 16;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // collegio_DatabaseDataSet
            // 
            this.collegio_DatabaseDataSet.DataSetName = "Collegio_DatabaseDataSet";
            this.collegio_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // principalBindingSource
            // 
            this.principalBindingSource.DataMember = "Principal";
            this.principalBindingSource.DataSource = this.collegio_DatabaseDataSet;
            // 
            // principalTableAdapter
            // 
            this.principalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.Non_Teaching_StaffTableAdapter = null;
            this.tableAdapterManager.PrincipalTableAdapter = this.principalTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // principal_IDTextBox
            // 
            this.principal_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.principalBindingSource, "Principal_ID", true));
            this.principal_IDTextBox.Location = new System.Drawing.Point(140, 47);
            this.principal_IDTextBox.Name = "principal_IDTextBox";
            this.principal_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.principal_IDTextBox.TabIndex = 18;
            // 
            // principal_FNameTextBox
            // 
            this.principal_FNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.principalBindingSource, "Principal_FName", true));
            this.principal_FNameTextBox.Location = new System.Drawing.Point(140, 73);
            this.principal_FNameTextBox.Name = "principal_FNameTextBox";
            this.principal_FNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.principal_FNameTextBox.TabIndex = 22;
            // 
            // principal_LNameTextBox
            // 
            this.principal_LNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.principalBindingSource, "Principal_LName", true));
            this.principal_LNameTextBox.Location = new System.Drawing.Point(140, 99);
            this.principal_LNameTextBox.Name = "principal_LNameTextBox";
            this.principal_LNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.principal_LNameTextBox.TabIndex = 24;
            // 
            // principal_PhoneNumTextBox
            // 
            this.principal_PhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.principalBindingSource, "Principal_PhoneNum", true));
            this.principal_PhoneNumTextBox.Location = new System.Drawing.Point(140, 125);
            this.principal_PhoneNumTextBox.Name = "principal_PhoneNumTextBox";
            this.principal_PhoneNumTextBox.Size = new System.Drawing.Size(200, 20);
            this.principal_PhoneNumTextBox.TabIndex = 26;
            // 
            // principal_EmailTextBox
            // 
            this.principal_EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.principalBindingSource, "Principal_Email", true));
            this.principal_EmailTextBox.Location = new System.Drawing.Point(140, 151);
            this.principal_EmailTextBox.Name = "principal_EmailTextBox";
            this.principal_EmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.principal_EmailTextBox.TabIndex = 28;
            // 
            // principal_AddressTextBox
            // 
            this.principal_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.principalBindingSource, "Principal_Address", true));
            this.principal_AddressTextBox.Location = new System.Drawing.Point(140, 177);
            this.principal_AddressTextBox.Name = "principal_AddressTextBox";
            this.principal_AddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.principal_AddressTextBox.TabIndex = 30;
            // 
            // principal_HiredateDateTimePicker
            // 
            this.principal_HiredateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.principal_HiredateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.principalBindingSource, "Principal_Hiredate", true));
            this.principal_HiredateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.principal_HiredateDateTimePicker.Location = new System.Drawing.Point(140, 203);
            this.principal_HiredateDateTimePicker.Name = "principal_HiredateDateTimePicker";
            this.principal_HiredateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.principal_HiredateDateTimePicker.TabIndex = 32;
            // 
            // principal_SalaryTextBox
            // 
            this.principal_SalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.principalBindingSource, "Principal_Salary", true));
            this.principal_SalaryTextBox.Location = new System.Drawing.Point(140, 229);
            this.principal_SalaryTextBox.Name = "principal_SalaryTextBox";
            this.principal_SalaryTextBox.Size = new System.Drawing.Size(200, 20);
            this.principal_SalaryTextBox.TabIndex = 34;
            // 
            // Add_Class_Button
            // 
            this.Add_Class_Button.Location = new System.Drawing.Point(28, 279);
            this.Add_Class_Button.Name = "Add_Class_Button";
            this.Add_Class_Button.Size = new System.Drawing.Size(87, 35);
            this.Add_Class_Button.TabIndex = 35;
            this.Add_Class_Button.Text = "ADD";
            this.Add_Class_Button.UseVisualStyleBackColor = true;
            this.Add_Class_Button.Click += new System.EventHandler(this.Add_Class_Button_Click);
            // 
            // principalBindingSource1
            // 
            this.principalBindingSource1.DataMember = "Principal";
            this.principalBindingSource1.DataSource = this.collegio_DatabaseDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 400);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // principal_update_button
            // 
            this.principal_update_button.Location = new System.Drawing.Point(127, 279);
            this.principal_update_button.Name = "principal_update_button";
            this.principal_update_button.Size = new System.Drawing.Size(94, 35);
            this.principal_update_button.TabIndex = 37;
            this.principal_update_button.Text = "UPDATE";
            this.principal_update_button.UseVisualStyleBackColor = true;
            this.principal_update_button.Click += new System.EventHandler(this.principal_update_button_Click);
            // 
            // Principal_delete_button
            // 
            this.Principal_delete_button.Location = new System.Drawing.Point(236, 279);
            this.Principal_delete_button.Name = "Principal_delete_button";
            this.Principal_delete_button.Size = new System.Drawing.Size(91, 35);
            this.Principal_delete_button.TabIndex = 38;
            this.Principal_delete_button.Text = "DELETE";
            this.Principal_delete_button.UseVisualStyleBackColor = true;
            this.Principal_delete_button.Click += new System.EventHandler(this.Principal_delete_button_Click);
            // 
            // Principal_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 511);
            this.Controls.Add(this.Principal_delete_button);
            this.Controls.Add(this.principal_update_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add_Class_Button);
            this.Controls.Add(principal_IDLabel);
            this.Controls.Add(this.principal_IDTextBox);
            this.Controls.Add(principal_FNameLabel);
            this.Controls.Add(this.principal_FNameTextBox);
            this.Controls.Add(principal_LNameLabel);
            this.Controls.Add(this.principal_LNameTextBox);
            this.Controls.Add(principal_PhoneNumLabel);
            this.Controls.Add(this.principal_PhoneNumTextBox);
            this.Controls.Add(principal_EmailLabel);
            this.Controls.Add(this.principal_EmailTextBox);
            this.Controls.Add(principal_AddressLabel);
            this.Controls.Add(this.principal_AddressTextBox);
            this.Controls.Add(principal_HiredateLabel);
            this.Controls.Add(this.principal_HiredateDateTimePicker);
            this.Controls.Add(principal_SalaryLabel);
            this.Controls.Add(this.principal_SalaryTextBox);
            this.Controls.Add(this.Back_Button);
            this.MaximumSize = new System.Drawing.Size(1240, 550);
            this.Name = "Principal_Details";
            this.Text = "Add_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.principalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back_Button;
        private Collegio_DatabaseDataSet collegio_DatabaseDataSet;
        private System.Windows.Forms.BindingSource principalBindingSource;
        private Collegio_DatabaseDataSetTableAdapters.PrincipalTableAdapter principalTableAdapter;
        private Collegio_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox principal_IDTextBox;
        private System.Windows.Forms.TextBox principal_FNameTextBox;
        private System.Windows.Forms.TextBox principal_LNameTextBox;
        private System.Windows.Forms.TextBox principal_PhoneNumTextBox;
        private System.Windows.Forms.TextBox principal_EmailTextBox;
        private System.Windows.Forms.TextBox principal_AddressTextBox;
        private System.Windows.Forms.DateTimePicker principal_HiredateDateTimePicker;
        private System.Windows.Forms.TextBox principal_SalaryTextBox;
        private System.Windows.Forms.Button Add_Class_Button;
        private System.Windows.Forms.BindingSource principalBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button principal_update_button;
        private System.Windows.Forms.Button Principal_delete_button;
    }
}