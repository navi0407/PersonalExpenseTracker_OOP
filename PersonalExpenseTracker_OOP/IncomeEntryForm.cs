using Microsoft.VisualBasic;
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
    public partial class IncomeEntryForm : Form
    {
        string cs = @"Data Source=BudgetTracker.db;";

        public IncomeEntryForm()
        {
            InitializeComponent();
        }
        private void IncomeEntryForm_Load(object sender, EventArgs e)
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
                string stm = @"CREATE TABLE IF NOT EXISTS Income (
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
            cmbCategory.Items.Add("Salary");
            cmbCategory.Items.Add("Allowance");
            cmbCategory.Items.Add("Bonus");
            cmbCategory.Items.Add("Overtime Pay");

        }
        private void LoadData()
        {
            using (var conn = new SQLiteConnection(cs))
            {
                conn.Open();
                using (var adapter = new SQLiteDataAdapter("SELECT * FROM Income", conn))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    dgvIncome.DataSource = dt;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(cs))
            {
                {
                    conn.Open();
                    using (var cmd = new SQLiteCommand("INSERT INTO Income (Amount, Date, Category, Description) VALUES (@Amount,@Date,@Category,@Description)", conn))
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
            if (dgvIncome.CurrentRow == null)
                return;
            int id = Convert.ToInt32(dgvIncome.CurrentRow.Cells["Id"].Value);
            using (var conn = new SQLiteConnection(cs))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("UPDATE Income SET Amount=@Amount, Date=@Date, Category=@Category, " +
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
            if (dgvIncome.CurrentRow == null)
                return;
            int id = Convert.ToInt32(dgvIncome.CurrentRow.Cells["Id"].Value);
            using (var conn = new SQLiteConnection(cs))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("DELETE FROM Income WHERE Id=@Id", conn))
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

        private void dgvIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dgvIncome.Rows[e.RowIndex];
            txtAmount.Text = row.Cells["Amount"].Value.ToString();
            dtpDate.Value = DateTime.Parse(row.Cells["Date"].Value.ToString());
            cmbCategory.Text = row.Cells["Category"].Value.ToString();
            txtDescription.Text = row.Cells["Description"].Value.ToString();
        }
    }
}
