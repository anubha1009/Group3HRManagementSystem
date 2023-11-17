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
            this.label4 = new System.Windows.Forms.Label();
            this.hourlyWagetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hoursWorkedtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fixedSalaryLabel = new System.Windows.Forms.Label();
            this.contractPeriodtextBox = new System.Windows.Forms.TextBox();
            this.payRateTextBox = new System.Windows.Forms.TextBox();
            this.fixedSalaryTextBox = new System.Windows.Forms.TextBox();
            this.tempContractEmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.salaryCalculatorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contractEmployeeGroupBox.SuspendLayout();
            this.tempContractEmployeeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryCalculatorErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Salary Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 63);
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
            "Salaried Employee"});
            this.typeOfEmployeeComboBox.Location = new System.Drawing.Point(410, 63);
            this.typeOfEmployeeComboBox.Name = "typeOfEmployeeComboBox";
            this.typeOfEmployeeComboBox.Size = new System.Drawing.Size(121, 28);
            this.typeOfEmployeeComboBox.TabIndex = 2;
            this.typeOfEmployeeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeOfEmployeeComboBox_SelectedIndexChanged);
            // 
            // CalculateSalaryButton
            // 
            this.CalculateSalaryButton.Location = new System.Drawing.Point(176, 344);
            this.CalculateSalaryButton.Name = "CalculateSalaryButton";
            this.CalculateSalaryButton.Size = new System.Drawing.Size(183, 34);
            this.CalculateSalaryButton.TabIndex = 4;
            this.CalculateSalaryButton.Text = "Calculate Salary";
            this.CalculateSalaryButton.UseVisualStyleBackColor = true;
            this.CalculateSalaryButton.Click += new System.EventHandler(this.CalculateSalaryButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(411, 344);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(130, 34);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(176, 381);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(457, 60);
            this.resultLabel.TabIndex = 6;
            // 
            // contractEmployeeGroupBox
            // 
            this.contractEmployeeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contractEmployeeGroupBox.AutoSize = true;
            this.contractEmployeeGroupBox.Controls.Add(this.hoursWorkedtextBox);
            this.contractEmployeeGroupBox.Controls.Add(this.label5);
            this.contractEmployeeGroupBox.Controls.Add(this.hourlyWagetextBox);
            this.contractEmployeeGroupBox.Controls.Add(this.label4);
            this.contractEmployeeGroupBox.Location = new System.Drawing.Point(30, 108);
            this.contractEmployeeGroupBox.Name = "contractEmployeeGroupBox";
            this.contractEmployeeGroupBox.Size = new System.Drawing.Size(370, 125);
            this.contractEmployeeGroupBox.TabIndex = 7;
            this.contractEmployeeGroupBox.TabStop = false;
            this.contractEmployeeGroupBox.Text = "Contract Employee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hourly Wage";
            // 
            // hourlyWagetextBox
            // 
            this.hourlyWagetextBox.Location = new System.Drawing.Point(165, 36);
            this.hourlyWagetextBox.Name = "hourlyWagetextBox";
            this.hourlyWagetextBox.Size = new System.Drawing.Size(100, 26);
            this.hourlyWagetextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hours Worked";
            // 
            // hoursWorkedtextBox
            // 
            this.hoursWorkedtextBox.Location = new System.Drawing.Point(165, 74);
            this.hoursWorkedtextBox.Name = "hoursWorkedtextBox";
            this.hoursWorkedtextBox.Size = new System.Drawing.Size(100, 26);
            this.hoursWorkedtextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Contract Period(In days)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Pay Rate";
            // 
            // fixedSalaryLabel
            // 
            this.fixedSalaryLabel.AutoSize = true;
            this.fixedSalaryLabel.Location = new System.Drawing.Point(276, 251);
            this.fixedSalaryLabel.Name = "fixedSalaryLabel";
            this.fixedSalaryLabel.Size = new System.Drawing.Size(95, 20);
            this.fixedSalaryLabel.TabIndex = 6;
            this.fixedSalaryLabel.Text = "Fixed Salary";
            // 
            // contractPeriodtextBox
            // 
            this.contractPeriodtextBox.Location = new System.Drawing.Point(187, 62);
            this.contractPeriodtextBox.Name = "contractPeriodtextBox";
            this.contractPeriodtextBox.Size = new System.Drawing.Size(100, 26);
            this.contractPeriodtextBox.TabIndex = 7;
            // 
            // payRateTextBox
            // 
            this.payRateTextBox.Location = new System.Drawing.Point(187, 30);
            this.payRateTextBox.Name = "payRateTextBox";
            this.payRateTextBox.Size = new System.Drawing.Size(100, 26);
            this.payRateTextBox.TabIndex = 8;
            // 
            // fixedSalaryTextBox
            // 
            this.fixedSalaryTextBox.Location = new System.Drawing.Point(440, 248);
            this.fixedSalaryTextBox.Name = "fixedSalaryTextBox";
            this.fixedSalaryTextBox.Size = new System.Drawing.Size(100, 26);
            this.fixedSalaryTextBox.TabIndex = 9;
            // 
            // tempContractEmployeeGroupBox
            // 
            this.tempContractEmployeeGroupBox.Controls.Add(this.label6);
            this.tempContractEmployeeGroupBox.Controls.Add(this.label7);
            this.tempContractEmployeeGroupBox.Controls.Add(this.payRateTextBox);
            this.tempContractEmployeeGroupBox.Controls.Add(this.contractPeriodtextBox);
            this.tempContractEmployeeGroupBox.Location = new System.Drawing.Point(450, 118);
            this.tempContractEmployeeGroupBox.Name = "tempContractEmployeeGroupBox";
            this.tempContractEmployeeGroupBox.Size = new System.Drawing.Size(317, 115);
            this.tempContractEmployeeGroupBox.TabIndex = 10;
            this.tempContractEmployeeGroupBox.TabStop = false;
            this.tempContractEmployeeGroupBox.Text = "Temp Contract Employee";
            // 
            // noteLabel
            // 
            this.noteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noteLabel.Location = new System.Drawing.Point(176, 283);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(457, 58);
            this.noteLabel.TabIndex = 9;
            // 
            // salaryCalculatorErrorProvider
            // 
            this.salaryCalculatorErrorProvider.ContainerControl = this;
            // 
            // SalaryCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "SalaryCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Calculator Form";
            this.Load += new System.EventHandler(this.SalaryCalculatorForm_Load);
            this.contractEmployeeGroupBox.ResumeLayout(false);
            this.contractEmployeeGroupBox.PerformLayout();
            this.tempContractEmployeeGroupBox.ResumeLayout(false);
            this.tempContractEmployeeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryCalculatorErrorProvider)).EndInit();
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
        private System.Windows.Forms.TextBox payRateTextBox;
        private System.Windows.Forms.TextBox contractPeriodtextBox;
        private System.Windows.Forms.GroupBox tempContractEmployeeGroupBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.ErrorProvider salaryCalculatorErrorProvider;
    }
}