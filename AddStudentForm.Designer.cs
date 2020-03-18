namespace Fake_Dashboard
{
    partial class AddStudentForm
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
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.UPILabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.UPITextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.MarkTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeadingLabel.Location = new System.Drawing.Point(154, 40);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(389, 19);
            this.HeadingLabel.TabIndex = 0;
            this.HeadingLabel.Text = "Please Enter Student\'s UPI and Surname";
            // 
            // UPILabel
            // 
            this.UPILabel.AutoSize = true;
            this.UPILabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UPILabel.Location = new System.Drawing.Point(118, 105);
            this.UPILabel.Name = "UPILabel";
            this.UPILabel.Size = new System.Drawing.Size(49, 19);
            this.UPILabel.TabIndex = 0;
            this.UPILabel.Text = "UPI:";
            this.UPILabel.Click += new System.EventHandler(this.UPILabel_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SurnameLabel.Location = new System.Drawing.Point(116, 161);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(89, 19);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Surname:";
            this.SurnameLabel.Click += new System.EventHandler(this.SurnameLabel_Click);
            // 
            // UPITextBox
            // 
            this.UPITextBox.Location = new System.Drawing.Point(241, 103);
            this.UPITextBox.Name = "UPITextBox";
            this.UPITextBox.Size = new System.Drawing.Size(316, 21);
            this.UPITextBox.TabIndex = 1;
            this.UPITextBox.TextChanged += new System.EventHandler(this.UPITextBox_TextChanged);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(241, 159);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(316, 21);
            this.SurnameTextBox.TabIndex = 1;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(204, 253);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(429, 253);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MarkLabel.Location = new System.Drawing.Point(116, 211);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(59, 19);
            this.MarkLabel.TabIndex = 0;
            this.MarkLabel.Text = "Mark:";
            this.MarkLabel.Click += new System.EventHandler(this.MarkLabel_Click);
            // 
            // MarkTextBox
            // 
            this.MarkTextBox.Location = new System.Drawing.Point(241, 209);
            this.MarkTextBox.Name = "MarkTextBox";
            this.MarkTextBox.Size = new System.Drawing.Size(316, 21);
            this.MarkTextBox.TabIndex = 1;
            this.MarkTextBox.TextChanged += new System.EventHandler(this.MarkTextBox_TextChanged);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 342);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MarkTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.UPITextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.UPILabel);
            this.Controls.Add(this.HeadingLabel);
            this.Name = "AddStudentForm";
            this.Text = "Add Student To";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddStudentForm_FormClosed);
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label UPILabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox UPITextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.TextBox MarkTextBox;
    }
}