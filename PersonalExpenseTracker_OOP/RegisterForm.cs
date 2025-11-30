namespace PersonalExpenseTracker_OOP
{
    public partial class RegisterForm : Form
    {
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
