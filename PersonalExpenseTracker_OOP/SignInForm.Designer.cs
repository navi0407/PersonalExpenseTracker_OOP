namespace PersonalExpenseTracker_OOP
{
    partial class SignInForm
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
            panel1 = new Panel();
            btnSignup = new Button();
            label6 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            login_showPass = new CheckBox();
            login_password = new TextBox();
            login_username = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            close = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(btnSignup);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 511);
            panel1.TabIndex = 9;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Maroon;
            btnSignup.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnSignup.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Malgun Gothic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = SystemColors.ControlLightLight;
            btnSignup.Location = new Point(49, 437);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(289, 44);
            btnSignup.TabIndex = 9;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(148, 390);
            label6.Name = "label6";
            label6.Size = new Size(98, 31);
            label6.TabIndex = 2;
            label6.Text = "Register";
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
            // btnLogin
            // 
            btnLogin.BackColor = Color.Maroon;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(494, 318);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 35);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Location = new Point(565, 268);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(132, 24);
            login_showPass.TabIndex = 16;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            // 
            // login_password
            // 
            login_password.Location = new Point(393, 235);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(304, 27);
            login_password.TabIndex = 15;
            // 
            // login_username
            // 
            login_username.Location = new Point(393, 167);
            login_username.Name = "login_username";
            login_username.Size = new Size(304, 27);
            login_username.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(393, 209);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 13;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(387, 141);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 12;
            label4.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(393, 63);
            label3.Name = "label3";
            label3.Size = new Size(102, 31);
            label3.TabIndex = 11;
            label3.Text = "SIGN IN";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Berlin Sans FB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(682, 9);
            close.Name = "close";
            close.Size = new Size(18, 18);
            close.TabIndex = 10;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 511);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(login_showPass);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(close);
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IncomeEntryForm";
            Load += SignInForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSignup;
        private Label label6;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private CheckBox login_showPass;
        private TextBox login_password;
        private TextBox login_username;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label close;
    }
}