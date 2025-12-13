using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PersonalExpenseTracker_OOP
{
    public partial class CategoriesForm : Form
    {
        string cs = @"Data Source=BudgetTracker.db;";
        int selectedCategoryId = -1;
        public CategoriesForm()
        {
            InitializeComponent();
        }
        private void CategoriesTable()
        {
            using (var conn = OpenConn())
            using (var cmd = new SQLiteCommand(
        @"CREATE TABLE IF NOT EXISTS Categories (
              CategoryID   INTEGER PRIMARY KEY AUTOINCREMENT,
              CategoryName TEXT NOT NULL,
              Type         TEXT NOT NULL
          );", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        SQLiteConnection OpenConn()
        {
            var conn = new SQLiteConnection(cs);
            conn.Open();
            return conn;
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("Income");
            cmbType.Items.Add("Expense");
            if (cmbType.Items.Count > 0)
                cmbType.SelectedIndex = 0;
            CategoriesTable();
            LoadData();
            ClearInputs();
        }
        private void LoadData()
        {
            using (var conn = OpenConn())
            using (var da = new SQLiteDataAdapter(
                "SELECT CategoryID, CategoryName, Type FROM Categories ORDER BY CategoryName;", conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                dgvCategories.DataSource = dt;
            }
        }
        private void ClearInputs()
        {
            textCName.Clear();
            if(cmbType.Items.Count > 0)
                cmbType.SelectedIndex = 0;
            selectedCategoryId = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textCName.Text.Trim();
            string type = cmbType.SelectedItem.ToString();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }
            using (var conn = OpenConn())
            using (var cmd = new SQLiteCommand(
                "INSERT INTO Categories (CategoryName, Type) VALUES (@name, @type);", conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.ExecuteNonQuery();
            }
            LoadData();
            ClearInputs();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dgvCategories.Rows[e.RowIndex];
            selectedCategoryId = Convert.ToInt32(row.Cells["CategoryID"].Value);
            textCName.Text = row.Cells["CategoryName"].Value.ToString();
            cmbType.SelectedItem = row.Cells["Type"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId <= 0)
            {
                MessageBox.Show("Please select a category.");
                return;
            }
            string name = textCName.Text.Trim();
            string type = cmbType.SelectedItem.ToString();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }
            using (var conn = OpenConn())
            using (var cmd = new SQLiteCommand(
            "UPDATE Categories SET CategoryName=@name, Type=@type WHERE CategoryID=@id;", conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@id", selectedCategoryId);
                cmd.ExecuteNonQuery();
            }
            LoadData();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId <= 0)
            {
                MessageBox.Show("Please select a category.");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            using (var conn = OpenConn())
            using (var cmd = new SQLiteCommand("DELETE FROM Categories WHERE CategoryID=@id;", conn))
            {
                cmd.Parameters.AddWithValue("@id", selectedCategoryId);
                cmd.ExecuteNonQuery();
            }
            LoadData();
            ClearInputs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}
