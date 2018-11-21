namespace KraftHeinzUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kraftHeinzDataSet = new KraftHeinzUI.KraftHeinzDataSet();
            this.departments_tbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departments_tbTableAdapter = new KraftHeinzUI.KraftHeinzDataSetTableAdapters.departments_tbTableAdapter();
            this.tableAdapterManager = new KraftHeinzUI.KraftHeinzDataSetTableAdapters.TableAdapterManager();
            this.positions_tbTableAdapter = new KraftHeinzUI.KraftHeinzDataSetTableAdapters.positions_tbTableAdapter();
            this.departments_tbBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.departments_tbBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.departments_tbDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positions_tbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positions_tbDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kraftHeinzDataSet1 = new KraftHeinzUI.KraftHeinzDataSet();
            this.positions_tbBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.positions_tbBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.depMoveFirst = new System.Windows.Forms.Button();
            this.depMovePrev = new System.Windows.Forms.Button();
            this.depMoveNext = new System.Windows.Forms.Button();
            this.depMoveLast = new System.Windows.Forms.Button();
            this.posMoveLast = new System.Windows.Forms.Button();
            this.posMoveNext = new System.Windows.Forms.Button();
            this.posMovePrev = new System.Windows.Forms.Button();
            this.posMoveFirst = new System.Windows.Forms.Button();
            this.depAddNew = new System.Windows.Forms.Button();
            this.depDeleteCurrent = new System.Windows.Forms.Button();
            this.posDeleteCurrent = new System.Windows.Forms.Button();
            this.posAddNew = new System.Windows.Forms.Button();
            this.depCounter = new System.Windows.Forms.TextBox();
            this.posCounter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDep = new System.Windows.Forms.Button();
            this.insDepDesc = new System.Windows.Forms.TextBox();
            this.insDepName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.insPosIdDep = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAppPos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.insPosDesc = new System.Windows.Forms.TextBox();
            this.insPosName = new System.Windows.Forms.TextBox();
            this.depSave = new System.Windows.Forms.Button();
            this.posSave = new System.Windows.Forms.Button();
            this.departmentstbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtFindDep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFindDep = new System.Windows.Forms.Button();
            this.btnFindPKDep = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFindPKDep = new System.Windows.Forms.TextBox();
            this.btnFindPKPos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFindPKPos = new System.Windows.Forms.TextBox();
            this.btnFindPos = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFindPos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.depCol = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.posCol = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.depSortF = new System.Windows.Forms.ComboBox();
            this.depSortDir = new System.Windows.Forms.ComboBox();
            this.btnDepSort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.posSortDir = new System.Windows.Forms.ComboBox();
            this.posSortF = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.posFilField = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.posFilterValue = new System.Windows.Forms.TextBox();
            this.btnPosFilter = new System.Windows.Forms.Button();
            this.btnDepFilter = new System.Windows.Forms.Button();
            this.depFilterValue = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.depFilField = new System.Windows.Forms.ComboBox();
            this.LinkBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kraftHeinzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departments_tbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departments_tbBindingNavigator)).BeginInit();
            this.departments_tbBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departments_tbDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positions_tbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positions_tbDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kraftHeinzDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positions_tbBindingNavigator)).BeginInit();
            this.positions_tbBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insPosIdDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentstbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kraftHeinzDataSet
            // 
            this.kraftHeinzDataSet.DataSetName = "KraftHeinzDataSet";
            this.kraftHeinzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departments_tbBindingSource
            // 
            this.departments_tbBindingSource.DataMember = "departments_tb";
            this.departments_tbBindingSource.DataSource = this.kraftHeinzDataSet;
            // 
            // departments_tbTableAdapter
            // 
            this.departments_tbTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.departments_tbTableAdapter = this.departments_tbTableAdapter;
            this.tableAdapterManager.positions_tbTableAdapter = this.positions_tbTableAdapter;
            this.tableAdapterManager.UpdateOrder = KraftHeinzUI.KraftHeinzDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // positions_tbTableAdapter
            // 
            this.positions_tbTableAdapter.ClearBeforeFill = true;
            // 
            // departments_tbBindingNavigator
            // 
            this.departments_tbBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.departments_tbBindingNavigator.BindingSource = this.departments_tbBindingSource;
            this.departments_tbBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.departments_tbBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.departments_tbBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.departments_tbBindingNavigatorSaveItem});
            this.departments_tbBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.departments_tbBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.departments_tbBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.departments_tbBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.departments_tbBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.departments_tbBindingNavigator.Name = "departments_tbBindingNavigator";
            this.departments_tbBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.departments_tbBindingNavigator.Size = new System.Drawing.Size(1113, 25);
            this.departments_tbBindingNavigator.TabIndex = 0;
            this.departments_tbBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // departments_tbBindingNavigatorSaveItem
            // 
            this.departments_tbBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.departments_tbBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("departments_tbBindingNavigatorSaveItem.Image")));
            this.departments_tbBindingNavigatorSaveItem.Name = "departments_tbBindingNavigatorSaveItem";
            this.departments_tbBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.departments_tbBindingNavigatorSaveItem.Text = "Save Data";
            this.departments_tbBindingNavigatorSaveItem.Click += new System.EventHandler(this.departments_tbBindingNavigatorSaveItem_Click);
            // 
            // departments_tbDataGridView
            // 
            this.departments_tbDataGridView.AutoGenerateColumns = false;
            this.departments_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departments_tbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.departments_tbDataGridView.DataSource = this.departments_tbBindingSource;
            this.departments_tbDataGridView.Location = new System.Drawing.Point(0, 57);
            this.departments_tbDataGridView.Name = "departments_tbDataGridView";
            this.departments_tbDataGridView.Size = new System.Drawing.Size(628, 220);
            this.departments_tbDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idDepartment";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Department";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "departmentName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Department Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "departmentDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "Department Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // positions_tbBindingSource
            // 
            this.positions_tbBindingSource.DataMember = "positions_tb";
            this.positions_tbBindingSource.DataSource = this.kraftHeinzDataSet;
            // 
            // positions_tbDataGridView
            // 
            this.positions_tbDataGridView.AutoGenerateColumns = false;
            this.positions_tbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positions_tbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.positions_tbDataGridView.DataSource = this.positions_tbBindingSource;
            this.positions_tbDataGridView.Location = new System.Drawing.Point(0, 292);
            this.positions_tbDataGridView.Name = "positions_tbDataGridView";
            this.positions_tbDataGridView.Size = new System.Drawing.Size(628, 277);
            this.positions_tbDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idPosition";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id Position";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idDepartment";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id Department";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "positionName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Position Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "positionDescription";
            this.dataGridViewTextBoxColumn7.HeaderText = "Position Description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // kraftHeinzDataSet1
            // 
            this.kraftHeinzDataSet1.DataSetName = "KraftHeinzDataSet";
            this.kraftHeinzDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positions_tbBindingNavigator
            // 
            this.positions_tbBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.positions_tbBindingNavigator.BindingSource = this.positions_tbBindingSource;
            this.positions_tbBindingNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.positions_tbBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.positions_tbBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.positions_tbBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.positions_tbBindingNavigatorSaveItem});
            this.positions_tbBindingNavigator.Location = new System.Drawing.Point(0, 617);
            this.positions_tbBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.positions_tbBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.positions_tbBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.positions_tbBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.positions_tbBindingNavigator.Name = "positions_tbBindingNavigator";
            this.positions_tbBindingNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.positions_tbBindingNavigator.Size = new System.Drawing.Size(1113, 25);
            this.positions_tbBindingNavigator.Stretch = true;
            this.positions_tbBindingNavigator.TabIndex = 3;
            this.positions_tbBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // positions_tbBindingNavigatorSaveItem
            // 
            this.positions_tbBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.positions_tbBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("positions_tbBindingNavigatorSaveItem.Image")));
            this.positions_tbBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.positions_tbBindingNavigatorSaveItem.Name = "positions_tbBindingNavigatorSaveItem";
            this.positions_tbBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.positions_tbBindingNavigatorSaveItem.Text = "Save Data";
            this.positions_tbBindingNavigatorSaveItem.Click += new System.EventHandler(this.positions_tbBindingNavigatorSaveItem_Click);
            // 
            // depMoveFirst
            // 
            this.depMoveFirst.Location = new System.Drawing.Point(12, 28);
            this.depMoveFirst.Name = "depMoveFirst";
            this.depMoveFirst.Size = new System.Drawing.Size(70, 23);
            this.depMoveFirst.TabIndex = 4;
            this.depMoveFirst.Text = "MoveFirst";
            this.depMoveFirst.UseVisualStyleBackColor = true;
            this.depMoveFirst.Click += new System.EventHandler(this.depMoveFirst_Click);
            // 
            // depMovePrev
            // 
            this.depMovePrev.Location = new System.Drawing.Point(88, 28);
            this.depMovePrev.Name = "depMovePrev";
            this.depMovePrev.Size = new System.Drawing.Size(70, 23);
            this.depMovePrev.TabIndex = 5;
            this.depMovePrev.Text = "MovePrev";
            this.depMovePrev.UseVisualStyleBackColor = true;
            this.depMovePrev.Click += new System.EventHandler(this.depMovePrev_Click);
            // 
            // depMoveNext
            // 
            this.depMoveNext.Location = new System.Drawing.Point(254, 28);
            this.depMoveNext.Name = "depMoveNext";
            this.depMoveNext.Size = new System.Drawing.Size(70, 23);
            this.depMoveNext.TabIndex = 6;
            this.depMoveNext.Text = "MoveNext";
            this.depMoveNext.UseVisualStyleBackColor = true;
            this.depMoveNext.Click += new System.EventHandler(this.depMoveNext_Click);
            // 
            // depMoveLast
            // 
            this.depMoveLast.Location = new System.Drawing.Point(330, 28);
            this.depMoveLast.Name = "depMoveLast";
            this.depMoveLast.Size = new System.Drawing.Size(70, 23);
            this.depMoveLast.TabIndex = 7;
            this.depMoveLast.Text = "MoveLast";
            this.depMoveLast.UseVisualStyleBackColor = true;
            this.depMoveLast.Click += new System.EventHandler(this.depMoveLast_Click);
            // 
            // posMoveLast
            // 
            this.posMoveLast.Location = new System.Drawing.Point(330, 575);
            this.posMoveLast.Name = "posMoveLast";
            this.posMoveLast.Size = new System.Drawing.Size(70, 23);
            this.posMoveLast.TabIndex = 11;
            this.posMoveLast.Text = "MoveLast";
            this.posMoveLast.UseVisualStyleBackColor = true;
            this.posMoveLast.Click += new System.EventHandler(this.posMoveLast_Click);
            // 
            // posMoveNext
            // 
            this.posMoveNext.Location = new System.Drawing.Point(254, 575);
            this.posMoveNext.Name = "posMoveNext";
            this.posMoveNext.Size = new System.Drawing.Size(70, 23);
            this.posMoveNext.TabIndex = 10;
            this.posMoveNext.Text = "MoveNext";
            this.posMoveNext.UseVisualStyleBackColor = true;
            this.posMoveNext.Click += new System.EventHandler(this.posMoveNext_Click);
            // 
            // posMovePrev
            // 
            this.posMovePrev.Location = new System.Drawing.Point(88, 575);
            this.posMovePrev.Name = "posMovePrev";
            this.posMovePrev.Size = new System.Drawing.Size(70, 23);
            this.posMovePrev.TabIndex = 9;
            this.posMovePrev.Text = "MovePrev";
            this.posMovePrev.UseVisualStyleBackColor = true;
            this.posMovePrev.Click += new System.EventHandler(this.posMovePrev_Click);
            // 
            // posMoveFirst
            // 
            this.posMoveFirst.Location = new System.Drawing.Point(12, 575);
            this.posMoveFirst.Name = "posMoveFirst";
            this.posMoveFirst.Size = new System.Drawing.Size(70, 23);
            this.posMoveFirst.TabIndex = 8;
            this.posMoveFirst.Text = "MoveFirst";
            this.posMoveFirst.UseVisualStyleBackColor = true;
            this.posMoveFirst.Click += new System.EventHandler(this.posMoveFirst_Click);
            // 
            // depAddNew
            // 
            this.depAddNew.Location = new System.Drawing.Point(406, 28);
            this.depAddNew.Name = "depAddNew";
            this.depAddNew.Size = new System.Drawing.Size(70, 23);
            this.depAddNew.TabIndex = 12;
            this.depAddNew.Text = "AddNew";
            this.depAddNew.UseVisualStyleBackColor = true;
            this.depAddNew.Click += new System.EventHandler(this.depAddNew_Click);
            // 
            // depDeleteCurrent
            // 
            this.depDeleteCurrent.Location = new System.Drawing.Point(482, 28);
            this.depDeleteCurrent.Name = "depDeleteCurrent";
            this.depDeleteCurrent.Size = new System.Drawing.Size(70, 23);
            this.depDeleteCurrent.TabIndex = 13;
            this.depDeleteCurrent.Text = "DeleteCurrent";
            this.depDeleteCurrent.UseVisualStyleBackColor = true;
            this.depDeleteCurrent.Click += new System.EventHandler(this.depDeleteCurrent_Click);
            // 
            // posDeleteCurrent
            // 
            this.posDeleteCurrent.Location = new System.Drawing.Point(482, 575);
            this.posDeleteCurrent.Name = "posDeleteCurrent";
            this.posDeleteCurrent.Size = new System.Drawing.Size(70, 23);
            this.posDeleteCurrent.TabIndex = 15;
            this.posDeleteCurrent.Text = "DeleteCurrent";
            this.posDeleteCurrent.UseVisualStyleBackColor = true;
            this.posDeleteCurrent.Click += new System.EventHandler(this.posDeleteCurrent_Click);
            // 
            // posAddNew
            // 
            this.posAddNew.Location = new System.Drawing.Point(406, 575);
            this.posAddNew.Name = "posAddNew";
            this.posAddNew.Size = new System.Drawing.Size(70, 23);
            this.posAddNew.TabIndex = 14;
            this.posAddNew.Text = "AddNew";
            this.posAddNew.UseVisualStyleBackColor = true;
            this.posAddNew.Click += new System.EventHandler(this.posAddNew_Click);
            // 
            // depCounter
            // 
            this.depCounter.Location = new System.Drawing.Point(164, 30);
            this.depCounter.Name = "depCounter";
            this.depCounter.ReadOnly = true;
            this.depCounter.Size = new System.Drawing.Size(84, 20);
            this.depCounter.TabIndex = 16;
            this.depCounter.Text = "0 of 0";
            this.depCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // posCounter
            // 
            this.posCounter.Location = new System.Drawing.Point(164, 577);
            this.posCounter.Name = "posCounter";
            this.posCounter.ReadOnly = true;
            this.posCounter.Size = new System.Drawing.Size(84, 20);
            this.posCounter.TabIndex = 17;
            this.posCounter.Text = "0 of 0";
            this.posCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddDep);
            this.groupBox1.Controls.Add(this.insDepDesc);
            this.groupBox1.Controls.Add(this.insDepName);
            this.groupBox1.Location = new System.Drawing.Point(643, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 220);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Department Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Department Name";
            // 
            // btnAddDep
            // 
            this.btnAddDep.Location = new System.Drawing.Point(56, 191);
            this.btnAddDep.Name = "btnAddDep";
            this.btnAddDep.Size = new System.Drawing.Size(75, 23);
            this.btnAddDep.TabIndex = 2;
            this.btnAddDep.Text = "Add";
            this.btnAddDep.UseVisualStyleBackColor = true;
            this.btnAddDep.Click += new System.EventHandler(this.btnAddDep_Click);
            // 
            // insDepDesc
            // 
            this.insDepDesc.Location = new System.Drawing.Point(6, 102);
            this.insDepDesc.Multiline = true;
            this.insDepDesc.Name = "insDepDesc";
            this.insDepDesc.Size = new System.Drawing.Size(188, 83);
            this.insDepDesc.TabIndex = 1;
            // 
            // insDepName
            // 
            this.insDepName.Location = new System.Drawing.Point(6, 63);
            this.insDepName.Name = "insDepName";
            this.insDepName.Size = new System.Drawing.Size(188, 20);
            this.insDepName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.insPosIdDep);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAppPos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.insPosDesc);
            this.groupBox2.Controls.Add(this.insPosName);
            this.groupBox2.Location = new System.Drawing.Point(643, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 277);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Id Department";
            // 
            // insPosIdDep
            // 
            this.insPosIdDep.Location = new System.Drawing.Point(6, 50);
            this.insPosIdDep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.insPosIdDep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.insPosIdDep.Name = "insPosIdDep";
            this.insPosIdDep.Size = new System.Drawing.Size(188, 20);
            this.insPosIdDep.TabIndex = 7;
            this.insPosIdDep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Position Description";
            // 
            // btnAppPos
            // 
            this.btnAppPos.Location = new System.Drawing.Point(56, 248);
            this.btnAppPos.Name = "btnAppPos";
            this.btnAppPos.Size = new System.Drawing.Size(75, 23);
            this.btnAppPos.TabIndex = 3;
            this.btnAppPos.Text = "Add";
            this.btnAppPos.UseVisualStyleBackColor = true;
            this.btnAppPos.Click += new System.EventHandler(this.btnAppPos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Position Name";
            // 
            // insPosDesc
            // 
            this.insPosDesc.Location = new System.Drawing.Point(6, 139);
            this.insPosDesc.Multiline = true;
            this.insPosDesc.Name = "insPosDesc";
            this.insPosDesc.Size = new System.Drawing.Size(188, 103);
            this.insPosDesc.TabIndex = 4;
            // 
            // insPosName
            // 
            this.insPosName.Location = new System.Drawing.Point(6, 98);
            this.insPosName.Name = "insPosName";
            this.insPosName.Size = new System.Drawing.Size(188, 20);
            this.insPosName.TabIndex = 3;
            // 
            // depSave
            // 
            this.depSave.Location = new System.Drawing.Point(558, 28);
            this.depSave.Name = "depSave";
            this.depSave.Size = new System.Drawing.Size(70, 23);
            this.depSave.TabIndex = 20;
            this.depSave.Text = "Save";
            this.depSave.UseVisualStyleBackColor = true;
            this.depSave.Click += new System.EventHandler(this.depSave_Click);
            // 
            // posSave
            // 
            this.posSave.Location = new System.Drawing.Point(558, 575);
            this.posSave.Name = "posSave";
            this.posSave.Size = new System.Drawing.Size(70, 23);
            this.posSave.TabIndex = 21;
            this.posSave.Text = "Save";
            this.posSave.UseVisualStyleBackColor = true;
            this.posSave.Click += new System.EventHandler(this.posSave_Click);
            // 
            // departmentstbBindingSource
            // 
            this.departmentstbBindingSource.DataMember = "departments_tb";
            this.departmentstbBindingSource.DataSource = this.kraftHeinzDataSet;
            // 
            // txtFindDep
            // 
            this.txtFindDep.Location = new System.Drawing.Point(851, 31);
            this.txtFindDep.Name = "txtFindDep";
            this.txtFindDep.Size = new System.Drawing.Size(113, 20);
            this.txtFindDep.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(817, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Term";
            // 
            // btnFindDep
            // 
            this.btnFindDep.Location = new System.Drawing.Point(970, 30);
            this.btnFindDep.Name = "btnFindDep";
            this.btnFindDep.Size = new System.Drawing.Size(63, 23);
            this.btnFindDep.TabIndex = 24;
            this.btnFindDep.Text = "Find";
            this.btnFindDep.UseVisualStyleBackColor = true;
            this.btnFindDep.Click += new System.EventHandler(this.btnFindDep_Click);
            // 
            // btnFindPKDep
            // 
            this.btnFindPKDep.Location = new System.Drawing.Point(970, 63);
            this.btnFindPKDep.Name = "btnFindPKDep";
            this.btnFindPKDep.Size = new System.Drawing.Size(63, 23);
            this.btnFindPKDep.TabIndex = 27;
            this.btnFindPKDep.Text = "Find";
            this.btnFindPKDep.UseVisualStyleBackColor = true;
            this.btnFindPKDep.Click += new System.EventHandler(this.btnFindPKDep_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(848, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Find PK";
            // 
            // txtFindPKDep
            // 
            this.txtFindPKDep.Location = new System.Drawing.Point(896, 65);
            this.txtFindPKDep.Name = "txtFindPKDep";
            this.txtFindPKDep.Size = new System.Drawing.Size(68, 20);
            this.txtFindPKDep.TabIndex = 25;
            // 
            // btnFindPKPos
            // 
            this.btnFindPKPos.Location = new System.Drawing.Point(970, 539);
            this.btnFindPKPos.Name = "btnFindPKPos";
            this.btnFindPKPos.Size = new System.Drawing.Size(63, 23);
            this.btnFindPKPos.TabIndex = 33;
            this.btnFindPKPos.Text = "Find";
            this.btnFindPKPos.UseVisualStyleBackColor = true;
            this.btnFindPKPos.Click += new System.EventHandler(this.btnFindPKPos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(848, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Find PK";
            // 
            // txtFindPKPos
            // 
            this.txtFindPKPos.Location = new System.Drawing.Point(896, 541);
            this.txtFindPKPos.Name = "txtFindPKPos";
            this.txtFindPKPos.Size = new System.Drawing.Size(68, 20);
            this.txtFindPKPos.TabIndex = 31;
            // 
            // btnFindPos
            // 
            this.btnFindPos.Location = new System.Drawing.Point(970, 575);
            this.btnFindPos.Name = "btnFindPos";
            this.btnFindPos.Size = new System.Drawing.Size(63, 23);
            this.btnFindPos.TabIndex = 30;
            this.btnFindPos.Text = "Find";
            this.btnFindPos.UseVisualStyleBackColor = true;
            this.btnFindPos.Click += new System.EventHandler(this.btnFindPos_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(817, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Term";
            // 
            // txtFindPos
            // 
            this.txtFindPos.Location = new System.Drawing.Point(851, 577);
            this.txtFindPos.Name = "txtFindPos";
            this.txtFindPos.Size = new System.Drawing.Size(113, 20);
            this.txtFindPos.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(640, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Column";
            // 
            // depCol
            // 
            this.depCol.Location = new System.Drawing.Point(699, 30);
            this.depCol.Name = "depCol";
            this.depCol.Size = new System.Drawing.Size(100, 20);
            this.depCol.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(640, 581);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Column";
            // 
            // posCol
            // 
            this.posCol.Location = new System.Drawing.Point(699, 577);
            this.posCol.Name = "posCol";
            this.posCol.Size = new System.Drawing.Size(100, 20);
            this.posCol.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(848, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Field";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(849, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Dir";
            // 
            // depSortF
            // 
            this.depSortF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depSortF.FormattingEnabled = true;
            this.depSortF.Items.AddRange(new object[] {
            "idDepartment",
            "departmentName",
            "departmentDescription"});
            this.depSortF.Location = new System.Drawing.Point(896, 95);
            this.depSortF.Name = "depSortF";
            this.depSortF.Size = new System.Drawing.Size(137, 21);
            this.depSortF.TabIndex = 41;
            // 
            // depSortDir
            // 
            this.depSortDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depSortDir.FormattingEnabled = true;
            this.depSortDir.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.depSortDir.Location = new System.Drawing.Point(896, 121);
            this.depSortDir.Name = "depSortDir";
            this.depSortDir.Size = new System.Drawing.Size(137, 21);
            this.depSortDir.TabIndex = 42;
            // 
            // btnDepSort
            // 
            this.btnDepSort.Location = new System.Drawing.Point(957, 148);
            this.btnDepSort.Name = "btnDepSort";
            this.btnDepSort.Size = new System.Drawing.Size(75, 23);
            this.btnDepSort.TabIndex = 43;
            this.btnDepSort.Text = "Sort";
            this.btnDepSort.UseVisualStyleBackColor = true;
            this.btnDepSort.Click += new System.EventHandler(this.btnDepSort_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(955, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // posSortDir
            // 
            this.posSortDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.posSortDir.FormattingEnabled = true;
            this.posSortDir.Items.AddRange(new object[] {
            "ASC",
            "DESC"});
            this.posSortDir.Location = new System.Drawing.Point(894, 318);
            this.posSortDir.Name = "posSortDir";
            this.posSortDir.Size = new System.Drawing.Size(137, 21);
            this.posSortDir.TabIndex = 47;
            // 
            // posSortF
            // 
            this.posSortF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.posSortF.FormattingEnabled = true;
            this.posSortF.Items.AddRange(new object[] {
            "idPosition",
            "idDepartment",
            "positionName",
            "positionDescription"});
            this.posSortF.Location = new System.Drawing.Point(894, 292);
            this.posSortF.Name = "posSortF";
            this.posSortF.Size = new System.Drawing.Size(137, 21);
            this.posSortF.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(847, 326);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Dir";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(846, 300);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Field";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "idPosition",
            "idDepartment",
            "positionName",
            "positionDescription"});
            this.comboBox1.Location = new System.Drawing.Point(894, 389);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 50;
            // 
            // posFilField
            // 
            this.posFilField.AutoSize = true;
            this.posFilField.Location = new System.Drawing.Point(846, 397);
            this.posFilField.Name = "posFilField";
            this.posFilField.Size = new System.Drawing.Size(51, 13);
            this.posFilField.TabIndex = 49;
            this.posFilField.Text = "FilterField";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(846, 423);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "Value";
            // 
            // posFilterValue
            // 
            this.posFilterValue.Location = new System.Drawing.Point(894, 420);
            this.posFilterValue.Name = "posFilterValue";
            this.posFilterValue.Size = new System.Drawing.Size(137, 20);
            this.posFilterValue.TabIndex = 52;
            // 
            // btnPosFilter
            // 
            this.btnPosFilter.Location = new System.Drawing.Point(955, 446);
            this.btnPosFilter.Name = "btnPosFilter";
            this.btnPosFilter.Size = new System.Drawing.Size(75, 23);
            this.btnPosFilter.TabIndex = 53;
            this.btnPosFilter.Text = "Filter";
            this.btnPosFilter.UseVisualStyleBackColor = true;
            this.btnPosFilter.Click += new System.EventHandler(this.btnPosFilter_Click);
            // 
            // btnDepFilter
            // 
            this.btnDepFilter.Location = new System.Drawing.Point(955, 238);
            this.btnDepFilter.Name = "btnDepFilter";
            this.btnDepFilter.Size = new System.Drawing.Size(75, 23);
            this.btnDepFilter.TabIndex = 57;
            this.btnDepFilter.Text = "Filter";
            this.btnDepFilter.UseVisualStyleBackColor = true;
            this.btnDepFilter.Click += new System.EventHandler(this.btnDepFilter_Click);
            // 
            // depFilterValue
            // 
            this.depFilterValue.Location = new System.Drawing.Point(894, 212);
            this.depFilterValue.Name = "depFilterValue";
            this.depFilterValue.Size = new System.Drawing.Size(137, 20);
            this.depFilterValue.TabIndex = 56;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(846, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "Value";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(846, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 54;
            this.label18.Text = "FilterField";
            // 
            // depFilField
            // 
            this.depFilField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depFilField.FormattingEnabled = true;
            this.depFilField.Items.AddRange(new object[] {
            "idDepartment",
            "departmentName",
            "departmentDescription"});
            this.depFilField.Location = new System.Drawing.Point(894, 181);
            this.depFilField.Name = "depFilField";
            this.depFilField.Size = new System.Drawing.Size(137, 21);
            this.depFilField.TabIndex = 58;
            // 
            // LinkBtn
            // 
            this.LinkBtn.Location = new System.Drawing.Point(1039, 29);
            this.LinkBtn.Name = "LinkBtn";
            this.LinkBtn.Size = new System.Drawing.Size(75, 23);
            this.LinkBtn.TabIndex = 59;
            this.LinkBtn.Text = "Link";
            this.LinkBtn.UseVisualStyleBackColor = true;
            this.LinkBtn.Click += new System.EventHandler(this.LinkBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 642);
            this.Controls.Add(this.LinkBtn);
            this.Controls.Add(this.depFilField);
            this.Controls.Add(this.btnDepFilter);
            this.Controls.Add(this.depFilterValue);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnPosFilter);
            this.Controls.Add(this.posFilterValue);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.posFilField);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.posSortDir);
            this.Controls.Add(this.posSortF);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnDepSort);
            this.Controls.Add(this.depSortDir);
            this.Controls.Add(this.depSortF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.posCol);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.depCol);
            this.Controls.Add(this.btnFindPKPos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFindPKPos);
            this.Controls.Add(this.btnFindPos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFindPos);
            this.Controls.Add(this.btnFindPKDep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFindPKDep);
            this.Controls.Add(this.btnFindDep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFindDep);
            this.Controls.Add(this.posSave);
            this.Controls.Add(this.depSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.posCounter);
            this.Controls.Add(this.depCounter);
            this.Controls.Add(this.posDeleteCurrent);
            this.Controls.Add(this.posAddNew);
            this.Controls.Add(this.depDeleteCurrent);
            this.Controls.Add(this.depAddNew);
            this.Controls.Add(this.posMoveLast);
            this.Controls.Add(this.posMoveNext);
            this.Controls.Add(this.posMovePrev);
            this.Controls.Add(this.posMoveFirst);
            this.Controls.Add(this.depMoveLast);
            this.Controls.Add(this.depMoveNext);
            this.Controls.Add(this.depMovePrev);
            this.Controls.Add(this.depMoveFirst);
            this.Controls.Add(this.positions_tbBindingNavigator);
            this.Controls.Add(this.positions_tbDataGridView);
            this.Controls.Add(this.departments_tbDataGridView);
            this.Controls.Add(this.departments_tbBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kraftHeinzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departments_tbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departments_tbBindingNavigator)).EndInit();
            this.departments_tbBindingNavigator.ResumeLayout(false);
            this.departments_tbBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departments_tbDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positions_tbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positions_tbDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kraftHeinzDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positions_tbBindingNavigator)).EndInit();
            this.positions_tbBindingNavigator.ResumeLayout(false);
            this.positions_tbBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insPosIdDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentstbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KraftHeinzDataSet kraftHeinzDataSet;
        private System.Windows.Forms.BindingSource departments_tbBindingSource;
        private KraftHeinzDataSetTableAdapters.departments_tbTableAdapter departments_tbTableAdapter;
        private KraftHeinzDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator departments_tbBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton departments_tbBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView departments_tbDataGridView;
        private KraftHeinzDataSetTableAdapters.positions_tbTableAdapter positions_tbTableAdapter;
        private System.Windows.Forms.BindingSource positions_tbBindingSource;
        private System.Windows.Forms.DataGridView positions_tbDataGridView;
        private KraftHeinzDataSet kraftHeinzDataSet1;
        private System.Windows.Forms.BindingNavigator positions_tbBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton positions_tbBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button depMoveFirst;
        private System.Windows.Forms.Button depMovePrev;
        private System.Windows.Forms.Button depMoveNext;
        private System.Windows.Forms.Button depMoveLast;
        private System.Windows.Forms.Button posMoveLast;
        private System.Windows.Forms.Button posMoveNext;
        private System.Windows.Forms.Button posMovePrev;
        private System.Windows.Forms.Button posMoveFirst;
        private System.Windows.Forms.Button depAddNew;
        private System.Windows.Forms.Button depDeleteCurrent;
        private System.Windows.Forms.Button posDeleteCurrent;
        private System.Windows.Forms.Button posAddNew;
        private System.Windows.Forms.TextBox depCounter;
        private System.Windows.Forms.TextBox posCounter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox insDepDesc;
        private System.Windows.Forms.TextBox insDepName;
        private System.Windows.Forms.TextBox insPosDesc;
        private System.Windows.Forms.TextBox insPosName;
        private System.Windows.Forms.Button btnAddDep;
        private System.Windows.Forms.Button btnAppPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown insPosIdDep;
        private System.Windows.Forms.Button depSave;
        private System.Windows.Forms.Button posSave;
        private System.Windows.Forms.BindingSource departmentstbBindingSource;
        private System.Windows.Forms.TextBox txtFindDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFindDep;
        private System.Windows.Forms.Button btnFindPKDep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFindPKDep;
        private System.Windows.Forms.Button btnFindPKPos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFindPKPos;
        private System.Windows.Forms.Button btnFindPos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFindPos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox depCol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox posCol;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox depSortF;
        private System.Windows.Forms.ComboBox depSortDir;
        private System.Windows.Forms.Button btnDepSort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox posSortDir;
        private System.Windows.Forms.ComboBox posSortF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label posFilField;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox posFilterValue;
        private System.Windows.Forms.Button btnPosFilter;
        private System.Windows.Forms.Button btnDepFilter;
        private System.Windows.Forms.TextBox depFilterValue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox depFilField;
        private System.Windows.Forms.Button LinkBtn;
    }
}

