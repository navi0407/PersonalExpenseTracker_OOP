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

        //public bool checkConnection()
        //{
        //    //return (conn.State == ConnectionState.Closed) ? true : false;
        //}

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

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '•';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '•';
        }
    }
}
