namespace Spotini
{
    partial class Register
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
            label3 = new Label();
            tbFullname = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbRePassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(364, 24);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 0;
            label1.Text = "Spotini";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(237, 73);
            label2.Name = "label2";
            label2.Size = new Size(343, 37);
            label2.TabIndex = 1;
            label2.Text = "Sign up to create account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 149);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Full name:";
            // 
            // tbFullname
            // 
            tbFullname.Location = new Point(334, 146);
            tbFullname.Name = "tbFullname";
            tbFullname.Size = new Size(234, 27);
            tbFullname.TabIndex = 3;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(334, 196);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(234, 27);
            tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(334, 249);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(234, 27);
            tbPassword.TabIndex = 5;
            // 
            // tbRePassword
            // 
            tbRePassword.Location = new Point(334, 305);
            tbRePassword.Name = "tbRePassword";
            tbRePassword.Size = new Size(234, 27);
            tbRePassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 199);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 7;
            label4.Text = "Username: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 252);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 7;
            label5.Text = "Password: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(237, 308);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 7;
            label6.Text = "Re-password:";
            // 
            // button1
            // 
            button1.Location = new Point(322, 381);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 8;
            button1.Text = "Create account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += createAccount;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbRePassword);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(tbFullname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbFullname;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbRePassword;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}