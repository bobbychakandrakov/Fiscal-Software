namespace Fiscal_Software.Forms
{
    partial class SettingsForm
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
            this.serverNameBox = new System.Windows.Forms.TextBox();
            this.enableAuthenticationBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveConnectionBtn = new System.Windows.Forms.Button();
            this.testConnectionBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.catalogNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name:";
            // 
            // serverNameBox
            // 
            this.serverNameBox.Location = new System.Drawing.Point(146, 39);
            this.serverNameBox.Name = "serverNameBox";
            this.serverNameBox.Size = new System.Drawing.Size(209, 20);
            this.serverNameBox.TabIndex = 1;
            // 
            // enableAuthenticationBox
            // 
            this.enableAuthenticationBox.AutoSize = true;
            this.enableAuthenticationBox.Location = new System.Drawing.Point(35, 104);
            this.enableAuthenticationBox.Name = "enableAuthenticationBox";
            this.enableAuthenticationBox.Size = new System.Drawing.Size(94, 17);
            this.enableAuthenticationBox.TabIndex = 2;
            this.enableAuthenticationBox.Text = "Authentication";
            this.enableAuthenticationBox.UseVisualStyleBackColor = true;
            this.enableAuthenticationBox.CheckedChanged += new System.EventHandler(this.enableAuthenticationBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(146, 148);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(209, 20);
            this.usernameBox.TabIndex = 5;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(146, 189);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(209, 20);
            this.passwordBox.TabIndex = 6;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(146, 241);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveConnectionBtn
            // 
            this.saveConnectionBtn.Location = new System.Drawing.Point(279, 240);
            this.saveConnectionBtn.Name = "saveConnectionBtn";
            this.saveConnectionBtn.Size = new System.Drawing.Size(75, 23);
            this.saveConnectionBtn.TabIndex = 8;
            this.saveConnectionBtn.Text = "Save";
            this.saveConnectionBtn.UseVisualStyleBackColor = true;
            this.saveConnectionBtn.Click += new System.EventHandler(this.saveConnectionBtn_Click);
            // 
            // testConnectionBtn
            // 
            this.testConnectionBtn.Location = new System.Drawing.Point(38, 239);
            this.testConnectionBtn.Name = "testConnectionBtn";
            this.testConnectionBtn.Size = new System.Drawing.Size(75, 23);
            this.testConnectionBtn.TabIndex = 9;
            this.testConnectionBtn.Text = "Test";
            this.testConnectionBtn.UseVisualStyleBackColor = true;
            this.testConnectionBtn.Click += new System.EventHandler(this.testConnectionBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Catalog name:";
            // 
            // catalogNameBox
            // 
            this.catalogNameBox.Location = new System.Drawing.Point(146, 65);
            this.catalogNameBox.Name = "catalogNameBox";
            this.catalogNameBox.Size = new System.Drawing.Size(208, 20);
            this.catalogNameBox.TabIndex = 11;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 287);
            this.Controls.Add(this.catalogNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.testConnectionBtn);
            this.Controls.Add(this.saveConnectionBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enableAuthenticationBox);
            this.Controls.Add(this.serverNameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverNameBox;
        private System.Windows.Forms.CheckBox enableAuthenticationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveConnectionBtn;
        private System.Windows.Forms.Button testConnectionBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox catalogNameBox;
    }
}