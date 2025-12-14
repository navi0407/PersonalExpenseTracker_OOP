using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalExpenseTracker_OOP
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '•';

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = login_username.Text;
                string password = login_password.Text;
                if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }
                bool isValid = ValidateUser(username, password);
                if(!isValid)
                {
                    MessageBox.Show("Invalid username or password.");
                }
                var dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();

                //bool isValid = ValidateUser(username, password);

                //if (!isValid)
                //{
                //    MessageBox.Show("Invalid credentials.");
                //    return;
                //}
                //var dash = new DashboardForm();
                //dash.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private bool ValidateUser(string username, string password)
        {
            return true;
        }
    }
}
