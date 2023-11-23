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
            this.searchProjectByNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchProjectByIdTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.projectViewDataGridView = new System.Windows.Forms.DataGridView();
            this.projectViewDescriptionLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectViewDataGridView)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(93, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Project By Name";
            // 
            // searchProjectByNameTextBox
            // 
            this.searchProjectByNameTextBox.Location = new System.Drawing.Point(395, 94);
            this.searchProjectByNameTextBox.Name = "searchProjectByNameTextBox";
            this.searchProjectByNameTextBox.Size = new System.Drawing.Size(246, 22);
            this.searchProjectByNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search By ID";
            // 
            // searchProjectByIdTextBox
            // 
            this.searchProjectByIdTextBox.Location = new System.Drawing.Point(395, 149);
            this.searchProjectByIdTextBox.Name = "searchProjectByIdTextBox";
            this.searchProjectByIdTextBox.Size = new System.Drawing.Size(246, 22);
            this.searchProjectByIdTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(96, 190);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(314, 190);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(540, 190);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(101, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // projectViewDataGridView
            // 
            this.projectViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectViewDataGridView.Location = new System.Drawing.Point(84, 286);
            this.projectViewDataGridView.Name = "projectViewDataGridView";
            this.projectViewDataGridView.RowHeadersWidth = 51;
            this.projectViewDataGridView.RowTemplate.Height = 24;
            this.projectViewDataGridView.Size = new System.Drawing.Size(586, 142);
            this.projectViewDataGridView.TabIndex = 8;
            // 
            // projectViewDescriptionLabel
            // 
            this.projectViewDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectViewDescriptionLabel.Location = new System.Drawing.Point(84, 443);
            this.projectViewDescriptionLabel.Name = "projectViewDescriptionLabel";
            this.projectViewDescriptionLabel.Size = new System.Drawing.Size(586, 51);
            this.projectViewDescriptionLabel.TabIndex = 9;
            // 
            // errorLabel
            // 
            this.errorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errorLabel.Location = new System.Drawing.Point(84, 237);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(586, 23);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "No Error";
            // 
            // Project_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 641);
            this.Controls.Add(this.errorLabel);
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
            this.Name = "Project_View";
            this.Text = "ProjectView";
            this.Load += new System.EventHandler(this.Project_View_Load);
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
        private System.Windows.Forms.Label errorLabel;
    }
}