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
            EnsureTransactionsTableExists();
            LoadTotals();
            LoadRecentTransactions();
            //LoadCurrentEntries();
        }
        void LoadTotals()
        {
            decimal income = 0, expense = 0;

            using (var conn = OpenConn())
            {
                using (var cmd = new SQLiteCommand(
                    "SELECT IFNULL(SUM(Amount),0) FROM Transactions WHERE Type='Income';", conn))
                {
                    income = Convert.ToDecimal(cmd.ExecuteScalar());
                }
                using (var cmd = new SQLiteCommand(
                    "SELECT IFNULL(SUM(Amount),0) FROM Transactions WHERE Type='Expense';", conn))
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
            using (var da = new SQLiteDataAdapter(
                @"SELECT TransactionID, Type, Amount, Date, Description
                      FROM Transactions
                      ORDER BY Date DESC
                      LIMIT 20;", conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                dgvRecent.DataSource = dt;
            }
        }
        //void LoadCurrentEntries()
        //decimal GetLatestAmount(string type)
        //{
        //    using (var conn = OpenConn())
        //    {
        //        using (var cmd = new SQLiteCommand(
        //         @"SELECT Amount
        //            FROM Transactions
        //            WHERE Type = @type
        //            ORDER BY Date DESC, TransactionID DESC
        //            LIMIT 1;", conn))
        //        {
        //            cmd.Parameters.AddWithValue("@type", type);
        //            object result = cmd.ExecuteScalar();
        //            return (result == null || result == DBNull.Value)  ? 0m : Convert.ToDecimal(result);

        //        }
        //    }
        //}
        //    void LoadCurrentEntries()
        //    {
        //        decimal currentIncome = GetLatestAmount("Income");
        //        decimal currentExpense = GetLatestAmount("Expense");
        //        lblTotalExpense.Text = currentExpense.ToString("N2");
        //        lblTotalIncome.Text = currentIncome.ToString("N2");
        //    }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            using (var f = new IncomeEntryForm())
            {
                f.ShowDialog();
            }
            LoadTotals();
            LoadRecentTransactions();
            //LoadCurrentEntries();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            using (var f = new ExpenseEntryForm())
            {
                f.ShowDialog();
            }
            LoadTotals();
            LoadRecentTransactions();
            //LoadCurrentEntries();
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
        void EnsureTransactionsTableExists()
        {
            using (var conn = OpenConn())
            using (var cmd = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS Transactions (
                    TransactionID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Type TEXT NOT NULL,
                    Amount REAL NOT NULL,
                    Date TEXT NOT NULL,
                    Description TEXT
                );", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

    }
}
