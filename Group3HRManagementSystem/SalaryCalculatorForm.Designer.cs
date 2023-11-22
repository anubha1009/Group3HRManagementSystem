namespace Group3HRManagementSystem
{
    partial class SalaryCalculatorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeOfEmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.CalculateSalaryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.contractEmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.contractEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contractndDate = new System.Windows.Forms.Label();
            this.contractStartDate = new System.Windows.Forms.Label();
            this.contractStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contractSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hoursWorkedtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hourlyWagetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fixedSalaryLabel = new System.Windows.Forms.Label();
            this.payRateTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.fixedSalaryTextBox = new System.Windows.Forms.TextBox();
            this.tempContractEmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.salaryCalculatorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.hourlyEmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.contractEmployeeGroupBox.SuspendLayout();
            this.tempContractEmployeeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryCalculatorErrorProvider)).BeginInit();
            this.hourlyEmployeeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Salary Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Type Of Employee";
            // 
            // typeOfEmployeeComboBox
            // 
            this.typeOfEmployeeComboBox.FormattingEnabled = true;
            this.typeOfEmployeeComboBox.Items.AddRange(new object[] {
            "Contract Employee",
            "Temp Contract Employee",
            "Salaried Employee",
            "HourlyEmployee"});
            this.typeOfEmployeeComboBox.Location = new System.Drawing.Point(274, 96);
            this.typeOfEmployeeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeOfEmployeeComboBox.Name = "typeOfEmployeeComboBox";
            this.typeOfEmployeeComboBox.Size = new System.Drawing.Size(625, 28);
            this.typeOfEmployeeComboBox.TabIndex = 2;
            this.typeOfEmployeeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeOfEmployeeComboBox_SelectedIndexChanged);
            // 
            // CalculateSalaryButton
            // 
            this.CalculateSalaryButton.Location = new System.Drawing.Point(75, 505);
            this.CalculateSalaryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculateSalaryButton.Name = "CalculateSalaryButton";
            this.CalculateSalaryButton.Size = new System.Drawing.Size(183, 34);
            this.CalculateSalaryButton.TabIndex = 4;
            this.CalculateSalaryButton.Text = "Calculate &Salary";
            this.CalculateSalaryButton.UseVisualStyleBackColor = true;
            this.CalculateSalaryButton.Click += new System.EventHandler(this.CalculateSalaryButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(393, 505);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(130, 34);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Location = new System.Drawing.Point(73, 560);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(826, 60);
            this.resultLabel.TabIndex = 6;
            // 
            // contractEmployeeGroupBox
            // 
            this.contractEmployeeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contractEmployeeGroupBox.AutoSize = true;
            this.contractEmployeeGroupBox.Controls.Add(this.contractEndDateTimePicker);
            this.contractEmployeeGroupBox.Controls.Add(this.contractndDate);
            this.contractEmployeeGroupBox.Controls.Add(this.contractStartDate);
            this.contractEmployeeGroupBox.Controls.Add(this.contractStartDateTimePicker);
            this.contractEmployeeGroupBox.Controls.Add(this.contractSalaryTextBox);
            this.contractEmployeeGroupBox.Controls.Add(this.label8);
            this.contractEmployeeGroupBox.Location = new System.Drawing.Point(12, 154);
            this.contractEmployeeGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contractEmployeeGroupBox.Name = "contractEmployeeGroupBox";
            this.contractEmployeeGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contractEmployeeGroupBox.Size = new System.Drawing.Size(314, 166);
            this.contractEmployeeGroupBox.TabIndex = 7;
            this.contractEmployeeGroupBox.TabStop = false;
            this.contractEmployeeGroupBox.Text = "Contract Employee";
            // 
            // contractEndDateTimePicker
            // 
            this.contractEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.contractEndDateTimePicker.Location = new System.Drawing.Point(100, 71);
            this.contractEndDateTimePicker.Name = "contractEndDateTimePicker";
            this.contractEndDateTimePicker.Size = new System.Drawing.Size(146, 26);
            this.contractEndDateTimePicker.TabIndex = 7;
            // 
            // contractndDate
            // 
            this.contractndDate.AutoSize = true;
            this.contractndDate.Location = new System.Drawing.Point(11, 74);
            this.contractndDate.Name = "contractndDate";
            this.contractndDate.Size = new System.Drawing.Size(77, 20);
            this.contractndDate.TabIndex = 6;
            this.contractndDate.Text = "End Date";
            // 
            // contractStartDate
            // 
            this.contractStartDate.AutoSize = true;
            this.contractStartDate.Location = new System.Drawing.Point(11, 33);
            this.contractStartDate.Name = "contractStartDate";
            this.contractStartDate.Size = new System.Drawing.Size(83, 20);
            this.contractStartDate.TabIndex = 5;
            this.contractStartDate.Text = "Start Date";
            // 
            // contractStartDateTimePicker
            // 
            this.contractStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.contractStartDateTimePicker.Location = new System.Drawing.Point(100, 32);
            this.contractStartDateTimePicker.Name = "contractStartDateTimePicker";
            this.contractStartDateTimePicker.Size = new System.Drawing.Size(146, 26);
            this.contractStartDateTimePicker.TabIndex = 4;
            this.contractStartDateTimePicker.Value = new System.DateTime(2023, 12, 19, 0, 0, 0, 0);
            // 
            // contractSalaryTextBox
            // 
            this.contractSalaryTextBox.Location = new System.Drawing.Point(102, 115);
            this.contractSalaryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contractSalaryTextBox.Name = "contractSalaryTextBox";
            this.contractSalaryTextBox.Size = new System.Drawing.Size(112, 26);
            this.contractSalaryTextBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Salary";
            // 
            // hoursWorkedtextBox
            // 
            this.hoursWorkedtextBox.Location = new System.Drawing.Point(134, 99);
            this.hoursWorkedtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursWorkedtextBox.Name = "hoursWorkedtextBox";
            this.hoursWorkedtextBox.Size = new System.Drawing.Size(100, 26);
            this.hoursWorkedtextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hours Worked";
            // 
            // hourlyWagetextBox
            // 
            this.hourlyWagetextBox.Location = new System.Drawing.Point(124, 48);
            this.hourlyWagetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hourlyWagetextBox.Name = "hourlyWagetextBox";
            this.hourlyWagetextBox.Size = new System.Drawing.Size(100, 26);
            this.hourlyWagetextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hourly Wage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Pay Rate";
            // 
            // fixedSalaryLabel
            // 
            this.fixedSalaryLabel.AutoSize = true;
            this.fixedSalaryLabel.Location = new System.Drawing.Point(71, 335);
            this.fixedSalaryLabel.Name = "fixedSalaryLabel";
            this.fixedSalaryLabel.Size = new System.Drawing.Size(95, 20);
            this.fixedSalaryLabel.TabIndex = 6;
            this.fixedSalaryLabel.Text = "Fixed Salary";
            // 
            // payRateTextBox
            // 
            this.payRateTextBox.Location = new System.Drawing.Point(107, 86);
            this.payRateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payRateTextBox.Name = "payRateTextBox";
            this.payRateTextBox.Size = new System.Drawing.Size(100, 26);
            this.payRateTextBox.TabIndex = 7;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(107, 38);
            this.durationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 26);
            this.durationTextBox.TabIndex = 8;
            // 
            // fixedSalaryTextBox
            // 
            this.fixedSalaryTextBox.Location = new System.Drawing.Point(188, 332);
            this.fixedSalaryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fixedSalaryTextBox.Name = "fixedSalaryTextBox";
            this.fixedSalaryTextBox.Size = new System.Drawing.Size(712, 26);
            this.fixedSalaryTextBox.TabIndex = 9;
            // 
            // tempContractEmployeeGroupBox
            // 
            this.tempContractEmployeeGroupBox.Controls.Add(this.label6);
            this.tempContractEmployeeGroupBox.Controls.Add(this.label7);
            this.tempContractEmployeeGroupBox.Controls.Add(this.durationTextBox);
            this.tempContractEmployeeGroupBox.Controls.Add(this.payRateTextBox);
            this.tempContractEmployeeGroupBox.Location = new System.Drawing.Point(367, 167);
            this.tempContractEmployeeGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tempContractEmployeeGroupBox.Name = "tempContractEmployeeGroupBox";
            this.tempContractEmployeeGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tempContractEmployeeGroupBox.Size = new System.Drawing.Size(239, 147);
            this.tempContractEmployeeGroupBox.TabIndex = 10;
            this.tempContractEmployeeGroupBox.TabStop = false;
            this.tempContractEmployeeGroupBox.Text = "Temp Contract Employee";
            // 
            // noteLabel
            // 
            this.noteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.noteLabel.Location = new System.Drawing.Point(73, 386);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(826, 85);
            this.noteLabel.TabIndex = 9;
            // 
            // salaryCalculatorErrorProvider
            // 
            this.salaryCalculatorErrorProvider.ContainerControl = this;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(728, 505);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 29);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // hourlyEmployeeGroupBox
            // 
            this.hourlyEmployeeGroupBox.Controls.Add(this.hoursWorkedtextBox);
            this.hourlyEmployeeGroupBox.Controls.Add(this.label4);
            this.hourlyEmployeeGroupBox.Controls.Add(this.label5);
            this.hourlyEmployeeGroupBox.Controls.Add(this.hourlyWagetextBox);
            this.hourlyEmployeeGroupBox.Location = new System.Drawing.Point(641, 154);
            this.hourlyEmployeeGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hourlyEmployeeGroupBox.Name = "hourlyEmployeeGroupBox";
            this.hourlyEmployeeGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hourlyEmployeeGroupBox.Size = new System.Drawing.Size(259, 160);
            this.hourlyEmployeeGroupBox.TabIndex = 12;
            this.hourlyEmployeeGroupBox.TabStop = false;
            this.hourlyEmployeeGroupBox.Text = "Hourly Employee";
            // 
            // SalaryCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 629);
            this.Controls.Add(this.hourlyEmployeeGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.tempContractEmployeeGroupBox);
            this.Controls.Add(this.fixedSalaryLabel);
            this.Controls.Add(this.fixedSalaryTextBox);
            this.Controls.Add(this.contractEmployeeGroupBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CalculateSalaryButton);
            this.Controls.Add(this.typeOfEmployeeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalaryCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Calculator Form";
            this.Load += new System.EventHandler(this.SalaryCalculatorForm_Load);
            this.contractEmployeeGroupBox.ResumeLayout(false);
            this.contractEmployeeGroupBox.PerformLayout();
            this.tempContractEmployeeGroupBox.ResumeLayout(false);
            this.tempContractEmployeeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryCalculatorErrorProvider)).EndInit();
            this.hourlyEmployeeGroupBox.ResumeLayout(false);
            this.hourlyEmployeeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeOfEmployeeComboBox;
        private System.Windows.Forms.Button CalculateSalaryButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.GroupBox contractEmployeeGroupBox;
        private System.Windows.Forms.Label fixedSalaryLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hoursWorkedtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hourlyWagetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fixedSalaryTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox payRateTextBox;
        private System.Windows.Forms.GroupBox tempContractEmployeeGroupBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.ErrorProvider salaryCalculatorErrorProvider;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox hourlyEmployeeGroupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox contractSalaryTextBox;
        private System.Windows.Forms.DateTimePicker contractStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker contractEndDateTimePicker;
        private System.Windows.Forms.Label contractndDate;
        private System.Windows.Forms.Label contractStartDate;
    }
}