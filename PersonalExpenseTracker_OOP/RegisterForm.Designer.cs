namespace PersonalExpenseTracker_OOP
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            register_loginBtn = new Button();
            label6 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            close = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            register_username = new TextBox();
            register_password = new TextBox();
            register_showPass = new CheckBox();
            btnRegister = new Button();
            label1 = new Label();
            register_cPassword = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(register_loginBtn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 511);
            panel1.TabIndex = 0;
            // 
            // register_loginBtn
            // 
            register_loginBtn.BackColor = Color.Maroon;
            register_loginBtn.FlatAppearance.MouseDownBackColor = Color.Maroon;
            register_loginBtn.FlatAppearance.MouseOverBackColor = Color.Maroon;
            register_loginBtn.FlatStyle = FlatStyle.Flat;
            register_loginBtn.Font = new Font("Malgun Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_loginBtn.ForeColor = SystemColors.ControlLightLight;
            register_loginBtn.Location = new Point(49, 437);
            register_loginBtn.Name = "register_loginBtn";
            register_loginBtn.Size = new Size(289, 44);
            register_loginBtn.TabIndex = 9;
            register_loginBtn.Text = "Sign In";
            register_loginBtn.UseVisualStyleBackColor = false;
            register_loginBtn.Click += register_loginBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(123, 394);
            label6.Name = "label6";
            label6.Size = new Size(143, 31);
            label6.TabIndex = 2;
            label6.Text = "Sign In Here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(49, 177);
            label2.Name = "label2";
            label2.Size = new Size(277, 31);
            label2.TabIndex = 1;
            label2.Text = "Personal Expense Tracker";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(134, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Berlin Sans FB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(682, 9);
            close.Name = "close";
            close.Size = new Size(18, 18);
            close.TabIndex = 1;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(396, 63);
            label3.Name = "label3";
            label3.Size = new Size(118, 31);
            label3.TabIndex = 2;
            label3.Text = "REGISTER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(390, 141);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 3;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(396, 209);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 4;
            label5.Text = "Password:";
            // 
            // register_username
            // 
            register_username.Location = new Point(396, 167);
            register_username.Name = "register_username";
            register_username.Size = new Size(304, 27);
            register_username.TabIndex = 5;
            // 
            // register_password
            // 
            register_password.Location = new Point(396, 235);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(304, 27);
            register_password.TabIndex = 6;
            // 
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Location = new Point(562, 340);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(132, 24);
            register_showPass.TabIndex = 7;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Maroon;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(491, 390);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(95, 35);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "SIGNUP";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 278);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 9;
            label1.Text = "Confirm Password:";
            // 
            // register_cPassword
            // 
            register_cPassword.Location = new Point(396, 304);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.PasswordChar = '*';
            register_cPassword.Size = new Size(304, 27);
            register_cPassword.TabIndex = 10;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 511);
            Controls.Add(register_cPassword);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(register_showPass);
            Controls.Add(register_password);
            Controls.Add(register_username);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(close);
            Controls.Add(panel1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label close;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox register_username;
        private TextBox register_password;
        private CheckBox register_showPass;
        private Button btnRegister;
        private Button register_loginBtn;
        private Label label6;
        private Label label1;
        private TextBox register_cPassword;
    }
}
