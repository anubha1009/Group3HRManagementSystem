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
            this.components = new System.ComponentModel.Container();
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
            this.exitButton = new System.Windows.Forms.Button();
            this.addProjectDetailsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.resultLabel = new System.Windows.Forms.Label();
            this.allProjectDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hoursAllocatedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProjectDetailsErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Project Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Hours Allocated";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estimated Budget";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Project Description";
            // 
            // addProjectButton
            // 
            this.addProjectButton.Location = new System.Drawing.Point(36, 362);
            this.addProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Size = new System.Drawing.Size(145, 34);
            this.addProjectButton.TabIndex = 5;
            this.addProjectButton.Text = "&Submit";
            this.addProjectButton.UseVisualStyleBackColor = true;
            this.addProjectButton.Click += new System.EventHandler(this.addProjectButton_Click);
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(241, 62);
            this.projectNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(191, 22);
            this.projectNameTextBox.TabIndex = 6;
            // 
            // estimatedBudgetTextBox
            // 
            this.estimatedBudgetTextBox.Location = new System.Drawing.Point(241, 157);
            this.estimatedBudgetTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estimatedBudgetTextBox.Name = "estimatedBudgetTextBox";
            this.estimatedBudgetTextBox.Size = new System.Drawing.Size(191, 22);
            this.estimatedBudgetTextBox.TabIndex = 7;
            // 
            // hoursAllocatedNumericUpDown
            // 
            this.hoursAllocatedNumericUpDown.Location = new System.Drawing.Point(241, 108);
            this.hoursAllocatedNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hoursAllocatedNumericUpDown.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.hoursAllocatedNumericUpDown.Name = "hoursAllocatedNumericUpDown";
            this.hoursAllocatedNumericUpDown.Size = new System.Drawing.Size(191, 22);
            this.hoursAllocatedNumericUpDown.TabIndex = 9;
            // 
            // projectDescriptionRichTextBox
            // 
            this.projectDescriptionRichTextBox.Location = new System.Drawing.Point(241, 206);
            this.projectDescriptionRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectDescriptionRichTextBox.Name = "projectDescriptionRichTextBox";
            this.projectDescriptionRichTextBox.Size = new System.Drawing.Size(191, 84);
            this.projectDescriptionRichTextBox.TabIndex = 11;
            this.projectDescriptionRichTextBox.Text = "";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(296, 362);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(136, 33);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addProjectDetailsErrorProvider
            // 
            this.addProjectDetailsErrorProvider.ContainerControl = this;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Location = new System.Drawing.Point(36, 316);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(396, 34);
            this.resultLabel.TabIndex = 13;
            // 
            // allProjectDataGridView
            // 
            this.allProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allProjectDataGridView.Location = new System.Drawing.Point(468, 62);
            this.allProjectDataGridView.Name = "allProjectDataGridView";
            this.allProjectDataGridView.RowHeadersWidth = 51;
            this.allProjectDataGridView.RowTemplate.Height = 24;
            this.allProjectDataGridView.Size = new System.Drawing.Size(623, 333);
            this.allProjectDataGridView.TabIndex = 14;
            // 
            // AddProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 426);
            this.Controls.Add(this.allProjectDataGridView);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitButton);
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
            this.Load += new System.EventHandler(this.AddProjectDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoursAllocatedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProjectDetailsErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProjectDataGridView)).EndInit();
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
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ErrorProvider addProjectDetailsErrorProvider;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.DataGridView allProjectDataGridView;
    }
}