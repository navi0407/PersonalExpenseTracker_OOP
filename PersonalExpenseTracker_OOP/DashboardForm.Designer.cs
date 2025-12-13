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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            lblBalance = new Label();
            lblTotalExpense = new Label();
            lblTotalIncome = new Label();
            dgvRecent = new DataGridView();
            btnCategories = new Button();
            btnIncome = new Button();
            btnExpense = new Button();
            btnLogout = new Button();
            btnReports = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(99, 108);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(89, 19);
            lblBalance.TabIndex = 13;
            lblBalance.Text = "Their balance";
            //lblBalance.Click += lblBalance_Click;
            // 
            // lblTotalExpense
            // 
            lblTotalExpense.AutoSize = true;
            lblTotalExpense.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalExpense.Location = new Point(235, 108);
            lblTotalExpense.Name = "lblTotalExpense";
            lblTotalExpense.Size = new Size(92, 19);
            lblTotalExpense.TabIndex = 14;
            lblTotalExpense.Text = "Their expense";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalIncome.Location = new Point(406, 108);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(117, 19);
            lblTotalIncome.TabIndex = 15;
            lblTotalIncome.Text = "their total income";
            //lblTotalIncome.Click += lblTotalIncome_Click;
            // 
            // dgvRecent
            // 
            dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecent.Location = new Point(40, 155);
            dgvRecent.Margin = new Padding(3, 2, 3, 2);
            dgvRecent.Name = "dgvRecent";
            dgvRecent.RowHeadersWidth = 51;
            dgvRecent.Size = new Size(543, 330);
            dgvRecent.TabIndex = 16;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.Gray;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnCategories.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = SystemColors.ControlLightLight;
            btnCategories.Location = new Point(305, 21);
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
            btnIncome.BackColor = Color.Gray;
            btnIncome.FlatAppearance.BorderSize = 0;
            btnIncome.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnIncome.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnIncome.FlatStyle = FlatStyle.Flat;
            btnIncome.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncome.ForeColor = SystemColors.ControlLightLight;
            btnIncome.Location = new Point(98, 21);
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
            btnExpense.BackColor = Color.Gray;
            btnExpense.FlatAppearance.BorderSize = 0;
            btnExpense.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnExpense.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnExpense.FlatStyle = FlatStyle.Flat;
            btnExpense.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExpense.ForeColor = SystemColors.ControlLightLight;
            btnExpense.Location = new Point(201, 21);
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
            btnLogout.BackColor = Color.Gray;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.Location = new Point(515, 21);
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
            btnReports.BackColor = Color.Gray;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnReports.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = SystemColors.ControlLightLight;
            btnReports.Location = new Point(409, 21);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(83, 26);
            btnReports.TabIndex = 22;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Maroon;
            pictureBox1.Location = new Point(-4, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(632, 65);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(12, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 62);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 79);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 25;
            label1.Text = "Your Balance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 79);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 26;
            label2.Text = "Your Total Expense";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(397, 79);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 27;
            label3.Text = "Your Total Income";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.Location = new Point(89, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(85, 33);
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Gray;
            pictureBox4.Location = new Point(225, 102);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(85, 33);
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Gray;
            pictureBox5.Location = new Point(397, 102);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(85, 33);
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(-42, -19);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(826, 609);
            pictureBox6.TabIndex = 45;
            pictureBox6.TabStop = false;
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dgvRecent);
            Controls.Add(lblTotalIncome);
            Controls.Add(lblTotalExpense);
            Controls.Add(lblBalance);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBalance;
        private Label lblTotalExpense;
        private Label lblTotalIncome;
        private DataGridView dgvRecent;
        private Button btnCategories;
        private Button btnIncome;
        private Button btnExpense;
        private Button btnLogout;
        private Button btnReports;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}