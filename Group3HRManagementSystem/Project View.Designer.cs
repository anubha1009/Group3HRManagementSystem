namespace Group3HRManagementSystem
{
    partial class Project_View
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
            this.getEmployeesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.employeeListDataGridView = new System.Windows.Forms.DataGridView();
            this.errorLabel = new System.Windows.Forms.Label();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Project Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Project";
            // 
            // getEmployeesButton
            // 
            this.getEmployeesButton.Location = new System.Drawing.Point(96, 160);
            this.getEmployeesButton.Name = "getEmployeesButton";
            this.getEmployeesButton.Size = new System.Drawing.Size(116, 23);
            this.getEmployeesButton.TabIndex = 5;
            this.getEmployeesButton.Text = "&Get Employees";
            this.getEmployeesButton.UseVisualStyleBackColor = true;
            this.getEmployeesButton.Click += new System.EventHandler(this.getEmployeesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(96, 316);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // employeeListDataGridView
            // 
            this.employeeListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeListDataGridView.Location = new System.Drawing.Point(84, 367);
            this.employeeListDataGridView.Name = "employeeListDataGridView";
            this.employeeListDataGridView.RowHeadersWidth = 51;
            this.employeeListDataGridView.RowTemplate.Height = 24;
            this.employeeListDataGridView.Size = new System.Drawing.Size(711, 192);
            this.employeeListDataGridView.TabIndex = 8;
            // 
            // errorLabel
            // 
            this.errorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errorLabel.Location = new System.Drawing.Point(84, 580);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(711, 23);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "Please click on Get Employees button to see all the employees working under the s" +
    "elected project.";
            // 
            // projectComboBox
            // 
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(223, 98);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(572, 24);
            this.projectComboBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Duration (in hrs)";
            // 
            // durationLabel
            // 
            this.durationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.durationLabel.Location = new System.Drawing.Point(277, 193);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(141, 23);
            this.durationLabel.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Budget";
            // 
            // budgetLabel
            // 
            this.budgetLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.budgetLabel.Location = new System.Drawing.Point(277, 316);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(141, 23);
            this.budgetLabel.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Project Description:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptionLabel.Location = new System.Drawing.Point(566, 193);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(229, 146);
            this.descriptionLabel.TabIndex = 17;
            // 
            // Project_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 624);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.employeeListDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getEmployeesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Project_View";
            this.Text = "ProjectView";
            this.Load += new System.EventHandler(this.Project_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getEmployeesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView employeeListDataGridView;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label descriptionLabel;
    }
}