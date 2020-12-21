
namespace LibraryDB
{
    partial class FromQueries
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
            this.libraryDataSet1 = new LibraryDB.LibraryDataSet();
            this.textBox_whereValue = new System.Windows.Forms.TextBox();
            this.comboBox_whereCondition = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_whereColumn = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_doQuery = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_queryText = new System.Windows.Forms.Button();
            this.comboBox_orderColumn = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_orderType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_actions = new System.Windows.Forms.ComboBox();
            this.comboBox_selectColumn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combobox_from = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "LibraryDataSet";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_whereValue
            // 
            this.textBox_whereValue.Location = new System.Drawing.Point(59, 73);
            this.textBox_whereValue.Name = "textBox_whereValue";
            this.textBox_whereValue.Size = new System.Drawing.Size(198, 20);
            this.textBox_whereValue.TabIndex = 22;
            // 
            // comboBox_whereCondition
            // 
            this.comboBox_whereCondition.FormattingEnabled = true;
            this.comboBox_whereCondition.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            ">=",
            "<=",
            "LIKE",
            "NOT LIKE"});
            this.comboBox_whereCondition.Location = new System.Drawing.Point(59, 46);
            this.comboBox_whereCondition.Name = "comboBox_whereCondition";
            this.comboBox_whereCondition.Size = new System.Drawing.Size(88, 21);
            this.comboBox_whereCondition.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "condition";
            // 
            // comboBox_whereColumn
            // 
            this.comboBox_whereColumn.FormattingEnabled = true;
            this.comboBox_whereColumn.Location = new System.Drawing.Point(59, 19);
            this.comboBox_whereColumn.Name = "comboBox_whereColumn";
            this.comboBox_whereColumn.Size = new System.Drawing.Size(198, 21);
            this.comboBox_whereColumn.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_whereValue);
            this.groupBox2.Controls.Add(this.comboBox_whereCondition);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox_whereColumn);
            this.groupBox2.Location = new System.Drawing.Point(296, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 101);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WHERE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Column";
            // 
            // button_doQuery
            // 
            this.button_doQuery.Location = new System.Drawing.Point(303, 225);
            this.button_doQuery.Name = "button_doQuery";
            this.button_doQuery.Size = new System.Drawing.Size(268, 42);
            this.button_doQuery.TabIndex = 26;
            this.button_doQuery.Text = "Execurte query";
            this.button_doQuery.UseVisualStyleBackColor = true;
            this.button_doQuery.Click += new System.EventHandler(this.button_doQuery_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Location = new System.Drawing.Point(15, 273);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(556, 113);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // button_queryText
            // 
            this.button_queryText.Location = new System.Drawing.Point(15, 225);
            this.button_queryText.Name = "button_queryText";
            this.button_queryText.Size = new System.Drawing.Size(268, 42);
            this.button_queryText.TabIndex = 24;
            this.button_queryText.Text = "Generate query text";
            this.button_queryText.UseVisualStyleBackColor = true;
            this.button_queryText.Click += new System.EventHandler(this.button_queryText_Click);
            // 
            // comboBox_orderColumn
            // 
            this.comboBox_orderColumn.FormattingEnabled = true;
            this.comboBox_orderColumn.Location = new System.Drawing.Point(52, 35);
            this.comboBox_orderColumn.Name = "comboBox_orderColumn";
            this.comboBox_orderColumn.Size = new System.Drawing.Size(198, 21);
            this.comboBox_orderColumn.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_orderColumn);
            this.groupBox1.Controls.Add(this.comboBox_orderType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 104);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ORDER BY";
            // 
            // comboBox_orderType
            // 
            this.comboBox_orderType.FormattingEnabled = true;
            this.comboBox_orderType.Items.AddRange(new object[] {
            "by ascending",
            "descending"});
            this.comboBox_orderType.Location = new System.Drawing.Point(54, 66);
            this.comboBox_orderType.Name = "comboBox_orderType";
            this.comboBox_orderType.Size = new System.Drawing.Size(198, 21);
            this.comboBox_orderType.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Column";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "sort type";
            // 
            // comboBox_actions
            // 
            this.comboBox_actions.FormattingEnabled = true;
            this.comboBox_actions.Location = new System.Drawing.Point(135, 88);
            this.comboBox_actions.Name = "comboBox_actions";
            this.comboBox_actions.Size = new System.Drawing.Size(172, 21);
            this.comboBox_actions.TabIndex = 21;
            this.comboBox_actions.SelectedIndexChanged += new System.EventHandler(this.comboBox_actions_SelectedIndexChanged);
            // 
            // comboBox_selectColumn
            // 
            this.comboBox_selectColumn.FormattingEnabled = true;
            this.comboBox_selectColumn.Location = new System.Drawing.Point(187, 40);
            this.comboBox_selectColumn.Name = "comboBox_selectColumn";
            this.comboBox_selectColumn.Size = new System.Drawing.Size(172, 21);
            this.comboBox_selectColumn.TabIndex = 20;
            this.comboBox_selectColumn.SelectedIndexChanged += new System.EventHandler(this.select_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select additional action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select column(-s) (action SELECT)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select table (action FROM)";
            // 
            // combobox_from
            // 
            this.combobox_from.FormattingEnabled = true;
            this.combobox_from.Location = new System.Drawing.Point(187, 10);
            this.combobox_from.Name = "combobox_from";
            this.combobox_from.Size = new System.Drawing.Size(172, 21);
            this.combobox_from.TabIndex = 19;
            this.combobox_from.SelectedIndexChanged += new System.EventHandler(this.combobox_from_SelectedIndexChanged);
            // 
            // FromQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_doQuery);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_queryText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_actions);
            this.Controls.Add(this.comboBox_selectColumn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox_from);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FromQueries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FromQueries";
            this.Load += new System.EventHandler(this.FromQueries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet1;
        private System.Windows.Forms.TextBox textBox_whereValue;
        private System.Windows.Forms.ComboBox comboBox_whereCondition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_whereColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_doQuery;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_queryText;
        private System.Windows.Forms.ComboBox comboBox_orderColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_orderType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_actions;
        private System.Windows.Forms.ComboBox comboBox_selectColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_from;
    }
}