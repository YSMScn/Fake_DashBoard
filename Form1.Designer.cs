namespace Fake_Dashboard
{
    partial class DashBorad
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.UPILabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UPITextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginDetailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(310, 374);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(584, 374);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // UPILabel
            // 
            this.UPILabel.AutoSize = true;
            this.UPILabel.Location = new System.Drawing.Point(308, 155);
            this.UPILabel.Name = "UPILabel";
            this.UPILabel.Size = new System.Drawing.Size(29, 12);
            this.UPILabel.TabIndex = 2;
            this.UPILabel.Text = "UPI:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(308, 219);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(59, 12);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // UPITextBox
            // 
            this.UPITextBox.Location = new System.Drawing.Point(414, 155);
            this.UPITextBox.Name = "UPITextBox";
            this.UPITextBox.Size = new System.Drawing.Size(245, 21);
            this.UPITextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(414, 216);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(245, 21);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginDetailLabel
            // 
            this.LoginDetailLabel.AutoSize = true;
            this.LoginDetailLabel.Location = new System.Drawing.Point(308, 309);
            this.LoginDetailLabel.Name = "LoginDetailLabel";
            this.LoginDetailLabel.Size = new System.Drawing.Size(359, 12);
            this.LoginDetailLabel.TabIndex = 4;
            this.LoginDetailLabel.Text = "UPI or Password are not correct, please check and try again";
            this.LoginDetailLabel.Visible = false;
            // 
            // DashBorad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.LoginDetailLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UPITextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UPILabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label1);
            this.Name = "DashBorad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "        ";
            this.Load += new System.EventHandler(this.DashBorad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label UPILabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UPITextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label LoginDetailLabel;
    }
}

