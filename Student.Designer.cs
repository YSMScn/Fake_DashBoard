namespace Fake_Dashboard
{
    partial class Student
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
            this.CourseLabel = new System.Windows.Forms.Label();
            this.StudentDataTable = new System.Windows.Forms.DataGridView();
            this.StudentsDetailButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(13, 13);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(41, 12);
            this.CourseLabel.TabIndex = 0;
            this.CourseLabel.Text = "Course";
            // 
            // StudentDataTable
            // 
            this.StudentDataTable.AllowUserToDeleteRows = false;
            this.StudentDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataTable.Location = new System.Drawing.Point(15, 39);
            this.StudentDataTable.Name = "StudentDataTable";
            this.StudentDataTable.RowTemplate.Height = 23;
            this.StudentDataTable.Size = new System.Drawing.Size(818, 519);
            this.StudentDataTable.TabIndex = 1;
            // 
            // StudentsDetailButton
            // 
            this.StudentsDetailButton.Location = new System.Drawing.Point(862, 39);
            this.StudentsDetailButton.Name = "StudentsDetailButton";
            this.StudentsDetailButton.Size = new System.Drawing.Size(117, 23);
            this.StudentsDetailButton.TabIndex = 2;
            this.StudentsDetailButton.Text = "Your Profile";
            this.StudentsDetailButton.UseVisualStyleBackColor = true;
            this.StudentsDetailButton.Click += new System.EventHandler(this.StudentsDetailButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(862, 605);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(117, 23);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.StudentsDetailButton);
            this.Controls.Add(this.StudentDataTable);
            this.Controls.Add(this.CourseLabel);
            this.Name = "Student";
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.DataGridView StudentDataTable;
        private System.Windows.Forms.Button StudentsDetailButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}