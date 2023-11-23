﻿namespace Group3HRManagementSystem
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
            this.searchProjectByNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchProjectByIdTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.projectViewDataGridView = new System.Windows.Forms.DataGridView();
            this.projectViewDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Project Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Project By Name";
            // 
            // searchProjectByNameTextBox
            // 
            this.searchProjectByNameTextBox.Location = new System.Drawing.Point(444, 117);
            this.searchProjectByNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchProjectByNameTextBox.Name = "searchProjectByNameTextBox";
            this.searchProjectByNameTextBox.Size = new System.Drawing.Size(276, 26);
            this.searchProjectByNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search By ID";
            // 
            // searchProjectByIdTextBox
            // 
            this.searchProjectByIdTextBox.Location = new System.Drawing.Point(444, 186);
            this.searchProjectByIdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchProjectByIdTextBox.Name = "searchProjectByIdTextBox";
            this.searchProjectByIdTextBox.Size = new System.Drawing.Size(276, 26);
            this.searchProjectByIdTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(109, 265);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(130, 29);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(350, 265);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 29);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(606, 265);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 29);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // projectViewDataGridView
            // 
            this.projectViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectViewDataGridView.Location = new System.Drawing.Point(94, 317);
            this.projectViewDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.projectViewDataGridView.Name = "projectViewDataGridView";
            this.projectViewDataGridView.RowHeadersWidth = 51;
            this.projectViewDataGridView.RowTemplate.Height = 24;
            this.projectViewDataGridView.Size = new System.Drawing.Size(659, 177);
            this.projectViewDataGridView.TabIndex = 8;
            // 
            // projectViewDescriptionLabel
            // 
            this.projectViewDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectViewDescriptionLabel.Location = new System.Drawing.Point(94, 518);
            this.projectViewDescriptionLabel.Name = "projectViewDescriptionLabel";
            this.projectViewDescriptionLabel.Size = new System.Drawing.Size(659, 148);
            this.projectViewDescriptionLabel.TabIndex = 9;
            // 
            // Project_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 801);
            this.Controls.Add(this.projectViewDescriptionLabel);
            this.Controls.Add(this.projectViewDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchProjectByIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchProjectByNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Project_View";
            this.Text = "ProjectView";
            ((System.ComponentModel.ISupportInitialize)(this.projectViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchProjectByNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchProjectByIdTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView projectViewDataGridView;
        private System.Windows.Forms.Label projectViewDescriptionLabel;
    }
}