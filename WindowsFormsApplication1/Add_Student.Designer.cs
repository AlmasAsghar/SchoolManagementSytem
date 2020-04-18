namespace WindowsFormsApplication1
{
    partial class Add_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student));
            System.Windows.Forms.Label student_IDLabel;
            System.Windows.Forms.Label student_FNameLabel;
            System.Windows.Forms.Label student_LNameLabel;
            System.Windows.Forms.Label student_ClassLabel;
            System.Windows.Forms.Label student_EmailLabel;
            System.Windows.Forms.Label student_PhoneNumLabel;
            System.Windows.Forms.Label student_AddressLabel;
            System.Windows.Forms.Label class_IDLabel;
            this.collegio_DatabaseDataSet = new WindowsFormsApplication1.Collegio_DatabaseDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.student_IDTextBox = new System.Windows.Forms.TextBox();
            this.student_FNameTextBox = new System.Windows.Forms.TextBox();
            this.student_LNameTextBox = new System.Windows.Forms.TextBox();
            this.student_ClassTextBox = new System.Windows.Forms.TextBox();
            this.student_EmailTextBox = new System.Windows.Forms.TextBox();
            this.student_PhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.student_AddressTextBox = new System.Windows.Forms.TextBox();
            this.class_IDTextBox = new System.Windows.Forms.TextBox();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            student_IDLabel = new System.Windows.Forms.Label();
            student_FNameLabel = new System.Windows.Forms.Label();
            student_LNameLabel = new System.Windows.Forms.Label();
            student_ClassLabel = new System.Windows.Forms.Label();
            student_EmailLabel = new System.Windows.Forms.Label();
            student_PhoneNumLabel = new System.Windows.Forms.Label();
            student_AddressLabel = new System.Windows.Forms.Label();
            class_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.Non_Teaching_StaffTableAdapter = null;
            this.tableAdapterManager.PrincipalTableAdapter = null;
            this.tableAdapterManager.SchoolTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(853, 25);
            this.studentBindingNavigator.TabIndex = 0;
            this.studentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.studentBindingNavigatorSaveItem.Text = "Save Data";
            this.studentBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentBindingNavigatorSaveItem_Click);
            // 
            // student_IDLabel
            // 
            student_IDLabel.AutoSize = true;
            student_IDLabel.Location = new System.Drawing.Point(48, 60);
            student_IDLabel.Name = "student_IDLabel";
            student_IDLabel.Size = new System.Drawing.Size(61, 13);
            student_IDLabel.TabIndex = 1;
            student_IDLabel.Text = "Student ID:";
            // 
            // student_IDTextBox
            // 
            this.student_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_ID", true));
            this.student_IDTextBox.Location = new System.Drawing.Point(160, 57);
            this.student_IDTextBox.Name = "student_IDTextBox";
            this.student_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.student_IDTextBox.TabIndex = 2;
            // 
            // student_FNameLabel
            // 
            student_FNameLabel.AutoSize = true;
            student_FNameLabel.Location = new System.Drawing.Point(48, 86);
            student_FNameLabel.Name = "student_FNameLabel";
            student_FNameLabel.Size = new System.Drawing.Size(84, 13);
            student_FNameLabel.TabIndex = 3;
            student_FNameLabel.Text = "Student FName:";
            // 
            // student_FNameTextBox
            // 
            this.student_FNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_FName", true));
            this.student_FNameTextBox.Location = new System.Drawing.Point(160, 83);
            this.student_FNameTextBox.Name = "student_FNameTextBox";
            this.student_FNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.student_FNameTextBox.TabIndex = 4;
            // 
            // student_LNameLabel
            // 
            student_LNameLabel.AutoSize = true;
            student_LNameLabel.Location = new System.Drawing.Point(48, 112);
            student_LNameLabel.Name = "student_LNameLabel";
            student_LNameLabel.Size = new System.Drawing.Size(84, 13);
            student_LNameLabel.TabIndex = 5;
            student_LNameLabel.Text = "Student LName:";
            // 
            // student_LNameTextBox
            // 
            this.student_LNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_LName", true));
            this.student_LNameTextBox.Location = new System.Drawing.Point(160, 109);
            this.student_LNameTextBox.Name = "student_LNameTextBox";
            this.student_LNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.student_LNameTextBox.TabIndex = 6;
            // 
            // student_ClassLabel
            // 
            student_ClassLabel.AutoSize = true;
            student_ClassLabel.Location = new System.Drawing.Point(48, 138);
            student_ClassLabel.Name = "student_ClassLabel";
            student_ClassLabel.Size = new System.Drawing.Size(75, 13);
            student_ClassLabel.TabIndex = 7;
            student_ClassLabel.Text = "Student Class:";
            // 
            // student_ClassTextBox
            // 
            this.student_ClassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_Class", true));
            this.student_ClassTextBox.Location = new System.Drawing.Point(160, 135);
            this.student_ClassTextBox.Name = "student_ClassTextBox";
            this.student_ClassTextBox.Size = new System.Drawing.Size(100, 20);
            this.student_ClassTextBox.TabIndex = 8;
            // 
            // student_EmailLabel
            // 
            student_EmailLabel.AutoSize = true;
            student_EmailLabel.Location = new System.Drawing.Point(48, 164);
            student_EmailLabel.Name = "student_EmailLabel";
            student_EmailLabel.Size = new System.Drawing.Size(75, 13);
            student_EmailLabel.TabIndex = 9;
            student_EmailLabel.Text = "Student Email:";
            // 
            // student_EmailTextBox
            // 
            this.student_EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_Email", true));
            this.student_EmailTextBox.Location = new System.Drawing.Point(160, 161);
            this.student_EmailTextBox.Name = "student_EmailTextBox";
            this.student_EmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.student_EmailTextBox.TabIndex = 10;
            // 
            // student_PhoneNumLabel
            // 
            student_PhoneNumLabel.AutoSize = true;
            student_PhoneNumLabel.Location = new System.Drawing.Point(48, 190);
            student_PhoneNumLabel.Name = "student_PhoneNumLabel";
            student_PhoneNumLabel.Size = new System.Drawing.Size(106, 13);
            student_PhoneNumLabel.TabIndex = 11;
            student_PhoneNumLabel.Text = "Student Phone Num:";
            // 
            // student_PhoneNumTextBox
            // 
            this.student_PhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_PhoneNum", true));
            this.student_PhoneNumTextBox.Location = new System.Drawing.Point(160, 187);
            this.student_PhoneNumTextBox.Name = "student_PhoneNumTextBox";
            this.student_PhoneNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.student_PhoneNumTextBox.TabIndex = 12;
            // 
            // student_AddressLabel
            // 
            student_AddressLabel.AutoSize = true;
            student_AddressLabel.Location = new System.Drawing.Point(48, 216);
            student_AddressLabel.Name = "student_AddressLabel";
            student_AddressLabel.Size = new System.Drawing.Size(88, 13);
            student_AddressLabel.TabIndex = 13;
            student_AddressLabel.Text = "Student Address:";
            // 
            // student_AddressTextBox
            // 
            this.student_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Student_Address", true));
            this.student_AddressTextBox.Location = new System.Drawing.Point(160, 213);
            this.student_AddressTextBox.Name = "student_AddressTextBox";
            this.student_AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.student_AddressTextBox.TabIndex = 14;
            // 
            // class_IDLabel
            // 
            class_IDLabel.AutoSize = true;
            class_IDLabel.Location = new System.Drawing.Point(48, 242);
            class_IDLabel.Name = "class_IDLabel";
            class_IDLabel.Size = new System.Drawing.Size(49, 13);
            class_IDLabel.TabIndex = 15;
            class_IDLabel.Text = "Class ID:";
            // 
            // class_IDTextBox
            // 
            this.class_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Class_ID", true));
            this.class_IDTextBox.Location = new System.Drawing.Point(160, 239);
            this.class_IDTextBox.Name = "class_IDTextBox";
            this.class_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.class_IDTextBox.TabIndex = 16;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(302, 57);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.Size = new System.Drawing.Size(551, 348);
            this.studentDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Student_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Student_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Student_FName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Student_FName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Student_LName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Student_LName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Student_Class";
            this.dataGridViewTextBoxColumn4.HeaderText = "Student_Class";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Student_Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Student_Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Student_PhoneNum";
            this.dataGridViewTextBoxColumn6.HeaderText = "Student_PhoneNum";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Student_Address";
            this.dataGridViewTextBoxColumn7.HeaderText = "Student_Address";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Class_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Class_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 428);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(student_IDLabel);
            this.Controls.Add(this.student_IDTextBox);
            this.Controls.Add(student_FNameLabel);
            this.Controls.Add(this.student_FNameTextBox);
            this.Controls.Add(student_LNameLabel);
            this.Controls.Add(this.student_LNameTextBox);
            this.Controls.Add(student_ClassLabel);
            this.Controls.Add(this.student_ClassTextBox);
            this.Controls.Add(student_EmailLabel);
            this.Controls.Add(this.student_EmailTextBox);
            this.Controls.Add(student_PhoneNumLabel);
            this.Controls.Add(this.student_PhoneNumTextBox);
            this.Controls.Add(student_AddressLabel);
            this.Controls.Add(this.student_AddressTextBox);
            this.Controls.Add(class_IDLabel);
            this.Controls.Add(this.class_IDTextBox);
            this.Controls.Add(this.studentBindingNavigator);
            this.Name = "Add_Student";
            this.Text = "Add_Student";
            this.Load += new System.EventHandler(this.Add_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Collegio_DatabaseDataSet collegio_DatabaseDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Collegio_DatabaseDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private Collegio_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox student_IDTextBox;
        private System.Windows.Forms.TextBox student_FNameTextBox;
        private System.Windows.Forms.TextBox student_LNameTextBox;
        private System.Windows.Forms.TextBox student_ClassTextBox;
        private System.Windows.Forms.TextBox student_EmailTextBox;
        private System.Windows.Forms.TextBox student_PhoneNumTextBox;
        private System.Windows.Forms.TextBox student_AddressTextBox;
        private System.Windows.Forms.TextBox class_IDTextBox;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}