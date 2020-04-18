namespace WindowsFormsApplication1
{
    partial class Add_Class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Class));
            System.Windows.Forms.Label class_IDLabel;
            System.Windows.Forms.Label class_NameLabel;
            System.Windows.Forms.Label school_IDLabel;
            this.collegio_DatabaseDataSet = new WindowsFormsApplication1.Collegio_DatabaseDataSet();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.ClassTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.classBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.classBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.class_IDTextBox = new System.Windows.Forms.TextBox();
            this.class_NameTextBox = new System.Windows.Forms.TextBox();
            this.school_IDTextBox = new System.Windows.Forms.TextBox();
            this.classDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            class_IDLabel = new System.Windows.Forms.Label();
            class_NameLabel = new System.Windows.Forms.Label();
            school_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingNavigator)).BeginInit();
            this.classBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = this.classTableAdapter;
            this.tableAdapterManager.Non_Teaching_StaffTableAdapter = null;
            this.tableAdapterManager.PrincipalTableAdapter = null;
            this.tableAdapterManager.SchoolTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.Collegio_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // classBindingNavigator
            // 
            this.classBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.classBindingNavigator.BindingSource = this.classBindingSource;
            this.classBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.classBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.classBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.classBindingNavigatorSaveItem});
            this.classBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.classBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.classBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.classBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.classBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.classBindingNavigator.Name = "classBindingNavigator";
            this.classBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.classBindingNavigator.Size = new System.Drawing.Size(724, 25);
            this.classBindingNavigator.TabIndex = 0;
            this.classBindingNavigator.Text = "bindingNavigator1";
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
            // classBindingNavigatorSaveItem
            // 
            this.classBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.classBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("classBindingNavigatorSaveItem.Image")));
            this.classBindingNavigatorSaveItem.Name = "classBindingNavigatorSaveItem";
            this.classBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.classBindingNavigatorSaveItem.Text = "Save Data";
            this.classBindingNavigatorSaveItem.Click += new System.EventHandler(this.classBindingNavigatorSaveItem_Click_1);
            // 
            // class_IDLabel
            // 
            class_IDLabel.AutoSize = true;
            class_IDLabel.Location = new System.Drawing.Point(24, 48);
            class_IDLabel.Name = "class_IDLabel";
            class_IDLabel.Size = new System.Drawing.Size(49, 13);
            class_IDLabel.TabIndex = 1;
            class_IDLabel.Text = "Class ID:";
            // 
            // class_IDTextBox
            // 
            this.class_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "Class_ID", true));
            this.class_IDTextBox.Location = new System.Drawing.Point(96, 48);
            this.class_IDTextBox.Name = "class_IDTextBox";
            this.class_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.class_IDTextBox.TabIndex = 2;
            // 
            // class_NameLabel
            // 
            class_NameLabel.AutoSize = true;
            class_NameLabel.Location = new System.Drawing.Point(24, 77);
            class_NameLabel.Name = "class_NameLabel";
            class_NameLabel.Size = new System.Drawing.Size(66, 13);
            class_NameLabel.TabIndex = 3;
            class_NameLabel.Text = "Class Name:";
            // 
            // class_NameTextBox
            // 
            this.class_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "Class_Name", true));
            this.class_NameTextBox.Location = new System.Drawing.Point(96, 74);
            this.class_NameTextBox.Name = "class_NameTextBox";
            this.class_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.class_NameTextBox.TabIndex = 4;
            // 
            // school_IDLabel
            // 
            school_IDLabel.AutoSize = true;
            school_IDLabel.Location = new System.Drawing.Point(24, 103);
            school_IDLabel.Name = "school_IDLabel";
            school_IDLabel.Size = new System.Drawing.Size(57, 13);
            school_IDLabel.TabIndex = 5;
            school_IDLabel.Text = "School ID:";
            // 
            // school_IDTextBox
            // 
            this.school_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "School_ID", true));
            this.school_IDTextBox.Location = new System.Drawing.Point(96, 100);
            this.school_IDTextBox.Name = "school_IDTextBox";
            this.school_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.school_IDTextBox.TabIndex = 6;
            // 
            // classDataGridView
            // 
            this.classDataGridView.AutoGenerateColumns = false;
            this.classDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.classDataGridView.DataSource = this.classBindingSource;
            this.classDataGridView.Location = new System.Drawing.Point(273, 48);
            this.classDataGridView.Name = "classDataGridView";
            this.classDataGridView.Size = new System.Drawing.Size(344, 239);
            this.classDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Class_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Class_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Class_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Class_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "School_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "School_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Add_Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 375);
            this.Controls.Add(this.classDataGridView);
            this.Controls.Add(class_IDLabel);
            this.Controls.Add(this.class_IDTextBox);
            this.Controls.Add(class_NameLabel);
            this.Controls.Add(this.class_NameTextBox);
            this.Controls.Add(school_IDLabel);
            this.Controls.Add(this.school_IDTextBox);
            this.Controls.Add(this.classBindingNavigator);
            this.Name = "Add_Class";
            this.Text = "Add_Class";
            this.Load += new System.EventHandler(this.Add_Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collegio_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingNavigator)).EndInit();
            this.classBindingNavigator.ResumeLayout(false);
            this.classBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Collegio_DatabaseDataSet collegio_DatabaseDataSet;
        private System.Windows.Forms.BindingSource classBindingSource;
        private Collegio_DatabaseDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private Collegio_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator classBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton classBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox class_IDTextBox;
        private System.Windows.Forms.TextBox class_NameTextBox;
        private System.Windows.Forms.TextBox school_IDTextBox;
        private System.Windows.Forms.DataGridView classDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}