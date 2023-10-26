namespace Spotini
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnLogin = new Button();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(362, 18);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 0;
            label1.Text = "Spotini";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(278, 78);
            label2.Name = "label2";
            label2.Size = new Size(250, 37);
            label2.TabIndex = 1;
            label2.Text = "Log in to continue";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(352, 157);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(193, 27);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(352, 231);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(193, 27);
            tbPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 160);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 234);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(338, 309);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += handleLogin;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 386);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 7;
            label5.Text = "Don't have an account? ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(437, 386);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.Click += redirectRegister;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label label3;
        private Label label4;
        private Button btnLogin;
        private Label label5;
        private LinkLabel linkLabel1;
    }
}