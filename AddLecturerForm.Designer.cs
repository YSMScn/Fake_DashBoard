namespace Fake_Dashboard
{
    partial class AddLecturerForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.UPITextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.UPILabel = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(444, 270);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(219, 270);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(256, 176);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(316, 21);
            this.SurnameTextBox.TabIndex = 9;
            // 
            // UPITextBox
            // 
            this.UPITextBox.Location = new System.Drawing.Point(256, 120);
            this.UPITextBox.Name = "UPITextBox";
            this.UPITextBox.Size = new System.Drawing.Size(316, 21);
            this.UPITextBox.TabIndex = 10;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SurnameLabel.Location = new System.Drawing.Point(131, 178);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(89, 19);
            this.SurnameLabel.TabIndex = 5;
            this.SurnameLabel.Text = "Surname:";
            // 
            // UPILabel
            // 
            this.UPILabel.AutoSize = true;
            this.UPILabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UPILabel.Location = new System.Drawing.Point(133, 122);
            this.UPILabel.Name = "UPILabel";
            this.UPILabel.Size = new System.Drawing.Size(49, 19);
            this.UPILabel.TabIndex = 6;
            this.UPILabel.Text = "UPI:";
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeadingLabel.Location = new System.Drawing.Point(169, 57);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(399, 19);
            this.HeadingLabel.TabIndex = 7;
            this.HeadingLabel.Text = "Please Enter Lecturer\'s UPI and Surname";
            // 
            // AddLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 342);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.UPITextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.UPILabel);
            this.Controls.Add(this.HeadingLabel);
            this.Name = "AddLecturerForm";
            this.Text = "AddLecturerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddLecturerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox UPITextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label UPILabel;
        private System.Windows.Forms.Label HeadingLabel;
    }
}