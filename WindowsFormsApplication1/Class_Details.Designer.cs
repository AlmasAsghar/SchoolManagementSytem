namespace WindowsFormsApplication1
{
    partial class Class_Details
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
            System.Windows.Forms.Label class_IDLabel;
            System.Windows.Forms.Label class_MaxStrengthLabel;
            System.Windows.Forms.Label class_RoomNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class_Details));
            this.collegio_DatabaseDataSet = new WindowsFormsApplication1.Collegio_DatabaseDataSet();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.ClassTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.class_IDTextBox = new System.Windows.Forms.TextBox();
            this.class_MaxStrengthTextBox = new System.Windows.Forms.TextBox();
            this.class_RoomNoTextBox = new System.Windows.Forms.TextBox();
            this.Add_Class_Button = new System.Windows.Forms.Button();
            this.Update_Class_Button = new System.Windows.Forms.Button();
            this.Class_Back_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            class_IDLabel = new System.Windows.Forms.Label();
            class_MaxStrengthLabel = new System.Windows.Forms.Label();
            class_RoomNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // class_IDLabel
            // 
            class_IDLabel.AutoSize = true;
            class_IDLabel.Location = new System.Drawing.Point(26, 87);
            class_IDLabel.Name = "class_IDLabel";
            class_IDLabel.Size = new System.Drawing.Size(49, 13);
            class_IDLabel.TabIndex = 2;
            class_IDLabel.Text = "Class ID:";
            // 
            // class_MaxStrengthLabel
            // 
            class_MaxStrengthLabel.AutoSize = true;
            class_MaxStrengthLabel.Location = new System.Drawing.Point(26, 113);
            class_MaxStrengthLabel.Name = "class_MaxStrengthLabel";
            class_MaxStrengthLabel.Size = new System.Drawing.Size(101, 13);
            class_MaxStrengthLabel.TabIndex = 4;
            class_MaxStrengthLabel.Text = "Class Max Strength:";
            // 
            // class_RoomNoLabel
            // 
            class_RoomNoLabel.AutoSize = true;
            class_RoomNoLabel.Location = new System.Drawing.Point(26, 139);
            class_RoomNoLabel.Name = "class_RoomNoLabel";
            class_RoomNoLabel.Size = new System.Drawing.Size(83, 13);
            class_RoomNoLabel.TabIndex = 6;
            class_RoomNoLabel.Text = "Class Room No:";
            // 
            // collegio_DatabaseDataSet
            // 
            this.collegio_DatabaseDataSet.DataSetName = "Collegio_DatabaseDataSet";
            this.collegio_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = this.classTableAdapter;
            this.tableAdapterManager.Non_Teaching_StaffTableAdapter = null;
            this.tableAdapterManager.PrincipalTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // class_IDTextBox
            // 
            this.class_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "Class_ID", true));
            this.class_IDTextBox.Location = new System.Drawing.Point(133, 84);
            this.class_IDTextBox.Name = "class_IDTextBox";
            this.class_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.class_IDTextBox.TabIndex = 3;
            // 
            // class_MaxStrengthTextBox
            // 
            this.class_MaxStrengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "Class_MaxStrength", true));
            this.class_MaxStrengthTextBox.Location = new System.Drawing.Point(133, 110);
            this.class_MaxStrengthTextBox.Name = "class_MaxStrengthTextBox";
            this.class_MaxStrengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.class_MaxStrengthTextBox.TabIndex = 5;
            // 
            // class_RoomNoTextBox
            // 
            this.class_RoomNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "Class_RoomNo", true));
            this.class_RoomNoTextBox.Location = new System.Drawing.Point(133, 136);
            this.class_RoomNoTextBox.Name = "class_RoomNoTextBox";
            this.class_RoomNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.class_RoomNoTextBox.TabIndex = 7;
            // 
            // Add_Class_Button
            // 
            this.Add_Class_Button.Location = new System.Drawing.Point(40, 188);
            this.Add_Class_Button.Name = "Add_Class_Button";
            this.Add_Class_Button.Size = new System.Drawing.Size(87, 35);
            this.Add_Class_Button.TabIndex = 8;
            this.Add_Class_Button.Text = "ADD";
            this.Add_Class_Button.UseVisualStyleBackColor = true;
            this.Add_Class_Button.Click += new System.EventHandler(this.Add_Class_Button_Click);
            // 
            // Update_Class_Button
            // 
            this.Update_Class_Button.Location = new System.Drawing.Point(133, 188);
            this.Update_Class_Button.Name = "Update_Class_Button";
            this.Update_Class_Button.Size = new System.Drawing.Size(87, 35);
            this.Update_Class_Button.TabIndex = 9;
            this.Update_Class_Button.Text = "UPDATE";
            this.Update_Class_Button.UseVisualStyleBackColor = true;
            this.Update_Class_Button.Click += new System.EventHandler(this.Update_Class_Button_Click);
            // 
            // Class_Back_Button
            // 
            this.Class_Back_Button.Location = new System.Drawing.Point(98, 239);
            this.Class_Back_Button.Name = "Class_Back_Button";
            this.Class_Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Class_Back_Button.TabIndex = 10;
            this.Class_Back_Button.Text = "BACK";
            this.Class_Back_Button.UseVisualStyleBackColor = true;
            this.Class_Back_Button.Click += new System.EventHandler(this.Class_Back_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(319, 163);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Class_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 285);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Class_Back_Button);
            this.Controls.Add(this.Update_Class_Button);
            this.Controls.Add(this.Add_Class_Button);
            this.Controls.Add(class_IDLabel);
            this.Controls.Add(this.class_IDTextBox);
            this.Controls.Add(class_MaxStrengthLabel);
            this.Controls.Add(this.class_MaxStrengthTextBox);
            this.Controls.Add(class_RoomNoLabel);
            this.Controls.Add(this.class_RoomNoTextBox);
            this.MaximumSize = new System.Drawing.Size(716, 324);
            this.Name = "Class_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class_Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Class_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Collegio_DatabaseDataSet collegio_DatabaseDataSet;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Collegio_DatabaseDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private Collegio_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox class_IDTextBox;
        private System.Windows.Forms.TextBox class_MaxStrengthTextBox;
        private System.Windows.Forms.TextBox class_RoomNoTextBox;
        private System.Windows.Forms.Button Add_Class_Button;
        private System.Windows.Forms.Button Update_Class_Button;
        private System.Windows.Forms.Button Class_Back_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}