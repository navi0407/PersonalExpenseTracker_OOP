namespace PersonalExpenseTracker_OOP
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            lblBalance = new Label();
            lblTotalExpense = new Label();
            lblTotalIncome = new Label();
            dgvRecent = new DataGridView();
            btnCategories = new Button();
            btnIncome = new Button();
            btnExpense = new Button();
            btnLogout = new Button();
            btnReports = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(187, 16);
            label2.Name = "label2";
            label2.Size = new Size(231, 25);
            label2.TabIndex = 2;
            label2.Text = "Personal Expense Tracker";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(32, 64);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(58, 19);
            lblBalance.TabIndex = 13;
            lblBalance.Text = "Balance:";
            // 
            // lblTotalExpense
            // 
            lblTotalExpense.AutoSize = true;
            lblTotalExpense.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalExpense.Location = new Point(32, 100);
            lblTotalExpense.Name = "lblTotalExpense";
            lblTotalExpense.Size = new Size(94, 19);
            lblTotalExpense.TabIndex = 14;
            lblTotalExpense.Text = "Total Expense:";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalIncome.Location = new Point(32, 146);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(90, 19);
            lblTotalIncome.TabIndex = 15;
            lblTotalIncome.Text = "Total Income:";
            // 
            // dgvRecent
            // 
            dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecent.Location = new Point(270, 64);
            dgvRecent.Margin = new Padding(3, 2, 3, 2);
            dgvRecent.Name = "dgvRecent";
            dgvRecent.RowHeadersWidth = 51;
            dgvRecent.Size = new Size(323, 387);
            dgvRecent.TabIndex = 16;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.Maroon;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnCategories.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = SystemColors.ControlLightLight;
            btnCategories.Location = new Point(32, 302);
            btnCategories.Margin = new Padding(3, 2, 3, 2);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(83, 26);
            btnCategories.TabIndex = 18;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnIncome
            // 
            btnIncome.BackColor = Color.Maroon;
            btnIncome.FlatAppearance.BorderSize = 0;
            btnIncome.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnIncome.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnIncome.FlatStyle = FlatStyle.Flat;
            btnIncome.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncome.ForeColor = SystemColors.ControlLightLight;
            btnIncome.Location = new Point(32, 190);
            btnIncome.Margin = new Padding(3, 2, 3, 2);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(83, 26);
            btnIncome.TabIndex = 19;
            btnIncome.Text = "Income";
            btnIncome.UseVisualStyleBackColor = false;
            btnIncome.Click += btnIncome_Click;
            // 
            // btnExpense
            // 
            btnExpense.BackColor = Color.Maroon;
            btnExpense.FlatAppearance.BorderSize = 0;
            btnExpense.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnExpense.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnExpense.FlatStyle = FlatStyle.Flat;
            btnExpense.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExpense.ForeColor = SystemColors.ControlLightLight;
            btnExpense.Location = new Point(32, 247);
            btnExpense.Margin = new Padding(3, 2, 3, 2);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(83, 26);
            btnExpense.TabIndex = 20;
            btnExpense.Text = "Expense";
            btnExpense.UseVisualStyleBackColor = false;
            btnExpense.Click += btnExpense_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Maroon;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.Location = new Point(32, 396);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(83, 26);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Maroon;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnReports.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = SystemColors.ControlLightLight;
            btnReports.Location = new Point(32, 350);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(83, 26);
            btnReports.TabIndex = 22;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(623, 508);
            Controls.Add(btnReports);
            Controls.Add(btnLogout);
            Controls.Add(btnExpense);
            Controls.Add(btnIncome);
            Controls.Add(btnCategories);
            Controls.Add(dgvRecent);
            Controls.Add(lblTotalIncome);
            Controls.Add(lblTotalExpense);
            Controls.Add(lblBalance);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblBalance;
        private Label lblTotalExpense;
        private Label lblTotalIncome;
        private DataGridView dgvRecent;
        private Button btnCategories;
        private Button btnIncome;
        private Button btnExpense;
        private Button btnLogout;
        private Button btnReports;
    }
}