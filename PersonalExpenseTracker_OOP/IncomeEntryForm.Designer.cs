namespace PersonalExpenseTracker_OOP
{
    partial class IncomeEntryForm
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
            lblAmount = new Label();
            lblDate = new Label();
            lblCategory = new Label();
            lblDescription = new Label();
            cmbCategory = new ComboBox();
            dtpDate = new DateTimePicker();
            dgvIncome = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvIncome).BeginInit();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(32, 34);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 19);
            lblAmount.TabIndex = 14;
            lblAmount.Text = "Amount:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(12, 76);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 19);
            lblDate.TabIndex = 15;
            lblDate.Text = "Date:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(32, 128);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(68, 19);
            lblCategory.TabIndex = 16;
            lblCategory.Text = "Category:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(32, 172);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(81, 19);
            lblDescription.TabIndex = 17;
            lblDescription.Text = "Description:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(106, 128);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(164, 23);
            cmbCategory.TabIndex = 18;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(59, 76);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(211, 23);
            dtpDate.TabIndex = 19;
            // 
            // dgvIncome
            // 
            dgvIncome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncome.Location = new Point(298, 34);
            dgvIncome.Margin = new Padding(3, 2, 3, 2);
            dgvIncome.Name = "dgvIncome";
            dgvIncome.RowHeadersWidth = 51;
            dgvIncome.Size = new Size(315, 264);
            dgvIncome.TabIndex = 20;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Maroon;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(104, 319);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 26);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Maroon;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(215, 319);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(83, 26);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Maroon;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(326, 319);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 26);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Maroon;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(440, 319);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 26);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(100, 34);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(151, 23);
            txtAmount.TabIndex = 25;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(119, 172);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(151, 23);
            txtDescription.TabIndex = 26;
            // 
            // IncomeEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(623, 383);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvIncome);
            Controls.Add(dtpDate);
            Controls.Add(cmbCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblCategory);
            Controls.Add(lblDate);
            Controls.Add(lblAmount);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IncomeEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IncomeEntryForm";
            Load += IncomeEntryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIncome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmount;
        private Label lblDate;
        private Label lblCategory;
        private Label lblDescription;
        private ComboBox cmbCategory;
        private DateTimePicker dtpDate;
        private DataGridView dgvIncome;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private TextBox txtAmount;
        private TextBox txtDescription;
    }
}