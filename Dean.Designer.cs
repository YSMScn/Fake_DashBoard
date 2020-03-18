namespace Fake_Dashboard
{
    partial class Dean
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
            this.StudentDataTable = new System.Windows.Forms.DataGridView();
            this.CourseNumComboBox = new System.Windows.Forms.ComboBox();
            this.AddNewStudentButton = new System.Windows.Forms.Button();
            this.ShowStatsButton = new System.Windows.Forms.Button();
            this.ChangeDataButton = new System.Windows.Forms.Button();
            this.LecturerDataTable = new System.Windows.Forms.DataGridView();
            this.StudentsLabel = new System.Windows.Forms.Label();
            this.LecturerLabel = new System.Windows.Forms.Label();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.AddLecturerButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentDataTable
            // 
            this.StudentDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataTable.Location = new System.Drawing.Point(21, 36);
            this.StudentDataTable.Name = "StudentDataTable";
            this.StudentDataTable.RowTemplate.Height = 23;
            this.StudentDataTable.Size = new System.Drawing.Size(746, 399);
            this.StudentDataTable.TabIndex = 0;
            // 
            // CourseNumComboBox
            // 
            this.CourseNumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CourseNumComboBox.FormattingEnabled = true;
            this.CourseNumComboBox.Location = new System.Drawing.Point(790, 12);
            this.CourseNumComboBox.Name = "CourseNumComboBox";
            this.CourseNumComboBox.Size = new System.Drawing.Size(194, 20);
            this.CourseNumComboBox.TabIndex = 1;
            this.CourseNumComboBox.SelectedIndexChanged += new System.EventHandler(this.CourseNumComboBox_SelectedIndexChanged);
            // 
            // AddNewStudentButton
            // 
            this.AddNewStudentButton.Location = new System.Drawing.Point(790, 51);
            this.AddNewStudentButton.Name = "AddNewStudentButton";
            this.AddNewStudentButton.Size = new System.Drawing.Size(194, 23);
            this.AddNewStudentButton.TabIndex = 2;
            this.AddNewStudentButton.Text = "Add Students To This Course";
            this.AddNewStudentButton.UseVisualStyleBackColor = true;
            this.AddNewStudentButton.Click += new System.EventHandler(this.AddNewStudentButton_Click);
            // 
            // ShowStatsButton
            // 
            this.ShowStatsButton.Location = new System.Drawing.Point(790, 172);
            this.ShowStatsButton.Name = "ShowStatsButton";
            this.ShowStatsButton.Size = new System.Drawing.Size(194, 23);
            this.ShowStatsButton.TabIndex = 3;
            this.ShowStatsButton.Text = "Show Stats";
            this.ShowStatsButton.UseVisualStyleBackColor = true;
            this.ShowStatsButton.Click += new System.EventHandler(this.ShowStatsButton_Click);
            // 
            // ChangeDataButton
            // 
            this.ChangeDataButton.Location = new System.Drawing.Point(790, 131);
            this.ChangeDataButton.Name = "ChangeDataButton";
            this.ChangeDataButton.Size = new System.Drawing.Size(194, 23);
            this.ChangeDataButton.TabIndex = 4;
            this.ChangeDataButton.Text = "Change Mark";
            this.ChangeDataButton.UseVisualStyleBackColor = true;
            this.ChangeDataButton.Click += new System.EventHandler(this.ChangeDataButton_Click);
            // 
            // LecturerDataTable
            // 
            this.LecturerDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LecturerDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturerDataTable.Location = new System.Drawing.Point(21, 477);
            this.LecturerDataTable.Name = "LecturerDataTable";
            this.LecturerDataTable.RowTemplate.Height = 23;
            this.LecturerDataTable.Size = new System.Drawing.Size(746, 137);
            this.LecturerDataTable.TabIndex = 5;
            // 
            // StudentsLabel
            // 
            this.StudentsLabel.AutoSize = true;
            this.StudentsLabel.Location = new System.Drawing.Point(21, 12);
            this.StudentsLabel.Name = "StudentsLabel";
            this.StudentsLabel.Size = new System.Drawing.Size(53, 12);
            this.StudentsLabel.TabIndex = 6;
            this.StudentsLabel.Text = "Students";
            // 
            // LecturerLabel
            // 
            this.LecturerLabel.AutoSize = true;
            this.LecturerLabel.Location = new System.Drawing.Point(21, 451);
            this.LecturerLabel.Name = "LecturerLabel";
            this.LecturerLabel.Size = new System.Drawing.Size(53, 12);
            this.LecturerLabel.TabIndex = 7;
            this.LecturerLabel.Text = "Lecturer";
            // 
            // ProfileButton
            // 
            this.ProfileButton.Location = new System.Drawing.Point(790, 210);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(194, 23);
            this.ProfileButton.TabIndex = 3;
            this.ProfileButton.Text = "Your Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // AddLecturerButton
            // 
            this.AddLecturerButton.Location = new System.Drawing.Point(790, 92);
            this.AddLecturerButton.Name = "AddLecturerButton";
            this.AddLecturerButton.Size = new System.Drawing.Size(194, 23);
            this.AddLecturerButton.TabIndex = 8;
            this.AddLecturerButton.Text = "Add Lecturer To This Course";
            this.AddLecturerButton.UseVisualStyleBackColor = true;
            this.AddLecturerButton.Click += new System.EventHandler(this.AddLecturerButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(867, 591);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(117, 23);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Dean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.AddLecturerButton);
            this.Controls.Add(this.LecturerLabel);
            this.Controls.Add(this.StudentsLabel);
            this.Controls.Add(this.LecturerDataTable);
            this.Controls.Add(this.ChangeDataButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.ShowStatsButton);
            this.Controls.Add(this.AddNewStudentButton);
            this.Controls.Add(this.CourseNumComboBox);
            this.Controls.Add(this.StudentDataTable);
            this.Name = "Dean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dean";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dean_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentDataTable;
        private System.Windows.Forms.ComboBox CourseNumComboBox;
        private System.Windows.Forms.Button AddNewStudentButton;
        private System.Windows.Forms.Button ShowStatsButton;
        private System.Windows.Forms.Button ChangeDataButton;
        private System.Windows.Forms.DataGridView LecturerDataTable;
        private System.Windows.Forms.Label StudentsLabel;
        private System.Windows.Forms.Label LecturerLabel;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button AddLecturerButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}