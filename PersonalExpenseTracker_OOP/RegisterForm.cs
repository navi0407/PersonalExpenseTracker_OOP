using System.Data;
using SQLite;
namespace PersonalExpenseTracker_OOP
{
    public partial class RegisterForm : Form
    {
        SQLiteConnection conn = new SQLiteConnection("Data Source=personal_expense_tracker.db;Version=3;");
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            SignInForm loginForm = new SignInForm();
            loginForm.Show();
            this.Hide();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string usernaname = register_username.Text;
                string password = register_password.Text;
                string cPassword = register_cPassword.Text;

                if(string.IsNullOrWhiteSpace(usernaname) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(cPassword))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }
                if(password != cPassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
                var dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '•';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '•';
        }

    }
}
