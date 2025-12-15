using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalExpenseTracker_OOP;
using System.Data.SQLite;


namespace PersonalExpenseTracker_OOP
{
    public partial class DashboardForm : Form
    {
        string cs = @"Data Source=BudgetTracker.db;";

        public DashboardForm()
        {
            InitializeComponent();
        }

        SQLiteConnection OpenConn()
        {
            var c = new SQLiteConnection(cs);
            c.Open();
            return c;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadTotals();
            LoadRecentTransactions();
        }

        void LoadTotals()
        {
            decimal income = 0;
            decimal expense = 0;

            using (var conn = OpenConn())
            {
                using (var cmd = new SQLiteCommand(
                    "SELECT IFNULL(SUM(Amount), 0) FROM Income;", conn))
                {
                    income = Convert.ToDecimal(cmd.ExecuteScalar());
                }

                using (var cmd = new SQLiteCommand(
                    "SELECT IFNULL(SUM(Amount), 0) FROM Expense;", conn))
                {
                    expense = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }

            decimal balance = income - expense;

            lblTotalIncome.Text = income.ToString("N2");
            lblTotalExpense.Text = expense.ToString("N2");
            lblBalance.Text = balance.ToString("N2");
        }

        void LoadRecentTransactions()
        {
            using (var conn = OpenConn())
            {
                string sql = @"
                    SELECT Id AS TransactionID, 'Income' AS Type, Amount, Date, Description
                    FROM Income
                    UNION ALL
                    SELECT Id AS TransactionID, 'Expense' AS Type, Amount, Date, Description
                    FROM Expense
                    ORDER BY Date DESC
                    LIMIT 20;
                ";

                using (var da = new SQLiteDataAdapter(sql, conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    dgvRecent.DataSource = dt;
                }
            }
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            using (var f = new IncomeEntryForm())
            {
                f.ShowDialog();
            }
            LoadTotals();
            LoadRecentTransactions();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            using (var f = new ExpenseEntryForm())
            {
                f.ShowDialog();
            }
            LoadTotals();
            LoadRecentTransactions();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            using (var f = new CategoriesForm())
            {
                f.ShowDialog();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            using (var f = new PrintReportsForm())
            {
                f.ShowDialog();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new SignInForm();
            login.Show();
        }
    }
}