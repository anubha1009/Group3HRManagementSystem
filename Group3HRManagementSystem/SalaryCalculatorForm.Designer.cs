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
            this.label1.Location = new System.Drawing.Point(289, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Salary Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
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
            this.typeOfEmployeeComboBox.Location = new System.Drawing.Point(213, 77);
            this.typeOfEmployeeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeOfEmployeeComboBox.Name = "typeOfEmployeeComboBox";
            this.typeOfEmployeeComboBox.Size = new System.Drawing.Size(587, 24);
            this.typeOfEmployeeComboBox.TabIndex = 2;
            this.typeOfEmployeeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeOfEmployeeComboBox_SelectedIndexChanged);
            // 
            // CalculateSalaryButton
            // 
            this.CalculateSalaryButton.Location = new System.Drawing.Point(29, 394);
            this.CalculateSalaryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculateSalaryButton.Name = "CalculateSalaryButton";
            this.CalculateSalaryButton.Size = new System.Drawing.Size(163, 46);
            this.CalculateSalaryButton.TabIndex = 4;
            this.CalculateSalaryButton.Text = "Calculate &Salary";
            this.CalculateSalaryButton.UseVisualStyleBackColor = true;
            this.CalculateSalaryButton.Click += new System.EventHandler(this.CalculateSalaryButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(351, 394);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 46);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(29, 459);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(770, 48);
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
            this.contractEmployeeGroupBox.Location = new System.Drawing.Point(29, 123);
            this.contractEmployeeGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contractEmployeeGroupBox.Name = "contractEmployeeGroupBox";
            this.contractEmployeeGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contractEmployeeGroupBox.Size = new System.Drawing.Size(279, 134);
            this.contractEmployeeGroupBox.TabIndex = 7;
            this.contractEmployeeGroupBox.TabStop = false;
            this.contractEmployeeGroupBox.Text = "Contract Employee";
            // 
            // contractEndDateTimePicker
            // 
            this.contractEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.contractEndDateTimePicker.Location = new System.Drawing.Point(105, 59);
            this.contractEndDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contractEndDateTimePicker.Name = "contractEndDateTimePicker";
            this.contractEndDateTimePicker.Size = new System.Drawing.Size(130, 22);
            this.contractEndDateTimePicker.TabIndex = 7;
            // 
            // contractndDate
            // 
            this.contractndDate.AutoSize = true;
            this.contractndDate.Location = new System.Drawing.Point(10, 59);
            this.contractndDate.Name = "contractndDate";
            this.contractndDate.Size = new System.Drawing.Size(63, 16);
            this.contractndDate.TabIndex = 6;
            this.contractndDate.Text = "End Date";
            // 
            // contractStartDate
            // 
            this.contractStartDate.AutoSize = true;
            this.contractStartDate.Location = new System.Drawing.Point(10, 26);
            this.contractStartDate.Name = "contractStartDate";
            this.contractStartDate.Size = new System.Drawing.Size(66, 16);
            this.contractStartDate.TabIndex = 5;
            this.contractStartDate.Text = "Start Date";
            // 
            // contractStartDateTimePicker
            // 
            this.contractStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.contractStartDateTimePicker.Location = new System.Drawing.Point(105, 26);
            this.contractStartDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contractStartDateTimePicker.Name = "contractStartDateTimePicker";
            this.contractStartDateTimePicker.Size = new System.Drawing.Size(130, 22);
            this.contractStartDateTimePicker.TabIndex = 4;
            this.contractStartDateTimePicker.Value = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            // 
            // contractSalaryTextBox
            // 
            this.contractSalaryTextBox.Location = new System.Drawing.Point(105, 92);
            this.contractSalaryTextBox.Name = "contractSalaryTextBox";
            this.contractSalaryTextBox.Size = new System.Drawing.Size(130, 22);
            this.contractSalaryTextBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Pay Rate(/hr)";
            // 
            // hoursWorkedtextBox
            // 
            this.hoursWorkedtextBox.Location = new System.Drawing.Point(119, 79);
            this.hoursWorkedtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursWorkedtextBox.Name = "hoursWorkedtextBox";
            this.hoursWorkedtextBox.Size = new System.Drawing.Size(89, 22);
            this.hoursWorkedtextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hours Worked";
            // 
            // hourlyWagetextBox
            // 
            this.hourlyWagetextBox.Location = new System.Drawing.Point(119, 35);
            this.hourlyWagetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hourlyWagetextBox.Name = "hourlyWagetextBox";
            this.hourlyWagetextBox.Size = new System.Drawing.Size(89, 22);
            this.hourlyWagetextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pay Rate(/hr)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Duration(hrs)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Pay Rate(/hr)";
            // 
            // fixedSalaryLabel
            // 
            this.fixedSalaryLabel.AutoSize = true;
            this.fixedSalaryLabel.Location = new System.Drawing.Point(26, 269);
            this.fixedSalaryLabel.Name = "fixedSalaryLabel";
            this.fixedSalaryLabel.Size = new System.Drawing.Size(122, 16);
            this.fixedSalaryLabel.TabIndex = 6;
            this.fixedSalaryLabel.Text = "Fixed Pay Rate(/hr)";
            // 
            // payRateTextBox
            // 
            this.payRateTextBox.Location = new System.Drawing.Point(103, 79);
            this.payRateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payRateTextBox.Name = "payRateTextBox";
            this.payRateTextBox.Size = new System.Drawing.Size(89, 22);
            this.payRateTextBox.TabIndex = 7;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(103, 40);
            this.durationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(89, 22);
            this.durationTextBox.TabIndex = 8;
            // 
            // fixedSalaryTextBox
            // 
            this.fixedSalaryTextBox.Location = new System.Drawing.Point(191, 266);
            this.fixedSalaryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fixedSalaryTextBox.Name = "fixedSalaryTextBox";
            this.fixedSalaryTextBox.Size = new System.Drawing.Size(609, 22);
            this.fixedSalaryTextBox.TabIndex = 9;
            // 
            // tempContractEmployeeGroupBox
            // 
            this.tempContractEmployeeGroupBox.Controls.Add(this.label6);
            this.tempContractEmployeeGroupBox.Controls.Add(this.label7);
            this.tempContractEmployeeGroupBox.Controls.Add(this.durationTextBox);
            this.tempContractEmployeeGroupBox.Controls.Add(this.payRateTextBox);
            this.tempContractEmployeeGroupBox.Location = new System.Drawing.Point(326, 123);
            this.tempContractEmployeeGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tempContractEmployeeGroupBox.Name = "tempContractEmployeeGroupBox";
            this.tempContractEmployeeGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tempContractEmployeeGroupBox.Size = new System.Drawing.Size(212, 134);
            this.tempContractEmployeeGroupBox.TabIndex = 10;
            this.tempContractEmployeeGroupBox.TabStop = false;
            this.tempContractEmployeeGroupBox.Text = "Temp Contract Employee";
            // 
            // noteLabel
            // 
            this.noteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.noteLabel.Location = new System.Drawing.Point(29, 309);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(770, 68);
            this.noteLabel.TabIndex = 9;
            // 
            // salaryCalculatorErrorProvider
            // 
            this.salaryCalculatorErrorProvider.ContainerControl = this;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(687, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 46);
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
            this.hourlyEmployeeGroupBox.Location = new System.Drawing.Point(570, 123);
            this.hourlyEmployeeGroupBox.Name = "hourlyEmployeeGroupBox";
            this.hourlyEmployeeGroupBox.Size = new System.Drawing.Size(230, 134);
            this.hourlyEmployeeGroupBox.TabIndex = 12;
            this.hourlyEmployeeGroupBox.TabStop = false;
            this.hourlyEmployeeGroupBox.Text = "Hourly Employee";
            // 
            // SalaryCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 529);
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