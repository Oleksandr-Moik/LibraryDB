
namespace LibraryDB
{
    partial class FormIssuanseRecord
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
            System.Windows.Forms.Label recordIdLabel;
            System.Windows.Forms.Label dateOfIssueLabel;
            System.Windows.Forms.Label dateOfReturnLabel;
            System.Windows.Forms.Label studentIdLabel;
            System.Windows.Forms.Label bookIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIssuanseRecord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.recordIdLabel1 = new System.Windows.Forms.Label();
            this.issuanseRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new LibraryDB.LibraryDataSet();
            this.dateOfIssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentIdComboBox = new System.Windows.Forms.ComboBox();
            this.bookIdComboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.issuanseRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuanseRecordTableAdapter = new LibraryDB.LibraryDataSetTableAdapters.IssuanseRecordTableAdapter();
            this.tableAdapterManager = new LibraryDB.LibraryDataSetTableAdapters.TableAdapterManager();
            this.issuanseRecordBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.issuanseRecordBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new LibraryDB.LibraryDataSetTableAdapters.StudentTableAdapter();
            recordIdLabel = new System.Windows.Forms.Label();
            dateOfIssueLabel = new System.Windows.Forms.Label();
            dateOfReturnLabel = new System.Windows.Forms.Label();
            studentIdLabel = new System.Windows.Forms.Label();
            bookIdLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuanseRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuanseRecordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuanseRecordBindingNavigator)).BeginInit();
            this.issuanseRecordBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // recordIdLabel
            // 
            recordIdLabel.AutoSize = true;
            recordIdLabel.Location = new System.Drawing.Point(230, 118);
            recordIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            recordIdLabel.Name = "recordIdLabel";
            recordIdLabel.Size = new System.Drawing.Size(57, 13);
            recordIdLabel.TabIndex = 1;
            recordIdLabel.Text = "Record Id:";
            // 
            // dateOfIssueLabel
            // 
            dateOfIssueLabel.AutoSize = true;
            dateOfIssueLabel.Location = new System.Drawing.Point(230, 142);
            dateOfIssueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateOfIssueLabel.Name = "dateOfIssueLabel";
            dateOfIssueLabel.Size = new System.Drawing.Size(75, 13);
            dateOfIssueLabel.TabIndex = 3;
            dateOfIssueLabel.Text = "Date Of Issue:";
            // 
            // dateOfReturnLabel
            // 
            dateOfReturnLabel.AutoSize = true;
            dateOfReturnLabel.Location = new System.Drawing.Point(230, 165);
            dateOfReturnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateOfReturnLabel.Name = "dateOfReturnLabel";
            dateOfReturnLabel.Size = new System.Drawing.Size(82, 13);
            dateOfReturnLabel.TabIndex = 5;
            dateOfReturnLabel.Text = "Date Of Return:";
            // 
            // studentIdLabel
            // 
            studentIdLabel.AutoSize = true;
            studentIdLabel.Location = new System.Drawing.Point(230, 187);
            studentIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new System.Drawing.Size(59, 13);
            studentIdLabel.TabIndex = 7;
            studentIdLabel.Text = "Student Id:";
            // 
            // bookIdLabel
            // 
            bookIdLabel.AutoSize = true;
            bookIdLabel.Location = new System.Drawing.Point(230, 212);
            bookIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new System.Drawing.Size(47, 13);
            bookIdLabel.TabIndex = 9;
            bookIdLabel.Text = "Book Id:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 413);
            this.panel1.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 228);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(134, 121);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 41);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 83);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 22);
            this.button4.TabIndex = 1;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(16, 17);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(92, 21);
            this.comboBox4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reset (show) all";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(134, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 74);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 22);
            this.button3.TabIndex = 1;
            this.button3.Text = "Filter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(16, 17);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(92, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(134, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 72);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(16, 48);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(136, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 415);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(recordIdLabel);
            this.tabPage1.Controls.Add(this.recordIdLabel1);
            this.tabPage1.Controls.Add(dateOfIssueLabel);
            this.tabPage1.Controls.Add(this.dateOfIssueDateTimePicker);
            this.tabPage1.Controls.Add(dateOfReturnLabel);
            this.tabPage1.Controls.Add(this.dateOfReturnDateTimePicker);
            this.tabPage1.Controls.Add(studentIdLabel);
            this.tabPage1.Controls.Add(this.studentIdComboBox);
            this.tabPage1.Controls.Add(bookIdLabel);
            this.tabPage1.Controls.Add(this.bookIdComboBox);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(560, 389);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // recordIdLabel1
            // 
            this.recordIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issuanseRecordBindingSource, "RecordId", true));
            this.recordIdLabel1.Location = new System.Drawing.Point(316, 118);
            this.recordIdLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.recordIdLabel1.Name = "recordIdLabel1";
            this.recordIdLabel1.Size = new System.Drawing.Size(150, 19);
            this.recordIdLabel1.TabIndex = 2;
            this.recordIdLabel1.Text = "label1";
            // 
            // issuanseRecordBindingSource
            // 
            this.issuanseRecordBindingSource.DataMember = "IssuanseRecord";
            this.issuanseRecordBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateOfIssueDateTimePicker
            // 
            this.dateOfIssueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.issuanseRecordBindingSource, "DateOfIssue", true));
            this.dateOfIssueDateTimePicker.Location = new System.Drawing.Point(316, 139);
            this.dateOfIssueDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateOfIssueDateTimePicker.Name = "dateOfIssueDateTimePicker";
            this.dateOfIssueDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dateOfIssueDateTimePicker.TabIndex = 4;
            // 
            // dateOfReturnDateTimePicker
            // 
            this.dateOfReturnDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.issuanseRecordBindingSource, "DateOfReturn", true));
            this.dateOfReturnDateTimePicker.Location = new System.Drawing.Point(316, 162);
            this.dateOfReturnDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateOfReturnDateTimePicker.Name = "dateOfReturnDateTimePicker";
            this.dateOfReturnDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.dateOfReturnDateTimePicker.TabIndex = 6;
            // 
            // studentIdComboBox
            // 
            this.studentIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issuanseRecordBindingSource, "StudentId", true));
            this.studentIdComboBox.DataSource = this.issuanseRecordBindingSource;
            this.studentIdComboBox.FormattingEnabled = true;
            this.studentIdComboBox.Location = new System.Drawing.Point(316, 184);
            this.studentIdComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentIdComboBox.Name = "studentIdComboBox";
            this.studentIdComboBox.Size = new System.Drawing.Size(151, 21);
            this.studentIdComboBox.TabIndex = 8;
            // 
            // bookIdComboBox
            // 
            this.bookIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issuanseRecordBindingSource, "BookId", true));
            this.bookIdComboBox.FormattingEnabled = true;
            this.bookIdComboBox.Location = new System.Drawing.Point(316, 210);
            this.bookIdComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookIdComboBox.Name = "bookIdComboBox";
            this.bookIdComboBox.Size = new System.Drawing.Size(151, 21);
            this.bookIdComboBox.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 6);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 381);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.issuanseRecordDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(560, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Таблиця";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // issuanseRecordDataGridView
            // 
            this.issuanseRecordDataGridView.AutoGenerateColumns = false;
            this.issuanseRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuanseRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.issuanseRecordDataGridView.DataSource = this.issuanseRecordBindingSource;
            this.issuanseRecordDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.issuanseRecordDataGridView.Location = new System.Drawing.Point(2, 2);
            this.issuanseRecordDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.issuanseRecordDataGridView.Name = "issuanseRecordDataGridView";
            this.issuanseRecordDataGridView.RowHeadersWidth = 51;
            this.issuanseRecordDataGridView.RowTemplate.Height = 24;
            this.issuanseRecordDataGridView.Size = new System.Drawing.Size(556, 385);
            this.issuanseRecordDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RecordId";
            this.dataGridViewTextBoxColumn1.HeaderText = "RecordId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateOfIssue";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateOfIssue";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateOfReturn";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateOfReturn";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StudentId";
            this.dataGridViewTextBoxColumn4.HeaderText = "StudentId";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BookId";
            this.dataGridViewTextBoxColumn5.HeaderText = "BookId";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // issuanseRecordTableAdapter
            // 
            this.issuanseRecordTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.IssuanseRecordTableAdapter = this.issuanseRecordTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryDB.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // issuanseRecordBindingNavigator
            // 
            this.issuanseRecordBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.issuanseRecordBindingNavigator.BindingSource = this.issuanseRecordBindingSource;
            this.issuanseRecordBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.issuanseRecordBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.issuanseRecordBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.issuanseRecordBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.issuanseRecordBindingNavigatorSaveItem});
            this.issuanseRecordBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.issuanseRecordBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.issuanseRecordBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.issuanseRecordBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.issuanseRecordBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.issuanseRecordBindingNavigator.Name = "issuanseRecordBindingNavigator";
            this.issuanseRecordBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.issuanseRecordBindingNavigator.Size = new System.Drawing.Size(704, 27);
            this.issuanseRecordBindingNavigator.TabIndex = 8;
            this.issuanseRecordBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // issuanseRecordBindingNavigatorSaveItem
            // 
            this.issuanseRecordBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.issuanseRecordBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("issuanseRecordBindingNavigatorSaveItem.Image")));
            this.issuanseRecordBindingNavigatorSaveItem.Name = "issuanseRecordBindingNavigatorSaveItem";
            this.issuanseRecordBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.issuanseRecordBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.issuanseRecordBindingNavigatorSaveItem.Click += new System.EventHandler(this.issuanseRecordBindingNavigatorSaveItem_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.libraryDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // FormIssuanseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 440);
            this.Controls.Add(this.issuanseRecordBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormIssuanseRecord";
            this.Text = "FormIssuanseRecord";
            this.Load += new System.EventHandler(this.FormIssuanseRecord_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuanseRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.issuanseRecordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuanseRecordBindingNavigator)).EndInit();
            this.issuanseRecordBindingNavigator.ResumeLayout(false);
            this.issuanseRecordBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource issuanseRecordBindingSource;
        private LibraryDataSetTableAdapters.IssuanseRecordTableAdapter issuanseRecordTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator issuanseRecordBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton issuanseRecordBindingNavigatorSaveItem;
        private System.Windows.Forms.Label recordIdLabel1;
        private System.Windows.Forms.DateTimePicker dateOfIssueDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateOfReturnDateTimePicker;
        private System.Windows.Forms.ComboBox studentIdComboBox;
        private System.Windows.Forms.ComboBox bookIdComboBox;
        private System.Windows.Forms.DataGridView issuanseRecordDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private LibraryDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
    }
}