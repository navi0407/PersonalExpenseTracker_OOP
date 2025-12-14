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
            CreateTable();// Make sure the Income table exists in the database
            LoadCategories(); // Fill the category dropdown with options
            LoadData();// Load existing income records into the DataGridView
        }
        private void CreateTable() // Creates the Income table if it does not already exist
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
        private void LoadData()// Loads all Income records from the database into the DataGridView
        {
            using (var conn = new SQLiteConnection(cs))
            {
                conn.Open();
                using (var adapter = new SQLiteDataAdapter("SELECT * FROM Income", conn))
                {
                    var dt = new DataTable();//gumagawa ng tables at rows
                    adapter.Fill(dt);// pupuno ang table ng data galing sa database
                    dgvIncome.DataSource = dt;// Ibinibind ang DataTable sa DataGridView para ipakita ang data
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
            if (dgvIncome.CurrentRow == null)//kapag walang napili sa datagridview, walang gagawin
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
            LoadData();//nire-refresh ang datagridview
            ClearFields();//nililinis ang input fields
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
