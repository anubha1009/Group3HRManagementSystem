namespace Group3HRManagementSystem
{
    partial class ProjectView
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
            this.searchProjectByNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchByIdTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.viewProjectDataGridView = new System.Windows.Forms.DataGridView();
            this.projectDescriptionLabel = new System.Windows.Forms.Label();
            this.viewProjectErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewProjectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProjectErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Project Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Project By Name";
            // 
            // searchProjectByNameTextBox
            // 
            this.searchProjectByNameTextBox.Location = new System.Drawing.Point(437, 102);
            this.searchProjectByNameTextBox.Name = "searchProjectByNameTextBox";
            this.searchProjectByNameTextBox.Size = new System.Drawing.Size(246, 22);
            this.searchProjectByNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search By ID";
            // 
            // searchByIdTextBox
            // 
            this.searchByIdTextBox.Location = new System.Drawing.Point(437, 151);
            this.searchByIdTextBox.Name = "searchByIdTextBox";
            this.searchByIdTextBox.Size = new System.Drawing.Size(246, 22);
            this.searchByIdTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(135, 186);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(379, 186);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(608, 186);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // viewProjectDataGridView
            // 
            this.viewProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProjectDataGridView.Location = new System.Drawing.Point(114, 294);
            this.viewProjectDataGridView.Name = "viewProjectDataGridView";
            this.viewProjectDataGridView.RowHeadersWidth = 51;
            this.viewProjectDataGridView.RowTemplate.Height = 24;
            this.viewProjectDataGridView.Size = new System.Drawing.Size(580, 101);
            this.viewProjectDataGridView.TabIndex = 8;
            // 
            // projectDescriptionLabel
            // 
            this.projectDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectDescriptionLabel.Location = new System.Drawing.Point(114, 411);
            this.projectDescriptionLabel.Name = "projectDescriptionLabel";
            this.projectDescriptionLabel.Size = new System.Drawing.Size(580, 122);
            this.projectDescriptionLabel.TabIndex = 9;
            // 
            // viewProjectErrorProvider
            // 
            this.viewProjectErrorProvider.ContainerControl = this;
            // 
            // errorLabel
            // 
            this.errorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.errorLabel.Location = new System.Drawing.Point(114, 251);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(580, 23);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "No Error";
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 562);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.projectDescriptionLabel);
            this.Controls.Add(this.viewProjectDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchByIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchProjectByNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProjectView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectView";
            this.Load += new System.EventHandler(this.ProjectView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewProjectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProjectErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchProjectByNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchByIdTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView viewProjectDataGridView;
        private System.Windows.Forms.Label projectDescriptionLabel;
        private System.Windows.Forms.ErrorProvider viewProjectErrorProvider;
        private System.Windows.Forms.Label errorLabel;
    }
}