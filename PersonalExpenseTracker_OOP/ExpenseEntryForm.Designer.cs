namespace PersonalExpenseTracker_OOP
{
    partial class ExpenseEntryForm
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
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvExpense = new DataGridView();
            dtpDate = new DateTimePicker();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            lblCategory = new Label();
            lblDate = new Label();
            lblAmount = new Label();
            txtAmount = new TextBox();
            txtDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvExpense).BeginInit();
            SuspendLayout();
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
            btnClear.Location = new Point(432, 316);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 26);
            btnClear.TabIndex = 35;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
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
            btnDelete.Location = new Point(318, 316);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(83, 26);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
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
            btnUpdate.Location = new Point(207, 316);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(83, 26);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
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
            btnAdd.Location = new Point(96, 316);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 26);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvExpense
            // 
            dgvExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpense.Location = new Point(275, 9);
            dgvExpense.Margin = new Padding(3, 2, 3, 2);
            dgvExpense.Name = "dgvExpense";
            dgvExpense.RowHeadersWidth = 51;
            dgvExpense.Size = new Size(338, 272);
            dgvExpense.TabIndex = 31;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(50, 58);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(219, 23);
            dtpDate.TabIndex = 30;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(105, 102);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(147, 23);
            cmbCategory.TabIndex = 29;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(24, 154);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(81, 19);
            lblDescription.TabIndex = 28;
            lblDescription.Text = "Description:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(37, 102);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(68, 19);
            lblCategory.TabIndex = 27;
            lblCategory.Text = "Category:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(12, 58);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 19);
            lblDate.TabIndex = 26;
            lblDate.Text = "Date:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(37, 17);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 19);
            lblAmount.TabIndex = 25;
            lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(105, 17);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(147, 23);
            txtAmount.TabIndex = 36;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(111, 154);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(147, 23);
            txtDescription.TabIndex = 37;
            // 
            // ExpenseEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 383);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvExpense);
            Controls.Add(dtpDate);
            Controls.Add(cmbCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblCategory);
            Controls.Add(lblDate);
            Controls.Add(lblAmount);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExpenseEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExpenseEntryForm";
            Load += ExpenseEntryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvExpense;
        private DateTimePicker dtpDate;
        private ComboBox cmbCategory;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblDate;
        private Label lblAmount;
        private TextBox txtAmount;
        private TextBox txtDescription;
    }
}