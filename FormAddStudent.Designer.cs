
namespace LibraryDB
{
    partial class FormAddStudent
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label surNameLabel;
            System.Windows.Forms.Label byFatherLabel;
            System.Windows.Forms.Label groupLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.surNameTextBox = new System.Windows.Forms.TextBox();
            this.byFatherTextBox = new System.Windows.Forms.TextBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            firstNameLabel = new System.Windows.Forms.Label();
            surNameLabel = new System.Windows.Forms.Label();
            byFatherLabel = new System.Windows.Forms.Label();
            groupLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(11, 32);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 17;
            firstNameLabel.Text = "First Name:";
            // 
            // surNameLabel
            // 
            surNameLabel.AutoSize = true;
            surNameLabel.Location = new System.Drawing.Point(11, 55);
            surNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            surNameLabel.Name = "surNameLabel";
            surNameLabel.Size = new System.Drawing.Size(57, 13);
            surNameLabel.TabIndex = 19;
            surNameLabel.Text = "Sur Name:";
            // 
            // byFatherLabel
            // 
            byFatherLabel.AutoSize = true;
            byFatherLabel.Location = new System.Drawing.Point(11, 78);
            byFatherLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            byFatherLabel.Name = "byFatherLabel";
            byFatherLabel.Size = new System.Drawing.Size(55, 13);
            byFatherLabel.TabIndex = 21;
            byFatherLabel.Text = "By Father:";
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new System.Drawing.Point(11, 100);
            groupLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new System.Drawing.Size(39, 13);
            groupLabel.TabIndex = 23;
            groupLabel.Text = "Group:";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(11, 124);
            birthDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(57, 13);
            birthDateLabel.TabIndex = 25;
            birthDateLabel.Text = "Birth Date:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(11, 146);
            phoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 27;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(96, 30);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.firstNameTextBox.TabIndex = 18;
            // 
            // surNameTextBox
            // 
            this.surNameTextBox.Location = new System.Drawing.Point(96, 53);
            this.surNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.surNameTextBox.Name = "surNameTextBox";
            this.surNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.surNameTextBox.TabIndex = 20;
            // 
            // byFatherTextBox
            // 
            this.byFatherTextBox.Location = new System.Drawing.Point(96, 75);
            this.byFatherTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.byFatherTextBox.Name = "byFatherTextBox";
            this.byFatherTextBox.Size = new System.Drawing.Size(151, 20);
            this.byFatherTextBox.TabIndex = 22;
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(96, 98);
            this.groupTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(151, 20);
            this.groupTextBox.TabIndex = 24;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(96, 121);
            this.birthDateDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.birthDateDateTimePicker.TabIndex = 26;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(96, 143);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(151, 20);
            this.phoneNumberTextBox.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 29;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 20);
            this.button3.TabIndex = 29;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 234);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(surNameLabel);
            this.Controls.Add(this.surNameTextBox);
            this.Controls.Add(byFatherLabel);
            this.Controls.Add(this.byFatherTextBox);
            this.Controls.Add(groupLabel);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddStudent";
            this.Load += new System.EventHandler(this.FormAddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox surNameTextBox;
        private System.Windows.Forms.TextBox byFatherTextBox;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}