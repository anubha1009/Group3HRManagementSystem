namespace Group3HRManagementSystem
{
    partial class ViewEmployees
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchByEmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchByEmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.viewEmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeDescriptionLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ARadioButton = new System.Windows.Forms.RadioButton();
            this.BRadioButton = new System.Windows.Forms.RadioButton();
            this.CRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeLastNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeTypeTextBox = new System.Windows.Forms.TextBox();
            this.projectAssignedComboBox = new System.Windows.Forms.ComboBox();
            this.employeeSalaryTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateEmployeeDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.DRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployeeDataGridView)).BeginInit();
            this.updateEmployeeDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Employee Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search By Employee Name";
            // 
            // searchByEmployeeNameTextBox
            // 
            this.searchByEmployeeNameTextBox.Location = new System.Drawing.Point(106, 89);
            this.searchByEmployeeNameTextBox.Name = "searchByEmployeeNameTextBox";
            this.searchByEmployeeNameTextBox.Size = new System.Drawing.Size(216, 22);
            this.searchByEmployeeNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search By Employee ID";
            // 
            // searchByEmployeeIdTextBox
            // 
            this.searchByEmployeeIdTextBox.Location = new System.Drawing.Point(373, 89);
            this.searchByEmployeeIdTextBox.Name = "searchByEmployeeIdTextBox";
            this.searchByEmployeeIdTextBox.Size = new System.Drawing.Size(214, 22);
            this.searchByEmployeeIdTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(373, 138);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 53);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(106, 138);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 55);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1193, 562);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 38);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // viewEmployeeDataGridView
            // 
            this.viewEmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewEmployeeDataGridView.Location = new System.Drawing.Point(106, 236);
            this.viewEmployeeDataGridView.Name = "viewEmployeeDataGridView";
            this.viewEmployeeDataGridView.RowHeadersWidth = 51;
            this.viewEmployeeDataGridView.RowTemplate.Height = 24;
            this.viewEmployeeDataGridView.Size = new System.Drawing.Size(1178, 317);
            this.viewEmployeeDataGridView.TabIndex = 8;
            this.viewEmployeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewEmployeeDataGridView_CellContentClick);
            // 
            // employeeDescriptionLabel
            // 
            this.employeeDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeeDescriptionLabel.Location = new System.Drawing.Point(882, 63);
            this.employeeDescriptionLabel.Name = "employeeDescriptionLabel";
            this.employeeDescriptionLabel.Size = new System.Drawing.Size(402, 150);
            this.employeeDescriptionLabel.TabIndex = 9;
            // 
            // errorLabel
            // 
            this.errorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errorLabel.Location = new System.Drawing.Point(106, 572);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(1061, 23);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "No Errors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search By  Employee Type";
            // 
            // employeeTypeComboBox
            // 
            this.employeeTypeComboBox.FormattingEnabled = true;
            this.employeeTypeComboBox.Location = new System.Drawing.Point(640, 86);
            this.employeeTypeComboBox.Name = "employeeTypeComboBox";
            this.employeeTypeComboBox.Size = new System.Drawing.Size(198, 24);
            this.employeeTypeComboBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(329, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "OR";
            // 
            // OR
            // 
            this.OR.AutoSize = true;
            this.OR.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.OR.Location = new System.Drawing.Point(594, 88);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(27, 16);
            this.OR.TabIndex = 14;
            this.OR.Text = "OR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Employee FirstName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Employee LastName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Employee Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Project Assigned";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Employee Pay Rate(/hr)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Employee Performance";
            // 
            // ARadioButton
            // 
            this.ARadioButton.AutoSize = true;
            this.ARadioButton.Location = new System.Drawing.Point(37, 377);
            this.ARadioButton.Name = "ARadioButton";
            this.ARadioButton.Size = new System.Drawing.Size(100, 20);
            this.ARadioButton.TabIndex = 21;
            this.ARadioButton.TabStop = true;
            this.ARadioButton.Text = "A : Excellent";
            this.ARadioButton.UseVisualStyleBackColor = true;
            // 
            // BRadioButton
            // 
            this.BRadioButton.AutoSize = true;
            this.BRadioButton.Location = new System.Drawing.Point(37, 403);
            this.BRadioButton.Name = "BRadioButton";
            this.BRadioButton.Size = new System.Drawing.Size(116, 20);
            this.BRadioButton.TabIndex = 22;
            this.BRadioButton.TabStop = true;
            this.BRadioButton.Text = "B : Satisfactory";
            this.BRadioButton.UseVisualStyleBackColor = true;
            // 
            // CRadioButton
            // 
            this.CRadioButton.AutoSize = true;
            this.CRadioButton.Location = new System.Drawing.Point(37, 429);
            this.CRadioButton.Name = "CRadioButton";
            this.CRadioButton.Size = new System.Drawing.Size(138, 20);
            this.CRadioButton.TabIndex = 23;
            this.CRadioButton.TabStop = true;
            this.CRadioButton.Text = "C : Below Average";
            this.CRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeeFirstNameTextBox
            // 
            this.employeeFirstNameTextBox.Location = new System.Drawing.Point(22, 43);
            this.employeeFirstNameTextBox.Name = "employeeFirstNameTextBox";
            this.employeeFirstNameTextBox.Size = new System.Drawing.Size(170, 22);
            this.employeeFirstNameTextBox.TabIndex = 24;
            // 
            // employeeLastNameTextBox
            // 
            this.employeeLastNameTextBox.Location = new System.Drawing.Point(22, 107);
            this.employeeLastNameTextBox.Name = "employeeLastNameTextBox";
            this.employeeLastNameTextBox.Size = new System.Drawing.Size(170, 22);
            this.employeeLastNameTextBox.TabIndex = 25;
            // 
            // employeeTypeTextBox
            // 
            this.employeeTypeTextBox.Location = new System.Drawing.Point(24, 175);
            this.employeeTypeTextBox.Name = "employeeTypeTextBox";
            this.employeeTypeTextBox.Size = new System.Drawing.Size(170, 22);
            this.employeeTypeTextBox.TabIndex = 26;
            // 
            // projectAssignedComboBox
            // 
            this.projectAssignedComboBox.FormattingEnabled = true;
            this.projectAssignedComboBox.Location = new System.Drawing.Point(22, 243);
            this.projectAssignedComboBox.Name = "projectAssignedComboBox";
            this.projectAssignedComboBox.Size = new System.Drawing.Size(170, 24);
            this.projectAssignedComboBox.TabIndex = 27;
            // 
            // employeeSalaryTextBox
            // 
            this.employeeSalaryTextBox.Location = new System.Drawing.Point(22, 310);
            this.employeeSalaryTextBox.Name = "employeeSalaryTextBox";
            this.employeeSalaryTextBox.Size = new System.Drawing.Size(170, 22);
            this.employeeSalaryTextBox.TabIndex = 28;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(22, 500);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(170, 38);
            this.updateButton.TabIndex = 29;
            this.updateButton.Text = "U&pdate";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateEmployeeDetailsGroupBox
            // 
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.DRadioButton);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.label6);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.updateButton);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.employeeFirstNameTextBox);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.CRadioButton);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.employeeSalaryTextBox);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.BRadioButton);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.label7);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.ARadioButton);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.projectAssignedComboBox);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.label11);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.employeeLastNameTextBox);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.employeeTypeTextBox);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.label8);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.label10);
            this.updateEmployeeDetailsGroupBox.Controls.Add(this.label9);
            this.updateEmployeeDetailsGroupBox.Location = new System.Drawing.Point(1326, 62);
            this.updateEmployeeDetailsGroupBox.Name = "updateEmployeeDetailsGroupBox";
            this.updateEmployeeDetailsGroupBox.Size = new System.Drawing.Size(221, 544);
            this.updateEmployeeDetailsGroupBox.TabIndex = 31;
            this.updateEmployeeDetailsGroupBox.TabStop = false;
            this.updateEmployeeDetailsGroupBox.Text = "Update Employee Details";
            // 
            // DRadioButton
            // 
            this.DRadioButton.AutoSize = true;
            this.DRadioButton.Location = new System.Drawing.Point(37, 455);
            this.DRadioButton.Name = "DRadioButton";
            this.DRadioButton.Size = new System.Drawing.Size(117, 20);
            this.DRadioButton.TabIndex = 30;
            this.DRadioButton.TabStop = true;
            this.DRadioButton.Text = "Not Applicable";
            this.DRadioButton.UseVisualStyleBackColor = true;
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 623);
            this.Controls.Add(this.updateEmployeeDetailsGroupBox);
            this.Controls.Add(this.OR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.employeeTypeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.employeeDescriptionLabel);
            this.Controls.Add(this.viewEmployeeDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchByEmployeeIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchByEmployeeNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            this.Load += new System.EventHandler(this.ViewEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployeeDataGridView)).EndInit();
            this.updateEmployeeDetailsGroupBox.ResumeLayout(false);
            this.updateEmployeeDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchByEmployeeNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchByEmployeeIdTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView viewEmployeeDataGridView;
        private System.Windows.Forms.Label employeeDescriptionLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox employeeTypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label OR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton ARadioButton;
        private System.Windows.Forms.RadioButton BRadioButton;
        private System.Windows.Forms.RadioButton CRadioButton;
        private System.Windows.Forms.TextBox employeeFirstNameTextBox;
        private System.Windows.Forms.TextBox employeeLastNameTextBox;
        private System.Windows.Forms.TextBox employeeTypeTextBox;
        private System.Windows.Forms.ComboBox projectAssignedComboBox;
        private System.Windows.Forms.TextBox employeeSalaryTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox updateEmployeeDetailsGroupBox;
        private System.Windows.Forms.RadioButton DRadioButton;
    }
}