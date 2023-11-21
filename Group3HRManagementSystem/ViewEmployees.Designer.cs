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
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployeeDataGridView)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(103, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search By Employee Name";
            // 
            // searchByEmployeeNameTextBox
            // 
            this.searchByEmployeeNameTextBox.Location = new System.Drawing.Point(346, 92);
            this.searchByEmployeeNameTextBox.Name = "searchByEmployeeNameTextBox";
            this.searchByEmployeeNameTextBox.Size = new System.Drawing.Size(240, 22);
            this.searchByEmployeeNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search By Employee ID";
            // 
            // searchByEmployeeIdTextBox
            // 
            this.searchByEmployeeIdTextBox.Location = new System.Drawing.Point(346, 126);
            this.searchByEmployeeIdTextBox.Name = "searchByEmployeeIdTextBox";
            this.searchByEmployeeIdTextBox.Size = new System.Drawing.Size(240, 22);
            this.searchByEmployeeIdTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(106, 184);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(326, 184);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(518, 184);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // viewEmployeeDataGridView
            // 
            this.viewEmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewEmployeeDataGridView.Location = new System.Drawing.Point(106, 262);
            this.viewEmployeeDataGridView.Name = "viewEmployeeDataGridView";
            this.viewEmployeeDataGridView.RowHeadersWidth = 51;
            this.viewEmployeeDataGridView.RowTemplate.Height = 24;
            this.viewEmployeeDataGridView.Size = new System.Drawing.Size(732, 136);
            this.viewEmployeeDataGridView.TabIndex = 8;
            // 
            // employeeDescriptionLabel
            // 
            this.employeeDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.employeeDescriptionLabel.Location = new System.Drawing.Point(106, 423);
            this.employeeDescriptionLabel.Name = "employeeDescriptionLabel";
            this.employeeDescriptionLabel.Size = new System.Drawing.Size(732, 109);
            this.employeeDescriptionLabel.TabIndex = 9;
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 558);
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
            ((System.ComponentModel.ISupportInitialize)(this.viewEmployeeDataGridView)).EndInit();
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
    }
}