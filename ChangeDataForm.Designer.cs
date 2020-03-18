namespace Fake_Dashboard
{
    partial class Editing
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.MarkTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.UPITextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.UPILabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeadingLabel.Location = new System.Drawing.Point(140, 40);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(389, 19);
            this.HeadingLabel.TabIndex = 1;
            this.HeadingLabel.Text = "Please Enter Student\'s UPI and Surname";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(428, 234);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(213, 234);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 10;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // MarkTextBox
            // 
            this.MarkTextBox.Location = new System.Drawing.Point(250, 190);
            this.MarkTextBox.Name = "MarkTextBox";
            this.MarkTextBox.Size = new System.Drawing.Size(316, 21);
            this.MarkTextBox.TabIndex = 7;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(250, 140);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(316, 21);
            this.SurnameTextBox.TabIndex = 8;
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MarkLabel.Location = new System.Drawing.Point(125, 192);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(59, 19);
            this.MarkLabel.TabIndex = 4;
            this.MarkLabel.Text = "Mark:";
            // 
            // UPITextBox
            // 
            this.UPITextBox.Location = new System.Drawing.Point(250, 84);
            this.UPITextBox.Name = "UPITextBox";
            this.UPITextBox.Size = new System.Drawing.Size(316, 21);
            this.UPITextBox.TabIndex = 9;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SurnameLabel.Location = new System.Drawing.Point(125, 142);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(89, 19);
            this.SurnameLabel.TabIndex = 5;
            this.SurnameLabel.Text = "Surname:";
            // 
            // UPILabel
            // 
            this.UPILabel.AutoSize = true;
            this.UPILabel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UPILabel.Location = new System.Drawing.Point(127, 86);
            this.UPILabel.Name = "UPILabel";
            this.UPILabel.Size = new System.Drawing.Size(49, 19);
            this.UPILabel.TabIndex = 6;
            this.UPILabel.Text = "UPI:";
            // 
            // Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 342);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.MarkTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.UPITextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.UPILabel);
            this.Controls.Add(this.HeadingLabel);
            this.Name = "Editing";
            this.Text = "ChangeDataForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editing_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox MarkTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.TextBox UPITextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label UPILabel;
    }
}