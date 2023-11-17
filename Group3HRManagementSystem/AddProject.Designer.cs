namespace Group3HRManagementSystem
{
    partial class AddProjectDetails
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addProjectButton = new System.Windows.Forms.Button();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.estimatedBudgetTextBox = new System.Windows.Forms.TextBox();
            this.hoursAllocatedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.projectDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hoursAllocatedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Project Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Hours Allocated";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estimated Budget";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Project Description";
            // 
            // addProjectButton
            // 
            this.addProjectButton.Location = new System.Drawing.Point(284, 379);
            this.addProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Size = new System.Drawing.Size(163, 42);
            this.addProjectButton.TabIndex = 5;
            this.addProjectButton.Text = "Submit";
            this.addProjectButton.UseVisualStyleBackColor = true;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(420, 78);
            this.projectNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(342, 26);
            this.projectNameTextBox.TabIndex = 6;
            // 
            // estimatedBudgetTextBox
            // 
            this.estimatedBudgetTextBox.Location = new System.Drawing.Point(420, 201);
            this.estimatedBudgetTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estimatedBudgetTextBox.Name = "estimatedBudgetTextBox";
            this.estimatedBudgetTextBox.Size = new System.Drawing.Size(342, 26);
            this.estimatedBudgetTextBox.TabIndex = 7;
            // 
            // hoursAllocatedNumericUpDown
            // 
            this.hoursAllocatedNumericUpDown.Location = new System.Drawing.Point(420, 140);
            this.hoursAllocatedNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursAllocatedNumericUpDown.Name = "hoursAllocatedNumericUpDown";
            this.hoursAllocatedNumericUpDown.Size = new System.Drawing.Size(342, 26);
            this.hoursAllocatedNumericUpDown.TabIndex = 9;
            // 
            // projectDescriptionRichTextBox
            // 
            this.projectDescriptionRichTextBox.Location = new System.Drawing.Point(420, 258);
            this.projectDescriptionRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectDescriptionRichTextBox.Name = "projectDescriptionRichTextBox";
            this.projectDescriptionRichTextBox.Size = new System.Drawing.Size(342, 104);
            this.projectDescriptionRichTextBox.TabIndex = 11;
            this.projectDescriptionRichTextBox.Text = "";
            // 
            // AddProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectDescriptionRichTextBox);
            this.Controls.Add(this.hoursAllocatedNumericUpDown);
            this.Controls.Add(this.estimatedBudgetTextBox);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.addProjectButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProjectDetails";
            this.Text = "Add Project";
            ((System.ComponentModel.ISupportInitialize)(this.hoursAllocatedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addProjectButton;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.TextBox estimatedBudgetTextBox;
        private System.Windows.Forms.NumericUpDown hoursAllocatedNumericUpDown;
        private System.Windows.Forms.RichTextBox projectDescriptionRichTextBox;
    }
}