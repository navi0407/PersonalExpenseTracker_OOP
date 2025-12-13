using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PersonalExpenseTracker_OOP
{
    public partial class ExpenseEntryForm : Form
    {
        string cs = @"Data Source=BudgetTracker.db;";
        public ExpenseEntryForm()
        {
            InitializeComponent();
        }

        private void ExpenseEntryForm_Load(object sender, EventArgs e)
        {
            CreateTable();
            LoadCategories();
            LoadData();
        }
        private void CreateTable()
        {
            using (var conn = new SQLiteConnection(cs))
            {
                conn.Open();
                string stm = @"
            CREATE TABLE IF NOT EXISTS Expense (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Amount REAL NOT NULL,
                Date TEXT NOT NULL,
                Category TEXT NOT NULL,
                Description TEXT
            );";
                using (var cmd = new SQLiteCommand(stm, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Food/Groceries");
            cmbCategory.Items.Add("Transportation");
            cmbCategory.Items.Add("Bills(electricity/water/internet)");
            cmbCategory.Items.Add("Rent");
            cmbCategory.Items.Add("Shopping");
            cmbCategory.Items.Add("School Supplies");
            cmbCategory.Items.Add("Entertainment");
            cmbCategory.Items.Add("Others/Miscellaneous");
        }
        private void LoadData()
        {
            using (var conn = new SQLiteConnection(cs))
            {
                conn.Open();
                using (var adapter = new SQLiteDataAdapter("SELECT * FROM Expense", conn))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    dgvExpense.DataSource = dt;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(cs))
            {
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("INSERT INTO Expense (Amount, Date, Category, Description) VALUES (@Amount,@Date,@Category,@Description)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(txtAmount.Text));
                        cmd.Parameters.AddWithValue("@Date", dtpDate.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadData();
                ClearFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvExpense.CurrentRow == null)
                return;
            int id = Convert.ToInt32(dgvExpense.CurrentRow.Cells["Id"].Value);
            using (var conn = new SQLiteConnection(cs))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("UPDATE Expense SET Amount=@Amount, Date=@Date, Category=@Category, " +
                    "Description=@Description WHERE Id=@Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToDouble(txtAmount.Text));
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpense.CurrentRow == null)
                return;
            int id = Convert.ToInt32(dgvExpense.CurrentRow.Cells["Id"].Value);
            using (var conn = new SQLiteConnection(cs))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("DELETE FROM Expense WHERE Id=@Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            LoadData();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtAmount.Clear();
            dtpDate.Value = DateTime.Now;
            cmbCategory.SelectedIndex = -1;
            txtDescription.Clear();
        }

        private void dgvExpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dgvExpense.Rows[e.RowIndex];
            txtAmount.Text = row.Cells["Amount"].Value.ToString();
            dtpDate.Value = DateTime.Parse(row.Cells["Date"].Value.ToString());
            cmbCategory.Text = row.Cells["Category"].Value.ToString();
            txtDescription.Text = row.Cells["Description"].Value.ToString();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
