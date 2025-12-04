using Microsoft.VisualBasic;
using SQLite;
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
    public partial class IncomeEntryForm : Form
    {
        //private string _connectionString = @"Data Source=BudgetTracker.db;Version=3;";
        //private int _selectedTransactionId = -1;
        public IncomeEntryForm()
        {
            InitializeComponent();
        }

        //private void IncomeEntryForm_Load(object sender, EventArgs e)
        //{
        //    LoadCategories();
        //    LoadIncomeData();
        //    ClearInputs();
        //}
        //        private void LoadCategories()
        //        {
        //            using (var conn = new SQLiteConnection(_connectionString))
        //            {
        //                conn.Open();
        //                string query = "SELECT CategoryID, CategoryName FROM Categories WHERE Type = 'Income';";
        //                using (var cmd = new SQLiteCommand(query, conn))
        //                using (var adapter = new SQLiteDataAdapter(cmd))
        //                {
        //                    DataTable dt = new DataTable();
        //                    adapter.Fill(dt);
        //                    cmbCategory.DataSource = dt;
        //                    cmbCategory.DisplayMember = "CategoryName";
        //                    cmbCategory.ValueMember = "CategoryID";
        //                }
        //            }
        //        }
        //        private void LoadIncomeData()
        //        {
        //            using (var conn = new SQLiteConnection(_connectionString))
        //            {
        //                conn.Open();
        //                string query = "SELECT TransactionID, Date, Amount, CategoryID, Description FROM Transactions WHERE Type = 'Income';";
        //                using (var cmd = new SQLiteCommand(query, conn))
        //                using (var adapter = new SQLiteDataAdapter(cmd))
        //                {
        //                    DataTable dt = new DataTable();
        //                    adapter.Fill(dt);
        //                    dgvIncome.DataSource = dt;
        //                }
        //            }
        //        }
        //        private void ClearInputs()
        //        {
        //            dtpDate.Value = DateTime.Now;
        //            txtAmount.Clear();
        //            cmbCategory.SelectedIndex = -1;
        //            txtDescription.Clear();
        //            _selectedTransactionId = -1;
        //        }
        //        private void btnAdd_Click(object sender, EventArgs e)
        //        {
        //            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
        //            {
        //                MessageBox.Show("Please enter a valid amount.");
        //                return;
        //            }

        //            if (cmbCategory.SelectedValue == null)
        //            {
        //                MessageBox.Show("Please select a category.");
        //                return;
        //            }

        //            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
        //            string date = dtpDate.Value.ToString("yyyy-MM-dd");
        //            string description = txtDescription.Text.Trim();

        //            using (var conn = new SQLiteConnection(_connectionString))
        //            {
        //                conn.Open();
        //                string query = @"INSERT INTO Transactions
        //                                 (Type, CategoryID, Amount, Date, Description)
        //                                 VALUES ('Income', @CategoryID, @Amount, @Date, @Description);";

        //                using (var cmd = new SQLiteCommand(query, conn))
        //                {
        //                    cmd.Parameters.AddWithValue("@CategoryID", categoryId);
        //                    cmd.Parameters.AddWithValue("@Amount", amount);
        //                    cmd.Parameters.AddWithValue("@Date", date);
        //                    cmd.Parameters.AddWithValue("@Description", description);
        //                    cmd.ExecuteNonQuery();
        //                }
        //            }

        //            LoadIncomeData();
        //            ClearInputs();
        //            MessageBox.Show("Income added successfully.");
        //        }
        //        private void dgvIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        //        {
        //            if (e.RowIndex < 0) return;

        //            DataGridViewRow row = dgvIncome.Rows[e.RowIndex];

        //            _selectedTransactionId = Convert.ToInt32(row.Cells["TransactionID"].Value);
        //            txtAmount.Text = row.Cells["Amount"].Value.ToString();
        //            dtpDate.Value = DateTime.Parse(row.Cells["Date"].Value.ToString());
        //            txtDescription.Text = row.Cells["Description"].Value.ToString();

        //            int categoryId = Convert.ToInt32(row.Cells["CategoryID"].Value);
        //            cmbCategory.SelectedValue = categoryId;
        //        }


    }
}
